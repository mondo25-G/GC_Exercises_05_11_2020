using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoveStory.Models
{
    class FrontDoor : Door
    {
        private string _doorknocker;

        public string DoorKnocker
        {
            get { return _doorknocker; }
            private set { this._doorknocker = value; }
        }

        public FrontDoor()
        {
            _doorname = "Frontdoor";
            _doorknocker = "Doorknocker"; //(guy who invented the doorknocker won the no-bell prize)
        }

        public override void Knock()//override makes sense since 
        {                           //Door a = new FrontDoor should call
                                    // Knock() of derived class
            Console.WriteLine($"The {_doorknocker} was heard.");

        }
    }
}
