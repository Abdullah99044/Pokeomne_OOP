using APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemone
{
    internal class Pokeball
    {

         

        public PokemoneClass pokemone;
        

        //This function will tell the class which pokemone is inside the pokeball so he can call his battle cry

        public string currnetPokemone;

        public void makePokemone(string pokemoneSubClass )
        {

            if(pokemoneSubClass == "Charmendar" )
            {
                this.pokemone = new Charmendar("Charmendar", "Fire", "Water");
                this.currnetPokemone = "Charmendar";

            }
            else if (pokemoneSubClass == "Bulbasaur" )
            {

                this.pokemone = new Bulbasaur("Bulbasaur", "Leaf", "Fire");
                this.currnetPokemone = "Bulbasaur";

            }
            else
            {
                this.pokemone = new Squirtle("Squirtle", "Water", "Leaf");
                this.currnetPokemone = "Squirtle";


            }

        }

        //Throwing the pokeball
        public  void theowPokemone()
        {
        
             pokemone.battleCry();
          
        }

         
        public void returnPokemone()
        {

            switch (this.currnetPokemone)
            {
                case "Charmendar":
                    Console.WriteLine("Charmender returned back to the Pokeball");
                    break;

                case "Bulbasaur":
                    Console.WriteLine("Bulbasaur returned back to the Pokeball");
                    break;

                case "Squirtle":
                    Console.WriteLine("Squirtle returned back to the Pokeball");
                    break;

            }
            
        }


    }
}
