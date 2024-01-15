using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pokemone
{
    internal class Battle
    {


        //The players
        private Trainer trainer1;
        private Trainer trainer2;

        //Storing the Pokemone who win the round
        private int pokemone1;
        private int pokemone2;   

        //Storing which trainer win the round
        private int winner;

        //Storing the results
        public int rounds;
        public int Trainer1Scores;
        public int Trainer2Scores;


        //Battle  
        public   Battle(Trainer trainer1, Trainer trainer2) {

            this.trainer1 = trainer1;
            this.trainer2 = trainer2;

            int index = 0;


            //The while loop will keep going as long as the players belts is not empty

            while (this.trainer1.belt.Count != 0 && this.trainer2.belt.Count != 0) { 



                //The while loop will break when the players have 1 pokeball left in their belt and both are the same pokemone

                if (this.trainer1.belt.Count == 1 && this.trainer2.belt.Count == 1 )
                {
                    if(this.trainer1.belt[0].CurrnetPokemone == this.trainer2.belt[0].CurrnetPokemone)
                    {
                        break;
                    }
                }

                //Round

                Console.WriteLine($"Round : {index + 1}    ");

                round(this.trainer1, this.trainer2);

                Console.WriteLine(" ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" ");

                index++;

               

 
            }

            //Saving the results

            this.rounds = index;
            this.Trainer1Scores = trainer1.belt.Count;
            this.Trainer2Scores = trainer2.belt.Count;

            if(this.trainer1.belt.Count == 1 && this.trainer2.belt.Count == 1)
            {
                this.winner = 3;
            }

        }


        //Calculating the outcome of every round
        private void outcome( int pokeball1Index , Pokeball pokeball1, int pokeball2Index , Pokeball pokeball2 )
        {
            if (pokeball1.Pokemone.Weakness == pokeball2.Pokemone.Strength)
            {

                this.pokemone2 = pokeball2Index;

                this.winner = 2;

                resultOutcome(2, pokeball1, pokeball2);
                
                returnningToPokeballs(pokeball1Index , pokeball2Index);

                this.trainer1.belt.RemoveAt(pokeball1Index);

            }
            else if (pokeball2.Pokemone.Weakness == pokeball1.Pokemone.Strength)
            {

                this.pokemone1 = pokeball1Index;

                this.winner = 1;

                resultOutcome(1, pokeball1, pokeball2);

                returnningToPokeballs(pokeball1Index, pokeball2Index);

                this.trainer2.belt.RemoveAt(pokeball2Index);
            }
            else if (pokeball2.Pokemone.Strength == pokeball1.Pokemone.Strength)
            {

                this.winner = 3;

                resultOutcome(3, pokeball1, pokeball2);

                returnningToPokeballs(pokeball1Index, pokeball2Index);

            }

            Console.WriteLine($" ");

            Console.WriteLine($"{trainer1.name}  has  {trainer1.belt.Count} pokeballs left in his belt ");
            Console.WriteLine($"{trainer2.name}  has  {trainer2.belt.Count} pokeballs left in his belt ");




        }

        //Declaring who won the round
        private void resultOutcome(int outcome , Pokeball pokeball1, Pokeball pokeball2)
        {
            if (outcome == 1)
            {
                Console.WriteLine($"{this.trainer1.name}  won ! ");
            }

            else if (outcome == 2)
            {

                Console.WriteLine($"{this.trainer2.name}  won ! ");

            }
            else
            {
                Console.WriteLine($"Draw ! ");

            }
        }

        //This the round method where the trainers throw their pokeballs randomly 
        private void round(  Trainer trainer1, Trainer trainer2)
        {

            int pokeBall1 = 0;
            int pokeBall2 = 0;

            Random rnd = new Random( );

            int num1 = trainer1.belt.Count;
            int num2 = trainer2.belt.Count;

            

            if (this.winner == 1 )
            {
                pokeBall1 = this.pokemone1;
                pokeBall2 = rnd.Next(0, num2);

            }
            else if (this.winner == 2)
            {
                pokeBall1 = rnd.Next(0, num1);
                pokeBall2 = this.pokemone2;
            }
            else
            {
                pokeBall1 = rnd.Next(0, num1);
                pokeBall2 = rnd.Next(0, num2);
            }



 
            Console.WriteLine($"{trainer1.name} turn : ");
            trainer1.throwPokeball(pokeBall1);

            Console.WriteLine($"{trainer2.name} turn : ");
            trainer2.throwPokeball(pokeBall2);

            Console.WriteLine(" ");
            Console.WriteLine("Results : ");

            outcome(pokeBall1, trainer1.belt[pokeBall1], pokeBall2, trainer2.belt[pokeBall2]);
        }


        //Declaring which pokeball will return to players belt
        private void returnningToPokeballs(int pokeball1Index , int pokeball2Index)
        {

            if (this.winner == 1)
            {
                Console.WriteLine($"{trainer2.name}  : ");
                trainer2.returningPokeballBack(pokeball2Index);

            }

            else if (this.winner == 2)
            {

                Console.WriteLine($"{trainer1.name}  : ");
                trainer1.returningPokeballBack(pokeball1Index);

            }

            else
            {

                Console.WriteLine($"{trainer1.name}  : ");
                trainer1.returningPokeballBack(pokeball1Index);

                Console.WriteLine($"{trainer2.name}  : ");
                trainer2.returningPokeballBack(pokeball2Index);

            }

        }

        public int getTheWinner()
        {
            return this.winner;
        }
    }
}
