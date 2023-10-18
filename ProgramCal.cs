double a;
double b;
double oper;
double ans;
do
{
    Console.WriteLine("Выбирите операцию");
    Console.WriteLine("1. Сложение 2 чисел");
    Console.WriteLine("2. Вычетание первого из второго");
    Console.WriteLine("3. Умножение двух чисел");
    Console.WriteLine("4. Деление первого числа на второе");
    Console.WriteLine("5. Возведение в N степень первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа ");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9.Выйти из программы ");
    oper = Convert.ToDouble(Console.ReadLine());
    switch (oper)
    {
        case 1:
            Console.Write("Введите первое  число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            ans = a + b;
            Console.WriteLine(" Сумма примера:" + a + " + " + b + "=" + ans +"" );
            break;
        case 2:
            Console.Write("Введите первое  число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе  число: ");
            b = Convert.ToDouble(Console.ReadLine());
            ans = a - b;
            Console.WriteLine(" Разность примера " + a + " - " + b + "=" + ans + "");
            break;
        case 3:
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            ans = a * b;
            Console.WriteLine(" Проиведение примера" + a + " * " + b + "=" + ans + "");
            break;
        case 4:
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            ans = a / b;
            Console.WriteLine(" Частное примера " + a + " / " + b + "=" + ans + "");
            break;
        case 5:
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе  число: ");
            b = Convert.ToDouble(Console.ReadLine());        
            ans = Math.Pow(a, b);
            Console.WriteLine(" Результат" + a + " ^ " + b + "=" + ans + "");
            break;
        case 6:
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            ans = Math.Sqrt(a);
            Console.WriteLine(" Результат:  " +" √ " + a + "=" + ans + "");
            break;
        case 7:
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            ans = a * 0.01;
            Console.WriteLine(" Процент от цисла " + a +  "=" + ans + "");
            break;
        case 8:
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            double k = a;
            double facl = 1;
            for (double i = 1; i <= a; i++)
            {
                facl = facl * i;
            }
            Console.WriteLine("Факториал числа" + a + " равен " + facl + "");
            break;
        default:
            if (oper == 9)
                continue;
            else
                Console.WriteLine(" Операция не проходит! Попробуй другую:");
            break;
    }
}
   while( oper !=9 );

               
            
            










    
    

  




   


