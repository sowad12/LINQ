using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    // Write a program in C# Sharp to find a string that starts and ends with a specific character.
    //Test Data :
    //The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
    //Input starting character for the string : A
    //Input ending character for the string : M
    //Expected Output :
    //The city starting with A and ending with M is : AMSTERDAM
    public class Problem7
    {
        public void Problem7_func()
        {
            var list=new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM" };
            var res = list.Where(x => x.StartsWith('A') && x.EndsWith("M")).ToList();
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
