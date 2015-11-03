using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case9 : ICaseRunner
    {
        public void Run()
        {
            int i = 0;
            var sequence = GenerateStrings(() => i++).Take(10);
            i = 50;

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
