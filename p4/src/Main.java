import java.util.Scanner;

// Абстрактный класс для фигуры
abstract class Shape {
    abstract double calculateArea();
    abstract double calculatePerimeter();
}

// Подкласс квадрата
class Square extends Shape {
    double side;

    Square(double side) {
        this.side = side;
    }

    @Override
    double calculateArea() {
        return side * side;
    }

    @Override
    double calculatePerimeter() {
        return 4 * side;
    }
}

// Подкласс треугольника
class Triangle extends Shape {
    double base;
    double height;
    double side1;
    double side2;

    Triangle(double base, double height, double side1, double side2) {
        this.base = base;
        this.height = height;
        this.side1 = side1;
        this.side2 = side2;
    }

    @Override
    double calculateArea() {
        return 0.5 * base * height;
    }

    @Override
    double calculatePerimeter() {
        return base + side1 + side2;
    }
}

// Подкласс прямоугольника
class Rectangle extends Shape {
    double length;
    double width;

    Rectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    @Override
    double calculateArea() {
        return length * width;
    }

    @Override
    double calculatePerimeter() {
        return 2 * (length + width);
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Выберите фигуру:");
        System.out.println("1. Квадрат");
        System.out.println("2. Треугольник");
        System.out.println("3. Прямоугольник");

        int choice = scanner.nextInt();

        if (choice == 1) {
            System.out.println("Введите сторону квадрата:");
            double side = scanner.nextDouble();
            Square square = new Square(side);
            System.out.println("Площадь квадрата: " + square.calculateArea());
            System.out.println("Периметр квадрата: " + square.calculatePerimeter());
        } else if (choice == 2) {
            System.out.println("Введите основание треугольника:");
            double base = scanner.nextDouble();
            System.out.println("Введите высоту треугольника:");
            double height = scanner.nextDouble();
            System.out.println("Введите длину первой стороны треугольника:");
            double side1 = scanner.nextDouble();
            System.out.println("Введите длину второй стороны треугольника:");
            double side2 = scanner.nextDouble();
            Triangle triangle = new Triangle(base, height, side1, side2);
            System.out.println("Площадь треугольника: " + triangle.calculateArea());
            System.out.println("Периметр треугольника: " + triangle.calculatePerimeter());
        } else if (choice == 3) {
            System.out.println("Введите длину прямоугольника:");
            double length = scanner.nextDouble();
            System.out.println("Введите ширину прямоугольника:");
            double width = scanner.nextDouble();
            Rectangle rectangle = new Rectangle(length, width);
            System.out.println("Площадь прямоугольника: " + rectangle.calculateArea());
            System.out.println("Периметр прямоугольника: " + rectangle.calculatePerimeter());
        } else {
            System.out.println("Некорректный выбор!");
        }
    }
}

