using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("furnace", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Furnace : EntityWithHealth, ICrafter
    { }
}