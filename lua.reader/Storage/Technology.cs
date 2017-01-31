using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
// ReSharper disable InconsistentNaming

namespace lua.reader
{
    [JsonObject("technology", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Technology : TypedNamedBase
    {
        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }

        [JsonProperty("prerequisites")]
        public string[] prerequisites { get; set; }

        [JsonProperty("effects")]
        public JObject[] effects { get; set; }

        public override void ProcessLinks()
        {
            base.ProcessLinks();

            foreach (var prerequisite in prerequisites ?? Enumerable.Empty<string>())
            {
                Storage.Link<TechnologyPrerequisiteEdge>(this, Storage.Nodes.OfType<Technology>().First(x => x.Name == prerequisite));
            }

            foreach (var effect in effects ?? Enumerable.Empty<JObject>())
            {
                var recipeProperty = effect.Property("recipe");
                var rec = recipeProperty?.Value.Value<string>();

                var typeProperty = effect.Property("type");
                var type = typeProperty?.Value.Value<string>();

                //Storage.Link<TechnologyPrerequisiteEdge>(this, Storage.Nodes.OfType<Technology>().First(x => x.Name == prerequisite));
            }

        }
    }
}