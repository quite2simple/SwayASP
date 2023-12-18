using System.ComponentModel.DataAnnotations.Schema;

namespace SwayASP.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Line")]
        public int LineFK { get; set; }
        public Line Line { get; set; }

        
    }
}
