using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Example
{
    internal class Program
    {
        class Me

        {
            private static int intTotalPlayer = 5;
            public static int TotalPlayer()
            {
                return Me.intTotalPlayer;
            }
            public string Greating(string hi)
            {
                string me = "there!";
                return hi + me;

            }
        }
        static void Main(string[] args)
        {
            Me me = new Me();
            Console.WriteLine( me.Greating("Hi"));

            Console.WriteLine("Total is: {0}", Me.TotalPlayer());
        }
    }
}
