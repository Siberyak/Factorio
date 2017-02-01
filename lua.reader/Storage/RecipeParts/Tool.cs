using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Tool : TypedNamedBase, IRecipePart
    { }
}