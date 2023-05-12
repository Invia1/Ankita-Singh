using day6.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6.bll
{
    public class waiter
    {
       public food fooddetails()
        {
            food obj = new food();
            obj.costoffood = 100;
            obj.foodname = " veg thali";

            return obj;
        }



    }
}
