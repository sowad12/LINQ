using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    internal class Problem3
    {
// Write a program in C# Sharp to find the number of an array and the square of each number.
//Expected Output :
//{ Number = 9, SqrNo = 81 }
//{ Number = 8, SqrNo = 64 }
//{ Number = 6, SqrNo = 36 }
//{ Number = 5, SqrNo = 25 }
    public void Problem3_func()
        {
            var list = Enumerable.Range(1, 10);
            var res = list.Select(x => new
            {
                Number=x,
                SqrNo=x*x
            }).ToList();
            foreach (var item in res)
            {
                Console.WriteLine($"Number:{item.Number}, SqrNo:{item.SqrNo}");
            }
        }
    }
}
