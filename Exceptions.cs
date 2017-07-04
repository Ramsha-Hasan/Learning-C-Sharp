using System;
using System.Collections.Generic;



namespace c(sharp)
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
        {
        Console.WriteLine(Airthmetic(120,120));
        }

        catch(numbersException)
        {
            Console.WriteLine(1);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero is not possible so making denominator 1");
            Console.WriteLine(Airthmetic(10,1));
        }
        catch(Exception ex)
        {
            //Console.WriteLine(ex.StackTrace); StackTrace tell us at which level error occured
            Console.WriteLine(ex.Message);

        }
        finally
        {
            Console.WriteLine("thankyou");
        }
 }
        private static int Airthmetic(int num1, int num2)
        {
            try
            {
            int result = Division(num1, num2);
            return result;
            }

            catch(Exception ex)
            {
                // it will throw the exception to the top
                throw ex; 
                
                //By this full previous stack is overridden
                //throw new Exception("Something bad happened"); 
                
                //we use this command when we want to add something new.
                //throw new Exception("Something bad happened ---> "+ ex.Message); 
            }
        }
        private static int Division(int num1 ,int num2)
        {
            if ((num1 < 0) || (num2 < 0))
            {
                //user defined exceptions
                throw new Exception ("Negative numbers not allowed");
            }

            if (num1 == num2)
            {
                throw new numbersException ("Both numbers are equal");
            }

            int answer = num1 / num2;
            return answer;

        }
        public class numbersException : Exception
        {
                public numbersException(string message) : base (message)
                {

                }
        }
    }
    
}
      
      
      