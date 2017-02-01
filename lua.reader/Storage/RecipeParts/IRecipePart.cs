using lua.reader.Graph;

namespace lua.reader
{
    public interface IRecipePart : IGraphNode
    {
        string Name { get; set; }

        string _Icon { get; set; }
    }
}