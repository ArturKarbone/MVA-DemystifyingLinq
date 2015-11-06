using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.C3
{
    static class MyLinqImplementation
    {
        public static IEnumerable<string> MySelect(this IEnumerable<int> source)
        {
            foreach (var item in source)
                yield return item.ToString();
        }
    }

    class Case3 : ICaseRunner
    {
        public void Run()
        {
            var sequence = GenerateNumbersSequence();

            //sequence = sequence.MySelect().Where(x=>x.Length ==1);

            var sequence2 = sequence.MySelect().Where(x => x.Length == 1);

            sequence2.Print();
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
