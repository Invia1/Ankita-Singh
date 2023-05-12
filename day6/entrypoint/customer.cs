using day6.bll;
using day6.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6.entrypoint
{
    public class customer
    {
        public static void Main()
        {
            waiter objwaiter = new waiter();
            food temp = objwaiter.fooddetails();
            Console.WriteLine(temp.costoffood+ " " + temp.foodname );

        }

    }
}
