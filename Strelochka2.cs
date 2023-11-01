using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СП5
{
    internal class Strelochka2
    {
            public static int Cursor(int min, int max)
            {
                ConsoleKeyInfo key;
                int pos = 2;
                do
                {
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");

                    if (key.Key == ConsoleKey.UpArrow && pos != min)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && pos != max)
                    {
                        pos++;
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Program.Main();
                    }
                }
                while (key.Key != ConsoleKey.Enter);
                return pos;
            }
    }
}

