using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{

[JsonObject("item", MemberSerialization = MemberSerialization.OptIn)]
    public partial class Item : TypedNamedBase
    {
        private string _subgroup;

        [JsonProperty("flags")]
        public object _Flags { get; set; }

        [JsonProperty("order")]
        public string _Order { get; set; }

        [JsonProperty("stack_size")]
        public uint _StackSize { get; set; }

        [JsonProperty("icon")]
        public string _Icon { get; set; }

        [JsonProperty("subgroup")]
        public string _Subgroup
        {
            get { return _subgroup ?? Type; }
            set { _subgroup = value; }
        }

        [JsonProperty("place_result")]
        public string _PlaceResult { get; set; }

        [JsonProperty("fuel_value")]
        public string _FuelValue { get; set; }

        [JsonProperty("healing_value")]
        public double _HealingValue { get; set; }


        public override void ProcessLinks()
        {
            base.ProcessLinks();

            var subGroup = Storage.FindNode<ItemSubGroup>(x => x.Name == _Subgroup);
            Storage.Link<ItemSubGroupEdge>(this, subGroup);


        }

    }
}