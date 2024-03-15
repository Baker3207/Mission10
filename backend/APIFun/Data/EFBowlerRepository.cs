namespace APIFun.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowlers> Bowlers => _bowlerContext.Bowlers;

        public IEnumerable<Team> Teams => _bowlerContext.Teams; // Provide access to the Teams table
    }
}
