using System;
using System.Linq;
using Step_footbal.Context;
using Step_footbal.Models;
using Step_footbal.Dto;

namespace Step_footbal.Services
{
    public class MatchService
    {
        private readonly PrimeraContext _context;

        public MatchService(PrimeraContext context)
        {
            _context = context;
        }

        public void AddMatch(Match match)
        {
            if (_context.Matches.Any(m => m.Team1Id == match.Team1Id && m.Team2Id == match.Team2Id && m.MatchDate == match.MatchDate))
            {
                throw new InvalidOperationException("Match already exists.");
            }

            _context.Matches.Add(match);
            _context.SaveChanges();
        }

        public void UpdateMatch(Match match)
        {
            var existingMatch = _context.Matches.Find(match.Id);
            if (existingMatch != null)
            {
                existingMatch.Team1Goals = match.Team1Goals;
                existingMatch.Team2Goals = match.Team2Goals;
                existingMatch.MatchDate = match.MatchDate;
                existingMatch.Scorers = match.Scorers;

                _context.SaveChanges();
            }
        }

        public void DeleteMatch(int team1Id, int team2Id, DateTime matchDate)
        {
            var match = _context.Matches.FirstOrDefault(m => m.Team1Id == team1Id && m.Team2Id == team2Id && m.MatchDate == matchDate);
            if (match != null)
            {
                _context.Matches.Remove(match);
                _context.SaveChanges();
            }
        }

        public IQueryable<Match> GetMatchesByDate(DateTime date)
        {
            return _context.Matches.Where(m => m.MatchDate.Date == date.Date);
        }

        public IQueryable<Match> GetMatchesByTeam(int teamId)
        {
            return _context.Matches.Where(m => m.Team1Id == teamId || m.Team2Id == teamId);
        }

        public IQueryable<Player> GetScorersByDate(DateTime date)
        {
            return _context.Matches
                .Where(m => m.MatchDate.Date == date.Date)
                .SelectMany(m => m.Scorers);
        }

        public IQueryable<GoalDifferenceDto> GetGoalDifference()
        {
            return _context.Teams.Select(t => new GoalDifferenceDto
            {
                Team = t,
                GoalDifference = t.GoalsScored - t.GoalsConceded
            });
        }

        public IQueryable<object> GetMatchDetails(int matchId)
        {
            return _context.Matches
                .Where(m => m.Id == matchId)
                .Select(m => new
                {
                    m.Team1,
                    m.Team2,
                    m.Team1Goals,
                    m.Team2Goals,
                    m.MatchDate,
                    Scorers = m.Scorers.Select(s => new { s.FullName, s.Country, s.Number, s.Position })
                });
        }
    }
}
