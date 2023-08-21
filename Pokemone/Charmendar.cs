using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class Charmander
    {
        //Fields

        public string name;
        public string strength;
        public string weakness;

        //Constructor
        public Charmander(string name, string strength, string weakness)
        {

            this.name = name;
            this.strength = strength;
            this.weakness = weakness;

        }


        //Methods

        public void battleCry()
        {

            Console.WriteLine($"{this.name}!!!!");
        }

    }
}
