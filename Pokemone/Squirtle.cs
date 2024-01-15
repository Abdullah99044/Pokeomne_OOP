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
        public Squirtle() : base()
        {
            this.name = "Squirtle";
            this.strength = Strength.Water;
            this.weakness = Strength.Leaf;
        }

        public override void battleCry()
        {
            Console.WriteLine($"{this.name}!!!!");
        }

        public override string Name { get { return name; } }

        public override Strength Strength { get { return this.strength; } }


        public override Strength Weakness { get { return this.weakness; } }

    }
}
