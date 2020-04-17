using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSus
{
    class Player
    {
        //member values 
        protected string gestures; //all gestures
        protected int score; //player score
        

        //inheritance class
        public Player()
        {
            List<string> gestures = new List<string> { "Rock", "Scissors", "Paper", "Lizard", "Spock" };

        }

        //Methods 
        //Create univsal method that applies to all players. 
        
        public string PlayerGestures()
        {

        }


    }
}
