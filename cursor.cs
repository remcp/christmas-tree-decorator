using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace christmas_tree_decorator
{
    internal class Cursor
    {
        public int[] move(ConsoleKeyInfo keypress, int[] position)
        {
            ConsoleKey key = keypress.Key;
  
            switch (key)
            {
                case ConsoleKey.D:
                    position[1]++;
                    break;

                case ConsoleKey.A:
                    position[1]--;
                    break;

                case ConsoleKey.W:
                    position[0]--;
                    break;
                case ConsoleKey.S:
                    position[0]++;
                    break;
            }
            return position;
        }

        public string direction(ConsoleKeyInfo keypress)
        {
            string direction = " ";
            ConsoleKey key = keypress.Key;
            switch (key)
            {
                case ConsoleKey.D:
                    direction = "d";
                    break;

                case ConsoleKey.A:
                    direction = "a";
                    break;

                case ConsoleKey.W:
                    direction = "w";
                    break;
                case ConsoleKey.S:
                    direction = "s";
                    break;
            }
            return direction;
        }
        public void setcursor(int[] position, string character)
        {
            int x = position[1];
            int y = position[0];
            try
            {
                Console.SetCursorPosition(x, y);
            }
            catch{ }
            Console.Write(character);
        }
    }
}
