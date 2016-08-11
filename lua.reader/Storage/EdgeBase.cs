using lua.reader.Graph;

namespace lua.reader
{
    public class EdgeBase : GraphEdge
    {
        public EdgeBase(Storage storage, Base @from, Base to) : base(storage, @from, to)
        {
        }

        public override string ToString()
        {
            return $"{From} -> {To}";
        }
    }
}