using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class50Examples
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>
            {
                new Person{FirstName = "John", LastName = "Smith", Age = 20},
                new Person{FirstName = "Jason", LastName = "Robert", Age = 30 },
                new Person{FirstName = "Zach", LastName = "Blagg", Age = 42},
                new Person{FirstName = "Kristy", LastName = "Currier", Age = 32},
                new Person{FirstName = "Marnie", LastName = "Fargle", Age = 25},
                new Person{FirstName = "Zach", LastName = "Gheldof", Age = 28},
                new Person{FirstName = "Adam", LastName="Hobart", Age = 35},
                new Person{FirstName = "Colleen", LastName = "Taylor", Age = 29},
                new Person{FirstName = "Melissa", LastName = "Small", Age = 25},
                new Person{FirstName = "Carrie", LastName = "Reed", Age = 33}
            };

            //List reversed and printed
            list.Reverse();
            list.ForEach(x => { Console.WriteLine(x.FirstName + " " + x.LastName + " Age: " + x.Age); });

            Console.WriteLine();

            //List of people 30 years old or younger
            list.Reverse();
            list.Where(x => x.Age <= 30).ToList().ForEach(x => { Console.WriteLine(x.FirstName + " " + x.LastName + " Age: " + x.Age); });

            Console.WriteLine();


            //First peron under the age of 30
            var person = list.FirstOrDefault(x => x.Age < 30);
            Console.WriteLine(person.FirstName + " " + person.LastName + " Age: " + person.Age);

            Console.WriteLine();

            //Query syntax people over or equal to 30 years old
            var personList = (from x in list
                              where x.Age >= 30
                              select x).ToList();

            foreach (var item in personList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " Age: " + item.Age);
            }

            //Console.WriteLine(list.First(x => x.LastName == "Smith").FirstName); //if doesn't find one throws exception

            //Console.WriteLine(list.FirstOrDefault(x => x.LastName == "Smith").FirstName); //good practice, default will be null if nothing is there



            //single will throw an exception if multiple are in the list
            //where command gives you an Ienumerable

            Console.ReadKey();
        }
    }
}
