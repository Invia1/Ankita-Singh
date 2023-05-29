using System;
namespace System;

class calculate
{
    public static int myfun(int a,double b, double c, int d)
    {
        return Convert.ToInt32(a * b *c * d);
    }

   public static void Main()
    {
        Func<int, double, double, int ,int > myfunc = myfun;
        Console.WriteLine(myfun(10,10.5,1.5,1));
    }
}
