using System.Xml.Serialization;


Student student =  new Student();
student.Name = "Саша";
student.Age = 25;
student.City = "Москва";
student.Speciality = "Медицинский";

XmlSerializer xml = new XmlSerializer(typeof(Student));
using(FileStream fs = new FileStream("Саша.xml", FileMode.OpenOrCreate))
{
    xml.Serialize(fs, student);
}

foreach (var item in student)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Age);
}

Console.WriteLine("Сохранение в файл");
Path = Console.ReadLine();

if (Path.EndsWith(" .xml"))
{
    XmlSerializer xml = new XmlSerializer(typeof(Student));
    using (FileStream fs = new FileStream("D\\Рабочий стол\\Саша.xml", FileMode.OpenOrCreate))
    {
        xml.Serialize(fs, Sasha);
    }
}

