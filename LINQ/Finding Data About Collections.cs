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
        var emptyList = new List<Person>();

        int numberOfPeopleInList = people.Count();
        Console.WriteLine(numberOfPeopleInList);
            
             Console.WriteLine(" ");
        
        bool thereArePeople = people.Any();
        Console.WriteLine(thereArePeople);
        bool thereAreNoPeople = emptyList.Any();
        Console.WriteLine(thereAreNoPeople);

             Console.WriteLine(" ");
        
        bool allEngs = people.All(x => x.Occupation == "Engineer");
        Console.WriteLine(allEngs);
        bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24);
        Console.WriteLine(everyoneAtLeastTwentyFour);

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
      
      
      