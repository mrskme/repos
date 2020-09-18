using System;

namespace PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 7; row++)
            {
                for (int hashNum = 1; hashNum <= 4-Math.Abs(4 - row); hashNum++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }
        }
    }
}
