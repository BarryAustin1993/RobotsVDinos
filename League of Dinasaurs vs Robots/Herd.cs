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
        Dinosaur anivia;
        Dinosaur chogath;
        Dinosaur renekton;
        public List<Dinosaur> dinosaurs;


        //constructor (spawner)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(new Dinosaur("Anivia", 500, 150, 100));
            dinosaurs.Add(new Dinosaur("Chogath", 1000, 75, 100));
            dinosaurs.Add(new Dinosaur("Renekton", 750, 100, 100));
        }



        //member methods (can do)

    }
}
