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

      
      var EngineersInList = people.Where(x => x.Occupation == "Engineer");
        foreach (var item in EngineersInList)
             {
                  Console.WriteLine(item.FirstName);
             }

                    Console.WriteLine(" ");

       IEnumerable<Person> afterOne = people.Skip(1);
        foreach (var item in afterOne)
        {
            Console.WriteLine(item.FirstName);
        }

                    Console.WriteLine(" ");

         IEnumerable<string> allOccupations = people.Select(x => x.Occupation);
        foreach (var item in allOccupations)
        {
            Console.WriteLine(item);
        }

                    Console.WriteLine(" ");

         IEnumerable<Person> TakeAll = people.Take(3);
        foreach (var item in TakeAll)
        {
            Console.WriteLine(item.Age);
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
      
      
      