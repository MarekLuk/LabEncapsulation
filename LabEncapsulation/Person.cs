using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEncapsulation
{
    internal class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set {
                if (firstName.Length<3) 
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols");
                }
            
            }
        }   

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName.Length<3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }

        private int age;

        public int Age 
        { 
        get { return age; }
            set
            {
                if (value <1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                
                }
                else
                {
                    age = value;
                }
            }
         }

        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 460) 
                {
                    throw new ArgumentException("Salary cannot be less then 460 dollar");
                }
                else
                {
                    salary = value;
                }
            }
        }
        private decimal IncreasedSalary { get; set; }





        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
            IncreasedSalary = salary;
           
        }

       
        public void IncreaseSalary(decimal percentage)
        {
            if (Age<30)
            {
                IncreasedSalary = Salary + (Salary*percentage/200);

            }
            else
            {
                IncreasedSalary = Salary + (Salary * percentage / 100);
            }

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old recive salary {Salary}  and after increase salary is {IncreasedSalary}";
        }

    }


}
