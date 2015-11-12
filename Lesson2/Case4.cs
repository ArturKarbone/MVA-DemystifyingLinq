using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.C4
{
    static class MyLinqImplementation
    {
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            Console.WriteLine("My Select");
            foreach (var item in source)
                yield return selector(item);
        }
    }

    class Case4 : ICaseRunner
    {
        public void Run()
        {         
            GenerateNumbersSequence()
                .Select(x =>
                {
                    return x.ToString();
                }).Where(x => x.Length == 1)
                .Print();


            GenerateSequence()
                .Select(x =>
                {
                    return x;
                }).Where(x => x.Length == 1)
                .Print();
        }


        //static List<string> GenerateSequence()
        static IEnumerable<string> GenerateSequence()
        {
            int i = 0;
            while (i++ < int.MaxValue)
            {
                yield return i.ToString();
            }
        }

        static IEnumerable<int> GenerateNumbersSequence()
        {
            int i = 0;
            while (i++ < 1000)
            {
                yield return i;
            }
        }
    }
}
