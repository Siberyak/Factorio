using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    public class Storage
    {
        abstract class LoadHelper
        {
            public abstract IEnumerable Load(JObject data, string property);
        }
        class LoadHelper<T> : LoadHelper
            where T : Base
        {
            public override IEnumerable Load(JObject data, string property)
            {
                return Load<T>(data, property);
            } 
        }


        private static Dictionary<Type, JsonObjectAttribute> _typesAttributes;

        public static List<Base> LoadAll(JObject data)
        {
            var all = new List<Base>();
            foreach (var type in _typesAttributes.Keys)
            {
                var helperType = typeof (LoadHelper<>).MakeGenericType(type);
                var helper = (LoadHelper)Activator.CreateInstance(helperType);
                var property = _typesAttributes[type].Id;
                var result = helper.Load(data, property).Cast<Base>().ToArray();
                all.AddRange(result);
            }
            return all;
        }

        public static List<T> Load<T>(JObject data, string property = null)
            where T : Base
        {
            property = property ?? _typesAttributes[typeof (T)].Id;
            var tokens = data[property].Children();

            var list = new List<T>();
            foreach (JToken token in tokens)
            {
                var json = token.ToString();
                json = json.Substring(json.IndexOf("{"));
                json = json.Replace(Environment.NewLine, " ");
                var tmp = JsonConvert.DeserializeObject<T>(json);
                tmp.SetToken(token.Children().First());
                list.Add(tmp);
            }

            return list;
        }

        public static Storage Load()
        {
            var storage = new Storage();
            storage.StringsByCategory = LoadJson(LocaleFilesJson);

            var data = LoadJson(ResultJson);

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


            foreach (var propsInfo in props)
            {
                var key = propsInfo.Key;
                var propsByKey = propsInfo.Value;

                var total = propsByKey["-total-"];
                propsByKey.Remove("-total-");

                var typed = propsByKey.ContainsKey("type");
                var named = propsByKey.ContainsKey("name");
                var ordered = propsByKey.ContainsKey("order");

                var iconed = propsByKey.ContainsKey("icon");
                var categorized = propsByKey.ContainsKey("catgory");
                var subgrouped = propsByKey.ContainsKey("subgroup");


            }


            var keys = data.Keys();

            _typesAttributes = typeof (Base).Assembly.GetTypes()
                .Select(x => new {Type = x, Attribute = x.Attribute<JsonObjectAttribute>()})
                .Where(x => typeof(Base).IsAssignableFrom(x.Type) && x.Attribute != null && !string.IsNullOrEmpty(x.Attribute.Id))
                .ToDictionary(x => x.Type, x => x.Attribute);

            var all = LoadAll(data);

            return storage;
        }

        public JObject StringsByCategory { get; set; }

        public List<RecipeCategory> RecipeCategories { get; private set; }

        public List<Recipe> Recipies { get; private set; }

        public const string ResultJson = "_data\\_result.json";
        public const string LocaleFilesJson = "_data\\_loc.json";

        public static JObject LoadJson(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            return JObject.Parse(File.ReadAllText(fileName, Encoding.UTF8));
        }
    }
}