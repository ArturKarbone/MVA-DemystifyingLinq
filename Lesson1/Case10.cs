using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case10 : ICaseRunner
    {
        public void Run()
        {
            var date = DateTime.Now;
            var sequence = GenerateStrings(() => { date = date.AddDays(7); return date; }).Take(10);


            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<T> GenerateStrings<T>(Func<T> itemGenerator)
        {
            int i = 0;
            while (i++ < Int32.MaxValue)
            {
                yield return itemGenerator();
            }
        }
    }
}
