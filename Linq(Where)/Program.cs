// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using System.Xml.Linq;

public class CustomerModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }
};
class Program
{
    static void Main()
    {
    var list = new List<CustomerModel>() {
    new CustomerModel(){ Name= "Rahim",Email="rahim@gmail.com", PhoneNumber="01235566", Age=20 },
    new CustomerModel(){ Name= "Karim",Email="karim@gmail.com", PhoneNumber="01235577", Age=21 },
    new CustomerModel(){ Name= "Kamal",Email="kamal@gmail.com", PhoneNumber="51935566", Age=22 },
    new CustomerModel(){ Name= "Naruto",Email="naurto@gmail.com", PhoneNumber="01235566", Age=23 },
    new CustomerModel(){ Name= "Sasuke",Email="sasuke@gmail.com", PhoneNumber="01235566", Age=24}
};
        Console.WriteLine(list);
        foreach (var item in list)
        {
            Console.WriteLine(item.Name);
        }
        //Normal where method
        var filterList = list.Where(x => x.Name.StartsWith('K') && x.Age >= 20);
        foreach (var item in filterList)
        {
            Console.WriteLine($"{item.Name} is filtered");
        }
        //Where extension method also have second overload
        var filterList2 = list.Where((x, i) =>
        {
            if (i % 2 == 0)
            {
                return true;
            }
            return false;
        });
        foreach (var item in filterList2)
        {
            Console.WriteLine($"{item.Name} and {item.Age} is filtered by even position");
        }

        //mutliple Where method
        var MutipleFilter = list.Where(x => x.Age > 21).Where(s => s.Age < 24);
        foreach (var item in MutipleFilter)
        {
            Console.WriteLine($"Multiple Filter {item.Name} and {item.Age} ");
        }

        //Where can use on array also
        var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        var ArrayFilter = arr.Where(x => x % 2 == 0);
        Console.WriteLine(ArrayFilter.GetType());
        foreach (var item in ArrayFilter)
        {
            Console.Write(item + " ");
        }
    }
}
