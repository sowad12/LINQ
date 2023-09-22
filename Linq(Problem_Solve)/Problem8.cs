using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    //Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
    //Test Data :
    //The members of the list are :
    //55 200 740 76 230 482 95
    //Expected Output :
    //The numbers greater than 80 are :
    //200
    //740
    //230
    //482
    //95
    public class Problem8
    {
        public void Problem8_func()
        {
          var list=new List<int>() { 55, 200 ,740, 76 ,230, 482, 95 };
          var res=list.Where(x => x > 80).ToList();
          foreach(var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}