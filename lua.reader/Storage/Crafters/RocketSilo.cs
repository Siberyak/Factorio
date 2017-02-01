using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("rocket-silo", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RocketSilo : TypedNamedBase, ICrafter { }
}