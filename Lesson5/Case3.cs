using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5
{
    public class Employee
    {
        public int Age
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", FirstName, LastName, Age);
        }
    }

    class Case3 : ICaseRunner
    {

        private static void WhereAndSelect(IEnumerable<Employee> employees)
        {
            Console.WriteLine("#1");
            var people = from e in employees
                         where e.Age > 30
                         orderby e.LastName, e.FirstName, e.Age
                         select e;

            people.Print();


            Console.WriteLine("#2");
            var people2 = employees.Where(e => e.Age > 30).
                OrderBy(e => e.LastName).
                ThenBy(e => e.FirstName).
                ThenBy(e => e.Age);

            people2.Print();


            Console.WriteLine("#3");
            //Order by iterates throgh the entire collection
            var people3 = from e in employees
                         where e.Age > 30
                         orderby e.LastName
                         orderby e.FirstName
                         orderby e.Age
                         select e;

            people3.Print();


            Console.WriteLine("#4");
            var people4 = from e in employees
                         where e.Age > 30
                         orderby e.LastName descending
                         orderby e.FirstName
                         orderby e.Age
                         select e;

            people4.Print();

        }


        public IEnumerable<Employee> GetEmployees()
        {
            yield return new Employee { Age = 25, LastName = "Ivanov", FirstName = "Aleksej" };
            yield return new Employee { Age = 31, LastName = "Ivanov", FirstName = "Andrej" };
            yield return new Employee { Age = 35, LastName = "Ivanov", FirstName = "Haim" };
            yield return new Employee { Age = 33, LastName = "Ivanov", FirstName = "Igor" };           
            yield return new Employee { Age = 38, LastName = "Abele", FirstName = "Peteris" };
        }

        public void Run()
        {
            WhereAndSelect(GetEmployees());
        }
    }
}
