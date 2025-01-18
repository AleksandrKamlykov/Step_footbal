using Microsoft.EntityFrameworkCore;
using Step_footbal.Models;

namespace Step_footbal.Context
{
    public class PrimeraContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        private readonly string _connectionString = "Server=tcp:pyshop.database.windows.net,1433;Initial Catalog=py_Shop;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team1)
                .WithMany()
                .HasForeignKey(m => m.Team1Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team2)
                .WithMany()
                .HasForeignKey(m => m.Team2Id)
                .OnDelete(DeleteBehavior.Restrict);

                        modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "FC Barcelona", City = "Barcelona", Wins = 26, Losses = 4, Draws = 8, GoalsScored = 85, GoalsConceded = 33 },
                new Team { Id = 2, Name = "Real Madrid", City = "Madrid", Wins = 25, Losses = 5, Draws = 8, GoalsScored = 88, GoalsConceded = 36 },
                new Team { Id = 3, Name = "Atletico Madrid", City = "Madrid", Wins = 24, Losses = 6, Draws = 8, GoalsScored = 70, GoalsConceded = 30 },
                new Team { Id = 4, Name = "Sevilla FC", City = "Sevilla", Wins = 22, Losses = 8, Draws = 8, GoalsScored = 65, GoalsConceded = 40 },
                new Team { Id = 5, Name = "Valencia CF", City = "Valencia", Wins = 20, Losses = 10, Draws = 8, GoalsScored = 60, GoalsConceded = 45 },
                new Team { Id = 6, Name = "Real Betis", City = "Sevilla", Wins = 18, Losses = 12, Draws = 8, GoalsScored = 55, GoalsConceded = 50 },
                new Team { Id = 7, Name = "Villarreal CF", City = "Villarreal", Wins = 16, Losses = 14, Draws = 8, GoalsScored = 50, GoalsConceded = 55 },
                new Team { Id = 8, Name = "Real Sociedad", City = "San Sebastian", Wins = 14, Losses = 16, Draws = 8, GoalsScored = 45, GoalsConceded = 60 }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, FullName = "Lionel Messi", Country = "Argentina", Number = 10, Position = "Forward", TeamId = 1 },
                new Player { Id = 2, FullName = "Karim Benzema", Country = "France", Number = 9, Position = "Forward", TeamId = 2 },
                new Player { Id = 3, FullName = "Luis Suarez", Country = "Uruguay", Number = 9, Position = "Forward", TeamId = 3 },
                new Player { Id = 4, FullName = "Ivan Rakitic", Country = "Croatia", Number = 10, Position = "Midfielder", TeamId = 4 },
                new Player { Id = 5, FullName = "Carlos Soler", Country = "Spain", Number = 8, Position = "Midfielder", TeamId = 5 },
                new Player { Id = 6, FullName = "Nabil Fekir", Country = "France", Number = 8, Position = "Midfielder", TeamId = 6 },
                new Player { Id = 7, FullName = "Gerard Moreno", Country = "Spain", Number = 7, Position = "Forward", TeamId = 7 },
                new Player { Id = 8, FullName = "Mikel Oyarzabal", Country = "Spain", Number = 10, Position = "Forward", TeamId = 8 },
                new Player { Id = 9, FullName = "Antoine Griezmann", Country = "France", Number = 7, Position = "Forward", TeamId = 1 },
                new Player { Id = 10, FullName = "Sergio Ramos", Country = "Spain", Number = 4, Position = "Defender", TeamId = 2 },
                new Player { Id = 11, FullName = "Jan Oblak", Country = "Slovenia", Number = 1, Position = "Goalkeeper", TeamId = 3 },
                new Player { Id = 12, FullName = "Jesus Navas", Country = "Spain", Number = 16, Position = "Defender", TeamId = 4 },
                new Player { Id = 13, FullName = "Jose Gaya", Country = "Spain", Number = 14, Position = "Defender", TeamId = 5 },
                new Player { Id = 14, FullName = "Marc Bartra", Country = "Spain", Number = 5, Position = "Defender", TeamId = 6 },
                new Player { Id = 15, FullName = "Pau Torres", Country = "Spain", Number = 4, Position = "Defender", TeamId = 7 },
                new Player { Id = 16, FullName = "David Silva", Country = "Spain", Number = 21, Position = "Midfielder", TeamId = 8 },
                new Player { Id = 17, FullName = "Frenkie de Jong", Country = "Netherlands", Number = 21, Position = "Midfielder", TeamId = 1 },
                new Player { Id = 18, FullName = "Luka Modric", Country = "Croatia", Number = 10, Position = "Midfielder", TeamId = 2 },
                new Player { Id = 19, FullName = "Koke", Country = "Spain", Number = 6, Position = "Midfielder", TeamId = 3 },
                new Player { Id = 20, FullName = "Lucas Ocampos", Country = "Argentina", Number = 5, Position = "Midfielder", TeamId = 4 }
            );

            modelBuilder.Entity<Match>().HasData(
                new Match { Id = 1, Team1Id = 1, Team2Id = 2, Team1Goals = 2, Team2Goals = 1, MatchDate = new DateTime(2023, 4, 10) },
                new Match { Id = 2, Team1Id = 3, Team2Id = 4, Team1Goals = 1, Team2Goals = 1, MatchDate = new DateTime(2023, 4, 11) },
                new Match { Id = 3, Team1Id = 5, Team2Id = 6, Team1Goals = 3, Team2Goals = 2, MatchDate = new DateTime(2023, 4, 12) },
                new Match { Id = 4, Team1Id = 7, Team2Id = 8, Team1Goals = 0, Team2Goals = 0, MatchDate = new DateTime(2023, 4, 13) },
                new Match { Id = 5, Team1Id = 1, Team2Id = 3, Team1Goals = 4, Team2Goals = 2, MatchDate = new DateTime(2023, 4, 14) },
                new Match { Id = 6, Team1Id = 2, Team2Id = 4, Team1Goals = 1, Team2Goals = 3, MatchDate = new DateTime(2023, 4, 15) },
                new Match { Id = 7, Team1Id = 5, Team2Id = 7, Team1Goals = 2, Team2Goals = 2, MatchDate = new DateTime(2023, 4, 16) },
                new Match { Id = 8, Team1Id = 6, Team2Id = 8, Team1Goals = 1, Team2Goals = 1, MatchDate = new DateTime(2023, 4, 17) }
            );
        }
    }
}
