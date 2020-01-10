using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Fleet
    {
        //member variables (has a)

        public List<Robot> robots;
        public Robot CurrentRobot;
        int counter;

        //constructor (spawner)
        public Fleet()
        {
            robots = new List<Robot>();
            robots.Add(new Robot("Yasuo", 750, 100, 100));
            robots.Add(new Robot("Ashe", 500, 150, 100));
            robots.Add(new Robot("Leona", 1000, 75, 100));
        }
        //member methods (can do)
        public void IdiotProof()
        {

            if (counter <= 3)
            {
                counter += 1;
                Console.Clear();
                ChooseRobot();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have failed humanity! Hit enter to wake up!");
                // add in final game code later
            }
        }
            public void ChooseRobot()
            {
                Console.WriteLine("Choose your robot: Yasuo, Ashe, or Leona!");
                string userInput = Console.ReadLine().ToLower();
                Console.Clear();
                switch (userInput)
                {
                    case "yasuo":
                        CurrentRobot = robots[0];
                        break;
                    case "ashe":
                        CurrentRobot = robots[1];
                        break;
                    case "leona":
                        CurrentRobot = robots[2];
                        break;
                    default:
                        IdiotProof();
                        break;
                }

            }
        }
    }

