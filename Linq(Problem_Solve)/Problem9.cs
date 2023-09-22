using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
//    Write a program in C# Sharp to display the top n-th records.
//Test Data :
//The members of the list are :
//5
//7
//13
//24
//6
//9
//8
//7
//How many records you want to display? : 3
//Expected Output :
//The top 3 records from the list are :
//24
//13
//9
    public class Problem9
    {
        public void Problem9_func()
        {
            var list=new List<int>() {5,7,13,24,6,9,8,7};
            var res=list.OrderByDescending(x => x).Take(3).ToList();
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
