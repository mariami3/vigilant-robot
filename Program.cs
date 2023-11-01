using System.Runtime.InteropServices;
using СП5;

Tortik Napoleon = new Tortik();
Napoleon.Name = "Наполеон";
Napoleon.Forma = "Квадратный";
Napoleon.Razmer = "Средний";
Napoleon.Vkys = "Сливочный";
Napoleon.Glazyr = "Заварной крем";
Napoleon.Dekor = "Песочная посыпка";
Napoleon.Kolichestvo = 5;
Napoleon.Price = 300;

Tortik Tiramisu = new Tortik();
Tiramisu.Name = "Тирамису";
Tiramisu.Forma = "Круглый";
Tiramisu.Razmer = "Маленький";
Tiramisu.Vkys = "Шоколдный";
Tiramisu.Glazyr = "Отсутствует";
Tiramisu.Dekor = "Посыпка из какао";
Tiramisu.Kolichestvo = 3;
Tiramisu.Price = 400;

Tortik PTM = new Tortik();
PTM.Name = "Птичье молоко";
PTM.Forma = "Круглый";
PTM.Razmer = "Маленький";
PTM.Vkys = "Ванильное суфле";
PTM.Glazyr = "Шоколад";
PTM.Dekor = "Карем";
PTM.Kolichestvo = 6;
PTM.Price = 350;

Tortik Muraveynik = new Tortik();
Muraveynik.Name = "Муравейник";
Muraveynik.Forma = "Прямоугольный";
Muraveynik.Razmer = "Большой";
Muraveynik.Vkys = "Сгущенки";
Muraveynik.Glazyr = "Отсутствует";
Muraveynik.Dekor = "Посыпка из печенья";
Muraveynik.Kolichestvo = 4;
Muraveynik.Price = 250;

var menu = new List<Tortik>();
menu.Add(PTM);
menu.Add(Muraveynik);
menu.Add(Napoleon);
menu.Add(Tiramisu);

DateTime d = DateTime.Now;
Console.WriteLine("Текщая дата: " +  d.Date);
for (int i = 0; i < menu.Count; i++)
{
    Console.WriteLine(" " + (i + 1) + " " + (menu[i].Name));
}
