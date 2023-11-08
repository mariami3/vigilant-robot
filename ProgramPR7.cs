using System.ComponentModel.Design;
using СП7;

string[] allFiles = Directory.GetFiles("D: \\Users\\Дарико\\Desktop\\Dariko Files");
    foreach (string filePath in allFiles)
{
    Console.WriteLine(filePath);
}




ShowPapkas(" C:\\Program.Files");
void ShowPapkas(string p)
{
    while (true)
    {
        Console.Clear();
        string[] paths = Directory.GetDirectories(p);
        string[] pathFiles = Directory.GetFiles(p);
        foreach ( string file in paths) 
        {
            Console.WriteLine("  " + paths);
        }

        Menu menu = new Menu( 0, paths.Length -1);
        int pos = menu.Show();

        if (pos == 0)
            return;
        ShowPapkas(paths[pos]);
    }
}  