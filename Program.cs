using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

int[] octave = new int [] { 6541, 6930, 7342, 7778, 8241, 8741, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
int[] octave2 = new int [] { 1308, 1386, 1468, 1556, 1648, 1746, 1850, 1960, 2077, 2200, 2331, 2469 };
int[] currentlyOctave = new int[] { 6541, 6930, 7342, 7778, 8241, 8741, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
while (true)
{
    ConsoleKeyInfo KeyReader = Console.ReadKey(true);
}
    static void sound(ConsoleKeyInfo keyReader, int[] currentlyOctave)
    {
    Console.WriteLine(" A1 , A2 ");
    switch (keyReader.Key)
        {
            case ConsoleKey.A:
                Console.Beep(currentlyOctave[0], 200);
                break;
            case ConsoleKey.D:
                Console.Beep(currentlyOctave[1], 200);
                break;
            case ConsoleKey.W:
                Console.Beep(currentlyOctave[2], 200);
                break;
            case ConsoleKey.S:
                Console.Beep(currentlyOctave[3], 200);
                break;
            case ConsoleKey.F:
                Console.Beep(currentlyOctave[4], 200);
                break;
            case ConsoleKey.E:
                Console.Beep(currentlyOctave[5],  200);
                break;
            case ConsoleKey.G:
                Console.Beep(currentlyOctave[6], 200);
                break;
            case ConsoleKey.J:
                Console.Beep(currentlyOctave[7], 200);
                break; 
            case ConsoleKey.Y:
                Console.Beep(currentlyOctave[8], 200);
                break;
                case ConsoleKey.Escape:
                Console.WriteLine(" Закончить");
                   break;

        }
    }
{

    ConsoleKeyInfo KeyReader = Console.ReadKey();
   
    Console.Clear();
    if (KeyReader.Key == ConsoleKey.F3 || KeyReader.Key == ConsoleKey.F5)

    {
        currentlyOctave = ChangeOctave(KeyReader);
    }
    else
    {
        sound(KeyReader, currentlyOctave);
    }
    static int[] ChangeOctave(ConsoleKeyInfo KeyReader)
    {
        switch (KeyReader.Key)

        {

            case ConsoleKey.F3:

                int[] octave1 = new int[] { 6541, 6930, 7342, 7778, 8241, 8741, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
                return octave1;
                break;

            case ConsoleKey.F5:

                int[] octave3 = new int[] { 1308, 1386, 1468, 1556, 1648, 1746, 1850, 1960, 2077, 2200, 2331, 2469 };
                return  octave3;
                break;
            default: return new int[]  { 6541, 6930, 7342, 7778, 8241, 8741, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
        }
        }
    }




  
