using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSus
{
    class Computer : Player 
    {
        //member variables 
        protected string randomGesture; //computer random selected guesture


        //constructor
        public Computer()
        {

        }

        //methods 

        protected string CompGesture()
        {
            foreach (string gesture in gestures)
            {
                return gesture;
            }
        }
    }
}
