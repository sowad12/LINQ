using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
// Write a program in C# Sharp to display the number and frequency of a given number from an array.
//Expected Output :
//The number and the Frequency are :
//Number 5 appears 3 times
//Number 9 appears 2 times
//Number 1 appears 1 times

    public  class Problem4
    {
  
        public void Problem4_func()
        {
            var list = new List<int>() { 1,6,9,5,9,5,5,2,4};
            var res = list.GroupBy(x=>x).Select(x => new
            {
                Number = x.Key,
                Frequency = x.Count()
            }).ToList(); 
            foreach (var item in res)
            {
                Console.WriteLine($"Number:{item.Number} Frequency:{item.Frequency}");
            }
        }
     
    }
}
