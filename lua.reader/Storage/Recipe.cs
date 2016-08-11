using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    [JsonObject("recipe", MemberSerialization = MemberSerialization.OptIn)]
    public class Recipe : TypedNamedBase
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
            Ingredients = GetIngredients();
            Results = GetResults();
        }

        public List<RecipePart> Ingredients { get; private set; }
        public List<RecipePart> Results { get; private set; }

        private List<RecipePart> GetIngredients()
        {
            return _token["ingredients"].Select(RecipePart.Input).ToList();
        }

        private List<RecipePart> GetResults()
        {

            var token = _token["results"];

            List<RecipePart> list;

            if (token != null && token.Any())
            {
                list = _token["results"].Select(RecipePart.Output).ToList();
            }
            else
            {
                list = new List<RecipePart> { RecipePart.Output(Result, Math.Max(ResultCount, 1)) };
            }


            return list;
        }

    }
}