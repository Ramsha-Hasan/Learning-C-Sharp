using System;
using System.Collections.Generic;
using System.Linq;


namespace c(sharp)
{
    class Program
    {
        public static void Main(string[] args)
        {
        var people = ListOfPeople();

        Person firstOrDefault = people.FirstOrDefault();
        Console.WriteLine(firstOrDefault.FirstName);

                Console.WriteLine("  ");
        
        Person single = people.SingleOrDefault(x => x.Hobby == "Gardening" ); 
        Console.WriteLine(single.FirstName);


                Console.WriteLine(" ");

        Person Hobby = people.LastOrDefault(x => x.Occupation == "Engineer");
        Console.WriteLine(Hobby.FirstName);
    }

public static List<Person> ListOfPeople()
    {
        var people = new List<Person>();

        people.Add(new Person { FirstName = "Ramsha", Hobby = "painting", Occupation = "Engineer", Age = 23 });
        people.Add(new Person { FirstName = "Ushna", Hobby = "Gardening", Occupation = "Doctor", Age = 22 });
        people.Add(new Person { FirstName = "Reeba", Hobby = "Swimming", Occupation = "Engineer", Age = 17 });

        return people;
     }
  }

public class Person
{
    public string FirstName { get; set; }
    public string Hobby { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
}

}
      
      
      