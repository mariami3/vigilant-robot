# import random
# Список комнат
rooms = ["гостиная", "кухня", "спальня", "кабинет", "подвал"]

# Словарь с предметами и их описанием
items = {
    "ключ": "Ключ от двери",
    "записка": "Таинственная записка",
    "меч": "Мощный меч"
}

#Добавление новых  данных
import json

with open('output.json', 'r') as file:
    existing_data = json.load(file)

new_data = {
    "улики" : "рубашка с бордовым пятном"
}
existing_data.update(new_data)

with open('output.json', 'w') as file:
    json.dump(existing_data, file, encoding='utf-8')


# Словарь с заданиями и их описанием
tasks = {
    "1": "Разгадайте загадку: Что можно сломать, но нельзя исправить?",
    "2": "Найдите ключ от двери",
    "3": "Осмотрите комнату и найдите тайную записку",
    "4": "Сразитесь с монстром в кабинете",
    "5": "Ты свободен"
}
#Добавление новых  данных
import json

with open('output.json', 'r') as file:
    existing_data = json.load(file)

new_data = {
    "5" : "Найти пустую бутылку вина  и посмотреть на этикетку "
}
existing_data.update(new_data)

with open('output.json', 'w') as file:
    json.dump(existing_data, file, encoding='utf-8')

def show_room_description(current_room):
    print(f"Вы находитесь в комнате {current_room}.\n")


def pick_up_item(item_name, inventory):
    if item_name in items:
        inventory.append(items[item_name])
        print(f"Вы подобрали {item_name}.")
    else:
        print("Такого предмета нет в этой комнате.")


def interact_with_task(task_id, current_room, inventory):
    task = tasks[task_id]
    print(task)

    if task_id == "1":
        answer = input("Ваш ответ: ")
        if answer.lower() == "надежду":
            print("Правильный ответ! Дверь открыта.")
            current_room = "кухня"
        else:
            print("Неправильный ответ. Попробуйте еще раз.")
            with open("save.json", "r", encoding='utf-8') as file:
                read = json.load(file)
                file.close()
                print("1. Удалить сохранение")
                print("2. Вернуться в начало")
    elif task_id == "2":
        if "ключ" in inventory:
            print("Вы нашли ключ от двери!")
            current_room = "спальня"
        else:
            print("У вас нет ключа для открытия этой двери.")

    elif task_id == "3":
        if "записка" in inventory:
            print("Вы разорвали тайную записку на кусочки и обнаружили код от следующей комнаты: '1234'.")
            current_room = "подвал"
        else:
            print("У вас нет предмета для осмотра комнаты.")

    elif task_id == "4":
        if "меч" in inventory:
            print("Вы успешно победили монстра и выбрались из особняка!")
        else:
            print("У вас нет оружия для сражения с монстром.")

    elif task_id == "5":
        if "меч" in inventory:
            print("Поздравляю, Вы выбрались!")
            print("Игра закончена")
            exit()
        else:
            print("Вы проиграли, жаль(")
            exit()
    return current_room


def main():
    inventory = ["записка", "меч", "ключ"]
    current_room = "гостиная"

    while current_room != "выход":
        show_room_description(current_room)

        if current_room == "гостиная":
            print("В этой комнате вы видите старую дверь.")
            task_id = "1"
        elif current_room == "кухня":
            print("Здесь запах еды и грязной посуды.")
            task_id = "2"
        elif current_room == "спальня":
            print("Вы видите небольшую комнату с кроватью.")
            task_id = "3"
        elif current_room == "кабинет":
            print("Вы в кабинете, здесь стоит огромный монстр.")
            task_id = "4"
        elif current_room == "подвал":
            print("В подвале вы видите закрытую дверь.")
            task_id = "5"

        action = input("Выберите действие (Осмотреться/Подобрать/Выполнить задание): ")

        if action.lower() == "осмотреться":
            print("Вы осматриваетесь и находите следующие предметы:")
            for item in items:
                print(f"- {item}: {items[item]}")
        elif action.lower() == "подобрать":
            item_name = input("Введите название предмета: ")
            pick_up_item(item_name, inventory)

        elif action.lower() == "выполнить задание":
            current_room = interact_with_task(task_id, current_room, inventory)

        else:
            print("Неверное действие. Попробуйте еще раз.")
            continue

    print("Спасибо за игру! До свидания!")


if __name__ == "__main__":
    main()

import csv
data = {
    "ключ": "Ключ от двери",
    "записка": "Таинственная записка",
    "меч": "Мощный меч"
    }
data1 = [
    {"ключ": "Ключ от двери", "записка": "Таинственная записка", "меч": "Мощный меч"}
]
with open('save.json', 'w', encoding='utf-8') as file:
    json.dump(data, file, indent=4, ensure_ascii=False)
    file.close()
with open("save.csv", "w",newline='', encoding='cp1251') as file:
    names = ["ключ", "записка", "меч"]
    writer = csv.DicWriter(file, fieldnames=names, delimiter=";")
    writer.writeheader()
    for row in data1:
        writer.writeheader()

