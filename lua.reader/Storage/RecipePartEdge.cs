namespace lua.reader
{
    public class RecipePartEdge : EdgeBase
    {
        public RecipePartEdge(Storage storage, Recipe recipe, IRecipePart item) : base(storage, recipe, (Base)item)
        {
        }

        public Direction Direction { get; set; }
        public object Amount { get; set; }

        public override string ToString()
        {
            return $"[{GetType().Name}] {From}: {Direction} {Amount} {To}";
        }
    }


    public class RecipeRecipeCategoryEdge : EdgeBase
    {
        public RecipeRecipeCategoryEdge(Storage storage, Recipe recipe, RecipeCategory recipeCategory) : base(storage, recipe, recipeCategory)
        {
        }

        public new Recipe From => (Recipe) base.From;
        public new RecipeCategory To => (RecipeCategory)base.To;
    }
}