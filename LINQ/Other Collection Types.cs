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
        
        List<Person> listOfEngs = people.Where(x => x.Occupation == "Engineer").ToList();
        foreach (var item in listOfEngs)
        {
             Console.WriteLine(item.FirstName);
        }

            Console.WriteLine(" ");
       
        Person[] arrayOfDocs = people.Where(x => x.Occupation == "Doctor").ToArray();
            foreach (var item in arrayOfDocs)
        {
             Console.WriteLine(item.Hobby);
        }

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
      
      
      