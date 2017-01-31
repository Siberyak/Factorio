using System;
using System.Collections.Generic;
using System.Linq;
using lua.reader.Graph;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    [JsonObject("recipe", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Recipe : TypedNamedBase
    {

        [JsonProperty("result")]
        private string _result { get; set; }

        [JsonProperty("result_count")]
        private uint _result_count { get; set; }

        [JsonProperty("category")]
        private string _recipe_category { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup { get; set; }

        [JsonProperty("energy_required")]
        public uint EnergyRequired { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }



        public override void SetToken(JToken token)
        {
            base.SetToken(token);
        }

        public override void ProcessLinks()
        {
            base.ProcessLinks();

            // inputs
            {
                foreach (var token in _token["ingredients"])
                {
                    Populate(token, true);
                }

            }

            // outputs
            {
                var collectionToken = _token["results"];

                if (collectionToken != null && collectionToken.Any())
                {
                    foreach (var token in _token["ingredients"])
                    {
                        Populate(token, false);
                    }
                }
                else
                {
                    Populate(_result, Math.Max(_result_count, 1), false);
                }
            }


            // category
            {
                var category = ((JObject) _token).Property("category")?.Value.Value<string>();
                if(category != null)
                {
                    var recipeCategory = Storage.RecipeCategories.First(x => x.Name == category);
                    Storage.Link<RecipeRecipeCategoryEdge>(this, recipeCategory);
                }
            }

            // crafitng categories
            //RecipeCategory
            //Storage.Nodes<AssemblingMachine>().Where(x => x.CraftingCategories)

        }

        private void Populate(JToken token, bool input)
        {
            object amount = null;
            string name = null;

            if (token.Type == JTokenType.Object)
            {
                dynamic source = token;

                name = source.name;
                amount = source.amount;
            }
            else if (token.Type == JTokenType.Array)
            {
                name = token[0].Value<string>();
                amount = token[1].Value<double>();
            }

            Populate(name, amount, input);
        }

        private void Populate(string name, object amount, bool input)
        {
            var item = Storage.FindNode<Item>(x => x.Name == name);

            var link = Storage.Link<RecipePartEdge>(this, item);
            link.Direction = input ? Direction.Input : Direction.Output;
            link.Amount = amount;
        }
    }
}