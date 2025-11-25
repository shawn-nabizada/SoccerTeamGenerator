using SoccerApp.Models;

namespace SoccerApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SoccerContext context)
        {
            if (context.Players.Any())
            {
                return;
            }

            var players = new List<Player>();

            // --- GOALKEEPERS (10) ---
            players.AddRange(new[] {
                new Player { Name = "Thibaut Courtois", Position="GK", BallControl=40, PassingAccuracy=75, Dribbling=45, DefensiveAwareness=94, Shooting=20 },
                new Player { Name = "Alisson Becker", Position="GK", BallControl=50, PassingAccuracy=85, Dribbling=50, DefensiveAwareness=92, Shooting=25 },
                new Player { Name = "Marc-André ter Stegen", Position="GK", BallControl=48, PassingAccuracy=88, Dribbling=45, DefensiveAwareness=91, Shooting=20 },
                new Player { Name = "Ederson", Position="GK", BallControl=55, PassingAccuracy=91, Dribbling=55, DefensiveAwareness=90, Shooting=30 },
                new Player { Name = "Jan Oblak", Position="GK", BallControl=35, PassingAccuracy=60, Dribbling=30, DefensiveAwareness=92, Shooting=15 },
                new Player { Name = "Gianluigi Donnarumma", Position="GK", BallControl=40, PassingAccuracy=70, Dribbling=40, DefensiveAwareness=91, Shooting=15 },
                new Player { Name = "Mike Maignan", Position="GK", BallControl=45, PassingAccuracy=78, Dribbling=48, DefensiveAwareness=89, Shooting=20 },
                new Player { Name = "Manuel Neuer", Position="GK", BallControl=60, PassingAccuracy=90, Dribbling=55, DefensiveAwareness=88, Shooting=35 },
                new Player { Name = "Emiliano Martinez", Position="GK", BallControl=40, PassingAccuracy=70, Dribbling=40, DefensiveAwareness=88, Shooting=20 },
                new Player { Name = "Yassine Bounou", Position="GK", BallControl=35, PassingAccuracy=65, Dribbling=35, DefensiveAwareness=87, Shooting=15 }
            });

            // --- DEFENDERS (40) ---
            players.AddRange(new[] {
                new Player { Name = "Ruben Dias", Position="Defender", BallControl=75, PassingAccuracy=80, Dribbling=65, DefensiveAwareness=96, Shooting=40 },
                new Player { Name = "Virgil van Dijk", Position="Defender", BallControl=78, PassingAccuracy=82, Dribbling=72, DefensiveAwareness=95, Shooting=60 },
                new Player { Name = "Ronald Araujo", Position="Defender", BallControl=70, PassingAccuracy=70, Dribbling=65, DefensiveAwareness=92, Shooting=50 },
                new Player { Name = "Eder Militao", Position="Defender", BallControl=76, PassingAccuracy=78, Dribbling=75, DefensiveAwareness=91, Shooting=55 },
                new Player { Name = "Marquinhos", Position="Defender", BallControl=80, PassingAccuracy=85, Dribbling=74, DefensiveAwareness=92, Shooting=45 },
                new Player { Name = "William Saliba", Position="Defender", BallControl=78, PassingAccuracy=82, Dribbling=75, DefensiveAwareness=90, Shooting=40 },
                new Player { Name = "David Alaba", Position="Defender", BallControl=85, PassingAccuracy=88, Dribbling=82, DefensiveAwareness=89, Shooting=75 },
                new Player { Name = "Theo Hernandez", Position="Defender", BallControl=84, PassingAccuracy=80, Dribbling=88, DefensiveAwareness=82, Shooting=76 },
                new Player { Name = "Achraf Hakimi", Position="Defender", BallControl=83, PassingAccuracy=81, Dribbling=86, DefensiveAwareness=80, Shooting=74 },
                new Player { Name = "Trent Alexander-Arnold", Position="Defender", BallControl=86, PassingAccuracy=96, Dribbling=80, DefensiveAwareness=78, Shooting=78 },
                new Player { Name = "Alphonso Davies", Position="Defender", BallControl=84, PassingAccuracy=79, Dribbling=89, DefensiveAwareness=80, Shooting=70 },
                new Player { Name = "Joao Cancelo", Position="Defender", BallControl=88, PassingAccuracy=88, Dribbling=87, DefensiveAwareness=81, Shooting=75 },
                new Player { Name = "Antonio Rudiger", Position="Defender", BallControl=72, PassingAccuracy=75, Dribbling=68, DefensiveAwareness=91, Shooting=50 },
                new Player { Name = "John Stones", Position="Defender", BallControl=84, PassingAccuracy=89, Dribbling=80, DefensiveAwareness=90, Shooting=55 },
                new Player { Name = "Matthijs de Ligt", Position="Defender", BallControl=75, PassingAccuracy=78, Dribbling=68, DefensiveAwareness=90, Shooting=55 },
                new Player { Name = "Jules Kounde", Position="Defender", BallControl=78, PassingAccuracy=80, Dribbling=75, DefensiveAwareness=89, Shooting=50 },
                new Player { Name = "Kyle Walker", Position="Defender", BallControl=76, PassingAccuracy=78, Dribbling=78, DefensiveAwareness=88, Shooting=60 },
                new Player { Name = "Andrew Robertson", Position="Defender", BallControl=80, PassingAccuracy=84, Dribbling=79, DefensiveAwareness=85, Shooting=65 },
                new Player { Name = "Lisandro Martinez", Position="Defender", BallControl=81, PassingAccuracy=83, Dribbling=75, DefensiveAwareness=89, Shooting=50 },
                new Player { Name = "Alessandro Bastoni", Position="Defender", BallControl=80, PassingAccuracy=84, Dribbling=75, DefensiveAwareness=88, Shooting=45 },
                new Player { Name = "Bremer", Position="Defender", BallControl=70, PassingAccuracy=70, Dribbling=65, DefensiveAwareness=89, Shooting=40 },
                new Player { Name = "Kim Min Jae", Position="Defender", BallControl=75, PassingAccuracy=78, Dribbling=70, DefensiveAwareness=89, Shooting=40 },
                new Player { Name = "Josko Gvardiol", Position="Defender", BallControl=80, PassingAccuracy=82, Dribbling=78, DefensiveAwareness=88, Shooting=60 },
                new Player { Name = "Raphael Varane", Position="Defender", BallControl=75, PassingAccuracy=76, Dribbling=70, DefensiveAwareness=88, Shooting=45 },
                new Player { Name = "Reece James", Position="Defender", BallControl=83, PassingAccuracy=86, Dribbling=82, DefensiveAwareness=84, Shooting=72 },
                new Player { Name = "Kieran Trippier", Position="Defender", BallControl=80, PassingAccuracy=87, Dribbling=76, DefensiveAwareness=82, Shooting=68 },
                new Player { Name = "Jeremie Frimpong", Position="Defender", BallControl=85, PassingAccuracy=80, Dribbling=88, DefensiveAwareness=75, Shooting=70 },
                new Player { Name = "Grimaldo", Position="Defender", BallControl=86, PassingAccuracy=88, Dribbling=85, DefensiveAwareness=78, Shooting=78 },
                new Player { Name = "Dayot Upamecano", Position="Defender", BallControl=74, PassingAccuracy=76, Dribbling=72, DefensiveAwareness=87, Shooting=45 },
                new Player { Name = "Ibrahima Konate", Position="Defender", BallControl=72, PassingAccuracy=74, Dribbling=68, DefensiveAwareness=88, Shooting=40 },
                new Player { Name = "Gabriel Magalhaes", Position="Defender", BallControl=73, PassingAccuracy=75, Dribbling=65, DefensiveAwareness=89, Shooting=50 },
                new Player { Name = "Manuel Akanji", Position="Defender", BallControl=78, PassingAccuracy=80, Dribbling=75, DefensiveAwareness=88, Shooting=55 },
                new Player { Name = "Nathan Ake", Position="Defender", BallControl=79, PassingAccuracy=81, Dribbling=74, DefensiveAwareness=88, Shooting=50 },
                new Player { Name = "Federico Dimarco", Position="Defender", BallControl=82, PassingAccuracy=86, Dribbling=80, DefensiveAwareness=78, Shooting=74 },
                new Player { Name = "Dani Carvajal", Position="Defender", BallControl=80, PassingAccuracy=81, Dribbling=78, DefensiveAwareness=85, Shooting=60 },
                new Player { Name = "Nuno Mendes", Position="Defender", BallControl=81, PassingAccuracy=78, Dribbling=84, DefensiveAwareness=79, Shooting=65 },
                new Player { Name = "Ferland Mendy", Position="Defender", BallControl=80, PassingAccuracy=78, Dribbling=82, DefensiveAwareness=84, Shooting=65 },
                new Player { Name = "Cristian Romero", Position="Defender", BallControl=75, PassingAccuracy=74, Dribbling=70, DefensiveAwareness=89, Shooting=45 },
                new Player { Name = "Sven Botman", Position="Defender", BallControl=72, PassingAccuracy=75, Dribbling=65, DefensiveAwareness=88, Shooting=40 },
                new Player { Name = "Ben White", Position="Defender", BallControl=78, PassingAccuracy=80, Dribbling=76, DefensiveAwareness=85, Shooting=55 }
            });

            // --- MIDFIELDERS (40) ---
            players.AddRange(new[] {
                new Player { Name = "Kevin De Bruyne", Position="Midfielder", BallControl=92, PassingAccuracy=99, Dribbling=88, DefensiveAwareness=65, Shooting=88 },
                new Player { Name = "Rodri", Position="Midfielder", BallControl=88, PassingAccuracy=93, Dribbling=82, DefensiveAwareness=90, Shooting=80 },
                new Player { Name = "Jude Bellingham", Position="Midfielder", BallControl=90, PassingAccuracy=88, Dribbling=91, DefensiveAwareness=80, Shooting=86 },
                new Player { Name = "Bernardo Silva", Position="Midfielder", BallControl=95, PassingAccuracy=90, Dribbling=96, DefensiveAwareness=70, Shooting=78 },
                new Player { Name = "Martin Odegaard", Position="Midfielder", BallControl=91, PassingAccuracy=92, Dribbling=90, DefensiveAwareness=65, Shooting=82 },
                new Player { Name = "Luka Modric", Position="Midfielder", BallControl=93, PassingAccuracy=95, Dribbling=90, DefensiveAwareness=72, Shooting=78 },
                new Player { Name = "Federico Valverde", Position="Midfielder", BallControl=86, PassingAccuracy=88, Dribbling=84, DefensiveAwareness=82, Shooting=86 },
                new Player { Name = "Pedri", Position="Midfielder", BallControl=92, PassingAccuracy=90, Dribbling=91, DefensiveAwareness=68, Shooting=70 },
                new Player { Name = "Bruno Fernandes", Position="Midfielder", BallControl=88, PassingAccuracy=92, Dribbling=84, DefensiveAwareness=70, Shooting=86 },
                new Player { Name = "Joshua Kimmich", Position="Midfielder", BallControl=88, PassingAccuracy=92, Dribbling=84, DefensiveAwareness=84, Shooting=75 },
                new Player { Name = "Frenkie de Jong", Position="Midfielder", BallControl=92, PassingAccuracy=90, Dribbling=91, DefensiveAwareness=78, Shooting=68 },
                new Player { Name = "Declan Rice", Position="Midfielder", BallControl=84, PassingAccuracy=86, Dribbling=80, DefensiveAwareness=88, Shooting=75 },
                new Player { Name = "Toni Kroos", Position="Midfielder", BallControl=90, PassingAccuracy=98, Dribbling=82, DefensiveAwareness=70, Shooting=80 },
                new Player { Name = "Ilkay Gundogan", Position="Midfielder", BallControl=89, PassingAccuracy=90, Dribbling=88, DefensiveAwareness=75, Shooting=80 },
                new Player { Name = "Jamal Musiala", Position="Midfielder", BallControl=94, PassingAccuracy=85, Dribbling=96, DefensiveAwareness=55, Shooting=82 },
                new Player { Name = "Nicolo Barella", Position="Midfielder", BallControl=87, PassingAccuracy=88, Dribbling=85, DefensiveAwareness=78, Shooting=76 },
                new Player { Name = "Eduardo Camavinga", Position="Midfielder", BallControl=88, PassingAccuracy=86, Dribbling=87, DefensiveAwareness=84, Shooting=72 },
                new Player { Name = "Aurelien Tchouameni", Position="Midfielder", BallControl=84, PassingAccuracy=86, Dribbling=80, DefensiveAwareness=88, Shooting=75 },
                new Player { Name = "Sandro Tonali", Position="Midfielder", BallControl=85, PassingAccuracy=86, Dribbling=82, DefensiveAwareness=82, Shooting=75 },
                new Player { Name = "Gavi", Position="Midfielder", BallControl=88, PassingAccuracy=86, Dribbling=89, DefensiveAwareness=75, Shooting=68 },
                new Player { Name = "Bruno Guimaraes", Position="Midfielder", BallControl=87, PassingAccuracy=88, Dribbling=86, DefensiveAwareness=79, Shooting=75 },
                new Player { Name = "Alexis Mac Allister", Position="Midfielder", BallControl=86, PassingAccuracy=87, Dribbling=85, DefensiveAwareness=76, Shooting=80 },
                new Player { Name = "Dominik Szoboszlai", Position="Midfielder", BallControl=86, PassingAccuracy=88, Dribbling=84, DefensiveAwareness=65, Shooting=86 },
                new Player { Name = "Florian Wirtz", Position="Midfielder", BallControl=91, PassingAccuracy=89, Dribbling=92, DefensiveAwareness=50, Shooting=80 },
                new Player { Name = "Lucas Paqueta", Position="Midfielder", BallControl=90, PassingAccuracy=85, Dribbling=89, DefensiveAwareness=70, Shooting=78 },
                new Player { Name = "Hakan Calhanoglu", Position="Midfielder", BallControl=88, PassingAccuracy=92, Dribbling=84, DefensiveAwareness=72, Shooting=82 },
                new Player { Name = "Casemiro", Position="Midfielder", BallControl=80, PassingAccuracy=82, Dribbling=75, DefensiveAwareness=90, Shooting=74 },
                new Player { Name = "Fabinho", Position="Midfielder", BallControl=82, PassingAccuracy=84, Dribbling=78, DefensiveAwareness=88, Shooting=65 },
                new Player { Name = "Marco Verratti", Position="Midfielder", BallControl=94, PassingAccuracy=92, Dribbling=93, DefensiveAwareness=80, Shooting=60 },
                new Player { Name = "Enzo Fernandez", Position="Midfielder", BallControl=86, PassingAccuracy=89, Dribbling=84, DefensiveAwareness=78, Shooting=78 },
                new Player { Name = "Moisés Caicedo", Position="Midfielder", BallControl=82, PassingAccuracy=84, Dribbling=80, DefensiveAwareness=86, Shooting=65 },
                new Player { Name = "Douglas Luiz", Position="Midfielder", BallControl=85, PassingAccuracy=86, Dribbling=83, DefensiveAwareness=80, Shooting=76 },
                new Player { Name = "Rodrigo De Paul", Position="Midfielder", BallControl=84, PassingAccuracy=85, Dribbling=82, DefensiveAwareness=78, Shooting=76 },
                new Player { Name = "Adrien Rabiot", Position="Midfielder", BallControl=84, PassingAccuracy=83, Dribbling=82, DefensiveAwareness=80, Shooting=75 },
                new Player { Name = "Leon Goretzka", Position="Midfielder", BallControl=83, PassingAccuracy=84, Dribbling=80, DefensiveAwareness=82, Shooting=80 },
                new Player { Name = "Granit Xhaka", Position="Midfielder", BallControl=82, PassingAccuracy=88, Dribbling=78, DefensiveAwareness=80, Shooting=78 },
                new Player { Name = "Mateo Kovacic", Position="Midfielder", BallControl=91, PassingAccuracy=88, Dribbling=90, DefensiveAwareness=75, Shooting=65 },
                new Player { Name = "Thomas Partey", Position="Midfielder", BallControl=84, PassingAccuracy=85, Dribbling=82, DefensiveAwareness=84, Shooting=72 },
                new Player { Name = "James Maddison", Position="Midfielder", BallControl=88, PassingAccuracy=89, Dribbling=86, DefensiveAwareness=55, Shooting=82 },
                new Player { Name = "Martin Zubimendi", Position="Midfielder", BallControl=83, PassingAccuracy=86, Dribbling=80, DefensiveAwareness=84, Shooting=65 }
            });

            // --- STRIKERS (20) ---
            players.AddRange(new[] {
                new Player { Name = "Kylian Mbappe", Position="Striker", BallControl=94, PassingAccuracy=82, Dribbling=98, DefensiveAwareness=40, Shooting=95 },
                new Player { Name = "Erling Haaland", Position="Striker", BallControl=84, PassingAccuracy=70, Dribbling=82, DefensiveAwareness=45, Shooting=99 },
                new Player { Name = "Harry Kane", Position="Striker", BallControl=88, PassingAccuracy=92, Dribbling=84, DefensiveAwareness=55, Shooting=98 },
                new Player { Name = "Robert Lewandowski", Position="Striker", BallControl=89, PassingAccuracy=80, Dribbling=86, DefensiveAwareness=45, Shooting=96 },
                new Player { Name = "Karim Benzema", Position="Striker", BallControl=92, PassingAccuracy=88, Dribbling=90, DefensiveAwareness=40, Shooting=94 },
                new Player { Name = "Vinicius Jr", Position="Striker", BallControl=92, PassingAccuracy=80, Dribbling=98, DefensiveAwareness=35, Shooting=86 },
                new Player { Name = "Mohamed Salah", Position="Striker", BallControl=90, PassingAccuracy=84, Dribbling=92, DefensiveAwareness=45, Shooting=92 },
                new Player { Name = "Lionel Messi", Position="Striker", BallControl=99, PassingAccuracy=98, Dribbling=99, DefensiveAwareness=40, Shooting=94 },
                new Player { Name = "Victor Osimhen", Position="Striker", BallControl=82, PassingAccuracy=70, Dribbling=84, DefensiveAwareness=45, Shooting=90 },
                new Player { Name = "Lautaro Martinez", Position="Striker", BallControl=86, PassingAccuracy=78, Dribbling=86, DefensiveAwareness=55, Shooting=89 },
                new Player { Name = "Antoine Griezmann", Position="Striker", BallControl=91, PassingAccuracy=89, Dribbling=88, DefensiveAwareness=65, Shooting=88 },
                new Player { Name = "Son Heung-min", Position="Striker", BallControl=88, PassingAccuracy=84, Dribbling=89, DefensiveAwareness=50, Shooting=92 },
                new Player { Name = "Rafael Leao", Position="Striker", BallControl=89, PassingAccuracy=76, Dribbling=92, DefensiveAwareness=35, Shooting=82 },
                new Player { Name = "Christopher Nkunku", Position="Striker", BallControl=89, PassingAccuracy=84, Dribbling=90, DefensiveAwareness=60, Shooting=86 },
                new Player { Name = "Paulo Dybala", Position="Striker", BallControl=92, PassingAccuracy=88, Dribbling=91, DefensiveAwareness=45, Shooting=86 },
                new Player { Name = "Gabriel Jesus", Position="Striker", BallControl=89, PassingAccuracy=80, Dribbling=90, DefensiveAwareness=55, Shooting=84 },
                new Player { Name = "Alexander Isak", Position="Striker", BallControl=84, PassingAccuracy=75, Dribbling=85, DefensiveAwareness=40, Shooting=86 },
                new Player { Name = "Julian Alvarez", Position="Striker", BallControl=86, PassingAccuracy=82, Dribbling=86, DefensiveAwareness=60, Shooting=85 },
                new Player { Name = "Darwin Nunez", Position="Striker", BallControl=78, PassingAccuracy=72, Dribbling=80, DefensiveAwareness=50, Shooting=86 },
                new Player { Name = "Ousmane Dembele", Position="Striker", BallControl=88, PassingAccuracy=82, Dribbling=94, DefensiveAwareness=35, Shooting=78 }
            });

            context.Players.AddRange(players);
            context.SaveChanges();
        }
    }
}