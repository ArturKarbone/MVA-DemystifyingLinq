using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{

//Query(more concise syntax/ no lambda “overhead” n=>)  reads more like english VS Fluent
//some stuff is not available in queries

//Query Expression Pattern(pattern based - certain methods must be available)
//order by / then by
//descending

// figure out group join /compare with db join(подключись)

//recursive linq

//Reactive Extensions LINQ to Events
//source is pushing data at you and you are reacting(opposite flow)

//2 froms - cross

//SelectMany = flatten

//Resharper - LINQ tips



    class Program
    {

        public static IEnumerable<ICaseRunner> GatherCases()
        {
            //yield return new Case1();
            //yield return new Case2();
            //yield return new Case3();
            //yield return new Case4();
            //yield return new Case5();
            yield return new Case6();


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