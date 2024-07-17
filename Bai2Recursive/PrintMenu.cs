using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Recursive
{
    public static class PrintMenu
    {
        //In ra các menu
        public static void Print(this Menu[] menus)
        {
            PrintChild(menus, 0, 0); // bắt đầu từ gốc (parentId = 0)
        }

        //In ra các menu con theo parentId
        private static void PrintChild(this Menu[] menus, int parentId, int level)
        {
            foreach(var child in menus)
            {
                if(child.ParentId == parentId) // Nếu là menu con của parentId thì in ra
                {
                    Console.WriteLine($"{string.Concat(Enumerable.Repeat("--", level))}{child.Title}");
                    PrintChild(menus, child.Id, level + 1); // Tiếp tục in ra các menu con của menu hiện tại
                }
            }
        }
    }
}
