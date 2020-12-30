using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class Matchup
    {
        public int Id { get; set; }
        public List<MatchupEntry> Entries { get; set; } = new List<MatchupEntry>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
