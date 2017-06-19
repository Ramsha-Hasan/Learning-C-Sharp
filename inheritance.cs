using System;
namespace c(sharp)
{
   class Polygon
   {
    public int  width, height;

    public void setValues(int a, int b)
         {
            this.width = a;
            this.height = b;
         }
  }

class Rectangle : Polygon
{
    public int area()
    {
        return width*height;
    }
}

class Triangle : Polygon
{
    public int area()
    {
        return height*width*1/2;
    }
}


    class Program
     {

public static void Main()
{
        Rectangle rect = new Rectangle();
        Triangle tri = new Triangle();

        rect.setValues(12,6);
        tri.setValues(12,5);

        Console.WriteLine("Area of Rectangle is {0}",rect.area());
        Console.WriteLine("Area of Triangle is {0}",tri.area());
}

     }

}
      
      
      