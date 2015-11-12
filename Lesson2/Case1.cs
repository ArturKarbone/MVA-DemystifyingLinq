using Common;
using System;
using System.Collections.Generic;

namespace Lesson2
{
    static class MyLinqImplementation1
    {
        public static IEnumerable<string> MyWhere(this IEnumerable<string> source, Func<string, bool> predicate)
        {
            foreach (var item in source)
                if (predicate(item))
                    yield return item;
        }
    }

    class Case1 : ICaseRunner
    {
        public void Run()
        {
            GenerateSequence()
                .MyWhere(x => x.Length == 1)
                .Print();

            //MyWhere nongeneric first, generic later
            //GenerateNumbers see compiler error
            //GenerateNumbersSequence().MyWhere(x => x > 1)
        }


        //static List<string> GenerateSequence()
        static IEnumerable<string> GenerateSequence()
        {
            int i = 0;
            while (i++ < Int32.MaxValue)
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
