using System;
class math
{
    public static void calculate(int a ,int b,int c,int d)
    {
        Console.WriteLine(a+b+c+d);
        Console.WriteLine(a+b-c+d);
        Console.WriteLine(a * b * c);
        Console.WriteLine((a + b+c+d)/4);
    }

    public static void Main()
    {
        Action<int, int, int, int> val = calculate;
        
        val(10, 20,10,30);
    }
}