
// 11.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <Windows.h>
#include <conio.h>

using namespace std;

int main()
{
    SetConsoleCP(1251);
    setlocale(0, "Russian");
    char oper;

    cout << "Введите операцию: +, -, *, /, ^, √, %, !, = ";
    cin >> oper;
    float num1, num2;

    while (true)
    {
        if (oper == '+')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << "Введите второе число: ";
            cin >> num2;

            double ans = num1 + num2;
            cout << "Сумма равна: " << ans << endl;
        }
        if (oper == '-')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << "Введите второе число: ";
            cin >> num2;

            double ans = num1 - num2;
            cout << "Разность равна: " << ans << endl;
        }
        if (oper == '*')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << "Введите второе число: ";
            cin >> num2;

            double ans = num1 * num2;
            cout << "Произведение равна: " << ans << endl;
        }
       
        if (oper == '/')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << "Введите второе число: ";
            cin >> num2;

            double ans = num1 / num2;
            cout << "Частность равна: " << ans << endl;
        }

        if (oper == '^')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << "Введите второе число: ";
            cin >> num2;

            cout << pow(num1, num2) << "\n";
            cin.get();
        }
        if (oper == '√')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << sqrt(num1) << "\n";
            cin.get();
        }
        if (oper == '%')
        {
            cout << "Введите первое число: ";
            cin >> num1;

            cout << "Введите второе число: ";
            cin >> num2;

            double ans = (num1 * 100)/num2;
            cout << "Процент числа равен: " << ans << endl;
        }
        if (oper == '!')
        {
            int num1;
            int i;
            int res;

            cin >> num1;
            res = 1;
            for (i = 1; i <= num1; i++) {
                res = res * num1;
            }
            cout << res;     
        }

        if (oper == '=') {
            exit(0);
        }
    }
    return 0;
}
        
  
 



