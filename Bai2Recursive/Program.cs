using Bai2Recursive.CalMonth;
using Bai2Recursive.CalSalary;
namespace Bai2Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cal salary: ");
            Console.WriteLine(Salary.CalSalary(1000, 4));
            Console.Write("Cal salary recursive: ");
            Console.WriteLine(Salary.CalSalaryRecursive(1000, 4));
            Console.Write("Cal month: ");
            Console.WriteLine(Savings.CalMonth(1000, 10));
            Console.Write("Cal month recursive: ");
            Console.WriteLine(Savings.CalMonthRecursive(1000, 10));

        }
    }
}
