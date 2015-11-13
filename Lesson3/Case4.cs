using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    static class MyLinqImplementation4
    {
        public static TResult Aggregate<TResult, TSource>(this IEnumerable<TSource> source, Func<TResult, TSource, TResult> aggregator)
        {
            var accumulator = default(TResult);

            foreach (var item in source)
            {
                accumulator = aggregator(accumulator, item);
            }

            return accumulator;
        }
    }

    class Case4 : ICaseRunner
    {
        public void Run()
        {
            var res = GenerateSequenceFromConsole().Select(x => int.Parse(x)).Aggregate((x, y) => x + y);
        }

        static IEnumerable<string> GenerateSequenceFromConsole()
        {
            string line = Console.ReadLine();

            while (line != "done")
            {
                yield return line;
                line = Console.ReadLine();
            }
        }
    }
}
