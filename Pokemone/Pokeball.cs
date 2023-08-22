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

         

        public Charmendar charmander;
        public Bulbasaur  bulbasaur;
        public Squirtle   squirtle;

        //This function will tell the class which pokemone is inside the pokeball so he can call his battle cry

        private string currnetPokemone;

        public void makePokemone(string pokemoneSubClass )
        {

            if(pokemoneSubClass == "Charmendar" )
            {
                this.charmander = new Charmendar("Charmendar", "Fire", "Water");
                this.currnetPokemone = "Charmendar";

            }
            else if (pokemoneSubClass == "Bulbasaur" )
            {

                this.bulbasaur = new Bulbasaur("Bulbasaur", "Fire", "Water");
                this.currnetPokemone = "Bulbasaur";

            }
            else
            {
                this.squirtle = new Squirtle("Squirtle", "Fire", "Water");
                this.currnetPokemone = "Squirtle";


            }

        }

        //Throwing the pokeball
        public  void theowPokemone()
        {

            switch (this.currnetPokemone)
            {
                case "Charmendar":
                    charmander.battleCry();
                    break;

                case "Bulbasaur":
                    bulbasaur.battleCry();
                    break;

                case "Squirtle":
                    squirtle.battleCry();
                    break;

            }
 
          
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
