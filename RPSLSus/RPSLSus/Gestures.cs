using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSus
{
    class Gestures
    {
        //member variables (has a)

        public string allGestures;
        public string playerGestures;

        //constructor (spawner)
        public Gestures()
        {
            List<string> allGestures = new List<string>();
            allGestures.Add("Rock");
            allGestures.Add("Scissors");
            allGestures.Add("Paper");
            allGestures.Add("Lizard");
            allGestures.Add("Spock");
        }
        //methods (can do)

    }
}
