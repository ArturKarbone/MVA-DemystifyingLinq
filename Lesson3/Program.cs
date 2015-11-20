using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{


//Don’t do sequence.count != 0, cause it has to iterate trough the entire collection first !

//All(predicate) efficient. fall out as soon it finds an item which does not match

//breakpoint on lambda go on line(or via right click)

//Lambdas understanding and practice


    class Program
    {

        public static IEnumerable<ICaseRunner> GatherCases()
        {
            //yield return new Case1();
            yield return new Case2();
           //yield return new Case3();
            //yield return new Case4();
            //yield return new Case5();


        }

        static void Main(string[] args)
        {
            GatherCases()
                .ToList()
                .ForEach(c => c.Run());

            Console.ReadKey();
        }
    }
}
