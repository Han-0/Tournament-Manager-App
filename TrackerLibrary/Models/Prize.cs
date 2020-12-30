using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class Prize
    {
        /// <summary>
        /// unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// numeric identifier for a finishing place
        /// </summary>
        public int PlaceNum { get; set; }
        /// <summary>
        /// english name for a finishing place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// fixed ammount this finishing place earns or zero 
        /// (if not used)
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// percentage of the overall take or zero
        /// (if not used)
        /// </summary>
        public double prizePercentage { get; set; }

        public Prize()
        {

        }
        public Prize(string placeName, string placeNum, string prizeAmnt, string prizePercent)
        {
            PlaceName = placeName;

            int placeNumVal = 0;
            int.TryParse(placeNum, out placeNumVal);
            PlaceNum = placeNumVal;

            decimal prizeAmntVal = 0;
            decimal.TryParse(prizeAmnt, out prizeAmntVal);
            PrizeAmount = prizeAmntVal;

            double prizePercentVal = 0;
            double.TryParse(prizePercent, out prizePercentVal);
            prizePercentage = prizePercentVal;
        }
    }
}
