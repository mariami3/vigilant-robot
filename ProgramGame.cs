

int oper;
do
{
    Console.WriteLine("Выбирите операцию");
    Console.WriteLine("1. Угадай число.");
    Console.WriteLine("2. Таблица умножения.");
    Console.WriteLine("3. Вывод делителей числа.");
    Console.WriteLine("4. Выйти из программы. ");
    oper = Convert.ToInt32(Console.ReadLine());
    switch (oper)
    {
        case 1:
            Random rand = new Random();
            int i =rand.Next(100);
            Console.WriteLine(" Компьютер загадал число от 1 до 100. Угадай какое число");
            Console.WriteLine(" Введите число: ");
            int ri =Convert.ToInt32(Console.ReadLine());
            while (ri != i)
            {
                string answer = (i > ri) ? "Больше" : "Меньше";
                Console.WriteLine(answer);
                i = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Поздравляю вы угадали !");
            break;
            case 2:
                 int[,] num = new int [9, 9];
            {
                { "1"  "2", "3",  "4", "5", "6", "7", "8", "9" };
                { "2", "4", "6", "8", "10", "12", "14", "16", "18" },
                { "3", "6", "9", "12", "15", "18", "21", "24", "27" },
                { "4", "8", "12", "16", "20", "24", "28", "32", "36" }, 
                { "5", "10", "15",  "20", "25", "30", "35", "40", "45" },
                { "6", "12", "18", "24", "30", "36", "42", "48", "54" },
                { "7", "14", "21",  "28", "35", "42", "49", "56", "63" },
                { "8", "16", "24",  "32", "40", "48", "56", "64", "72" },
                { "9", "18", "27",  "36", "45", "54", "63", "72", "81" },
                };


            for (int colona = 0; colona < num.GetLength(0); colona++); 
            {
                for (int line = 1; line < num.GetLength(1); line++)
                { num[colona, line] = colona * line;
                    int colona = 0;
                    Console.WriteLine(num[colona, line] + "\t");
                }
                Console.WriteLine("");
            }
            break;
        case 3:
            Console.WriteLine("Введите число :");
            int nums = Convert.ToInt32(Console.ReadLine());
            for ( oper = 1; oper <= nums; oper++)
            {
                if (nums % oper == 0)
                    Console.WriteLine(oper + " ");
            }
            break;
        default:
            if (oper == 4)
                continue;
            else
                Console.WriteLine("  Выйти из программы. ");
            break;
    }
}
while (oper != 4);
   

