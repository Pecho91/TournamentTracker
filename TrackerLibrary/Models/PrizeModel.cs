using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        public object placeNameTextBox;

        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numeric indetifier for the place (2 for scond place, etc.)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The frindly name for the place (second place, first runner up, etc.)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this plac earns of zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The number that represents th percentage of the overall take or zero if it is not used.
        /// The percentage is a ffraction of 1 (so 0.5 for 50%).
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberTextBox = 0;
            int.TryParse(placeNumber, out placeNumberTextBox);
            PlaceNumber = placeNumberTextBox;


            decimal prizeAmountTextBox = 0;
            decimal.TryParse(prizeAmount, out prizeAmountTextBox);
            PrizeAmount = prizeAmountTextBox;

            double prizePercentageTextBox = 0;
            double.TryParse(prizePercentage, out prizePercentageTextBox);
            PrizePercentage = prizePercentageTextBox;


        }

    }
}
