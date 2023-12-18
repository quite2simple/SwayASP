using System.ComponentModel.DataAnnotations.Schema;

namespace SwayASP.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OpeningYear { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Depth { get; set; }
        public uint PlatformCount { get; set; }
        public uint TrackCount { get; set; }

        [ForeignKey("Line")]
        public int LineFK { get; set; }
        public Line Line { get; set; }

        
    }
}
