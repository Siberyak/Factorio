using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("rail-planner", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RailPlanner : TypedNamedBase, IRecipePart { }
}