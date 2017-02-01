using lua.reader.Graph;

namespace lua.reader
{
    public interface ICrafter : IGraphNode
    {
        object[] _CraftingCategories { get; }
    }
}