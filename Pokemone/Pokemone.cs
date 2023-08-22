using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal abstract class PokemoneClass
    {
        //Fields

        public string name;
        public string strength;
        public string weakness;

        //Constructor
        public   PokemoneClass(string name, string strength, string weakness)
        {

        }


        //Methods

        public abstract void battleCry();
        

            
         

    }
}
