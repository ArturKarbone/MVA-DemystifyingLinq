using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.C5
{
    static class MyLinqImplementation
    {
        public static IEnumerable<TResult> Select<Tsource, TResult>(this IEnumerable<Tsource> source, Func<Tsource, int, TResult> selector)
        {
            int i = 0;
            Console.WriteLine("My Select With Index");
            foreach (var item in source)
                yield return selector(item, i++);
        }

    }

    class Case5 : ICaseRunner
    {
        public void Run()
        {
            GenerateNumbersSequence()
                .Select((x, i) =>
                {
                    return new { x, i };
                })
                .Print();

        }
    
        static IEnumerable<string> GenerateSequence()
        {
            int i = 0;
            while (i++ < 100000)
            {
                yield return i.ToString();
            }
        }

        static IEnumerable<int> GenerateNumbersSequence()
        {
            int i = 0;
            while (i++ < 7)
            {
                yield return i;
            }
        }
    }
}
