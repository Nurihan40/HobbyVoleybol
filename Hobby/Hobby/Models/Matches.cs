using System.ComponentModel.DataAnnotations;

namespace Hobby.Models
{
    public class Matches
    {
        [Key]
        public int MatchID { get; set; }
        public DateTime MatchTime { get; set; }
        public int LocationID { get; set; }
        public required Locations Location { get; set; }
        public int RefereeID { get; set; }
        public required Referees Referee  { get; set; }

        public int DifficultyLevelID { get; set; }
        public required DifficultyLevels difficultyLevel { get; set; }

        public int MissingPlayerCount { get; set; }
        public int MaxPlayers { get; set; }
        public string? Rules { get; set; }
        public string? Prize { get; set; }
        public bool Status { get; set; }
    }
}
