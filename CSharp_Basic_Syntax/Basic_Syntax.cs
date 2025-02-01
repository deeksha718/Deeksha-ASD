using System;

class Program
{
    static void Main()
    {
        const string correctUsername = "Deeksha";
        const string correctPassword = "Disneyland123";

        try
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine()?.Trim();
            
            if (string.IsNullOrEmpty(username))
                throw new Exception("Oops! You forgot to enter a username.");

            Console.Write("Enter your password: ");
            string password = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(password))
                throw new Exception("Oops! You forgot to enter a password.");

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine($"Great to see you, {username}! You've successfully logged in.");
            }
            else
            {
                Console.WriteLine("Please check your username and password and try again.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oh no! Something went wrong: {ex.Message}");
        }
    }
}
