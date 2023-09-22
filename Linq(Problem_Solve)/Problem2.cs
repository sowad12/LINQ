using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    public class Problem2
    {
        // Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
        //Expected Output:
        //The numbers within the range of 1 to 11 are :
        //1 3 6 9 10
        public void Problem2_func()
        {
            var list = new List<int>() { 1,2,3,4,-1,-3,-4,5,8,9,-10,11};
            var res=list.Where(x=>x > 0).ToList();
            foreach(var x in res)
            {
                Console.Write(x+" ");
            }
        }

    }
}
