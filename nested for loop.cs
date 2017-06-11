using System;

namespace c(sharp)
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Multiplication Table");

for  (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++ )
    {
        var product = (i * j).ToString();
        Console.Write(product.PadLeft(7));
    
    }
    Console.WriteLine();
}

   
        }
    }
}
