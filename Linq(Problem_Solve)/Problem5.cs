using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problem_Solve_
{
    //Write a program in C# Sharp to display the characters and frequency of each character in a given string.
    //Test Data:
    //Input the string: apple
    //Expected Output:
    //The frequency of the characters are :
    //Character a: 1 times
    //Character p: 2 times
    //Character l: 1 times
    //Character e: 1 times
    public class Problem5
    {
        public void Problem5_func()
        {
            Console.Write("Please input string:");
            var str = Console.ReadLine();
            var res = str.GroupBy(x => x).Select(x => new
            {
                Character = x.Key,
                Frequency= x.Count()
            }).ToList();
         foreach (var item in res)
            {
                Console.WriteLine($"Character {item.Character}:{item.Frequency} times");
            }
        }

    }
}
