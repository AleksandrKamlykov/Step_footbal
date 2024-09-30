using Step_footbal.Context;
using Step_footbal.Models;
using Step_footbal.Services;

var context = new PrimeraContext();
var matchService = new MatchService(context);

bool exit = false;

while (!exit)
{
    Console.WriteLine("La Liga Management System");
    Console.WriteLine("1. Add a new match");
    Console.WriteLine("2. View matches by date");
    Console.WriteLine("3. View goal differences");
    Console.WriteLine("4. Exit");
    Console.Write("Select an option: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddNewMatch(matchService);
            break;
        case "2":
            ViewMatchesByDate(matchService);
            break;
        case "3":
            ViewGoalDifferences(matchService);
            break;
        case "4":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

void AddNewMatch(MatchService matchService)
{
    Console.Write("Enter Team 1 ID: ");
    int team1Id = int.Parse(Console.ReadLine());

    Console.Write("Enter Team 2 ID: ");
    int team2Id = int.Parse(Console.ReadLine());

    Console.Write("Enter Team 1 Goals: ");
    int team1Goals = int.Parse(Console.ReadLine());

    Console.Write("Enter Team 2 Goals: ");
    int team2Goals = int.Parse(Console.ReadLine());

    Console.Write("Enter Match Date (yyyy-mm-dd): ");
    DateTime matchDate = DateTime.Parse(Console.ReadLine());

    var newMatch = new Match
    {
        Team1Id = team1Id,
        Team2Id = team2Id,
        Team1Goals = team1Goals,
        Team2Goals = team2Goals,
        MatchDate = matchDate,
        Scorers = new List<Player>()     };

    matchService.AddMatch(newMatch);
    Console.WriteLine("Match added successfully.");
}

void ViewMatchesByDate(MatchService matchService)
{
    Console.Write("Enter Date (yyyy-mm-dd): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    var matches = matchService.GetMatchesByDate(date);
    foreach (var match in matches)
    {
        Console.WriteLine($"Match: {match.Team1.Name} vs {match.Team2.Name}, Score: {match.Team1Goals}-{match.Team2Goals}");
    }
}

void ViewGoalDifferences(MatchService matchService)
{
    var goalDifferences = matchService.GetGoalDifference().ToList();
    foreach (var gd in goalDifferences)
    {
        Console.WriteLine($"Team: {gd.Team.Name}, Goal Difference: {gd.GoalDifference}");
    }
}
