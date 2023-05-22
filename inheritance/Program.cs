using System;
public class inherit
{
    public void method()
    {
        Console.WriteLine("method1");
    }
    public void method2() 
    {
        Console.WriteLine("method2");
    }

    class child:inherit
    {
       public void method3()
        {
            Console.WriteLine("Method3");
        }
        public static void Main()
        {
           
           child obj = new child();
            obj.method();
            obj.method2();
            obj.method3();
            
        }
    }
}

