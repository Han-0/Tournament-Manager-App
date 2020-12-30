using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntry
    {
        /// <summary>
        /// unique identifier for matchupEntry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 1 team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// score for a particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// matchup that this
        /// team came from
        /// </summary>
        public Matchup ParentMatchup { get; set; }
    }
}
