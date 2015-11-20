using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5
{
    class Case4 : ICaseRunner
    {
        public void Run()
        {

            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var labels = new string[] { "0", "1", "2", "3", "4", "5" };

            var query1 = from num in numbers
                         join label in labels on num.ToString() equals label
                         select new { num, X = label };

            var results = query1.ToList();

            var query2 =
                        numbers.Join(labels, num => num.ToString(), label => label, (num, label) => new { num, label });

            var results2 = query2.ToList();
       
        }
    }
}
