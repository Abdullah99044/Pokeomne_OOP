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

         

        public Charmander charmander;

        public void makePokemone()
        {

           

            this.charmander = new Charmander("Charmendar", "Fire", "Water");
             


             
        }

        //Throwing the pokeball
        public  void theowPokemone()
        {
 
 
            charmander.battleCry();
            

        }

         
        public void returnPokemone()
        {
             

            
            Console.WriteLine("Charmender returned back to the Pokeball");
            
        }


    }
}
