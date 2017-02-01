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
        private string _Result { get; set; }

        [JsonProperty("result_count")]
        private uint _ResultCount { get; set; }

        [JsonProperty("category")]
        private string _RecipeCategory { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup { get; set; }

        [JsonProperty("energy_required")]
        public uint _EnergyRequired { get; set; }

        [JsonProperty("enabled")]
        public bool _Enabled { get; set; }



        public override void SetToken(JToken token)
        {
            base.SetToken(token);
        }

        public override void ProcessLinks()
        {
            base.ProcessLinks();

            // inputs
            {
                foreach (var token in _Ingredients.Cast<JToken>())
                {
                //}
                //foreach (var token in _token["ingredients"])
                //{
                    Populate(token, true);
                }

            }

            // outputs
            {
                
                var collectionToken = (_Results?.Cast<JToken>() ?? Enumerable.Empty<JToken>()).ToArray();
                if (collectionToken.Any())
                {
                    foreach (var token in collectionToken)
                    {
                        Populate(token, false);
                    }
                }
                else
                {
                    Populate(_Result, Math.Max(_ResultCount, 1), false);
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
            var item = Storage.FindNode<IRecipePart>(x => x.Name == name);

            if (item == null)
            {
                var arr = Storage.Nodes.OfType<TypedNamedBase>().Where(x => x.Name == name).ToArray();
            }

            var link = Storage.Link<RecipePartEdge>(this, item);
            link.Direction = input ? Direction.Input : Direction.Output;
            link.Amount = amount;
        }
    }
}