using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.C2
{
    static class MyLinqImplementation2
    {
        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            Console.WriteLine("MyLinq");
            foreach (var item in source)
                if (predicate(item))
                {
                    Console.WriteLine($"yeilding item={item}");
                    yield return item;
                }
        }
    }

    class Case2 : ICaseRunner
    {
        public void Run()
        {
            GenerateSequence()
                .MyWhere(x => x.Length == 1)
                .Print();

            GenerateNumbersSequence()
                .MyWhere(x => x < 10)
                .Print();            
        }
       
        static IEnumerable<string> GenerateSequence()
        {
            int i = 0;
            while (i++ < 10000000)
            {
                yield return i.ToString();
            }
        }

        static IEnumerable<int> GenerateNumbersSequence()
        {
            int i = 0;
            while (i++ < Int32.MaxValue)
            {
                yield return i;
            }
        }
    }
}
