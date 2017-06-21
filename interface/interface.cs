using System;
namespace c(sharp)
    {
interface Inumber1
{
    void print1();      //no access modifier and definition required in interface.
}

interface Inumber2
{
    void print2();
}

class example : Inumber1, Inumber2 // can inherit from multiple interface classes
{
    public void print1()
    {
        Console.WriteLine("We are in print1 method.");
    }

    public void print2()
    {
        Console.WriteLine("We are in print2 method.");
    }

}
    class Program 
        {
            
        public static void Main()
            {
                example objOfExample = new example();
                objOfExample.print1();
                objOfExample.print2();


                // creating object of interface

                Inumber1 objOfI1 = new example();
                objOfI1.print1();
                Inumber2 objOfI2 = new example();
                objOfI2.print2();
            }

        }

    }
      
      
      