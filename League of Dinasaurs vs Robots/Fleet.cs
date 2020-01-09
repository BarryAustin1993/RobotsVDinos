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
        Robot yasuo;
        Robot ashe;
        Robot leona;
        public List<Robot> robots;


        //constructor (spawner)
        public Fleet()
        {
            robots = new List<Robot>();
            robots.Add(new Robot("Yasuo", 750, 100, 100));
            robots.Add(new Robot("Ashe", 500, 150, 100));
            robots.Add(new Robot("Leona", 1000, 75, 100));



        }
        //member methods (can do)

    }
}
