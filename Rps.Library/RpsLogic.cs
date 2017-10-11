/* Written by Brian Bird    *
 * 4/27/16                  *
 * Revised 10/10/17         */

using System;

namespace Rps.Library
{

    public enum handShape { rock, paper, scissors }

    public class RpsLogic
    {
        Random rand = new Random();
        handShape machineHand;

        public string PlayerName { get; set; }

        /// <summary>
        /// Randomly chooses a number to represent a hand position.
        /// </summary>
        /// <returns>1 for rock, 2 for paper, 3 for scissors.</returns>
        public handShape ChooseHand()
        {
            machineHand = (handShape)rand.Next(3);
            return machineHand;  // produces random 0 through 2
        }


        // does the choice entered by the user beat the random (android) one?
        public string WhoWon(string hand)
        {
            // Convert the user's hand shape choice to an enum
            handShape playerHand = (handShape)Enum.Parse(typeof(handShape), hand.ToLower());
            if (playerHand == machineHand)
                return "Tie";
            else if ((playerHand == handShape.rock && machineHand == handShape.scissors) ||
                     (playerHand > machineHand && !(machineHand == handShape.rock && playerHand == handShape.scissors)))
                return PlayerName + " won!";
            else
                return "Machine won";
        }
    }
}

