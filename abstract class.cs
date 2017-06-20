using System;
namespace c(sharp)
    {

    public abstract class colors
    {
        public abstract void green();   //we cannot define abtract method

        public void yellow()
        {
            Console.WriteLine("Its a yellow color.");
        }
    }

    class Program : colors
        {
            public override void green()
            {
                Console.WriteLine("Its a green color.");
            }
        
        public static void Main()
            {
                Program colorObject = new Program();
                colorObject.green();
                colorObject.yellow();
            }

        }

    }
      
      
      