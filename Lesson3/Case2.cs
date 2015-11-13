using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    static class MyLinqImplementation2
    {
        public static int Count1<T>(this IEnumerable<T> source)
        {
            int count = 0;
            foreach (var item in source)
            {
                count++;
            }
            return count;
        }


        public static int Count2<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.Where(predicate).Count();
        }

        public static int Count3<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            int count = 0;
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Case2 : ICaseRunner
    {
        public void Run()
        {

            var res =  GenerateSequenceFromConsole().Count1();
            //var res = GenerateSequenceFromConsole().Count2(x => x.Length == 1);
            //var res = GenerateSequenceFromConsole().Count3(x => x.Length == 1);



        }

        static IEnumerable<string> GenerateSequenceFromConsole()
        {
            var line = Console.ReadLine();
            while (line != "done")
            {
                line = Console.ReadLine();
                yield return line;
            }
        }
    }
}
