using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class Tournament
    {
        public int Id { get; set; }
        public string tournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        public List<List<Matchup>> Rounds { get; set; } = new List<List<Matchup>>();
    }
}
