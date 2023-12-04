using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ПР8 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<ClassUser> users;
        static Stopwatch stopWatch;
        static int КоличествоПравильноВведенныхСимволов;
        static string ТекстДляВводаПользователем;
        static void Main(string[] args)
        {
            while (true)
            {


                // создаем объект BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                users = new List<ClassUser>();
                using (FileStream fs = new FileStream("usersrec.txt", FileMode.OpenOrCreate))
                {
                    users = (List<ClassUser>)formatter.Deserialize(fs);
                    Console.WriteLine("Объект десериализован");
                }

                ClassUser? user = null;
                Console.Write("Введите имя: ");
                string? Name = Console.ReadLine();
                for (int i = 0; i < users.Count; i = i + 1)
                {
                    if (users[i].Name == Name)
                    {
                        user = users[i];
                    }
                }
                if (user == null)
                {
                    user = new ClassUser();
                    users.Add(user);
                    user.Name = Name;
                    user.РекорднаяСкоростьВводаСимволовВсекунду = 0;
                    user.РекорднаяСкоростьВводаСимволовВминуту = 0;
                }





                ТекстДляВводаПользователем = "Когда мы отправляемся в путешествие, мы не просто перемещаемся из одной точки в другую. Мы встречаем новые люди, погружаемся в местные обычаи, пробуем местную кухню и проникаемся духом каждого уникального места. Это как погружение в увлекательную книгу, где каждая страница полна новыми открытиями.";


                Console.WriteLine("Нажмите Enter когда будите готовы ");
                Console.ReadLine();
                КоличествоПравильноВведенныхСимволов = 0;
                Thread ПотокДляТаймера = new Thread(new ThreadStart(ФункцияДляРаботыТаймераВДругомПотоке));
                ПотокДляТаймера.Start();




                Console.Clear();
                string text = "";
                while (true)
                {

                    if (КоличествоПравильноВведенныхСимволов == ТекстДляВводаПользователем.Length)
                    {
                        double СкоростьВводаСимволовВмиллисекунду;
                        double СкоростьВводаСимволовВсекунду;
                        double СкоростьВводаСимволовВминуту;
                        stopWatch.Stop();
                        СкоростьВводаСимволовВмиллисекунду = КоличествоПравильноВведенныхСимволов / stopWatch.Elapsed.TotalMilliseconds;
                        СкоростьВводаСимволовВсекунду = СкоростьВводаСимволовВмиллисекунду * 1000;
                        СкоростьВводаСимволовВминуту = СкоростьВводаСимволовВсекунду * 60;
                        Console.Clear();
                        Console.WriteLine("Скорость ввода символов в минуту" + " " + string.Format("{0:f1}", СкоростьВводаСимволовВминуту));
                        Console.WriteLine("Скорость ввода символов в секунду" + " " + string.Format("{0:f2}", СкоростьВводаСимволовВсекунду));
                        if (user.РекорднаяСкоростьВводаСимволовВминуту < СкоростьВводаСимволовВминуту)
                        {
                            user.РекорднаяСкоростьВводаСимволовВминуту = СкоростьВводаСимволовВминуту;
                            user.РекорднаяСкоростьВводаСимволовВсекунду = СкоростьВводаСимволовВсекунду;
                        }
                        for (int i = 0; i < users.Count; i = i + 1)
                        {
                            Console.WriteLine($"{users[i].Name}");
                            Console.WriteLine("Рекордная скорость ввода символов в минуту" + " " + string.Format("{0:f1}", users[i].РекорднаяСкоростьВводаСимволовВминуту));
                            Console.WriteLine("Рекордная скорость ввода символов в секунду" + " " + string.Format("{0:f2}", users[i].РекорднаяСкоростьВводаСимволовВсекунду));
                        }



                        // получаем поток, куда будем записывать сериализованный объект
                        using (FileStream fs = new FileStream("usersrec.txt", FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, users);

                            Console.WriteLine("Объект сериализован");
                        }
                        break;



                    }
                    ConsoleKeyInfo x = Console.ReadKey();
                    //ТекстДляВводаПользователем.Length(Кол-во символов в строке которую должен ввести пользователь) 
                    if (КоличествоПравильноВведенныхСимволов < ТекстДляВводаПользователем.Length)
                    {
                        //x.KeyChar(символ который только что ввел пользователь) ТекстДляВводаПользователем[КоличествоПравильноВведенныхСимволов](Очередгой сивол который должен ввести пользователь)
                        if (x.KeyChar == ТекстДляВводаПользователем[КоличествоПравильноВведенныхСимволов])
                        {
                            КоличествоПравильноВведенныхСимволов = КоличествоПравильноВведенныхСимволов + 1;
                        }
                    }
                    text = text + x.KeyChar.ToString();
                }
                Console.ReadLine();
            }
        }

        static void ФункцияДляРаботыТаймераВДругомПотоке()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
 
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < КоличествоПравильноВведенныхСимволов; i++)
                {

                    Console.Write(ТекстДляВводаПользователем[i]);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = КоличествоПравильноВведенныхСимволов; i < ТекстДляВводаПользователем.Length; i++)
                {

                    Console.Write(ТекстДляВводаПользователем[i]);
                }
                
                Console.WriteLine();
                Console.WriteLine("Таймер: " + " " + stopWatch.Elapsed.TotalSeconds.ToString("#"));
                Thread.Sleep(100);
                
                if (КоличествоПравильноВведенныхСимволов == ТекстДляВводаПользователем.Length)
                {
                    break;
                }
               
            }
        }
    }
}
