using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5
{

    class Case1 : ICaseRunner
    {
        public void Run()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //select is required here
            var smallNubers = from n in nums
                              where n < 5
                              //orderby -n
                              select n;
                              
            smallNubers.Print();


            //a minor syntax overhead with lambda versus : where n < 5
            var smallNubers2 = nums.Where(x => x < 5);                            

            smallNubers2.Print();
        }       
    }
}
