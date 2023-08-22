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

            while (true)
            {


                //Charmendar name

                Console.WriteLine("Give the first trainer a name : ");
                string trainer1name = Console.ReadLine();

                Console.WriteLine("Give the second trainer a name : ");
                string trainer2name = Console.ReadLine();

                Trainer trainer1 = new Trainer(trainer1name);
                Trainer trainer2 = new Trainer(trainer2name);

                trainer1.makingPokeballs();
                trainer2.makingPokeballs();

                int index = 0;
                int round = 0;

                    for (int i = 0; i < 6; i++ )  
                        
                    {
                        if (index < 5)
                            round++;

                        Console.WriteLine($" Round : {index + 1}    ");

                        Console.WriteLine($"{trainer1.name} turn : ");
                        trainer1.throwPokeball(index);

                        Console.WriteLine($"{trainer2.name} turn : ");
                        trainer2.throwPokeball(index);

                        Console.WriteLine($"{trainer1.name}  : ");
                        trainer1.returningPokeballBack(index);

                        Console.WriteLine($"{trainer2.name}  : ");
                        trainer2.returningPokeballBack(index);

                        index++;

                    }

                Console.WriteLine("Games is end");

                Console.WriteLine("Do you want to replay ? : yes/no");
                string answer = Console.ReadLine();

                if (answer == "no")
                {
                    break;
                }
                

            }

        }


    }



      
     
}
