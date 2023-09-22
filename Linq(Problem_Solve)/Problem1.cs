using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    public class Problem1
    {
//Write a program in C# Sharp to show how the three parts of a query operation execute.
//Expected Output:
//The numbers which produce the remainder 0 after divided by 2 are :
//0 2 4 6 8
        public void Problem1_func()
        {
           var list=new List<int>() { 0,1,2,3,4,5,6,7,8,9};
           var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var res=list.Where(x=>x%2==0).ToList();
            var type = res.GetType();
            foreach(var x in res)
            {
                Console.Write(x+" ");
            }   
           
        }
    }
}
