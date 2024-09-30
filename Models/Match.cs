using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Step_footbal.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int Team1Id { get; set; }
        public Team Team1 { get; set; }
        public int Team2Id { get; set; }
        public Team Team2 { get; set; }
        public int Team1Goals { get; set; }
        public int Team2Goals { get; set; }
        public DateTime MatchDate { get; set; }
        public ICollection<Player> Scorers { get; set; }
    }
}
