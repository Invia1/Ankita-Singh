using System;
using System.Collections.Generic;
using ConsoleApp11.Model;
namespace ConsoleApp11.services
{
    public class frienddata
    {
        public string Name;
        List<string> ls = new List<string>();
        

        public void Display()
        {

            foreach (string name in ls)
                Console.WriteLine(name);
        }
        public void Updatedata(string oldname,string newname)
        {
            ls.Remove(oldname);
            ls.Add(newname);
            Display();

        }

        public void deletedata(string name)
        {
            ls.Clear();
            Display();
        }
        public void searchdata(string name)
        {
           bool b= ls.Contains(name);
            if(b)
            {
                Console.WriteLine($"Name is found");
            }
            else
            {
                Console.WriteLine($"Name is not found");
            }
            Display();

        }

        friend obj = new friend();
      

    }
        



    
}
