using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("ammo", MemberSerialization = MemberSerialization.OptIn)]
    public class Ammo : Item
    {
        [JsonProperty("ammo_type")]
        public object AmmoType { get; set; }
    }
}