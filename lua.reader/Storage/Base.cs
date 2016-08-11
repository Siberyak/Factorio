using lua.reader.Graph;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lua.reader
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Base : GraphNode
    {
        protected JToken _token;

        public virtual void SetToken(JToken token)
        {
            _token = token;
        }

        public virtual void ProcessLinks()
        { }

        public Base() : base(null)
        {
        }

        public void SetGraph(IGraph graph)
        {
            _graph = graph;
        }

        public Storage Storage => (Storage) _graph;
    }
}