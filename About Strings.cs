using System;

namespace c(sharp)
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = String.Empty; //a declared as an empty string
            string b = null;        //a declared as an empty string

Console.WriteLine(a); // prints nothing
Console.WriteLine(b); // prints nothing

//it will print 0 length.
Console.WriteLine($"Length of a is {a.Length}");

// below line will throw exception
Console.WriteLine($"2nd string is {b.Length} characters long.");
            
            /* STRING OPERATIONS */
            
 string a = " Ramsha ";
 string b = a.ToUpper(); //RAMSHA
 string c = b.ToLower(); //ramsha
 string d = "HEY READER".ToLower(); //hey reader
            
   
 string t1 = a.TrimStart(); // "Ramsha "
 string t2 = a.TrimEnd(); // " Ramsha"
 string t3 = a.Trim(); // "Ramsha"   Trim removes white spaces from string
 string s = a.Trim().Substring(2,4); // "msha"
            
            
string x = "Hello Reader!";
string y = x.Replace("Reader", a); // Hello Ramsha!
      
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
            
        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(s);
            
        
        Console.WriteLine(x);
        Console.WriteLine(y);
            

 
        }
    }
}
