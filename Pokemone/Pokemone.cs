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

        protected string name;
        protected Strength strength;
        protected Strength weakness;

        //Constructor
        public PokemoneClass()
        {

        }


        //Methods

        public abstract void battleCry();


        public abstract string Name {
        
            get;
        
        }

        public abstract Strength Strength
        {

            get;

        }

        public abstract Strength Weakness
        {

            get;

        }

    }

    internal enum Strength
    {
        Fire,
        Water,
        Leaf

    }

     
}
 
