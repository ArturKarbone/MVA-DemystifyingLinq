using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case4 : ICaseRunner
    {
        public void Run()
        {

            var enumerator = GenerateStringsTheOldWay().GetEnumerator();           

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
            GenerateStringsTheOldWay().Print();
        }

        static IEnumerable<string> GenerateStringsTheOldWay()
        {
            int i = 0;
            List<string> result = new List<string>();

            while (i++ < int.MaxValue / 200)
            {
                result.Add(i.ToString());
            }

            //Cannot combine yield return and return
            //yield return "1";
            return result;

        }
    }
}
