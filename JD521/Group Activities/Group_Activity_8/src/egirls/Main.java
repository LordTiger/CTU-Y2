package egirls;

/*
 Brandon de Bruyn 6854
 Luke De Kiewit 7293
 */

class Animal {
    public void animalSound() {
        System.out.println("The Animal makes a sound");
    }
}

class Pig extends Animal {
    public void animalSound() {
        System.out.println("The pig says: I am A PIG!");
    }
}

class Dog extends Animal {
    public void animalSound() {
        System.out.println("The dog says: E-Girls Are Ruining my Life");
    }
}

class Bird extends Animal {
    public void animalSound() {
        System.out.println("The Bird says: Tsugi wa Jotaro, kisama da!");
    }
}

class Lion extends Animal {
    public void animalSound() {
        System.out.println("The Lion says: Yarou DIO!");
    }
}

class EGirl extends Animal {
    public void animalSound() {
        System.out.println("The E-Girl says: Donate to me Please!");
    }
}

public class Main {

    public static void main(String[] args) {
	// write your code here
        Animal Animallolz = new Animal();
        Animal Pigo = new Pig();
        Animal Doggo = new Dog();
        Animal Dio = new Bird();
        Animal JoJo = new Lion();
        Animal SIMP = new EGirl();

        Animallolz.animalSound();
        Pigo.animalSound();
        Doggo.animalSound();
        Dio.animalSound();
        JoJo.animalSound();
        SIMP.animalSound();
    }
}
