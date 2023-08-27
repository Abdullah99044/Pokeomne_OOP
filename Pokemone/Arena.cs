using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemone
{
    internal class Arena
    {

        //Tracking rounds
        private static int rounds;
        
        //Tracking scores
        private static int trainer1scores;
        private static int trainer2scores;

        private Trainer trainer1;
        private Trainer trainer2;
        private Battle battle;

        public Arena(Trainer trainer1 , Trainer treainer2) { 
        
            
            this.trainer1 = trainer1;
            this.trainer2 = treainer2;

            
            //Starting the battle

            Console.WriteLine("---------Start the Arena------------");

                this.battle = new Battle(this.trainer1, this.trainer2);

 
            Console.WriteLine("---------End of the Arena------------");


            //Declaring the winner

            if (battle.getTheWinner() == 1)
            {
                Console.WriteLine($"The weinner is {this.trainer1.name}");

            }
            else if (battle.getTheWinner() == 2)
            {
                Console.WriteLine($"The weinner is {this.trainer2.name}");

            }
            else
            {
                Console.WriteLine($"Draw");

            }

            //Saving the results

            rounds = rounds + battle.rounds;
            trainer1scores = trainer1scores + battle.Trainer1Scores;
            trainer2scores = trainer2scores + battle.Trainer2Scores;


            Console.WriteLine($"Rounds : {rounds}");
            Console.WriteLine($"{this.trainer1.name} scores : {trainer1scores}");
            Console.WriteLine($"{this.trainer2.name} scores : {trainer2scores}");



        }

    }
}
