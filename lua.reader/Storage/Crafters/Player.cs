using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("player", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Player : EntityWithHealth, ICrafter { }
}