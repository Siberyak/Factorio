using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("repair-tool", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RepairTool : TypedNamedBase, IRecipePart { }
}