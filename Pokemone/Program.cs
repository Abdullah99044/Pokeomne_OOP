using APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APP
{
    internal class Program

    {



        static void Main(string[] args)
        {

            //Player starts his game

            Console.WriteLine("Press a button to start your game");
            Console.ReadLine();

            while (true)
            {


                //Charmendar name

                Console.WriteLine("Give your Charmendar a name : ");
                string name = Console.ReadLine();

                Charmander charmander = new Charmander(name, "Fire", "Water");


                //Charmendar battle cry

                for (int i = 0; i < 10; i++)
                {
                    charmander.battleCry();
                }

                //Do the player wants to continue ?

                Console.WriteLine("Do you want to continue ? yes/no ");

                string answer = Console.ReadLine();

                if (answer == "yes")
                {

                    break;

                }


            }



        }
    }
}
