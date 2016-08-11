using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TypedNamedBase : TypedBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Type}: '{Name}'" ?? base.ToString();
        }
    }
}