using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol
{
    /// <summary>
    /// Wumpus
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            WumpusMap map = new WumpusMap(5);

            while (true) {
                string input = Console.ReadLine();
                try
                {
                    map.GoDirection(ParseDirection(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static Direction ParseDirection(string direc)
        {
            switch (direc) 
            {
                case "up": return Direction.Up;
                case "down": return Direction.Down;
                case "left": return Direction.Left;
                case "right": return Direction.Right;
                default: Console.WriteLine("Bad directions, Allowed up down right left!");
                    return Direction.None;
            }
        }
    }
}
