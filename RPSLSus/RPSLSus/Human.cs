using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSus
{
    class Human : Player 
    {
        //member variables

        string selectedGesture; 


        //constructor 

        //methods 

        public PlayerGestures()
        {
            if (selectedGesture == "Rock")
            {
                selectedGesture = "Rock";
                return selectedGesture;
            }
            else if (selectedGesture == "Scissors")
            {
                selectedGesture = "Scissors";
                return selectedGesture;
            }
            else if (selectedGesture == "Paper")
            {
                selectedGesture = "Paper";
                return selectedGesture;
            }
            else if (selectedGesture == "Lizard")
            {
                selectedGesture = "Lizard";
                return selectedGesture;
            }
            else if (selectedGesture == "Spock")
            {
                selectedGesture = "spock";
                return selectedGesture;
            }
        }
    }
}
