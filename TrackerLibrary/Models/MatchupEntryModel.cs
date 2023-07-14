using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifier for the matchup entry.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents on team in the matchup.
        /// </summary>
        public TeamModel? TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score or this patricular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winer.
        /// </summary>
        public MatchupModel? ParentMatchup { get; set; }


    }

}
