using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALoveStory.Interfaces;
using ALoveStory.Models;

namespace ALoveStory
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Lovebird john = new Lovebird("John", house);
            Lovebird anna = new Lovebird("Anna");
            FrontDoor frontDoor = house.FrontDoor;


            john.LivesInHouse();
            house.HasFrontDoor();

            frontDoor.Knock();

            john.Speak("Who is it?");
            anna.Speak($"It's me, {john.Name}!!");
            john.Speak($"I'm coming outside, {anna.Name}!!!");

            frontDoor.Open(john.Name);
            house.Exit(john.Name);
            frontDoor.Close(john.Name);

            john.HoldHands(anna.Name);
            john.GoForAStroll(anna.Name);


        }
    }
}
