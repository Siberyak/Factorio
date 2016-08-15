using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    [JsonObject("item", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Item : TypedNamedBase
    {
        private string _subgroup;

        [JsonProperty("flags")]
        public object Flags { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("stack_size")]
        public uint StackSize { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }

        [JsonProperty("subgroup")]
        public string Subgroup
        {
            get { return _subgroup ?? Type; }
            set { _subgroup = value; }
        }

        [JsonProperty("place_result")]
        public string PlaceResult { get; set; }

        [JsonProperty("fuel_value")]
        public string FuelValue { get; set; }

        [JsonProperty("healing_value")]
        public double HealingValue { get; set; }


        public override void ProcessLinks()
        {
            base.ProcessLinks();

            var subGroup = Storage.FindNode<ItemSubGroup>(x => x.Name == Subgroup);
            Storage.Link<ItemSubGroupEdge>(this, subGroup);
        }

        public override void SetToken(JToken token)
        {
            base.SetToken(token);
            // flags

        }
    }
}