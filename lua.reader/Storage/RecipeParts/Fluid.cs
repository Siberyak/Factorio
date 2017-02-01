using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("fluid", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Fluid : TypedNamedBase, IRecipePart
    { }
}