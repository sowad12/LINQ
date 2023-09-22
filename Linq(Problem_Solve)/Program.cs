namespace Linq_Problem_Solve_
{
    internal class Program
    {
        //all questions are available in W3Resource
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Problem1 obj=new Problem1();
            obj.Problem1_func();
            Console.WriteLine();
            Problem2 obj2 = new Problem2();
            obj2.Problem2_func();
            Console.WriteLine();
            Problem3 obj3 = new Problem3();
            obj3.Problem3_func();
            Console.WriteLine();
            Problem4 obj4 = new Problem4();
            obj4.Problem4_func();
            //Console.WriteLine();
            //Problem5 obj5 = new Problem5();
            //obj5.Problem5_func();
            Console.WriteLine();
            Problem6 obj6 = new Problem6();
            obj6.Problem6_func();
            Console.WriteLine();
            Problem7 obj7 = new Problem7();
            obj7.Problem7_func();
            Console.WriteLine();
            var obj8 = new Problem8();
            obj8.Problem8_func();
            Console.WriteLine();
            var obj9 = new Problem9();
            obj9.Problem9_func();
        }
    }
}