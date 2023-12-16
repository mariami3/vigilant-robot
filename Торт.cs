using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace торт
{
    internal class Program
    {
        struct Cake
        {
            public string Форма;
            public string Размер;
            public string Вкус;
            public int Количество;
            public string Глазурь;
            public string Decoration;
            public decimal TotalPrice;

            public Cake(string форма, string размер, string вкус, int количество, string глазурь, string декор, decimal цена)
            {
                Форма = форма;
                Размер = размер;
                Вкус = вкус;
                Количество = количество;
                Глазурь = глазурь;
                Decoration = декор;
                TotalPrice = цена;
            }
        }

        static class OrderManager
        {
            public static List<Cake> Orders = new List<Cake>();
            public static int totalCost = 0;
            public static string orderComposition = "";

            public static void Menu(int itemCost = 0, string itemName = "")
            {
                Cake newCake = new Cake();

                Console.WriteLine("Добро пожаловать в кондитерскую ПО");

                newCake.Форма = ChooseFromMenu("Форма", new string[] { "Круг", "Квадрат", "Сердце" });
                newCake.Размер = ChooseFromMenu("Размер", new string[] { "Маленький", "Средний", "Большой" });
                newCake.Вкус = ChooseFromMenu("Вкус", new string[] { "Шоколадный", "Ванильный", "Клубничный" });
                newCake.Количество = ChooseQuantity();
                newCake.Глазурь = ChooseFromMenu("Глазурь", new string[] { "Взбитые сливки", "Крем чис", "Сливочный крем" });
                newCake.Decoration = ChooseFromMenu("Декор", new string[] { "Помадка", "Свежие фрукты", "Шоколадные осколки" });

                newCake.TotalPrice = CalculateTotalPrice(newCake.Количество, 10); 

                Orders.Add(newCake);

                Console.WriteLine($"Сумма вашего заказа: {totalCost}");
                Console.WriteLine($"Состав торта (заказа):{orderComposition}");

                Console.WriteLine("Хотите заказать что-то еще? (Да/Нет)");
                string response = Console.ReadLine();
                if (response.ToLower() == "Да")
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine($"Сумма вашего заказа: {totalCost}");
                    Console.WriteLine($"Состав торта (заказа):{orderComposition}");
                }
                Console.Clear();
                Console.WriteLine("Вы сделали заказ! Если хотите создать ещё один, нажмите Escape, иначе Enter");
                var txt = $"Дата заказа: {DateTime.Now}" + $"\n\t\t\tСумма заказа: {MenuOrder.totalCost}" + $"\n\t\t\tСостав торта: {MenuOrder.orderComposition}" + "\n******************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************\n";
                File.AppendAllText("C:\\Users\\SonicXTails\\Desktop\\Check.txt", txt);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Menu.totalCost = 0;
                    Menu.orderComposition = "";
                    Menu.MainMenu();
                }
                else if (key.Key == ConsoleKey.Enter)
                    Environment.Exit(0);
                break;
            }

            private static string ChooseFromMenu(string header, string[] options)
            {
                Console.WriteLine("Выбор " + header + ":");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + options[i]);
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                return options[choice - 1];
            }

            private static int ChooseQuantity()
            {
                Console.WriteLine("Введите количество:");
                return Convert.ToInt32(Console.ReadLine());

            }

            private static decimal CalculateTotalPrice(int quantity, decimal unitPrice)
            {
                return quantity * unitPrice;
            }

            private static void SaveOrderDetails(Cake cake)
            {
                using (StreamWriter sw = File.AppendText("OrderHistory.txt"))
                {
                    sw.WriteLine("Форма: " + cake.Форма);
                    sw.WriteLine("Размер: " + cake.Размер);
                    sw.WriteLine("Вкус: " + cake.Вкус);
                    sw.WriteLine("Количество: " + cake.Количество);
                    sw.WriteLine("Глазурь: " + cake.Глазурь);
                    sw.WriteLine("Декор: " + cake.Decoration);
                    sw.WriteLine("Цены: $" + cake.TotalPrice);
                    sw.WriteLine("--------------------------------------------------");
                }
            }
        }
        class MenuItem
        {
            public string Description { get; }
            public decimal Price { get; }

            public MenuItem(string description, decimal price)
            {
                Description = description;
                Price = price;
            }
        }

        // Статический класс для стрелочного меню
        static class ArrowMenu
        {
            public static short Arrow(short max, short min)
            {
                short pos = max; // Позиция стрелки.

                short Max_pos = max; // Макс ограничение.
                short Min_pos = min; // Мин ограничение.

                ConsoleKeyInfo key;

                do
                {
                    Console.SetCursorPosition(0, pos); // Ставим курсор на 0,pos, где pos = положению стрелки
                    Console.WriteLine("->"); 

                    key = Console.ReadKey(true); // Считываем кнопку и не выводим ее на консоль

                    Console.SetCursorPosition(0, pos); // Ставим курсор на 0,pos, где pos = положению стрелки, для удаления
                    Console.WriteLine("  "); 

                    if (key.Key == ConsoleKey.DownArrow && pos != Min_pos) // Если кнопка - вниз + позиция не равна минимальной то...
                        pos++; // ... 
                    else if (key.Key == ConsoleKey.UpArrow && pos != Max_pos)
                        pos--;
                    else if (key.Key == ConsoleKey.Escape)
                        MenuItem.Main();
                } while (key.Key != ConsoleKey.Enter);

                return pos;
            }
        }

        // Класс для представления заказа


        private void SaveOrderToFile(MenuItem mainItem, MenuItem additionalItem)
        {
            using (StreamWriter writer = new StreamWriter("Order.txt", true))
            {
                writer.WriteLine("Основной товар: " + mainItem.Description + " - " + mainItem.Price);
                writer.WriteLine("Дополнительный : " + additionalItem.Description + " - " + additionalItem.Price);
            }
        }
    }


        class Товары
        {
            static void Main()
            {
                OrderManager.StartOrdering();
            }
        }
    }
}


