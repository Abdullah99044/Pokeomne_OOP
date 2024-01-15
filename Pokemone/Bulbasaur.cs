
using APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemone
{
    internal class Bulbasaur : PokemoneClass
    {

        public Bulbasaur(  ) : base(  )
        {
            this.name = "Bulbasaur";
            this.strength = Strength.Leaf;
            this.weakness = Strength.Fire;
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
