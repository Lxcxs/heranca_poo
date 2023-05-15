using System;

// Classe base
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("O animal fez um som");
    }
}

// Classe derivada (subclasse)
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("O cachorro latiu.");
    }
}

// Classe principal
class Program
{
    static void Main()
    {
        // Cria um objeto da classe base
        Animal animal = new Animal();
        animal.Name = "Leão";
        animal.Age = 5;
        animal.MakeSound();

        // Cria um objeto da classe derivada
        Dog dog = new Dog();
        dog.Name = "Bastião";
        dog.Age = 3;
        dog.MakeSound();
        dog.Bark();
    }
}
