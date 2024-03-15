namespace APIFun.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Team> Teams { get; } // Add access to the Teams table
    }
}
