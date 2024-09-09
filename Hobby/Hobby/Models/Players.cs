using System.ComponentModel.DataAnnotations;

namespace Hobby.Models
{
    public class Players
    {
        [Key]
        public int PlayerID { get; set; }
        public required string PlayerName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}
