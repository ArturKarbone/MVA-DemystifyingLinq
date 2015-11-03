using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case2 : ICaseRunner
    {
        public void Run()
        {
            TestYield().Print();
        }

        static IEnumerable<string> TestYield()
        {

            //yield is contextual keyword. yield by it self is not a keyword
            var yield = "yeld value";
            yield return "one";
            yield return "two";
            yield return "three";
            yield return yield;
        }
    }
}
