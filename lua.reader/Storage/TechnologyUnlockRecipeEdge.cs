namespace lua.reader
{
    public class TechnologyUnlockRecipeEdge : EdgeBase
    {
        public TechnologyUnlockRecipeEdge(Storage storage, Technology technology, Recipe recipe) : base(storage, technology, recipe)
        {
        }

        public Technology Technology => (Technology)From;
        public Recipe Recipe => (Recipe)To;
    }
}