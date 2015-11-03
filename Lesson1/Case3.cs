using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case3: ICaseRunner
    {
        public void Run()
        {
            GenerateStrings().Print();
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
