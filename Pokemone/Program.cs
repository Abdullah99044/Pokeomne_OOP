using APP;
using Pokemone;
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


            //Player input the trainers names


            Console.WriteLine("Give the first trainer a name : ");
            string trainer1name = Console.ReadLine();

            Console.WriteLine("Give the second trainer a name : ");
            string trainer2name = Console.ReadLine();

            while(true)
            {
                //Creating trainers

                Trainer trainer1 = new Trainer(trainer1name);
                Trainer trainer2 = new Trainer(trainer2name);


                //Making pokeballs

                trainer1.makingPokeballs();
                trainer2.makingPokeballs();

                Arena arena = new Arena(trainer1, trainer2);



                Console.WriteLine("Do you want to replay ? yes/no ");


                string answer = Console.ReadLine();

                if (answer == "no")
                {
                     
                    break;
                }

 

            }

        }

    }
}



      
     
 
