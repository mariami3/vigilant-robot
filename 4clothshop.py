import database_for_clothshop #Регестрация

def main():
    databae = database_for_clothshop.UserDatabae()

    try:
        while True:
            print("\n1. Зарегестрироваться")
            print("2. Войти")
            print("3. Выйти")
            choice = input("Выберите действия: ")

            if choice == "1":
                login = input("\nПридумайте ваш логин для входа в систему: ")
                password = input("Введите пароль: ")

                if len(login) < 5:
                    print("Недостаточно символов")
                    continue
                elif ' ' in login:
                    print("Введите без пробелов")
                    continue
                databae.add_user(login, password)

            elif choice == "2":
                login = input("\nПридумайте ваш логин для входа в систему: ")
                password = input("Введите пароль: ")

                if databae.authenticate_users(login, password):
                    while True:
                        print("\n1. Посмотреть товар")
                        print("2. Посмотреть заказы")
                        print("3. Оформить заказ")
                        print("4. Выйти")

                        users_choice = input("\nВыбирите операцию")

                        if users_choice == "1":
                            databae._view_element(login)

                        elif users_choice == "2":
                            databae._view_element(login)

                        elif users_choice == "3":
                            address = input("Введите адрес")
                            databae._view_element(login, address)

                        elif users_choice == "4":
                            break

                        else:
                            print("\nПопробуйте снова. Неверный ввод")

            elif choice == "3":
                break

            else:
                print("\nНеправильный ввод")
    finally:
        databae.close()

if __name__ == "__main__":
    main()



