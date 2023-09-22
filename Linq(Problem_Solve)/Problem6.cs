using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    //Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
    //Test Data :
    //The numbers in the array are :
    //5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
    //Expected Output :
    //Number Number* Frequency Frequency
    //------------------------------------------------
    //5 15 3
    //1 1 1
    //9 9 1
    //2 4 2
    public class Problem6
    {
        public void Problem6_func()
        {
            var arr = new[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var res = arr.GroupBy(x => x).Select(x => new
            {
                Number=x.Key,
                Multiplication = x.Key * x.Count(),
                Frequency=x.Count()
            });
            foreach (var item in res)
            {
                Console.WriteLine($"Number:{item.Number} Multiplication:{item.Multiplication} Frequency:{item.Frequency}");
            }
        }
    }
}
