using System;

namespace c(sharp)
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var a = DateTime.Now;
            Console.WriteLine(a);

            var b = DateTime.Today;
            Console.WriteLine(b);

            //The above mentioned operations are static and can be created without creating instance.

            var c = new DateTime(2014,02,17,02,34,56);
            Console.WriteLine($"{nameof(c)}: {c}");
            int year = c.Month;
            Console.WriteLine(year);


            var d = DateTime.Today.AddDays(1);
            Console.WriteLine(d);
        
        //DateTime.Parse operation can be use when we want to use date as an string.

       DateTime e = new DateTime(DateTime.Today.Year+1, 1, 1); //e is initialized as next year
        TimeSpan f = e - DateTime.Today; //f is initialized as duration.
        Console.WriteLine(f.TotalDays);

            

 
        }
    }
}
