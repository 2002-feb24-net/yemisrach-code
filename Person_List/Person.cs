using System;
using System.Collections.Generic;
namespace PersonList
{

class Person
{
    private string _name = "N/A";
    private int _age = 0;

        public string Name { get
    {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

  
    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            _age = value;
        }
    }


    static void Main()
    {
        
        List<Person> person = new List<Person>();

      //  Console.WriteLine("Person details - {0}", person);

      
        person.Add(new Person {Name = "crank arm", Age = 14 });
        person.Add(new Person { Name = "chain ring", Age = 13 });
        person.Add(new Person { Name = "regular seat", Age = 14});
        person.Add(new Person { Name = "banana seat", Age = 14 });
        person.Add(new Person { Name = "cassette", Age = 15 });
        person.Add(new Person { Name = "shift lever", Age = 16 });

         foreach (var rsult in person)
        {
            Console.WriteLine(rsult);
        }}

//  person.Name = "YEMI";
//         person.Age = 99;
        // Console.WriteLine("Person details - {0}", person.Name);


     public override string ToString()
    {
        return "Name = " + Name + ", Age = " + Age;
    }
    }
}
