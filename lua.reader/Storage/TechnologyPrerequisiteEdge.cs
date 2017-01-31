namespace lua.reader
{
    public class TechnologyPrerequisiteEdge : EdgeBase
    {
        public TechnologyPrerequisiteEdge(Storage storage, Technology technology, Technology prerequisite) : base(storage, technology, prerequisite)
        {
        }

        public Technology Technology => (Technology) From;
        public Technology Prerequisite => (Technology) To;
    }
}