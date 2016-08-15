namespace lua.reader
{
    public class ItemSubGroupEdge : EdgeBase
    {
        public ItemSubGroupEdge(Storage storage, Item @from, ItemSubGroup to) : base(storage, @from, to)
        {
        }
    }

    public class ItemSubGroupGroupEdge : EdgeBase
    {
        public ItemSubGroupGroupEdge(Storage storage, ItemSubGroup @from, ItemGroup to) : base(storage, @from, to)
        {
        }
    }

    public class RecipePartEdge : EdgeBase
    {
        public RecipePartEdge(Storage storage, Recipe recipe, Item item) : base(storage, recipe, item)
        {
        }

        public Direction Direction { get; set; }
        public object Amount { get; set; }

        public override string ToString()
        {
            return $"[{GetType().Name}] {From}: {Direction} {Amount} {To}";
        }
    }
}