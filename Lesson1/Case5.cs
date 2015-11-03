using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case5 : ICaseRunner
    {
        public void Run()
        {

            var enumerator = GenerateStrings().GetEnumerator();

            for (int i = 0; i < 100; i++)
            {
                if (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
                else
                {
                    break;
                }
            }          
        }

        static IEnumerable<string> GenerateStrings()
        {
            int i = 0;
            while (i++ < Int32.MaxValue)
            {
                yield return i.ToString();
            }
        }
    }
}
