using Common;
using Lesson2.C2;
using Lesson2.C3;
using Lesson2.C4;
using Lesson2.C5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{

    //Filter = Where
    //Map = Select
    //Reduce - Aggregate like  Sum for instance

    //Separate traversing with what you do with the sequence


    //TestCase first than implementation


    //sequence = sequence? (because IEnumerable, try out with List)
    //Implementation in your namespace is closer than BCL



    //Predicate

    //MyWhere nongeneric first, generic later
    //GenerateNumbers see compiler error

    //lambda(int n) => {return …}

    //Oveload with domain specific(like logging, etc.)
    //WriteLine(“my implementation”)

    //Select with Index

    //C#6 $“item={item}”

    class Program
    {
        public static IEnumerable<ICaseRunner> GatherCases()
        {
            //yield return new Case1();
            //yield return new Case2();
            //yield return new Case3();
            //yield return new Case4();
            yield return new Case5();
           

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
