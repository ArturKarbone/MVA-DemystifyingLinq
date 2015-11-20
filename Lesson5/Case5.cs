using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5
{
    class Case5 : ICaseRunner
    {
        class Project
        {
            public string Name { get; set; }
        }

        class Task
        {
            public Project Parent { get; set; }
            public string Name { get; set; }
        }

        static void listingGroupJoin(IEnumerable<Task> tasks,
             IEnumerable<Project> projects)
        {
            var groups = from p in projects
                         join t in tasks on p equals t.Parent into projTasks
                         select new { Project = p, projTasks };

            var results = groups.ToList();

            var groups2 = projects.GroupJoin(tasks,
                p => p, t => t.Parent, (p, projTasks) =>
                    new { Project = p, TaskList = projTasks });

            var results2 = groups2.ToList();

        }

        public IEnumerable<Employee> GetEmployees()
        {
            yield return new Employee { Age = 25, LastName = "Ivanov", FirstName = "Aleksej", Department = "IT" };
            yield return new Employee { Age = 31, LastName = "Ivanov", FirstName = "Andrej", Department = "IT" };
            yield return new Employee { Age = 35, LastName = "Ivanov", FirstName = "Haim", Department = "IT" };
            yield return new Employee { Age = 33, LastName = "Ivanov", FirstName = "Igor", Department = "BI" };
            yield return new Employee { Age = 38, LastName = "Abele", FirstName = "Peteris", Department = "BI" };
        }

        private void GroupJoinEmployees(IEnumerable<Employee> employees)
        {
            var query = from e in employees
                          group e by e.Department into departmentGroup
                          select new { Department = departmentGroup.Key, Size = departmentGroup.Count() };

            var results = query.ToList();
        }


        private void GroupJoinTasksProjects()
        {
            var p1 = new Project()
            {
                Name = "p1"
            };

            var p2 = new Project()
            {
                Name = "p2"
            };

            var t1 = new Task()
            {
                Parent = p1,
                Name = "P1.T1"
            };

            var t2 = new Task()
            {
                Parent = p1,
                Name = "P1.T2"
            };


            var t3 = new Task()
            {
                Parent = p2,
                Name = "P2.T1"
            };

            listingGroupJoin(new List<Task> { t1, t2, t3 }, new List<Project> { p1, p2 });
        }


        public void Run()
        {
            GroupJoinEmployees(GetEmployees());
            GroupJoinTasksProjects();

            //var results = from e in employees
            //              group e by e.Department into d
            //              select new { Department = d.Key, Size = d.Count() };

            //WhereAndSelect(GetEmployees());
        }
    }

}
