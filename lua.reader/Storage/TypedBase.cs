using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TypedBase : Base
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}