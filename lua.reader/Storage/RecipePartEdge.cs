namespace lua.reader
{
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