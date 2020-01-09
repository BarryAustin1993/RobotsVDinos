using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Simulation
    {
        //member variables (has a)
        int counter = 1;


        //constructor (spawner)
        public Simulation()
        {

        }
        //member methods (can do)

        public void RunSim()
        {
            Console.WriteLine("Welcome to League of Robots!");
            Console.WriteLine("We are in a time far ahead of your own, and have called your concious forward through a dream continuium! ");
            Console.WriteLine("You have been selected as having extrodinary capabilites that we need to utilize to ensure human exsistance!");
            Console.WriteLine("You will be given three Robots to choose from. Should one fall you will be transfered to another!");
            Console.WriteLine("Should all three fall, your concious will be transported back to 2020, and you will wake up from a bad dream!");
            Console.WriteLine("However the Human race will have lost its last chance at survival, make sure you win!");
            Console.WriteLine("  ");
            Console.WriteLine("We have selected three of our best Robots for you!");
            Console.WriteLine("Yasuo - Is a Fighter class, melee attacks with average attack and health!");
            Console.WriteLine("Ashe - Is a Ranged class, ranged attacks with high attack and less health");
            Console.WriteLine("Leona - Is a Tank class, melee attacks with low attack and high health");
            IdiotProof();
        }
        public void IdiotProof()
        {
            
            if (counter <= 3)
            {
                counter += 1;
                RobotChoice();
            }
            else
            {
                Console.WriteLine("You have failed humanity! Hit enter to wake up!");
                // add in final game code later
            }
        }
        public void RobotChoice()
        {
            Console.Clear();
            Console.WriteLine("Choose: Yasuo, Ashe, Leona");
            string userInput = Console.ReadLine();     
            switch (userInput)
            {
                case "Yasuo":

                    break;

                case "Ashe":

                    break;

                case "Leona":

                    break;

                default:
                    IdiotProof();
                    break;
            }
        }
    }
}
