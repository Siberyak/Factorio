using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using lua.reader.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            LoadJson();
            //Load();

            return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //var current = Environment.CurrentDirectory;
            //Environment.CurrentDirectory = @"C:\Games\Steam\steamapps\common\Factorio\data\core\lualib\";
            //var lua = new Lua();
            //lua["container_module_loader"] = null;
            //var tmp = Directory.GetFiles(Environment.CurrentDirectory, "*.lua").Select(x => lua.DoFile(x)).ToArray();

            //lua.DoFile(@".\data.lua");
            //Environment.CurrentDirectory = @"C:\Games\Steam\steamapps\common\Factorio\data\base\";
            //lua.DoFile(@".\data.lua");
            //var table = lua.GetTable("data");
        }

        private static void LoadJson()
        {
            var result = DataCache.LoadJson(DataCache.ResultJson);

            var recipies = result["recipe"].Children();

            var list = new List<Recipe>();
            foreach (JToken recipe in recipies)
            {
                var json = recipe.ToString();
                json = json.Substring(json.IndexOf("{"));
                json = json.Replace(Environment.NewLine, " ");
                var tmp = JsonConvert.DeserializeObject<Recipe>(json);
                tmp.Token = recipe.Children().First();
                list.Add(tmp);
            }

            var keys = result.Keys();

            var localeFiles = DataCache.LoadJson(DataCache.LocaleFilesJson);
        }


        public static void Load()
        {
            //I changed the name of the variable, so this copies the value over for people who are upgrading their Foreman version
            if (Settings.Default.FactorioPath == "" && Settings.Default.FactorioDataPath != "")
            {
                Settings.Default["FactorioPath"] = Path.GetDirectoryName(Settings.Default.FactorioDataPath);
                Settings.Default["FactorioDataPath"] = "";
            }

            if (!Directory.Exists(Settings.Default.FactorioPath))
            {
                foreach (var defaultPath in new[]
                {
                    Path.Combine(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), "Factorio"),
                    Path.Combine(Environment.GetEnvironmentVariable("ProgramW6432"), "Factorio"),
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Applications", "factorio.app", "Contents")
                }) //Not actually tested on a Mac
                {
                    if (Directory.Exists(defaultPath))
                    {
                        Settings.Default["FactorioPath"] = defaultPath;
                        Settings.Default.Save();
                        break;
                    }
                }
            }

            if (!Directory.Exists(Settings.Default.FactorioPath))
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default["FactorioPath"] = dialog.SelectedPath;
                        Settings.Default.Save();
                    }
                    else
                    {
                        //Close();
                        //Dispose();
                        return;
                    }
                }
            }

            if (!Directory.Exists(Settings.Default.FactorioModPath))
            {
                if (Directory.Exists(Path.Combine(Settings.Default.FactorioPath, "mods")))
                {
                    Settings.Default["FactorioModPath"] = Path.Combine(Settings.Default.FactorioPath, "mods");
                }
                else if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "factorio", "mods")))
                {
                    Settings.Default["FactorioModPath"] = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "factorio", "mods");
                }
            }

            if (Settings.Default.EnabledMods == null) Settings.Default.EnabledMods = new StringCollection();
            if (Settings.Default.EnabledAssemblers == null) Settings.Default.EnabledAssemblers = new StringCollection();
            if (Settings.Default.EnabledMiners == null) Settings.Default.EnabledMiners = new StringCollection();
            if (Settings.Default.EnabledModules == null) Settings.Default.EnabledModules = new StringCollection();


            DataCache.LoadAllData(null);
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Recipe
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public JToken Token { get; set; }

        private List<Ingredient> _i;
        public List<Ingredient> Ingredients => _i ?? (_i = GetIngredients());

        private List<Ingredient> GetIngredients()
        {
            return Token["ingredients"].Select(x => new Ingredient(x)).ToList();
        }

        public override string ToString()
        {
            return $"{Type}: '{Name}'" ?? base.ToString();
        }
    }

    public class Ingredient
    {
        private readonly JToken _token;

        public Ingredient(JToken token)
        {
            _token = token;

            if(token.Type == JTokenType.Object)
            {
                dynamic source = token;

                Type = source.type ?? "item";
                Item = source.name;
                Amount = source.amount;
            }
            else if (token.Type == JTokenType.Array)
            {
                Item = token[0].Value<string>();
                Amount = token[1].Value<double>();
            }

        }

        public string Type { get; set; }
        public string Item { get; set; }
        public object Amount { get; set; }

        public override string ToString()
        {
            return $"{Type}: '{Item}', {Amount}";
        }
    }
}