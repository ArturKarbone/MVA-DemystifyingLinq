using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Lesson1
{

    //Sequence is not a collection
    //Compose sequences and ask for the collection when you need it
    //Usage - conditional statements in where clause(critical when datastore is not local or not in memory)

    //Card deck collection vs enumerable(generates next item only when you ask for that)

    //Big data/infinite sequence that never ends(don’t need the whole thing)

    //Enumerator pattern MoveNext/Current

    //can’t have yield return and return in the same method

    //yield by it self is not a keyword(contextual keyword)

    //yield return yield

    //Stream analogy
    //Streaming video vs rendering html


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
