using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Case8 : ICaseRunner
    {
        public void Run()
        {
            int i = 0;          
            var sequence = GenerateStringsTheOldWay(() => i++).Take(10);
            i = 50;

            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<T> GenerateStringsTheOldWay<T>(Func<T> itemGenerator)
        {
            int i = 0;
            List<T> result = new List<T>();

            while (i++ < int.MaxValue / 50)
            {
                result.Add(itemGenerator());
            }

            //Cannot combine yield return and return
            //yield return "1";
            return result;
        }
    }
}
