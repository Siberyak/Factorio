using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("item-with-entity-data", MemberSerialization = MemberSerialization.OptIn)]
    public partial class ItemWithEntityData : TypedNamedBase, IRecipePart
    { }
}