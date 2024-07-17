using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Recursive
{
    public static class PrintMenu
    {
        public static void Print(this Menu[] menus)
        {
            PrintChild(menus, 0, 0);
        }

        private static void PrintChild(this Menu[] menus, int parentId, int level)
        {
            foreach(var child in menus)
            {
                if(child.ParentId == parentId)
                {
                    Console.WriteLine($"{string.Concat(Enumerable.Repeat("--", level))}{child.Title}");
                    PrintChild(menus, child.Id, level + 1);
                }
            }
        }
    }
}
