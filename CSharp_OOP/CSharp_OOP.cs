using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; }
    protected Animal(string name) => Name = name;
    public abstract void MakeSound();
    public virtual void Describe() => Console.WriteLine($"{Name} is an animal.");
}

interface IPet
{
    void Play();
}

class Dog : Animal, IPet
{
    public Dog(string name) : base(name) { }
    public override void MakeSound() => Console.WriteLine("Bark");
    public override void Describe() => Console.WriteLine($"{Name} is a friendly dog.");
    public void Play() => Console.WriteLine("The dog enjoys playing fetch.");
}

class Cat : Animal, IPet
{
    public Cat(string name) : base(name) { }
    public override void MakeSound() => Console.WriteLine("Meow");
    public override void Describe() => Console.WriteLine($"{Name} is an independent cat.");
    public void Play() => Console.WriteLine("The cat loves chasing a laser pointer.");
}

class Program
{
    static void Main()
    {
        var animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Cat("Whiskers")
        };
        
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Describe();
            if (animal is IPet pet)
                pet.Play();
            Console.WriteLine();
        }
    }
}
