using System;
namespace c(sharp)
{
   class Box
   {
      private double length, breadth, height;   
      
      public void setLength( double l )
      {
         length = l;
      }
      
      public void setBreadth( double b )
      {
         breadth = b;
      }
      
      public void setHeight( double h )
      {
         height = h;
      }

      public double getVolume()
      {
         return (this.length * this.breadth * this.height);
      }
   }


   class Program
   {
      static void Main(string[] args)
      {
         Box Box1 = new Box();   
         

         
      
         Box1.setLength(6.0);
         Box1.setBreadth(7.0);
         Box1.setHeight(5.0);
         

         Console.WriteLine("Volume is {0}",Box1.getVolume());
         
        
         
      }
   }
}    
      
      