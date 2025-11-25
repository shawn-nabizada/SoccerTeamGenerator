using SoccerApp.Models;
using SoccerApp.Services;

namespace SoccerApp.Tests
{
    public class BalancerTests
    {
        [Fact]
        public void GenerateTeams_ShouldDistributePlayersEvenly()
        {
            // Arrange
            var players = new List<Player>();
            
            for (int i = 0; i < 10; i++)
            {
                players.Add(new Player 
                { 
                    Name = $"Player {i}", 
                    Position = "Midfielder",
                    BallControl = 50,
                    PassingAccuracy = 50,
                    Dribbling = 50,
                    DefensiveAwareness = 50,
                    Shooting = 50
                });
            }
            int numberOfTeams = 2;

            // Act
            var teams = TeamBalancer.GenerateTeams(players, numberOfTeams);

            // Assert
            Assert.Equal(2, teams.Count);
            Assert.Equal(5, teams[0].Count);
            Assert.Equal(5, teams[1].Count);
        }

        [Fact]
        public void GenerateTeams_ShouldBalanceSkillLevels()
        {
            // Arrange: 2 Superstars (Avg 100) and 2 Rookies (Avg 10)
            var players = new List<Player>
            {
                // Superstar 1
                new Player { 
                    Name = "Star 1", Position = "Striker",
                    BallControl=100, PassingAccuracy=100, Dribbling=100, DefensiveAwareness=100, Shooting=100 
                }, 
                // Superstar 2
                new Player { 
                    Name = "Star 2", Position = "Striker",
                    BallControl=100, PassingAccuracy=100, Dribbling=100, DefensiveAwareness=100, Shooting=100 
                }, 
                // Rookie 1
                new Player { 
                    Name = "Rookie 1", Position = "Defender",
                    BallControl=10, PassingAccuracy=10, Dribbling=10, DefensiveAwareness=10, Shooting=10 
                },
                // Rookie 2
                new Player { 
                    Name = "Rookie 2", Position = "GK",
                    BallControl=10, PassingAccuracy=10, Dribbling=10, DefensiveAwareness=10, Shooting=10 
                }
            };

            // Act
            var teams = TeamBalancer.GenerateTeams(players, 2);

            // Assert
            double team1Score = teams[0].Sum(p => p.OverallScore);
            double team2Score = teams[1].Sum(p => p.OverallScore);

            Assert.Equal(110, team1Score);
            Assert.Equal(110, team2Score);
        }
        
        [Fact]
        public void GenerateTeams_HandlesEmptyList()
        {
            // Arrange
            var players = new List<Player>();

            // Act
            var teams = TeamBalancer.GenerateTeams(players, 2);

            // Assert
            Assert.Equal(2, teams.Count);
            Assert.Empty(teams[0]);
            Assert.Empty(teams[1]);
        }
    }
}