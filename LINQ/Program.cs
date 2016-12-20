using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> kilkenneyFam = new List<Person>()
            {
                new Person() {FirstName = "Evie", LastName = "Kilkenney", Age = 1, Height = 13, Weight = 20 },
                new Person() {FirstName = "Maggie", LastName = "Kilkenney", Age = 6, Height = 40, Weight = 60 },
                new Person() {FirstName = "Jack", LastName = "Kilkenney", Age = 8, Height = 43, Weight = 78 },
                new Person() {FirstName = "Brad", LastName = "Kilkenney", Age = 34, Height = 69, Weight = 170 },
                new Person() {FirstName = "Max", LastName = "Kilkenney", Age = 37, Height = 69, Weight = 159 },
                new Person() {FirstName = "Michelle", LastName = "Kilkenney", Age = 39, Height = 68, Weight = 130 },
                new Person() {FirstName = "Ryan", LastName = "Kilkenney", Age = 40, Height = 67, Weight = 170 },
                new Person() {FirstName = "Cathy", LastName = "Kilkenney", Age = 66, Height = 50, Weight = 110 },
                new Person() {FirstName = "Bob", LastName = "Kilkenney", Age = 67, Height = 67, Weight = 190 }

            };

            IEnumerable<Person> adults =
                from person in kilkenneyFam
                where person.Age >= 18
                select person;

            Console.WriteLine("The adults in the family are: ");

            foreach (var person in adults)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

            IEnumerable<Person> kidsNeedingChildRestraints =
                from person in kilkenneyFam
                where person.Age <= 7 || person.Weight <= 60 || person.Height < 41
                //Can add another where which serves as an implicit &&
                select person;

            Console.WriteLine("The members of the family needing child restraints are: " );

            foreach (Person person in kidsNeedingChildRestraints)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

            Console.WriteLine("Uncle Brad's BMI is : {0}.", Person.BMI(69, 173));

            Console.ReadLine();

            IEnumerable<Person> overWeight =
                from person in kilkenneyFam
                where (person.Weight * 703) / (person.Height * person.Height) > 25
                select person;


            Console.WriteLine("The overweight people in the family are: ");
            foreach (var person in overWeight)
            {
                Console.WriteLine(person.FirstName);
            }
        
        }
       
    }
}
