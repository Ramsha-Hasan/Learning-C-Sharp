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

// constructor being intialized
        public Box(double length, double breadth, double height)
        {
            this.l = length;
            this.b = breadth;
            this.h = height;
        }
    }

    
    class Program
     {

 public static void Main()
             {
       Box box1 = new Box(2,3,4);
   
Console.WriteLine("Volume of box1 is {0}", box1.volume());
             }
     }

}
      
      
      