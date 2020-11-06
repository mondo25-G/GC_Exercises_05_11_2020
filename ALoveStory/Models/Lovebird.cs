using ALoveStory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ALoveStory.Models
{
    class Lovebird: Person, ILoveBirdActions
    {
        
        public Lovebird(string name)
        {
            _personname = name;
        }

        public Lovebird(string name, House house)
        {
            _personname = name;
            _personhouse = house;
        }

        public void HoldHands(string LoveBird)
        {
            Console.WriteLine($"{_personname} took {LoveBird} by the hand.");
        }

        public void GoForAStroll(string LoveBird)
        {
            Console.WriteLine($"{_personname} and {LoveBird} went for a stroll.");
        }

        
    }

}
