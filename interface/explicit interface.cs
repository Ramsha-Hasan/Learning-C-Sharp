using System;
namespace c(sharp)
    {
interface Inumber1
{
    void print();      
}

interface Inumber2
{
    void print();
}

//we have explicitly define both of the methods of interfaces
    class Program : Inumber1, Inumber2
        {
            void Inumber1.print()
            {
                  Console.WriteLine("We are in print1 method.");
            }

            void Inumber2.print()
            {
                 Console.WriteLine("We are in print2 method.");
            }
    public static void Main()
            {
               Program obj = new Program();
                ((Inumber1)obj).print();       //Typecasting
                ((Inumber2)obj).print();

               //'obj.print()' is wrong because we have explicitly define the methods.

              
               Inumber1 objOfI1 = new Program(); //creating object of interface
               Inumber2 objOfI2 = new Program();
               ((Inumber1)objOfI1).print();
               ((Inumber2)objOfI2).print();
               
            }

        }

    }
      
      
      