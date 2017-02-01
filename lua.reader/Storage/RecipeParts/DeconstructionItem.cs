using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("deconstruction-item", MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeconstructionItem : TypedNamedBase, IRecipePart
    {
        
    }
}