using System;

namespace c(sharp)
{
    class Program
   {

public static void Main()
    {
        string greeting = CreateGreeting();
        Console.WriteLine($"Default Greeting: {greeting}");
        
        string customGreeting = CreateGreeting("Ramsha");
        Console.WriteLine($"Custom Greeting: {customGreeting}");
    }
    
    static string CreateGreeting()
    {
        return CreateGreeting("Madam"); 
    }
    
    static string CreateGreeting(string name)
    {
        return $"Hi {name}!";
    }

   }
}