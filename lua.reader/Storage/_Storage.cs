using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;
using lua.reader;
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

            _typesAttributes = typeof(Base).Assembly.GetTypes()
                .Select(x => new { Type = x, Attribute = x.Attribute<JsonObjectAttribute>() })
                .Where(x => typeof(Base).IsAssignableFrom(x.Type) && x.Attribute != null && !string.IsNullOrEmpty(x.Attribute.Id))
                .ToDictionary(x => x.Type, x => x.Attribute);

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


            //AnalyzeData(data, props);

            GenerateClasses(data, props, itemTypes);

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

//            var assemblingMachines = storage.Nodes<AssemblingMachine>().ToArray();

            return storage;
        }

        private static void AnalyzeData(JObject data, Dictionary<string, Dictionary<string, uint>> props)
        {
            var types = data.Properties()
                .SelectMany(x => ((JObject) x.Value).Properties())
                .Select(x => (JObject) x.Value)
                .GroupBy(x => x["type"].Value<string>())
                .ToDictionary(x => x.Key, x => x.GroupBy(y => y["subgroup"] ?? "").ToDictionary(y => y.Key, y=> y.ToArray()))
                ;

            var tmp = types.Where(x => x.Value.Count > 1).ToDictionary(x => x.Key, x => x.Value);



            var properties = data.Properties();
            foreach (JProperty property in properties)
            {
                var propName = property.Name;

                if(propName != "fluid")
                    continue;

                var propValue = (JObject)property.Value;

                var instances = propValue.Properties().Select(x => x.Value).ToArray();
                foreach (dynamic instance in instances)
                {
                    var obj = (JObject) instance;
                    var subgroup = obj["subgroup"] ?? "";
                    var type = obj["type"];
                }
            }

        }

        private static string xml = @"

