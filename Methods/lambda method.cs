using System;


namespace c(sharp)
{
    class Program
   {

public static void Main()
        {

    // Func<int, int, string> TwoNumb = (a,b) =>
    // string.Format("Two numbers are = {0} and {1}", a, b);
    // Console.WriteLine(TwoNumb.Invoke(5,7));
        

    Func<int, int, int, int> multiplication = (a,b,c) => a * b * c; 
    //Console.WriteLine(multiplication.Invoke(4,2,3));
    Console.WriteLine(multiplication(4,2,3));

        }

     }
     }