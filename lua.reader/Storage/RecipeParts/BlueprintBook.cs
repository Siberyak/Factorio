using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("blueprint-book", MemberSerialization = MemberSerialization.OptIn)]
    public partial class BlueprintBook : TypedNamedBase, IRecipePart
    { }
}