<data><ul><li> <a href=""/index.php?title=Prototype/AmmoCategory"" title=""Prototype/AmmoCategory"">Prototype/AmmoCategory</a> <b>ammo-category</b></li>
<li> <a href=""/index.php?title=Prototype/AutoplaceControl"" title=""Prototype/AutoplaceControl"">Prototype/AutoplaceControl</a> <b>autoplace-control</b></li>
<li> <a href=""/index.php?title=Prototype/DamageType"" title=""Prototype/DamageType"">Prototype/DamageType</a> <b>damage-type</b></li>
<li> <a href=""/index.php?title=Prototype/Entity"" title=""Prototype/Entity"">Prototype/Entity</a> <b>entity</b>;
<ul><li> <a href=""/index.php?title=Prototype/Arrow&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Arrow (page does not exist)"">Prototype/Arrow</a> <b>arrow</b></li>
<li> <a href=""/index.php?title=Prototype/Corpse&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Corpse (page does not exist)"">Prototype/Corpse</a> <b>corpse</b></li>
<li> <a href=""/index.php?title=Prototype/Decorative"" title=""Prototype/Decorative"">Prototype/Decorative</a> <b>decorative</b></li>
<li> <a href=""/index.php?title=Prototype/Explosion&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Explosion (page does not exist)"">Prototype/Explosion</a> <b>explosion</b>
<ul><li> <a href=""/index.php?title=Prototype/FlameThrowerExplosion&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/FlameThrowerExplosion (page does not exist)"">Prototype/FlameThrowerExplosion</a> <b>flame-thrower-explosion</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/EntityWithHealth"" title=""Prototype/EntityWithHealth"">Prototype/EntityWithHealth</a> <b>entity-with-health</b>
<ul><li> <a href=""/index.php?title=Prototype/Accumulator"" title=""Prototype/Accumulator"">Prototype/Accumulator</a> <b>accumulator</b></li>
<li> <a href=""/index.php?title=Prototype/AssemblingMachine"" title=""Prototype/AssemblingMachine"">Prototype/AssemblingMachine</a> <b>assembling-machine</b></li>
<li> <a href=""/index.php?title=Prototype/Beacon&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Beacon (page does not exist)"">Prototype/Beacon</a> <b>beacon</b></li>
<li> <a href=""/index.php?title=Prototype/Car"" title=""Prototype/Car"">Prototype/Car</a> <b>car</b></li>
<li> <a href=""/index.php?title=Prototype/Character"" title=""Prototype/Character"">Prototype/Character</a> <b>player</b></li>
<li> <a href=""/index.php?title=Prototype/Container"" title=""Prototype/Container"">Prototype/Container</a> <b>container</b>
<ul><li> <a href=""/index.php?title=Prototype/SmartContainer"" title=""Prototype/SmartContainer"">Prototype/SmartContainer</a> <b>smart-container</b>
<ul><li> <a href=""/index.php?title=Prototype/LogisticContainer"" title=""Prototype/LogisticContainer"">Prototype/LogisticContainer</a> <b>logistic-container</b></li></ul></li></ul></li>
<li> <a href=""/index.php?title=Prototype/ElectricPole"" title=""Prototype/ElectricPole"">Prototype/ElectricPole</a> <b>electric-pole</b></li>
<li> <a href=""/index.php?title=Prototype/Fish&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Fish (page does not exist)"">Prototype/Fish</a> <b>fish</b></li>
<li> <a href=""/index.php?title=Prototype/Furnace"" title=""Prototype/Furnace"">Prototype/Furnace</a> <b>furnace</b></li>
<li> <a href=""/index.php?title=Prototype/Inserter"" title=""Prototype/Inserter"">Prototype/Inserter</a> <b>inserter</b></li>
<li> <a href=""/index.php?title=Prototype/Lab"" title=""Prototype/Lab"">Prototype/Lab</a> <b>lab</b></li>
<li> <a href=""/index.php?title=Prototype/Lamp&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Lamp (page does not exist)"">Prototype/Lamp</a> <b>lamp</b></li>
<li> <a href=""/index.php?title=Prototype/Market&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Market (page does not exist)"">Prototype/Market</a> <b>market</b></li>
<li> <a href=""/index.php?title=Prototype/MiningDrill"" title=""Prototype/MiningDrill"">Prototype/MiningDrill</a> <b>mining-drill</b></li>
<li> <a href=""/index.php?title=Prototype/PipeConnectable"" title=""Prototype/PipeConnectable"">Prototype/PipeConnectable</a> <b>pipe-connectable</b>
<ul><li> <a href=""/index.php?title=Prototype/Boiler&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Boiler (page does not exist)"">Prototype/Boiler</a> <b>boiler</b></li>
<li> <a href=""/index.php?title=Prototype/Generator"" title=""Prototype/Generator"">Prototype/Generator</a> <b>generator</b></li>
<li> <a href=""/index.php?title=Prototype/Pump&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Pump (page does not exist)"">Prototype/Pump</a> <b>pump</b></li>
<li> <a href=""/index.php?title=Prototype/Pipe&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Pipe (page does not exist)"">Prototype/Pipe</a> <b>pipe</b></li>
<li> <a href=""/index.php?title=Prototype/PipeToGround&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/PipeToGround (page does not exist)"">Prototype/PipeToGround</a> <b>pipe-to-ground</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/PlayerPort&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/PlayerPort (page does not exist)"">Prototype/PlayerPort</a> <b>player-port</b></li>
<li> <a href=""/index.php?title=Prototype/Radar"" title=""Prototype/Radar"">Prototype/Radar</a> <b>radar</b></li>
<li> <a href=""/index.php?title=Prototype/Rail&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Rail (page does not exist)"">Prototype/Rail</a> <b>rail</b></li>
<li> <a href=""/index.php?title=Prototype/RailSignal&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/RailSignal (page does not exist)"">Prototype/RailSignal</a> <b>rail-signal</b></li>
<li> <a href=""/index.php?title=Prototype/Roboport"" title=""Prototype/Roboport"">Prototype/Roboport</a> <b>roboport</b></li>
<li> <a href=""/index.php?title=Prototype/Robot&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Robot (page does not exist)"">Prototype/Robot</a> <b>robot</b>
<ul><li> <a href=""/index.php?title=Prototype/CombatRobot&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/CombatRobot (page does not exist)"">Prototype/CombatRobot</a> <b>combat-robot</b></li>
<li> <a href=""/index.php?title=Prototype/ConstructionRobot&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/ConstructionRobot (page does not exist)"">Prototype/ConstructionRobot</a> <b>construction-robot</b></li>
<li> <a href=""/index.php?title=Prototype/LogisticRobot&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/LogisticRobot (page does not exist)"">Prototype/LogisticRobot</a> <b>logistic-robot</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/RocketDefense&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/RocketDefense (page does not exist)"">Prototype/RocketDefense</a> <b>rocket-defense</b></li>
<li> <a href=""/index.php?title=Prototype/SolarPanel"" title=""Prototype/SolarPanel"">Prototype/SolarPanel</a> <b>solar-panel</b></li>
<li> <a href=""/index.php?title=Prototype/Splitter&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Splitter (page does not exist)"">Prototype/Splitter</a> <b>splitter</b></li>
<li> <a href=""/index.php?title=Prototype/TrainStop&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/TrainStop (page does not exist)"">Prototype/TrainStop</a> <b>train-stop</b></li>
<li> <a href=""/index.php?title=Prototype/TrainUnit&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/TrainUnit (page does not exist)"">Prototype/TrainUnit</a> <b>train-unit</b>
<ul><li> <a href=""/index.php?title=Prototype/CargoWagon&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/CargoWagon (page does not exist)"">Prototype/CargoWagon</a> <b>cargo-wagon</b></li>
<li> <a href=""/index.php?title=Prototype/Locomotive"" title=""Prototype/Locomotive"">Prototype/Locomotive</a> <b>locomotive</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/TransportBelt&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/TransportBelt (page does not exist)"">Prototype/TransportBelt</a> <b>transport-belt</b></li>
<li> <a href=""/index.php?title=Prototype/TransportBeltToGround&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/TransportBeltToGround (page does not exist)"">Prototype/TransportBeltToGround</a> <b>transport-belt-to-ground</b></li>
<li> <a href=""/index.php?title=Prototype/Tree&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Tree (page does not exist)"">Prototype/Tree</a> <b>tree</b></li>
<li> <a href=""/index.php?title=Prototype/Turret&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Turret (page does not exist)"">Prototype/Turret</a> <b>turret</b>
<ul><li> <a href=""/index.php?title=Prototype/AmmoTurret&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/AmmoTurret (page does not exist)"">Prototype/AmmoTurret</a> <b>ammo-turret</b></li>
<li> <a href=""/index.php?title=Prototype/ElectricTurret&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/ElectricTurret (page does not exist)"">Prototype/ElectricTurret</a> <b>electric-turret</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/Unit"" title=""Prototype/Unit"">Prototype/Unit</a> <b>unit</b></li>
<li> <a href=""/index.php?title=Prototype/UnitSpawner&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/UnitSpawner (page does not exist)"">Prototype/UnitSpawner</a> <b>unit-spawner</b></li>
<li> <a href=""/index.php?title=Prototype/Wall&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Wall (page does not exist)"">Prototype/Wall</a> <b>wall</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/FlyingText&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/FlyingText (page does not exist)"">Prototype/FlyingText</a> <b>flying-text</b></li>
<li> <a href=""/index.php?title=Prototype/Ghost&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Ghost (page does not exist)"">Prototype/Ghost</a> <b>ghost</b></li>
<li> <a href=""/index.php?title=Prototype/ItemEntity&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/ItemEntity (page does not exist)"">Prototype/ItemEntity</a> <b>item-entity</b></li>
<li> <a href=""/index.php?title=Prototype/LandMine&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/LandMine (page does not exist)"">Prototype/LandMine</a> <b>land-mine</b></li>
<li> <a href=""/index.php?title=Prototype/Particle&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Particle (page does not exist)"">Prototype/Particle</a> <b>particle</b></li>
<li> <a href=""/index.php?title=Prototype/Projectile&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Projectile (page does not exist)"">Prototype/Projectile</a> <b>projectile</b></li>
<li> <a href=""/index.php?title=Prototype/RailRemnants&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/RailRemnants (page does not exist)"">Prototype/RailRemnants</a> <b>rail-remnants</b></li>
<li> <a href=""/index.php?title=Prototype/Resource&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Resource (page does not exist)"">Prototype/Resource</a> <b>resource</b></li>
<li> <a href=""/index.php?title=Prototype/Smoke&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Smoke (page does not exist)"">Prototype/Smoke</a> <b>smoke</b></li>
<li> <a href=""/index.php?title=Prototype/Sticker&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Sticker (page does not exist)"">Prototype/Sticker</a> <b>sticker</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/Item"" title=""Prototype/Item"" class=""mw-redirect"">Prototype/Item</a> <b>item</b>
<ul><li> <a href=""/index.php?title=Prototype/Ammo&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Ammo (page does not exist)"">Prototype/Ammo</a> <b>ammo</b></li>
<li> <a href=""/index.php?title=Prototype/Armor&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Armor (page does not exist)"">Prototype/Armor</a> <b>armor</b></li>
<li> <a href=""/index.php?title=Prototype/Capsule&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Capsule (page does not exist)"">Prototype/Capsule</a> <b>capsule</b></li>
<li> <a href=""/index.php?title=Prototype/Equipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Equipment (page does not exist)"">Prototype/Equipment</a> <b>equipment</b>
<ul><li> <a href=""/index.php?title=Prototype/NightVisionEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/NightVisionEquipment (page does not exist)"">Prototype/NightVisionEquipment</a> <b>night-vision-equipment</b></li>
<li> <a href=""/index.php?title=Prototype/EnergyShieldEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/EnergyShieldEquipment (page does not exist)"">Prototype/EnergyShieldEquipment</a> <b>energy-shield-equipment</b></li>
<li> <a href=""/index.php?title=Prototype/BatteryEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/BatteryEquipment (page does not exist)"">Prototype/BatteryEquipment</a> <b>battery-equipment</b></li>
<li> <a href=""/index.php?title=Prototype/SolarPanelEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/SolarPanelEquipment (page does not exist)"">Prototype/SolarPanelEquipment</a> <b>solar-panel-equipment</b></li>
<li> <a href=""/index.php?title=Prototype/GeneratorEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/GeneratorEquipment (page does not exist)"">Prototype/GeneratorEquipment</a> <b>generator-equipment</b></li>
<li> <a href=""/index.php?title=Prototype/ActiveDefenseEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/ActiveDefenseEquipment (page does not exist)"">Prototype/ActiveDefenseEquipment</a> <b>active-defense-equipment</b></li>
<li> <a href=""/index.php?title=Prototype/MovementBonusEquipment&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/MovementBonusEquipment (page does not exist)"">Prototype/MovementBonusEquipment</a> <b>movement-bonus-equipment</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/Gun&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Gun (page does not exist)"">Prototype/Gun</a> <b>gun</b></li>
<li> <a href=""/index.php?title=Prototype/MiningTool&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/MiningTool (page does not exist)"">Prototype/MiningTool</a> <b>mining-tool</b></li>
<li> <a href=""/index.php?title=Prototype/Module&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Module (page does not exist)"">Prototype/Module</a> <b>module</b></li></ul></li>
<li> <a href=""/index.php?title=Prototype/ItemGroup"" title=""Prototype/ItemGroup"">Prototype/ItemGroup</a> <b>item-group</b></li>
<li> <a href=""/index.php?title=Prototype/MapSettings&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/MapSettings (page does not exist)"">Prototype/MapSettings</a> <b>map-settings</b></li>
<li> <a href=""/index.php?title=Prototype/NoiseLayer"" title=""Prototype/NoiseLayer"">Prototype/NoiseLayer</a> <b>noise-layer</b></li>
<li> <a href=""/index.php?title=Prototype/RailCategory&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/RailCategory (page does not exist)"">Prototype/RailCategory</a> <b>recipe-category</b></li>
<li> <a href=""/index.php?title=Prototype/Recipe"" title=""Prototype/Recipe"">Prototype/Recipe</a> <b>recipe</b></li>
<li> <a href=""/index.php?title=Prototype/RecipeCategory"" title=""Prototype/RecipeCategory"">Prototype/RecipeCategory</a> <b>recipe-category</b></li>
<li> <a href=""/index.php?title=Prototype/Technology"" title=""Prototype/Technology"">Prototype/Technology</a> <b>technology</b></li>
<li> <a href=""/index.php?title=Prototype/Tile&amp;action=edit&amp;redlink=1"" class=""new"" title=""Prototype/Tile (page does not exist)"">Prototype/Tile</a> <b>tile</b></li></ul>
</data>";



        private static void GenerateClasses(JObject data, Dictionary<string, Dictionary<string, uint>> props, string[] itemTypes)
        {

            var xs = new XmlSerializer(typeof (data));
            var rrr = (data)xs.Deserialize(new StringReader(xml));
            var entityInfo = rrr.Childs.First(x => x.TextInfo.Text == "Prototype/Entity");
            var itemInfo = rrr.Childs.First(x => x.TextInfo.Text == "Prototype/Item");

            itemInfo.SetParent(null);
            entityInfo.SetParent(null);
            var hierarchy = entityInfo.All.Union(itemInfo.All).ToList();

            var toAdd = itemTypes.Except(hierarchy.Select(x => x.Text)).ToArray();
            foreach (var name in toAdd)
            {
                var prototypeInfo = new PrototypeInfo() {Text = name, TextInfo = new TextInfo() {Text = $"Prototype/{NormalizeName(name)}"}};
                prototypeInfo.SetParent(itemInfo);
                hierarchy.Add(prototypeInfo);
            }


            var allTypes = data.Properties()
               .SelectMany(x => ((JObject)x.Value).Properties())
               .Select(x => (JObject)x.Value)
               .GroupBy(x => x["type"].Value<string>())
               .ToDictionary(x => x.Key, x => x.GroupBy(y => y["subgroup"] ?? "").ToDictionary(y => y.Key, y => y.ToArray()))
               ;

            List<PrototypeInfo> removed = new List<PrototypeInfo>();

            foreach (var prototypeInfo in hierarchy.ToArray())
            {
                if (props.ContainsKey(prototypeInfo.Text))
                    prototypeInfo.Properties = props[prototypeInfo.Text];
                else
                {
                    var typeInfo = _typesAttributes.FirstOrDefault(x => x.Value.Id == prototypeInfo.Text);
                    if (typeInfo.Key == null)
                    {
                        if(allTypes.ContainsKey(prototypeInfo.Text))
                            prototypeInfo.Properties = new Dictionary<string, uint>();
                        else
                        {
                            hierarchy.Remove(prototypeInfo);
                            removed.Add(prototypeInfo);
                        }
                        continue;
                    }

                    var existsProps = typeInfo.Key.GetProperties().Select(x => new {PI = x, Attribute = x.Attribute<JsonPropertyAttribute>()})
                        .Where(x => x.Attribute != null)
                        .ToDictionary(x => string.IsNullOrEmpty(x.Attribute.PropertyName) ? x.PI.Name : x.Attribute.PropertyName, x => (uint)1);

                    prototypeInfo.Properties = existsProps;
                }
            }

            var sb = new StringBuilder();
            sb.AppendLine("//*************************************************************************************");
            sb.AppendLine("//");
            sb.AppendLine("//     G E N E R A T E D   C L A S S E S");
            sb.AppendLine("//");
            sb.AppendLine("//*************************************************************************************");
            sb.AppendLine();
            sb.AppendLine("using Newtonsoft.Json;");
            sb.AppendLine();

            sb.AppendLine($"namespace {typeof (Base).Namespace}");
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

                    var existsProps = exists.GetProperties().Select(x => new {PI = x, Attribute = x.Attribute<JsonPropertyAttribute>()})
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
                    if (notExists)
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
        }

        public static string NormalizeName(string name, params char[] separator)
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


