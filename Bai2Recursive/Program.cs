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

            Console.Write("Cal salary recursive 2: ");
            Console.WriteLine(Salary.CalSalaryRecursive2(1000, 4));

            Console.Write("Cal month: ");
            Console.WriteLine(Savings.CalMonth(1000, 10));

            Console.Write("Cal month recursive: ");
            Console.WriteLine(Savings.CalMonthRecursive(1000, 10));

            Console.WriteLine("=== Menu ===");
            Menu[] menus = Init();
            menus.Print();
        }

        //Khởi tạo data
        public static Menu[] Init()
        {
            return new Menu[]
            {
                new Menu { Id = 1, Title = "The thao", ParentId = 0 },                       
                new Menu { Id = 2, Title = "Xa hoi", ParentId = 0 },                         
                new Menu { Id = 3, Title = "The thao trong nuoc", ParentId = 1 },            
                new Menu { Id = 4, Title = "Giao thong", ParentId = 2 },                     
                new Menu { Id = 5, Title = "Moi truong", ParentId = 2 },                      
                new Menu { Id = 6, Title = "The thao quoc te", ParentId = 1 },                
                new Menu { Id = 7, Title = "Moi truong đo thi", ParentId = 5 },              
                new Menu { Id = 8, Title = "Giao thong un tac", ParentId = 4 }              
            };
        }
    }
}
