using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case1 : ICaseRunner
    {
        public void Run()
        {
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
