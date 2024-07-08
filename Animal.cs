using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound();

        Dog dog = new Dog();
        dog.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();
    }
}
