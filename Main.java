import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        var eat = "Любимое блюдо";
        System.out.println((eat));

        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите кол-во молока: ");
        var milk = scanner.nextLine();
        System.out.println("Введите кол-во яиц: ");
        var eggs = scanner.nextLine();
        System.out.println("Введите кол-во муки: ");
        var flour = scanner.nextLine();
        System.out.println("Введите кол-во сахара: ");
        var sugar = scanner.nextLine();
        System.out.println("Введите кол-во масла: ");
        var oil = scanner.nextLine();
        System.out.println("Введите рецепт: ");
        var rec = scanner.nextLine();

        PrintWriter printWriter = new PrintWriter("Блюдо.txt");
        printWriter.println( "Молоко: " + milk);
        printWriter.println("Яйца: " + eggs);
        printWriter.println("Мука: " + flour);
        printWriter.println("Сахар: " + sugar);
        printWriter.println( "Рецепт: " + rec);
        printWriter.close();
        }
}