using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Recursive
{
    public static class Savings
    {
        //Tính số tháng để (tiền gửi + lãi suất) = x2 tiền gửi
        public static int CalMonth(decimal money, decimal rate)
        {
            int month = 0;
            decimal totalAmount = money;
            while (totalAmount < money * 2)
            {
                totalAmount += totalAmount * rate / 100;
                month++;
            }
            return month;
        }


        //Tính số tháng để (tiền gửi + lãi suất) = x2 tiền gửi
        public static int CalMonthRecursive(decimal money, decimal rate)
        {
            return CalMonthToDouble(money, money, rate, 0);
        }

        //Tính số tháng để (tiền gửi + lãi suất) = x2 tiền gửi
        //Điều kiện dừng: amount = *2 tiền gửi
        private static int CalMonthToDouble(decimal money, decimal amount, decimal rate, int month)
        {
            if (amount > money * 2)
            {
                return month;
            }
            month++;
            amount += amount * rate / 100;
            return CalMonthToDouble(money, amount, rate, month);
        }

        //Tính số tháng để (tiền gửi + lãi suất) = n x tiền gửi
        // tiền gửi * (1 + lãi suất)^tháng >= tiền gửi * n
        public static int CalMonthRecursive2(decimal rate, decimal n)
        {
            if(n <= 1)
            {
                return 0;
            }


            return 1 + CalMonthRecursive2(rate, n / ((rate + 100) / 100));
        }
    }
}
