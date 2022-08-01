using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06Exercises01
{
    
    internal class Program
    {
        class Player
        {
            public string strName;
            public int intScore;
            private static int intTotalPlayer;
            public static int TotalPlayer()
            {
                 return Player.intTotalPlayer; 
            }
            private static int intTotalScore;
            public static int TotalScore()
            {
                 return Player.intTotalScore; 
            }
            public Player(string strName, int intScore)
            {
                this.strName = strName;
                this.intScore = intScore;
                intTotalPlayer ++;
                intTotalScore += intScore;
            }
        }
        static void Main(string[] args)
        {
            Player objPlayer1, objPlayer2;
            Console.WriteLine("Enter the name of player 1");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the score of player 1");
            int score = int.Parse(Console.ReadLine());
            objPlayer1 = new Player(name, score);

            Console.WriteLine("Enter the name of player 2");
            name = Console.ReadLine();
            Console.WriteLine("Enter the score of player 2");
            score = int.Parse(Console.ReadLine());
            objPlayer2 = new Player(name, score);
            Console.WriteLine("Player 1: {0} got {1}." ,objPlayer1.strName,objPlayer1.intScore.ToString() );

            Console.WriteLine("Player 1: {0} got {1}.", objPlayer2.strName, objPlayer2.intScore.ToString());
            Console.WriteLine("Number of player {0} and total score {1}",Player.TotalPlayer(),Player.TotalScore() );
            Console.ReadKey();
        }
    }
}
