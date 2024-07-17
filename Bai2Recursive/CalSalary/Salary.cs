using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Recursive.CalSalary
{
    public static class Salary
    {
        //Tính tổng lương tháng
        public static decimal CalSalary(decimal baseSalary, int month)
        {
            decimal totalSalary = 0;
            decimal salary = baseSalary;
            for (int i = 0; i < month; i++)
            {
                totalSalary += salary;
                salary *= (decimal)1.1;
            }
            return totalSalary;
        }

        //Tính tổng lương tháng sử dụng đệ quy
        //Bằng lương tháng hiện tại + lương các tháng trước đó
        public static decimal CalSalaryRecursive(decimal salary, int month)
        {
            if (month == 1)
            {
                return salary;
            }

            return CalSalaryRecursive(salary, month - 1) + CalCurrentSalary(salary, month);
        }

        //Tính lương tháng hiện tại
        //Lương tháng hiện tại + 10% mỗi tháng
        public static decimal CalCurrentSalary(decimal salary, int month)
        {
            if (month == 1)
            {
                return salary;
            }

            return CalCurrentSalary(salary, month - 1) * (decimal)1.1;
        }
    }
}
