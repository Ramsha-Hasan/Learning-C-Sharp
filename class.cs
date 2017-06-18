using System;
namespace c(sharp)
{

    class Box
    {
        public double l, b, h;
              public double volume()
              {
               return (this.l * this.b * this.h);
              }
    }

    
    class Program
     {

 public static void Main()
             {
       Box box1 = new Box();
       box1.l = 34;
       box1.b = 24;
       box1.h = 74;
Console.WriteLine("Volume of box1 is {0}", box1.volume());
             }
     }

}
      
      
      