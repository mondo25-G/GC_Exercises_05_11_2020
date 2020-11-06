using ALoveStory.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALoveStory.Models
{
    class Person: IPersonActions
    {
        private protected string _personname;
        private protected House _personhouse; 

        public string Name
        {
            get { return _personname; }
            set { _personname = value; }
        }

        public Person()
        {

        }
        public Person(string name)
        {
            _personname = name;
        }

        public Person(string name, House house) //aggregation
        {
            _personname = name;
            _personhouse = house;
        }



        public void Speak(string words)
        {
            Console.WriteLine(words);
        }

        public void LivesInHouse()
        {
            Console.WriteLine($"{_personname} lives in a {_personhouse.HouseName} in the countryside.");
        }
    }
}
