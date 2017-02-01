using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("blueprint", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Blueprint : TypedNamedBase, IRecipePart
    { }
}