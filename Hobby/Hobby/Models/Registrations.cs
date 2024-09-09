using System.ComponentModel.DataAnnotations;

namespace Hobby.Models
{
    public class Registrations
    {
        [Key]
        public int RegistrationID { get; set; }
        public int MatchID { get; set; }
        public int PlayerID { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
