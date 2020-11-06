using ALoveStory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoveStory.Models
{
    class Door : IDoorActions
    {
        private protected string _doorname;

        public string DoorName
        {
            get { return _doorname; }
            private set { _doorname = value; }
        }

        public Door()
        {
            _doorname = "Door";
        }

        public virtual void Knock() 
        {
            
            Console.WriteLine($"The {_doorname} was knocked.");
           
        }

        public void Open(string name)
        { 
            Console.WriteLine($"{name} opened the {_doorname}.");
        }

        public void Close(string name)
        {
            Console.WriteLine($"{name} closed the {_doorname}.");
        }

        
    }
}
