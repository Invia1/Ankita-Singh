using System;
using ConsoleApp11.Model;
using ConsoleApp11.services;

namespace ConsoleApp11.UI
{
    public class Class1
    {
        public static void Main()
        {
            frienddata obj = new frienddata();
            

            int num;
            string name;

            do
            {
            Label:

                Console.WriteLine("...press 1 for updation of data... ");
                Console.WriteLine("...press 2 for updation of data... ");
                Console.WriteLine("...press 3 for updation of data... ");

                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("enter the data which you want to update");
                        Console.WriteLine(" enter old name");
                        string oldname = Console.ReadLine();
                        Console.WriteLine("enter new name");
                        string newname = Console.ReadLine();
                        obj.Updatedata(oldname, newname);
                        obj.Display();
                        break;

                    case 2:
                        Console.WriteLine("enter the data which you want to delete");
                        name = Console.ReadLine();
                        obj.deletedata(name);
                        obj.Display();
                        break;

                    case 3:
                        Console.WriteLine("enter the data which you want to search");
                        name = Console.ReadLine();
                        obj.searchdata(name);
                        obj.Display();
                        break;

                }

            } while (num !=0);
            





        }
    }
}
