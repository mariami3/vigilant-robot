import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Введите строку: ");
        String input = scanner.nextLine();


        String cleanedInput = input.replaceAll("\\s", "").toLowerCase();


        boolean isPalindrome = true;
        for (int i = 0; i < cleanedInput.length() / 2; i++) {
            if (cleanedInput.charAt(i) != cleanedInput.charAt(cleanedInput.length() - i - 1)) {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome) {
            System.out.println("Строка является палиндромом.");
        } else {
            System.out.println("Строка не является палиндромом.");
        }
    }
}
