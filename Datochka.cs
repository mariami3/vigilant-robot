/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Datochka
    {
        public static void Main()
        {
            DateTime a = new DateTime(2023, 11, 4);
            ConsoleKeyInfo a = Console.ReadKey();
            while (a.Key != ConsoleKey.Enter)
            {
                while (a.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    a = a.AddDays(1);
                    if (a.Date == new DateTime(2023, 11, 5).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom1();
                        }
                        Console.Clear();
                    }
                    else if (a.Date == new DateTime(2023, 10, 22).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom2();
                        }
                        Console.Clear();
                    }
                    else if (a.Date == new DateTime(2023, 12, 30).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom3();
                        }
                        Console.Clear();
                    }
                    else if (a.Date == new DateTime(2023, 10, 19).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom4();
                        }
                    }
                        Console.WriteLine(a);
                    a = Console.ReadKey();
                }
                while (a.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    a = a.AddDays(-1);
                    if (a.Date == new DateTime(2023, 11, 5).Date)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom1();
                        }
                        Console.Clear();
                    }
                    else if (a .Date == new DateTime(2023, 10, 22).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom2();
                        }
                        Console.Clear();
                    }
                    else if (a.Date == new DateTime(2023, 12, 30).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom3();
                        }
                        Console.Clear();
                    }
                    else if (a.Date == new DateTime(2023, 10, 19).Date)
                    {
                        Console.WriteLine("На выбранную дату есть заметка, нажмите Enter чтобы посмотреть");
                        ConsoleKeyInfo f = Console.ReadKey();
                        if (f.Key == ConsoleKey.Enter)
                        {
                            Program.Dom4();
                        }
                        Console.Clear();
                    }
                        Console.WriteLine(a);
                    a = Console.ReadKey();
                }
            }
        }
        public static void Datochka1()
        {
            Console.WriteLine("Дата: 4.11.2023");
            Console.WriteLine("  1. Приготовить завтрак по рецепту из интернета");
            Console.WriteLine("  2. Съездить в музей с друзьями");
            Console.WriteLine("  3. Сходить в кафешку");
            Console.WriteLine("  4. Поехать вместо метро на такси");

         }
    }
*/