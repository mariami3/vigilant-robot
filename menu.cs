using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace СП7
{
    internal class menu
    {
        public static int Pon()
        {
            ConsoleKeyInfo key;
            int pos = 1;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine(" ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
            }
            while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
