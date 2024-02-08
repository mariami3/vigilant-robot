import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        var hi = "Добро пожаловать!";
        System.out.println((hi));

        Scanner scanner = new Scanner(System.in);

        System.out.println("Введите ваш рост: ");

        System.out.println("Введите ваш вес: ");

        System.out.println("Введите ваш возраст: ");

        double height = scanner.nextDouble();
        double weight = scanner.nextDouble();
        int age = scanner.nextInt();
        double imtheight = weight/ (height * height); // ИМТ
        double imtweight = 24.9 * (height * height); //идеальный вес
        double bmrcolories = 88.36 + (13.4 * weight ) + (4.8 * height) - (5.7 * age); //норма калорий

        if (imtheight >= 24.9){
            double weightlost = weight - imtweight;
            double colories = bmrcolories - 500;
            System.out.println("Рекомендуется снизить вес для достижения идеального веса. Идеальный вес: "+
                    imtweight  + "кг. Необходимо сбросить:" + colories +  "кг.");
        }
        if (imtheight < 18.5){
            double weightgain = weight - imtweight;
            double colories = bmrcolories + 500;
            System.out.println( "Рекомендуется увеличить потребление пищи для набора веса. Идеальный вес: " + imtweight + "кг. Необходимо набрать:"
                    + colories +  "кг. Рекомендуемый дневной прием калорий:" + bmrcolories);
        }
        else {
            double normalweight = weight - imtweight;
            System.out.println( "Ваш вес находится в пределах нормы. Идеальный вес: " + imtweight + "кг. Рекомендуемый дневной прием калорий: " + bmrcolories );
        }

    }
}