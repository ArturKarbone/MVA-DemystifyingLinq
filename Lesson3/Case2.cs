using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    static class MyLinqImplementation2
    {

        public static int Count00<T>(this IEnumerable<T> source)
        {
            if (source.Any())
            {
                return 1 + Count00(source.Skip(1));
            }
            else
            {
                return 0;
            }
        }

        public static int Count0<T>(this IEnumerator<T> enumerator)
        {
            if (enumerator.MoveNext())
            {
                return 1 + Count0(enumerator);
            }
            else
            {
                return 0;
            }            
        }

        public static int Count1<T>(this IEnumerable<T> source)
        {
           
            int count = 0;

           if (source.Any())
            {
                foreach (var item in source)
                {
                    count++;
                }
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
            var res = GenerateSequenceFromConsole().Count00();
            //var res = GenerateSequenceFromConsole().GetEnumerator().Count0();
            //var res =  GenerateSequenceFromConsole().Select(x=>x.ToString()).Count1();
            //var res = GenerateSequenceFromConsole().Count2(x => x.Length == 1);
            //var res = GenerateSequenceFromConsole().Count3(x => x.Length == 1);



        }

        static IEnumerable<string> GenerateSequenceFromConsole()
        {
            return Enumerable.Range(1, 10).Select(x => x.ToString());

            //var line = Console.ReadLine();
            //while (line != "done")
            //{
            //    yield return line;
            //    line = Console.ReadLine();
            //}
        }
    }
}
