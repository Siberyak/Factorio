using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("item-subgroup", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ItemSubGroup : TypedNamedBase
    {
        [JsonProperty("group")]
        public string Group { get; set; }
    }
}