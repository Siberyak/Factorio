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
        public string Result { get; set; }

        [JsonProperty("result_count")]
        public uint ResultCount { get; set; }

        [JsonProperty("category")]
        public string RecipeCategory { get; set; }

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
                    Populate(Result, Math.Max(ResultCount, 1), false);
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

        //private List<RecipePart> GetIngredients()
        //{
        //    return _token["ingredients"].Select(RecipePart.Input).ToList();
        //}

        //private List<RecipePart> GetResults()
        //{

        //    var token = _token["results"];

        //    List<RecipePart> list;

        //    if (token != null && token.Any())
        //    {
        //        list = _token["results"].Select(RecipePart.Output).ToList();
        //    }
        //    else
        //    {
        //        list = new List<RecipePart> { RecipePart.Output(Result, Math.Max(ResultCount, 1)) };
        //    }


        //    return list;
        //}

    }
}