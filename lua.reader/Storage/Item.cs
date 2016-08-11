using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    [JsonObject("item", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Item : TypedNamedBase
    {
        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("stack_size")]
        public uint StackSize { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }

        [JsonProperty("subgroup")]
        public string subgroup { get; set; }

        [JsonProperty("place_result")]
        public string place_result { get; set; }

        [JsonProperty("fuel_value")]
        public string fuel_value { get; set; }

        [JsonProperty("healing_value")]
        public double healing_value { get; set; }



        public override void SetToken(JToken token)
        {
            base.SetToken(token);
            // flags

        }
    }
}