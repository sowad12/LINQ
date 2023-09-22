namespace Linq_select_
{
    class Employee
    {
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3,4,5,6,7,8};
      
            var selectResult1=arr.Select(x => x*x);
            
            foreach (var item in selectResult1)
            {
              Console.Write(item+" ");   
            }
            Console.WriteLine();    
            //or define array using var
            var str = new[] { "hi", "hello", "hey", "howdy" };
            var res = str.Select(x => x[0].ToString().ToUpper()+x.Substring(1));
            foreach (var item in res) { 
            Console.Write(item+" ");    
            }
            Console.WriteLine();
            var employees = new List<Employee>() {
                new Employee { Name = "John", Department = "HR", Salary = 50000 },
                new Employee { Name = "Jane", Department = "IT", Salary = 60000 },
                new Employee { Name = "Bob", Department = "HR", Salary = 45000 },
                new Employee { Name = "Sara", Department = "IT", Salary = 55000 },
                new Employee { Name = "Tom", Department = "IT", Salary = 65000 }
            };
            var names = employees.Where(x => x.Salary > 50000).Select(e => e.Name);
            foreach (var item in names) {
                Console.WriteLine(item);
            }

            var payroll = employees.Select(e => new {
                e.Name,
                e.Salary
            });

            foreach (var employee in payroll)
            {
                Console.WriteLine(employee);
            }
        }
    }
}