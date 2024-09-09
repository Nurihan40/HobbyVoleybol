using System.ComponentModel.DataAnnotations;

namespace Hobby.Models
{
    public class Locations
    {
        [Key]
        public int LocationID { get; set; }
        public required string LocationName { get; set; }
        public required string Address { get; set; }
       
        public required ICollection<Matches> Matches { get; set; } 
    }
}
