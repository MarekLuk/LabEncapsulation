using System.Collections.Generic;

namespace LabEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Anna", "Persson", 25,2000);
            Person person2 = new Person("Magnus", "Petterson", 65,3000);
            Person person3 = new Person("Johanna", "Eriksson", 57,4000);
            Person person4 = new Person("Peter", "Forsberg", 27,5000);
            Person person5 = new Person("Erika", "Samuelsson", 35,6000);

            List<Person> personList = new List<Person> { person1, person2, person3, person4, person5 };

            foreach (Person person in personList)
            {
                person.IncreaseSalary(20);
                Console.WriteLine(person.ToString());
            }

        }
    }
}
