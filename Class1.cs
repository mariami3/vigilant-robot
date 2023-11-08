using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СП7
{
    internal class Class1
    {
            static void Main()
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                int selectedDrive = 0;

                do
                {
                    Console.Clear();

                    for (int i = 0; i < allDrives.Length; i++)
                    {
                        if (i == selectedDrive)
                        {

                            Console.WriteLine(allDrives[i].Name + " - " + allDrives[i].DriveFormat + " (" + allDrives[i].AvailableFreeSpace / (1024 * 1024 * 1024) + " GB свободно из " + allDrives[i].TotalSize / (1024 * 1024 * 1024) + " GB)");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(allDrives[i].Name + " - " + allDrives[i].DriveFormat + " (" + allDrives[i].AvailableFreeSpace / (1024 * 1024 * 1024) + " GB свободно из " + allDrives[i].TotalSize / (1024 * 1024 * 1024) + " GB)");
                        }
                    }


                    ConsoleKeyInfo key = Console.ReadKey();
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
                            selectedDrive = (selectedDrive == 0) ? allDrives.Length - 1 : selectedDrive - 1;
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            selectedDrive = (selectedDrive == allDrives.Length - 1) ? 0 : selectedDrive + 1;
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    } while (key.Key != ConsoleKey.Enter);



                    Console.Clear();
                    Console.WriteLine("Выбран диск: " + AllDrives[selectedDrive].Name);
                    Console.WriteLine("Свободно места: " + AllDrives[selectedDrive].AvailableFreeSpace / (1024 * 1024 * 1024) + " GB");
                    Console.WriteLine("Формат диска: " + AllDrives[selectedDrive].DriveFormat);


                    DriveInfo[] AllDrives = DriveInfo.GetDrives();
                    Console.WriteLine("D:\\DriveInfo");
                    foreach (DriveInfo d in AllDrives)
                    {
                        Console.WriteLine($"{d.Name} - {d.DriveFormat} ({d.AvailableFreeSpace / (1024 * 1024 * 1024)} GB свободно из {d.TotalSize / (1024 * 1024 * 1024)} GB)");
                    }

                    string[] files = Directory.GetAllFiles();
                    string[] directory = Directory.GetDirectories();


                    Console.WriteLine("Файлы:");
                    foreach (string file in files)
                    {
                        Console.WriteLine($"{file} - {File.GetLastWriteTime(file)}");
                    }


                    Console.WriteLine("Папки:");
                    foreach (string dir in directory)
                    {
                        Console.WriteLine($"{dir} - {Directory.GetLastWriteTime(dir)}");
                    }

                }
                while (true);

            }
        }
    }




