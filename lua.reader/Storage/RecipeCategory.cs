using System.Linq;
using Newtonsoft.Json;

namespace lua.reader
{
    [JsonObject("recipe-category", MemberSerialization = MemberSerialization.OptIn)]
    public partial class RecipeCategory : TypedNamedBase
    {
        public override void ProcessLinks()
        {
            base.ProcessLinks();

            var crafters = Storage.Nodes.OfType<ICrafter>().ToArray();
            var craftersByName = crafters.Where(x => x._CraftingCategories.Contains(Name)).ToArray();
            if (craftersByName.Length != 0)
            {
                
            }

            foreach (var crafter in craftersByName)
            {
                Storage.Link<RecipeCategoryCrafterEdge>(this, crafter);
            }
        }
    }

    public class RecipeCategoryCrafterEdge : EdgeBase
    {
        public RecipeCategoryCrafterEdge(Storage storage, RecipeCategory recipeCategory, ICrafter crafter) : base(storage, recipeCategory, (Base)crafter)
        {
        }

        public RecipeCategory RecipeCategory => (RecipeCategory) From;
        public ICrafter Crafter => (ICrafter) To;
    }
}