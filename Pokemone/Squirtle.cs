using APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemone
{
    internal class Squirtle : PokemoneClass
    {
        public Squirtle(string name, string strength, string weakness) : base(name, strength, weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }

        public override void battleCry()
        {
            Console.WriteLine($"{this.name}!!!!");
        }
    }
}
