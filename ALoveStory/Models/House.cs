using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ALoveStory.Models
{
    class House
    {
        private string _housename;
        private FrontDoor _frontdoor = new FrontDoor(); //composition

        public string HouseName
        {
            get { return _housename; }
         private set { _housename = value; }
        }

        public FrontDoor FrontDoor
        {
            get { return _frontdoor; }
        }
        

        public House()
        {
            _housename = "House";
        }

        public void HasFrontDoor()
        {
            Console.WriteLine($"The {_housename} had a large {_frontdoor.DoorName}.");
            //i.e. a front door.
        }

        public void Exit(string name)
        {
            Console.WriteLine($"{name} exited the {_housename}.");
        }


    }
}
