using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    static class MyLinqImplementation3
    {
        public static int Sum1(this IEnumerable<int> source)
        {
            int sum = 0;
            foreach (var item in source)
            {
                sum += item;
            }
            return sum;
        }
    }

    class Case3 : ICaseRunner
    {
        public void Run()
        {
            var res = GenerateSequenceFromConsole().Select(x => int.Parse(x)).Sum1();

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
