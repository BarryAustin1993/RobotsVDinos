using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Battlefield
    {
        //member variables (has a)
        Herd herd;
        Fleet fleet;

        //constructor (spawner)
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();


        }

        //member methods (can do)
        public void Instructions()
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
        }

        public void RunSim()
        {
            Instructions();
            fleet.ChooseRobot();
            herd.ChooseDinosaur();
            DisplayScreen();
        }
        public void DisplayScreen()
        {
            Console.WriteLine("Enemy: " + herd.CurrentDinosaur.type);
            Console.WriteLine("Health: " + herd.CurrentDinosaur.health);
            Console.WriteLine("Attack: " + herd.CurrentDinosaur.attackPower);
            Console.WriteLine("");
            Console.WriteLine("Robot: " + fleet.CurrentRobot.name);
            Console.WriteLine("Health: " + fleet.CurrentRobot.health);
            Console.WriteLine("Power Level: " + fleet.CurrentRobot.powerLevel);
            Console.ReadLine();
            PlayerChoice();
        }
        public void PlayerChoice()
        {
            Console.WriteLine("/n Please choose to: /n 1: Attack,/n2: Dodge,/n3: or Charge!");
            string userdecision = Console.ReadLine();
            switch (userdecision)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:
                    Console.Clear();
                    DisplayScreen();
                    break;
            }
        }
        public void ComputerChoice()
        {
            List<String> Options = new List<string>() { "1", "2", "3" };
            Random random = new Random();
            int index = random.Next(Options.Count);

            string computerChoice = Options[index];

            switch (computerChoice)
            {
                case "1":
                    //AttackSequence();
                    break;
                case "2":
                    //blocksequence();
                    break;
                case "3":
                    //Chargesequence();
                    break;
                default:

                    break;
            }
        }
        public void DinoAttackSeq()
        {
            
        }



        }

    }

