using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Base
    {
        protected JToken _token;

        public virtual void SetToken(JToken token)
        {
            _token = token;
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class TypedBase : Base
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}