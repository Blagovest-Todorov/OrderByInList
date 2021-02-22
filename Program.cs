using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>(); //create a List holding objects of Type Class Person

            while (true)
            {
                string[] personData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);  // Read a line and make a string arr

                string elementOne = personData[0];

                if (elementOne == "End")
                {                    
                    break;
                }

                string elementTwo = personData[1];
                int elementThree = int.Parse(personData[2]);

                Person pers = new Person    // Object Initializer 
                {
                   Name = elementOne,
                   Age = elementThree,
                   Id = elementTwo                
                };

                persons.Add(pers);
            }

            List<Person> sortedPersons = persons.OrderBy(o => o.Age).ToList();

            foreach (Person person in sortedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
