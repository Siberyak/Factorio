using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("assembling-machine", MemberSerialization = MemberSerialization.OptIn)]
    public partial class AssemblingMachine : EntityWithHealth, ICrafter
    { }
}