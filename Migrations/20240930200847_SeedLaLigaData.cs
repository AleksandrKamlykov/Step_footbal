using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Step_footbal.Migrations
{
    /// <inheritdoc />
    public partial class SeedLaLigaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Draws = table.Column<int>(type: "int", nullable: false),
                    GoalsScored = table.Column<int>(type: "int", nullable: false),
                    GoalsConceded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team1Id = table.Column<int>(type: "int", nullable: false),
                    Team2Id = table.Column<int>(type: "int", nullable: false),
                    Team1Goals = table.Column<int>(type: "int", nullable: false),
                    Team2Goals = table.Column<int>(type: "int", nullable: false),
                    MatchDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_Team1Id",
                        column: x => x.Team1Id,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_Team2Id",
                        column: x => x.Team2Id,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Draws", "GoalsConceded", "GoalsScored", "Losses", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, "Barcelona", 8, 33, 85, 4, "FC Barcelona", 26 },
                    { 2, "Madrid", 8, 36, 88, 5, "Real Madrid", 25 },
                    { 3, "Madrid", 8, 30, 70, 6, "Atletico Madrid", 24 },
                    { 4, "Sevilla", 8, 40, 65, 8, "Sevilla FC", 22 },
                    { 5, "Valencia", 8, 45, 60, 10, "Valencia CF", 20 },
                    { 6, "Sevilla", 8, 50, 55, 12, "Real Betis", 18 },
                    { 7, "Villarreal", 8, 55, 50, 14, "Villarreal CF", 16 },
                    { 8, "San Sebastian", 8, 60, 45, 16, "Real Sociedad", 14 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "MatchDate", "Team1Goals", "Team1Id", "Team2Goals", "Team2Id" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1, 2 },
                    { 2, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1, 4 },
                    { 3, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, 2, 6 },
                    { 4, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 7, 0, 8 },
                    { 5, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2, 3 },
                    { 6, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 3, 4 },
                    { 7, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, 2, 7 },
                    { 8, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Country", "FullName", "MatchId", "Number", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, "Argentina", "Lionel Messi", null, 10, "Forward", 1 },
                    { 2, "France", "Karim Benzema", null, 9, "Forward", 2 },
                    { 3, "Uruguay", "Luis Suarez", null, 9, "Forward", 3 },
                    { 4, "Croatia", "Ivan Rakitic", null, 10, "Midfielder", 4 },
                    { 5, "Spain", "Carlos Soler", null, 8, "Midfielder", 5 },
                    { 6, "France", "Nabil Fekir", null, 8, "Midfielder", 6 },
                    { 7, "Spain", "Gerard Moreno", null, 7, "Forward", 7 },
                    { 8, "Spain", "Mikel Oyarzabal", null, 10, "Forward", 8 },
                    { 9, "France", "Antoine Griezmann", null, 7, "Forward", 1 },
                    { 10, "Spain", "Sergio Ramos", null, 4, "Defender", 2 },
                    { 11, "Slovenia", "Jan Oblak", null, 1, "Goalkeeper", 3 },
                    { 12, "Spain", "Jesus Navas", null, 16, "Defender", 4 },
                    { 13, "Spain", "Jose Gaya", null, 14, "Defender", 5 },
                    { 14, "Spain", "Marc Bartra", null, 5, "Defender", 6 },
                    { 15, "Spain", "Pau Torres", null, 4, "Defender", 7 },
                    { 16, "Spain", "David Silva", null, 21, "Midfielder", 8 },
                    { 17, "Netherlands", "Frenkie de Jong", null, 21, "Midfielder", 1 },
                    { 18, "Croatia", "Luka Modric", null, 10, "Midfielder", 2 },
                    { 19, "Spain", "Koke", null, 6, "Midfielder", 3 },
                    { 20, "Argentina", "Lucas Ocampos", null, 5, "Midfielder", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team1Id",
                table: "Matches",
                column: "Team1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team2Id",
                table: "Matches",
                column: "Team2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MatchId",
                table: "Players",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
