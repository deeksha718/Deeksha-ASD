using System;

class Person
{
    public string Name { get; set; }
    private int age;
    
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be a positive number");
            age = value;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()?.Trim();

            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
                throw new ArgumentException("Invalid input. Age must be a number.");

            Person person = new Person { Name = name, Age = age };
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
