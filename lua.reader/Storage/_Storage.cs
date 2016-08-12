using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using lua.reader.Graph;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    public class Storage : Graph.Graph
    {
        public Storage() : base(FF.Instance, FF.Instance)
        {
        }

        public static string ModsPath = "_data\\_Factorio_mods";
        abstract class LoadHelper
        {
            public abstract IEnumerable Load(Storage storage, JObject data, string property);
        }
        class LoadHelper<T> : LoadHelper
            where T : Base
        {
            public override IEnumerable Load(Storage storage, JObject data, string property)
            {
                return Load<T>(storage, data, property);
            }
        }


        private static Dictionary<Type, JsonObjectAttribute> _typesAttributes;

        public static List<Base> LoadAll(Storage storage, JObject data)
        {
            var all = new List<Base>();
            foreach (var type in _typesAttributes.Keys)
            {
                var helperType = typeof(LoadHelper<>).MakeGenericType(type);
                var helper = (LoadHelper)Activator.CreateInstance(helperType);
                var property = _typesAttributes[type].Id;
                var result = helper.Load(storage, data, property).Cast<Base>().ToArray();
                all.AddRange(result);
            }
            return all;
        }

        public static List<T> Load<T>(Storage storage, JObject data, string property = null)
            where T : Base
        {
            property = property ?? _typesAttributes[typeof(T)].Id;
            var properties = ((JObject)data[property]).Properties();


            var list = new List<T>();
            foreach (var token in properties)
            {
                var value = (JObject)token.Value;
                T item;

                if(true)
                {
                    item = storage.Add<T>();
                    var json = value.ToString();
                    JsonConvert.PopulateObject(json, item);
                }
                else
                {
                    item = value.ToObject<T>();
                }

                item.SetToken(token.Children().First());
                list.Add(item);


            }

            return list;
        }

        public static Storage Load()
        {
            var storage = new Storage();
            storage.StringsByCategory = LoadJson(LocaleJson);
            storage.Mods = LoadJson<Dictionary<string, Mod>>(ModsJson);

            var data = LoadJson(DataJson);

            var itemTypes = ((JObject)data["item-subgroup"]).Properties().Select(x => x.Name).ToArray();

            Dictionary<string, Dictionary<string, uint>> props = new Dictionary<string, Dictionary<string, uint>>();

            IDictionary<string, JToken> dict = data;


            foreach (var dictPair in dict)
            {
                var objprops = new Dictionary<string, uint>();
                props.Add(dictPair.Key, objprops);

                objprops["-total-"] = 0;

                foreach (var info in ((JObject)dictPair.Value).Properties())
                {
                    JObject obj = (JObject)info.Value;
                    objprops["-total-"]++;

                    foreach (var property in obj.Properties())
                    {
                        var name = property.Name;
                        if (!objprops.ContainsKey(name))
                            objprops.Add(name, 0);
                        objprops[name]++;
                    }
                }
            }

            _typesAttributes = typeof(Base).Assembly.GetTypes()
                .Select(x => new { Type = x, Attribute = x.Attribute<JsonObjectAttribute>() })
                .Where(x => typeof(Base).IsAssignableFrom(x.Type) && x.Attribute != null && !string.IsNullOrEmpty(x.Attribute.Id))
                .ToDictionary(x => x.Type, x => x.Attribute);


            var sb = new StringBuilder();
            sb.AppendLine("//*************************************************************************************");
            sb.AppendLine("//");
            sb.AppendLine("//     G E N E R A T E D   C L A S S E S");
            sb.AppendLine("//");
            sb.AppendLine("//*************************************************************************************");
            sb.AppendLine();
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine();

            sb.AppendLine($"namespace {typeof(Base).Namespace}");
            sb.AppendLine("{");
            sb.AppendLine();

            foreach (var propsInfo in props)
            {
                var key = propsInfo.Key;

                var propsByKey = propsInfo.Value;

                var total = propsByKey["-total-"];
                propsByKey.Remove("-total-");

                var isItem = itemTypes.Contains(key);

                var typed = propsByKey.ContainsKey("type") && propsByKey["type"] == total;
                var named = propsByKey.ContainsKey("name") && propsByKey["name"] == total;
                //var ordered = propsByKey.ContainsKey("order");

                //var iconed = propsByKey.ContainsKey("icon");
                //var categorized = propsByKey.ContainsKey("catgory");
                //var subgrouped = propsByKey.ContainsKey("subgroup");

                var exists = _typesAttributes.Where(x => x.Value.Id == key).Select(x => x.Key).FirstOrDefault();
                var notExists = exists == null;


                string baseType;
                if (notExists && !isItem)
                {
                    baseType = "Base";
                    if (typed)
                    {
                        baseType = "TypedBase";
                        propsByKey.Remove("type");
                        if (named)
                        {
                            baseType = "TypedNamedBase";
                            propsByKey.Remove("name");
                        }
                    }
                }
                else
                {
                    if (notExists)
                    {
                        exists = typeof (Item);
                        baseType = "Item";
                    }
                    else
                        baseType = "";

                    var existsProps = exists.GetProperties().Select(x => new { PI = x, Attribute = x.Attribute<JsonPropertyAttribute>() })
                        .Where(x => x.Attribute != null)
                        .ToDictionary(x => string.IsNullOrEmpty(x.Attribute.PropertyName) ? x.PI.Name : x.Attribute.PropertyName, x => x.Attribute);

                    foreach (var existsProp in existsProps)
                    {
                        propsByKey.Remove(existsProp.Key);
                    }
                }

                var className = NormalizeName(key);
                if (!string.IsNullOrEmpty(baseType))
                {
                    if(notExists)
                        sb.AppendLine($"\t[JsonObject(\"{key}\", MemberSerialization = MemberSerialization.OptIn)]");
                    sb.AppendLine($"\tpublic partial class {className} : {baseType}");
                }
                else
                    sb.AppendLine($"\tpublic partial class {className}");

                sb.AppendLine($"\t{{");
                sb.AppendLine();

                foreach (var pair in propsByKey)
                {
                    var propertyName = NormalizeName(pair.Key);

                    sb.AppendLine($"\t\t[JsonProperty(\"{pair.Key}\")]");
                    sb.AppendLine($"\t\tpublic object {propertyName}{{get;set;}}");
                    sb.AppendLine();
                }

                sb.AppendLine($"\t}}");
                sb.AppendLine();
            }

            sb.AppendLine("}");

            var classes = sb.ToString();

            var keys = data.Keys();

            _typesAttributes = typeof(Base).Assembly.GetTypes()
                .Select(x => new { Type = x, Attribute = x.Attribute<JsonObjectAttribute>() })
                .Where(x => typeof(Base).IsAssignableFrom(x.Type) && x.Attribute != null && !string.IsNullOrEmpty(x.Attribute.Id))
                .ToDictionary(x => x.Type, x => x.Attribute);

            var all = LoadAll(storage, data);
            foreach (var @base in all)
            {
                @base.ProcessLinks();
            }

            var errors = storage.Edges.Select(x => x.From).Where(x => !(x is Recipe)).ToArray();

            var subgroups = storage.Nodes<ItemSubGroup>().Select(x => x.Name).ToArray();

            var nosubgroup = storage.Nodes<Item>().Where(x => string.IsNullOrEmpty(x.subgroup)).ToArray();

            var nnnn = storage.Nodes<Item>().Select(x => x.Type).Except(subgroups).Distinct().ToArray();

            return storage;
        }

        static string NormalizeName(string name, params char[] separator)
        {
            if (separator.Length == 0)
                separator = new[] {'-', '_'};

            var result = string.Join("", name.Split(separator).Select(x => new string(char.ToUpper(x[0]), 1) + new string(x.Skip(1).ToArray())));
            return result;
        }

        public object Mods { get; set; }

        public JObject StringsByCategory { get; set; }

        public List<RecipeCategory> RecipeCategories { get; private set; }

        public List<Recipe> Recipies { get; private set; }

        public static string DataJson = Path.Combine(ModsPath, "_data.json");
        public static string LocaleJson = Path.Combine(ModsPath, "_locale.json");
        public static string ModsJson = Path.Combine(ModsPath, "_mods.json");

        public static JObject LoadJson(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            return JObject.Parse(File.ReadAllText(fileName, Encoding.UTF8));
        }

        public static T LoadJson<T>(string fileName)
        {
            if (!File.Exists(fileName))
                return default(T);

            var result = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName, Encoding.UTF8));
            return result;
        }
    }

    class FF : INodesFactory, IEdgesFactory
    {
        public static readonly FF Instance = new FF();
        public TNode Create<TNode>(IGraph graph) where TNode : IGraphNode
        {
            var instance = Activator.CreateInstance<TNode>();
            var @base = (instance as Base);
            @base?.SetGraph(graph);
            return instance;
        }

        public TNode Create<TNode, TData>(IGraph graph, TData data) where TNode : IGraphNode<TData>
        {
            throw new NotImplementedException();
        }

        public TEdge Create<TEdge>(IGraph graph, IGraphNode @from, IGraphNode to) where TEdge : IGraphEdge
        {
            return (TEdge) Activator.CreateInstance(typeof(TEdge), graph, @from, to);
        }

        public TEdge Create<TEdge, TData>(IGraph graph, IGraphNode @from, IGraphNode to, TData data) where TEdge : IGraphEdge<TData>
        {
            throw new NotImplementedException();
        }
    }
}