using System;

namespace c(sharp)
{
    class Program
    {
        static void Main(string[] args)
        {

    //          IF STATEMENTS

            bool someCondition = true; 
            var sum = 1;
       
        //when indentation is off.

    //it will not read first line when false and rest will be normal
    //it will read first line when true and rest will be normal

        if (someCondition)
          Console.WriteLine(sum);   
                           
        sum = sum + 9;
        Console.WriteLine(sum);
        
        sum = sum * 2;
        Console.WriteLine(sum);


        //when indentation is on

        //when false it will not go inside the body.
        //when true it will go inside the body.

         if (someCondition)
         {

        Console.WriteLine(sum);   
        
        sum = sum + 9;
        Console.WriteLine(sum);
        
        sum = sum * 2;
        Console.WriteLine(sum);
         }

//      IF - ELSE

Console.WriteLine("What is the capital of Pakistan?");
var answer = Console.ReadLine(); 

        if (answer == "Islamabad")
        {
            Console.WriteLine("Correct!");
        }

        else
        {
            Console.WriteLine("Wrong answer.");
        }


//SWITCH CASE
Console.WriteLine("Give input");
int grade = Console.Read();

switch (grade)
{
    case '1' :
        Console.WriteLine("A grade");
        break;
    case '2' :
        Console.WriteLine("B grade");
        break;
    case '3' :
        Console.WriteLine("C grade");
        break;
    default:
        Console.WriteLine("You failed");
        break;
}
        }
    }
}
