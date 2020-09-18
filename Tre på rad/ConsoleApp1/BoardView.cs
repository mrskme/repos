using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    class BoardView
    {
        public static void Show(BoardModel m)
        {
            Console.Clear();
            Console.WriteLine(
                "  a b c\n" +
                " ┌─────┐\n" +
                "1│o    │\n" +
                "2│    o│\n" +
                "3│× ×  │\n" +
                " └─────┘");
            
        }
        
    }
}
