using System.ComponentModel.DataAnnotations;

namespace Hobby.Models
{
    public class Referees
    {
        [Key]
        public int RefereeID { get; set; }
        public required string RefereeName { get; set; }
        public required string ContactDetails { get; set; }
        public required ICollection<Matches> Matches { get; set; }

    }
}
