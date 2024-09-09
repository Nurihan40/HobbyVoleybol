using System.ComponentModel.DataAnnotations;

namespace Hobby.Models
{
    public class DifficultyLevels
    {
        [Key]
        public int DifficultyLevelID { get; set; }
        public required string LevelName { get; set; }
        public required ICollection<Matches> Matches { get; set; }

    }
}
