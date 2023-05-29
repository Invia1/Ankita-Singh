using System;
class demo
{
    public static bool myfun(string mystring)
    {

        if (mystring.Length<=17)
        {
            return true;
        }
        else
        {
            return false;
        };


    }

    public static void Main()
    {
        Predicate<string> val = myfun;
        Console.WriteLine(val("C# coding @1223 "));
        Console.WriteLine(val("hey coding world..."));
    }
}