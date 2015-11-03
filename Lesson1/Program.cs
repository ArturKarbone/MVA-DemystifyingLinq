using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Lesson1
{
    class Program
    {
        public static IEnumerable<ICaseRunner> GatherCases()
        {
            //yield return new Case1();
            //yield return new Case2();
            //yield return new Case3();
            //yield return new Case4();
            //yield return new Case5();
            //yield return new Case6();
            //yield return new Case7();
            //yield return new Case8();
            yield return new Case9();
            yield return new Case10();
           
        }      

        static void Main(string[] args)
        {
            GatherCases().ToList().ForEach(c => c.Run());

            Console.ReadKey();
        }
    }
}
