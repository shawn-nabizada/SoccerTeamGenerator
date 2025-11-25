using System.ComponentModel.DataAnnotations;

namespace SoccerApp.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Position { get; set; } = string.Empty;
        [Range(1, 100)] public int BallControl { get; set; }
        [Range(1, 100)] public int PassingAccuracy { get; set; }
        [Range(1, 100)] public int Dribbling { get; set; }
        [Range(1, 100)] public int DefensiveAwareness { get; set; }
        [Range(1, 100)] public int Shooting { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public bool IsSelected { get; set; } = false;

        public double OverallScore => 
            (BallControl + PassingAccuracy + Dribbling + DefensiveAwareness + Shooting) / 5.0;

        
        public int PlayerRank
        {
            get
            {
                if (OverallScore >= 85) return 1;
                if (OverallScore >= 75) return 2;
                if (OverallScore >= 65) return 3;
                if (OverallScore >= 55) return 4;
                return 5;
            }
        }
    }
}