import math

while True:
    print('Введите тип операции:')
    print('1. (+) - Cложение')
    print('2. (-) - Вычитание ')
    print('3. (*) - Умножение ')
    print('4. (/) - Деление ')
    print('5. (!) - Факториал числа')
    print('6. (^) - Возведение числа в степень ')
    print('7. (√) - Квадратный корень из числа ')
    print('8.(cos) - Cos числа ') 
    print('9. (sin) - Sin числа ') 
    print('10. (tg) - Tg числа')
    oper = str(input())
    if type(oper) == str:
        pass
        if oper == '+' or oper == '-' or oper == '*' or oper == '/' or oper == '^' or oper == '√' or oper == 'cos' or oper == 'sin' or oper == 'tg' or oper == '!':
            match oper:
                case '+':
                    while True:
                        try:
                            num1 = float(input("\nВведите первое число: "))
                        except ValueError:
                            print("\nВы ввели некорректно первое слагаемое!")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели первое число: {num1}')
                            break
                        else:
                            print("\n Число введено некорректно!")


                    while True:
                        try:
                            num2 = float(input("\nВведите второе число: "))
                        except ValueError:
                            print("\nВы ввели некорректно второе слагаемое! Попробуйте снова.")
                            continue
                        if type(num2) == float:
                            print(f'Вы ввели второе число: {num2}')
                            break
                        else:
                            print("\nЧисло введено некорректно!")

                    ans = num1 + num2
                    print(f'\nОтвет данной суммы: {ans}')


                case '-':
                    while True:
                        try:
                            num1 = float(input("\nВведите уменьшаемое: "))
                        except ValueError:
                            print("\nВы ввели некорректно уменьшаемое! ")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели уменьшаемое: {num1}')
                            break
                        else:
                            print("\nУменьшаемое введено некорректно!")

                    while True:
                        try:
                            num2 = float(input("\nВведите вычитаемое: "))
                        except ValueError:
                            print("\nВы ввели некорректно вычитаемое! Попробуйте снова.")
                            continue
                        if type(num2) == float:
                            print(f'Вы ввели вычитаемое: {num2}')
                            break
                        else:
                            print("\nВычитаемое введено некорректно!")

                    ans = num1 - num2
                    print(f'\nОтвет данной разности: {ans}')


                case '*':
                    while True:
                        try:
                            num1 = float(input("\nВведите первый множитель: : "))
                        except ValueError:
                            print("\nВы ввели некорректно множитель! Попробуйте снова.")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели первый множитель: {num1}')
                            break
                        else:
                            print("\nМножитель введён некорректно!")

                    while True:
                        try:
                            num2 = float(input("\nВведите второй множитель: "))
                        except ValueError:
                            print("\nВы ввели некорректно множитель! Попробуйте снова.")
                            continue
                        if type(num2) == float:
                            print(f'Вы ввели второй множитель: {num2}')
                            break
                        else:
                            print("\nМножитель введён некорректно!")

                    ans = num1 * num2
                    print(f'\nОтвет данного произаедения: {ans}')


                case '/':
                    while True:
                        try:
                            num1 = float(input("\nВведите числитель: "))
                        except ValueError:
                            print("\nВы ввели некорректно числитель! Попробуйте снова.")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели числитель: {num1}')
                            break
                        else:
                            print("\nЧислитель введён некорректно!")

                    while True:
                        try:
                            num2 = float(input("\nВведите знаменатель: "))
                        except ValueError:
                            print("\nВы ввели некорректно множитель! Попробуйте снова.")
                            continue
                        if type(num2) == float and num2 != 0:
                            print(f'Вы ввели знаменатель: {num2}')
                            break
                        else:
                            print("\nЧислитель или знаменатель введён некорректно! (На ноль делить нельзя) Попробуйте снова")

                    ans = num1 / num2
                    print(f'\nОтвет данного выражения: {ans}')

                case '^':
                    while True:
                        try:
                            num1 = float(input("\nВведите число, которое хотите возвести в степень: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова:")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели число: {num1}')
                            break
                        else:
                            print("\nЧисло введено некорректно!")

                    while True:
                        try:
                            num2 = float(input("\nВведите степень: "))
                        except ValueError:
                            print("\nВы ввели некорректно степень! Попробуйте снова.")
                            continue
                        if type(num2) == float:
                            print(f'Вы ввели степень: {num2}')
                            break
                        else:
                            print("\nЧисло или степень введены некорректно!")

                    ans = num1 ** num2
                    print(f'\nВозведение числа {num1} в степень {num2} равно: {ans}')


                case '√':
                    while True:
                        try:
                            num1 = float(input("\nВведите число, из которого хотите вычеслить квадратный корень: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова.")
                            continue
                        if type(num1) == float and num1 >= 0:
                            print(f'Вы ввели число: {num1}')
                            break
                        else:
                            print("\nЧисло введено некорректно! (Подкоренное выражение не должно быть отрицательным) Попробуйте снова:")

                    ans = math.sqrt(num1)
                    print(f'\nКорень из числа {num1} равен: {ans}')

                case 'cos':
                    while True:
                        try:
                            num1 = float(input("\nВведите cosX: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова.")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели число (X): {num1}')
                            break
                        else:
                            print("\nЧисло введено некорректно!")

                    ans = math.cos (num1)
                    print(f'\nCos{num1} равнен: {ans}')

                case 'sin':
                    while True:
                        try:
                            num1 = float(input("\nВведите sinX: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова.")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели число (X): {num1}')
                            break
                        else:
                            print("\nЧисло введено некорректно!")

                    ans = math.sin (num1)
                    print(f'\nSin{num1} равнен: {ans}')

                case 'tg':
                    while True:
                        try:
                            num1 = float(input("\nВведите sinX: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова.")
                            continue
                        if type(num1) == float:
                            print(f'Вы ввели число (X): {num1}')
                            break
                        else:
                            print("\nЧисло введено некорректно!")

                    while True:
                        try:
                            num2 = float(input("\nВведите cosX: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова.")
                            continue
                        if type(num2) == float:
                            print(f'Вы ввели число (X): {num2}')
                            break
                        else:
                            print("\nЧисло введено некорректно!")

                    ans = math.sin(num1) / math.cos(num2)
                    print(f'\ntg {num1}/{num2} равнен: {ans}')

                case '!':
                    while True:
                        try:
                            num1 = int(input("\nВведите число, из которого хотите вычеслить факториал: "))
                        except ValueError:
                            print("\nВы ввели некорректно число! Попробуйте снова.")
                            continue
                        if type(num1) == int and num1 >= 0:
                            print(f'Вы ввели число: {num1}')
                            break
                        else:
                            print("\nТолько положительные и натуральные числа!")

                    ans = math.factorial(num1)
                    print(f'\nФакториал числа {num1} равен: {ans}')
        else:
            print("Данной оперции нет. Попробуйте снова:")