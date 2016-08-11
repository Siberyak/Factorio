using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("item-group", MemberSerialization = MemberSerialization.OptIn)]
    public class ItemGroup : TypedNamedBase
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}