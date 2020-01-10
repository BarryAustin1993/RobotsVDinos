using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Herd
    {
        //member variables (has a)

        public List<Dinosaur> dinosaurs;
        public Dinosaur CurrentDinosaur;

        //constructor (spawner)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(new Dinosaur("Anivia", 500, 150, 100));
            dinosaurs.Add(new Dinosaur("Chogath", 1000, 75, 100));
            dinosaurs.Add(new Dinosaur("Renekton", 750, 100, 100));
        }
        //member methods (can do)

        public void ChooseDinosaur()
        {
            List<String> dinonames = new List<string>() { "1", "2", "3" };
            Random random = new Random();
            int index = random.Next(dinonames.Count);

            string computerChoice = dinonames[index];

            switch (computerChoice)
            {
                case "1":
                    CurrentDinosaur = dinosaurs[0];
                    break;
                case "2":
                    CurrentDinosaur = dinosaurs[1];
                    break;
                case "3":
                    CurrentDinosaur = dinosaurs[2];
                    break;
                default:

                    break;

            }
        }
    }
}
