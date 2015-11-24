using Common;
using System.Linq;

namespace Lesson5
{

    class Case2 : ICaseRunner
    {
        public void Run()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //how anonymous toStirng works?
            var squares = from n in nums
                          select new { Number = n, Square = n * n };

            squares.Print();


            var squares2 = nums.Select(x => new { Number = x, Squate = x * x });
                          

            squares2.Print();
        }
    }
}
