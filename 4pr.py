#Разработать информационную систему по вашей предметной области:
#1) Должно быть 1 или больше подсистем (темы не должны повторяться, можете использовать темы из бд)
#2) Должна быть авторизация и регистрация
#3) Классы должны быть написаны с учетом инкапсуляции, наследования и полиморфизма
#4) Валидация данных
#5) Сохранение данных в бд
#6) Обработка ошибок: уведомляйте пользователя в случае возникновения ошибок, программа не должна прекращать свою работу в случае возникновения ошибок, она должна продолжать свою работу
#7) Минимум 4 таблицы
#8) Должны быть функции для добавления, изменения, удаления и фильтрации данных

import sqlite3
conn = sqlite3.connect("databae.db")
cursor = conn.cursor
cursor.execute()

class databae:
    def __init__(self, db_name):
        self._connection = sqlite3.connect("databae.db")

    def close(self):
         self._connection.close()

    def _execute(self, query, params=None, commit=False):
        with self._connection:
            cursor = self._connection.cursor()
            query_result = cursor.execute(query, params or [])
            if commit:
                self._connection.commit()
            return cursor if not commit else query_result

class UserDatabae(Database):
    def __init__(self):
        super().__init__("databs_ClothingShope.db")
        self._create_tables()
        self._populate_sample_element()

    def _create_tables(self):
        with self._connection:
            self._connection.execute("""
                CREATE TABLE IF NOT EXISTS users (
                    Login TEXT
                    Password TEXT
                )
            """)

            self._connection.execute("""
                CREATE TABLE IF NOT EXISTS element(
                    element_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    cloth_name TEXT,
                    size_cloth INTEGER,              
                    quantity INTEGER,
                    price REAL
                )
           """ )
            
            self._connection.execute("""
                CREATE TABLE IF NOT EXISTS card(
                    card_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_login TEXT,
                    element_id INTEGER,
                    size_cloth INTEGER,  
                    quantity INTEGER,
                    FOREING KEY (user_login) FREFERENCES user (Login),
                    FOREING KEY (element_id) FREFERENCES clothe (element_id),
                    FOREING KEY (size_cloth) FREFERENCES size (size_cloth)
                )
            """)
            
        with self._connection:
            self._connection.execute("""
                CREATE TABLE IF NOT EXISTS delevery(
                    delevery_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_login TEXT,
                    address TEXT,
                    number_zakaza INTEGER,
                    FOREING KEY (user_login) FREFERENCES user (Login),
                    FOREING KEY (number_zakaza) FREFERENCES zakaz (number_zakaza),
                )
            """) 

    def _populate_sample_element(self):
        cloth = [
            ('Куртки', 45-50, 30, 5000),
            ('Худи', 45-70, 60, 1500),
            ('Джинсы', 44-50, 40, 700),
            ('Школьная одежда', 35-70, 1000, 500-4000),
            ('Купальная одежда', 45-55, 500, 650-1000),
            ('Летняя одежда', 35-70, 1000, 750-3500),
        ]     

        #Проверка на наличие элиментов в таблице
        with self._connection as conn:
            cur = conn.cursor()
            cur.execute("SELECT COUNT(*) FROM clothes")
            if cur.fetchone()[0] == 0: 
                cur.executemany("INSERT INTO element (cloth_name, size_cloth, quantity, price) VALUES (?,?,?)",
                                sample_clothes)
                print("Таблица бла заполнена рандомными вещами") 

    def _add_clothes(self, cloth_name, size_cloth, quantity, price):
        with self._connection:
            cur = connection.execute("INSERT INTO element (cloth_name, size_cloth, quantity, price) VALUES (?,?,?)", 
                                     (cloth_name, size_cloth, quantity, price))
        print ("\nПродукт добавлен.")

    def _add_card(self, user_login, element_id , size_cloth , quantity ,):
        with self._connection as conn:
            cur = conn.cursor()

            #Проверка наличие товара в отделе
            cur.execute("SELECT quantity FROM clothes WHERE clothe_id = ?", (new_quantity, element_id ))
            clothe_data = cur.fetchone()

            if clothe_data and clothe_data[0] >= quantity:
                new.quantity = clothe_data - quantity
                cur.execute("UPDATE element SET quantity = ? WERE clothe_id = ?", (new.quantity, element_id))  

                cur.execute("INSERT INTO card (user_login, element_id, size_cloth, quantity) VALUES (?,?,?)"),
                (login, element_id, size_cloth, quantity )
                print ("\nТовар добавлен в корзину")
                conn.commit()
            else:
                print("\nТовара временно нет в наличии или такого товара нет")
    
    def add_users(self, login, password):
        with self._connection:
            self._connection.execute("INSERT INTO users (Login, Password) VALUES (?,?,?)", (login, password))
            print("\nПользователь зарегистрирован")

    def authenticate_users(self, login, password):
        with self._connection:   
            user.data = self._connection.execute("SELECT * FROM users WHERE Login=? AND Password=?", (login, password)).fetchone()
        if user_data:
            print ("\nВход выполнен")
            return True
        else:
           print ("\nНеверные данные")
           return False

    def _view_clothes(self, login):
        with self._connection:
            clothes_list = self._coonection.execute ("SELECT * FROM element").fetchall()
            print  ("\nСписок одежды: ")   
            for element in clothes_list:
                print (f"ID: {element[0]}, Название:{element[1]} , Размер:{element[2]} , Количество:{element[3]} , Цена:{element[4]}") 

            print ("\nВыбирите команду: ")
            print ("1. Добавить элимент в корзину")
            print ("2. Удалить товар из корзины ")
            print ("3. Выйти назад")
            choice = input()
            if choice == "1":
                element_id = int(input("Введите ID продукта чтобы добавить в карзину: "))
                quantity = int(input("Введите количество: "))

                with self._connection as conn:
                    cur = conn.cursor()
                    cur.execute("SELECT quantity FROM element WHERE element_id = ?", (element_id))
                    result = cur.fetchone()
                    if not result:
                        print("\nВыбранный элемент не найден")
                        return
                    if result[0] < quantity:
                        print("\nНедостаточно товара на складе ")
                        return
                    self._add_card(login, element_id, quantity, size_cloth)

            elif choice == "2":
                element_id = int(input("Введите ID продукта чтобы удалить из  карзины: "))
                quantity = int(input("Введите количество: "))

                with self._connection as conn:
                    cur = conn.cursor()
                    cur.execute("SELECT quantity FROM element WHERE element_id = ?", (element_id))
                    result = cur.fetchone()
                    if not result:
                        print("\nВыбранный элемент не найден")
                        return
                    if result[0] < quantity:
                        print("\nНедостаточно товара на складе ")
                        return
                    self._add_card(login, element_id, quantity, size_cloth)

            elif choice == "3":
                return
            else:
                print("\nНеправильный ввод. Попробуйте снова")

        def _view_delevery(self, login):
            print(f"\nСписок выбранных элиментов пользователем {login}: ")
            with self._connection as conn:
                cur = conn.cursor()
                cur.execute("""  
                    SELECT p.cloth_name, c.size_cloth, c.quantity, p.price
                    FROM card c
                    JOIN element p ON p.element_id = c.element_id
                    WHERE c.users_login = ?""" (login))
                delevery = cur.fetchall()
                if orders:
                    for cloth_name, size_cloth, quantity, price in delevery:
                        print(f"Название:{cloth_name} , Размер:{size_cloth} , Количество:{quantity} , Цена:{price}")
                else:
                    print("Ваша корзина пуста")

        def _checkout_card(self, login, address, number_zakaza):
            with self._connection as conn:
                cur = conn.cursor()

                cur.execute("SELECT COUNT(*) FROM card WHERE users_login = ?", (login))
                num_items_in_card = cur.fetchone()[0]

                if num_items_in_card == 0:
                    print("\nЗаказ не оформляется: корзина пуста")
                    return None #Указывает на отсутствие заказа
                
                cur.execute("INSERT INTO delevery (user_login, address, number_zakaza) VALUES (?,?, datetime('now'))",
                             (login,address))
                delevery_id = cur.lastrowid

                cur.execute("""
                            SELECT element_id, quantity FROM card WHERE users_login = ?""", (login,)) 
                items = cur.fetchall()

                delevery_items = []
                total_price = 0.0
                for items_id, quantity in items:
                    cur.execute("SELECT cloth_name, price FROM element WHERE element_id = ?", (items_id,)) 
                    cloth_name, price = cur.fetchone()
                    total_price += price * quantity
                    delevery_items.append(
                    {'element_id': items_id, 'quantity': quantity, 'cloth_name': cloth_name, 'price': price})

                delevery_info = {
                    'delevery_id' : delevery_id,
                    'users_login' : login,
                    'address' : address,
                    'number_zakaza' : number_zakaza,
                    'items' : delevery_items,
                    'total_price' : total_price #Добавляем полную сумму заказов
                }

                with open(f'delevery_{delevery_id}.json', 'w') as json_file:
                    json.dump(delevery_info, json_file, ensure_asoii=False, indent=4)

                    # Перемещаем содежимое корзины в закаы и удаляем
                    cur.execute("DELETE FROM card WHERE users_login = ?", (login,))
                    conn.commit()
                    print(f"\nСоздать заказ. Индефекатор заказа: {delevery_id}. Сумма заказа: {total_price:2f}.")
                    return delevery_id
                
        def close(self):
                self._connection.close()
                print("Соединение закрыто")

        def _add_element(self, cloth_name, size_cloth, quantity, price):
            with self._connection:
                self._cur.execute("INSERT INTO element (cloth_name, size_cloth, quantity, price) VALUES (?,?,?)", 
                                     (cloth_name, size_cloth, quantity, price))
                print("\nТовар добавлен")

        def _delete_element(self, element_id):
            with self._connection as conn:
                cur = conn.cursor()
                cur.execute("DELETE FROM element WHERE element_id = ?", (element_id,))
                if cur.rowcount == 0:
                    print("\nЭлемент не найден")
                else:
                    conn.commit()
                    print("\nЭлемент удален")

        def _block_users(self, login):
            with self._connection as conn:
                cur = conn.cursor()
                cur.execute("DELETE FROM users WHERE Login = ?", (login,))
                if cur.rowcount == 0:
                    print("\nПользователь не найден")
                else:
                    conn.commit()
                    print("\nПользователь заблокирован")

        def _find_users(self, users_id):
            with self._connection as conn:
                cur = conn.cursor()
                cur.execute("SELECT Login, Password FROM users WHERE rowid = ?", (users_id,))
                user_data = cur.fetchone()
                if user_data:
                    print(f"\nЛогин: {user_data[0]}, Пароль: {user_data[1]}")
                else:
                    print("\nНеудалось найти пользователя")


                    

                

               







              



                                     
                                     
                                     
                                            


        