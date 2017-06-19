                    // POLYMORPHISM

using System;
namespace c(sharp)
    {
   public class shapes
     {
public virtual void IntroToShapes()  // By using virtual keyword we can redefine this method in derived classes
{
    Console.WriteLine("Here we will discuss different shapes");
}
     }

public class Square : shapes 
{
    public override void IntroToShapes() //By using override keyword we are not hiding this function
    {
        Console.WriteLine("Here we have discussed about Squares");
    }
}

public class Triangle : shapes
{
    public override void IntroToShapes()
    {
        Console.WriteLine("Here we have discussed about Triangles");
    }
}

public class Circle : shapes
{
    public override void IntroToShapes()
    {
        Console.WriteLine("Here we have discussed about Circles");
    }
}
    class Program
        {

        public static void Main()
            {
                shapes[] arrayOfShapes = new shapes[4];
                arrayOfShapes[0] = new shapes();
                arrayOfShapes[1] = new Triangle();
                arrayOfShapes[2] = new Circle();
                arrayOfShapes[3] = new Square();

                foreach (shapes elements in arrayOfShapes)
                {
                    elements.IntroToShapes();
                }
            }

        }

    }
      
      
      