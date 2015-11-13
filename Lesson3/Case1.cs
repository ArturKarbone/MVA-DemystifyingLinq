using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    static class MyLinqImplementation1
    {
        public static bool Any0<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                return true;
            }
            return false;
        }

        public static bool Any1<T>(this IEnumerable<T> source)
        {
            return source.GetEnumerator().MoveNext();
        }

        public static bool Any2<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.Where(x => predicate(x)).GetEnumerator().MoveNext();
        }

        public static bool Any3<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

    }

    class Case1 : ICaseRunner
    {
        public void Run()
        {

            GenerateSequenceFromConsole().Select(s => int.Parse(s)).Any();

            GenerateSequenceFromConsole()
                .Any0();


            //GenerateConsoleSequence()
            //    .Any1();

            //GenerateConsoleSequence()
            // .Any2(x=>x.Length > 2);


            //GenerateConsoleSequence()
            // .Any3(x => x.Length > 2);



        }

        static IEnumerable<string> GenerateSequenceFromConsole()
        {
            var line = default(string);
            while (line != "done")
            {
                line = Console.ReadLine();
                yield return line;
            }
        }
    }
}
