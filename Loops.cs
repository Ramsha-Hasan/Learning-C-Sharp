using System;
using System.Collections.Generic;

namespace c(sharp)
{
    class Program
    {
        static void Main(string[] args)
        {

                //foreach loop
List<string> names = new List<string>(){"Faiza", "Naima", "rubab", "Javairia"};
foreach (string element in names)
{
    Console.WriteLine(element);
}
                //for loop
// on list
List<int> numbers = new List<int>(){11, 34, 56, 77, 89, 45, 96};
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

//on array
int[] numbersArray = {12, 22, 32, 42, 52, 62, 72, 82, 92};
for (int j = 0; j < numbersArray.Length;  j++)
{
    Console.WriteLine(numbersArray[j]);
}
        
                //while loop

int[] arrayOfNumbers = {1, 2, 3, 4, 5};
int K = 0;
while (K < arrayOfNumbers.Length)
{
    Console.WriteLine(arrayOfNumbers[K]);
    K++;
}
         
        }
    }
}
