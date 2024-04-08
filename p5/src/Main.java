// Интерфейс Animal
interface Animal {
    void eat();
    void sound();
}

// Класс Dog, реализующий интерфейс Animal
class Dog implements Animal {
    @Override
    public void eat() {
        System.out.println("Собака ест кость");
    }

    @Override
    public void sound() {
        System.out.println("Гав");
    }
}

// Класс Cat, реализующий интерфейс Animal
class Cat implements Animal {
    @Override
    public void eat() {
        System.out.println("Кошка ест рыбу");
    }

    @Override
    public void sound() {
        System.out.println("Мяу");
    }
}

// Интерфейс Pet, расширяющий Animal
interface Pet extends Animal {
    void play();
}

// Реализация интерфейса Pet для класса Dog
class PetDog extends Dog implements Pet {
    @Override
    public void play() {
        System.out.println("Собака играет с мячом");
    }
}

// Реализация интерфейса Pet для класса Cat
class PetCat extends Cat implements Pet {
    @Override
    public void play() {
        System.out.println("Кошка играет с мышкой");
    }
}

public class Main {
    public static void main(String[] args) {
        PetDog dog = new PetDog();
        dog.eat();
        dog.sound();
        dog.play();

        PetCat cat = new PetCat();
        cat.eat();
        cat.sound();
        cat.play();
    }
}