[XmlRoot("data")]
public class data
{
    [XmlArray("ul")]
    [XmlArrayItem(typeof(PrototypeInfo), ElementName = "li")]
    public PrototypeInfo[] Childs { get; set; } 
}

[XmlRoot("li")]
public class PrototypeInfo
{
    [XmlElement(typeof(TextInfo), ElementName = "a")]
    public TextInfo TextInfo { get; set; }
    [XmlElement("b")]
    public string Text { get; set; }

    [XmlArray("ul")]
    [XmlArrayItem(typeof(PrototypeInfo), ElementName = "li")]
    public PrototypeInfo[] Childs { get; set; }

    public override string ToString()
    {
        return $"{TextInfo} [{Text}] (Items={Childs?.Length ?? 0})";
    }
    [XmlIgnore]
    public PrototypeInfo Parent { get; private set; }
    [XmlIgnore]
    public IEnumerable<PrototypeInfo> All => GetAll();

    private IEnumerable<PrototypeInfo> GetAll()
    {
        var first = new[] { this };
        var second = Childs?.SelectMany(x => x.All);
        return second != null ? first.Union(second) : first;
    }

    public void SetParent(PrototypeInfo parent)
    {
        Parent = parent;
        if(Childs == null)
            return;

        foreach (var child in Childs)
        {
            child.SetParent(this);
        }
    }


    [XmlIgnore]
    public string BaseType => GetBaseType();
    [XmlIgnore]
    public string ClassName => Storage.NormalizeName(Text);

    [XmlIgnore]
    public Dictionary<string, uint> Properties { get; set; }


    private string GetBaseType()
    {
        if (Parent != null)
            return Parent.ClassName;

        var isTyped = Properties.ContainsKey("type");
        var isNamed = Properties.ContainsKey("type");

        return isTyped && isNamed
            ? typeof (TypedNamedBase).Name
            : isTyped ? typeof (TypedBase).Name : typeof (Base).Name;
    }
}


[XmlRoot("a")]
public class TextInfo
{
    [XmlText]
    public string Text { get; set; }

    public override string ToString()
    {
        return Text;
    }
}
