namespace SwayASP.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OpeningYear { get; set; }
        public uint StationCount { get; set; }
        public bool HasBranches { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}
