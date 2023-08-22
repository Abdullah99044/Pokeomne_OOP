using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pokemone
{
    internal class Trainer
    {
        public string name;

        public List<Pokeball> belt = new List<Pokeball>();
        public Pokeball pokeball;

        public Trainer(string name)
        {
            this.name = name;
        }

        public void makingPokeballs()
        {

            for (int i = 0; i < 2; i++)
            {

                pokeball = new Pokeball();
                pokeball.makePokemone("Charmendar");
                belt.Add(pokeball);

                pokeball = new Pokeball();
                pokeball.makePokemone("Bulbasaur");
                belt.Add(pokeball);

                pokeball = new Pokeball();
                pokeball.makePokemone("Squirtle");
                belt.Add(pokeball);

            }

            

        }

        public void throwPokeball(int index)
        {
 
            belt[index].theowPokemone();
            
            
        }

        public void returningPokeballBack(int index)
        {

             
            belt[index].returnPokemone();

            
             
        }

    }
}
