using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleGame
{
    class Program
    {

        int Height = 20;
        int Width = 30;
        
        public int WriteBoard()
        {
            Console.Clear();
            for (int i = 1; i <= (Width+2);i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }    
            Console.Clear();
            for (int i = 1; i <= (Width+2);i++)
            {
                Console.SetCursorPosition(i, );
                Console.Write("-");
            }

        }
        static void Main(string[] args)
        {
        
        
        }
    }
}
