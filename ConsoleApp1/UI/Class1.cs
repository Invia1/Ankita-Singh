using System;
using System.Reflection.Emit;
using project_test.counter;
using project_test.service;

namespace project_test.UI
{
    internal class main
    {
        private static int num;

        public static void Main()
        {
            services obj1 = new services();
            // store obj2 = new store();

            obj1.Adddata();
            obj1.Display();
            //obj2 = new store();
            int n;
            Console.WriteLine("\n\t\t\t\t\t|-----------------------------|");
            Console.WriteLine("\t\t\t\t\t|Welcome to RiM Hospital        |");
            Console.WriteLine("\t\t\t\t\t|-----------------------------|");


            do
            {
            Label:
                Console.WriteLine("...press 1 for add  data... ");
                Console.WriteLine("...press 2 for deletion of data... ");
                Console.WriteLine("...press 3 for display of data... ");

                n = int.Parse(Console.ReadLine());
                if (n >= 0 && n <= 4)
                {
                    Console.WriteLine(n + " ");
                }
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        //num = Convert.ToInt32(Console.ReadLine());
                        case 1:

                            Console.WriteLine(" enter firstname");
                            string firstname = Console.ReadLine();

                            Console.WriteLine("enter lastname");
                            string lastname = Console.ReadLine();
                            obj1.Adddata();
                            obj1.Display();
                            break;

                        case 2:
                            Console.WriteLine("enter the data which you want to delete");
                            Console.WriteLine(" enter name");
                            string name = Console.ReadLine();

                            break;

                        case 3:
                            int id = Convert.ToInt32(Console.ReadLine());
                            obj1.deletedata(id);
                            obj1.Display();

                            break;




                    }



                } while (true) ;






            }
            

    }
    

}