using SoccerApp.Models;

namespace SoccerApp.Services
{
    public class TeamBalancer
    {
        public static List<List<Player>> GenerateTeams(List<Player> players, int numberOfTeams)
        {
            if (numberOfTeams <= 0) return new List<List<Player>>();
            
            
            var teams = new List<List<Player>>();
            for (int i = 0; i < numberOfTeams; i++) teams.Add(new List<Player>());
            
            
            var sortedPlayers = players.OrderByDescending(p => p.OverallScore).ToList();
            foreach (var player in sortedPlayers)
            {
                
                var weakestTeam = teams.OrderBy(t => t.Sum(p => p.OverallScore)).First();
                weakestTeam.Add(player);
            }

            return teams;
        }
    }
}