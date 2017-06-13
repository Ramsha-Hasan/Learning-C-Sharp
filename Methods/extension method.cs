using System;

namespace c(sharp)
{
    class Program
   {
public static void Main()
        {
                int answer = 6.subtract();
                Console.WriteLine(answer);
        }

    } // closing bracket of program


public static class ExtensionMethods
{
    public static int subtract(this int number)
        {
              return number - 5;
        }
}


}