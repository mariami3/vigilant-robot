using ConsoleApp6;

var a = DateTime.Now;
Console.WriteLine(" Дата: " + a );
Console.WriteLine(" 1. Приготовить завтрак по рецепту из интернета");
Console.WriteLine(" 2. Съездить в музей с друзьями");
Console.WriteLine(" 3. Сходить в кафешку");
Console.WriteLine(" 4. Поехать вместо метро на такси");
int selected =  Boooba.Biba();
Console.Clear();

if ( selected == 1)
{
    Dom den1 = new Dom();
    den1.Name = "Приготовить завтрак по рецепту из интернета";
    den1.Description = " Найти рецепт завтрака" ;
    den1.Date = a;
    Console.WriteLine("название:" +  den1.Name );
    Console.WriteLine("описание:" + den1.Description);
    Console.WriteLine("дата:" + den1.Date);
    //DateTime.Date();
}
else if ( selected == 2)
{
    Dom den2 = new Dom();
    den2.Name = "Съездить в музей с друзьями";
    den2.Description = "Узнать много нового";
    den2.Date = a;
    Console.WriteLine("название:" + den2.Name);
    Console.WriteLine("описание:" + den2.Description);
    Console.WriteLine("дата:" + den2.Date);
    //DateTime.Date();
}
else if (selected == 3)
{
    Dom den3 = new Dom();
    den3.Name = "Сходить в кафешку";
    den3.Description = "Вкусно поесть вредной еды";
    den3.Date = a;
    Console.WriteLine("название:" + den3.Name);
    Console.WriteLine("описание:" + den3.Description);
    Console.WriteLine("дата:" + den3.Date);
    //DateTime.Date();
}
else if (selected == 4)
{
    Dom den4 = new Dom();
    den4.Name = "Поехать вместо метро на такси";
    den4.Description = "Потратить чуть болше денег";
    den4.Date = a;
    Console.WriteLine("название:" + den4.Name);
    Console.WriteLine("описание:" + den4.Description);
    Console.WriteLine("дата:" + den4.Date);
    //DateTime.Date();
}