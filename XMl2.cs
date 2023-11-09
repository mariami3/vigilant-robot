using СП6;
using System.Xml.Serialization;


List<Student> students;

Console.WriteLine("Файл: ");
string path = Console.ReadLine();

if (path.EndsWith(" .xml"))
{
    XmlSerializer xml = new XmlSerializer(typeof(Student));
    using (FileStream fs = new FileStream("Саша.xml", FileMode.OpenOrCreate)) ;
    {
        student = (List<Student>)xml.Deserialize(fs);
    }
}

XmlSerializer xml = new XmlSerializer(typeof(Student));
using (FileStream fs = new FileStream("D\\Рабочий стол\\Саша.xml", FileMode.OpenOrCreate))
{
    xml.Serialize(fs, Sasha);
}
