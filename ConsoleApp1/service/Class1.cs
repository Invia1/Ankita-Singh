using project_test.counter;
using System;

using System.Collections.Generic;

namespace project_test.service;

public class services
{

    public int id;
    List<store> ls = new List<store>();


 public void Display()
    {
        Console.WriteLine("\t---------------WELCOME-----------------");



        foreach (store st in ls)
            Console.WriteLine(st);
      
    }
   
    public void Adddata()
    { 
    
        Console.WriteLine("\n enter your first name:");
        string P_firstname=Console.ReadLine();
        Console.WriteLine(" firstname is:" +P_firstname);

        Console.WriteLine("enter your last name:");
        string lastname = Console.ReadLine();
        Console.WriteLine("lasttname is:" + lastname);

        Console.WriteLine("enter your phone_no:");
        int Phone_no = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("phone_no is:" + Phone_no);

        Console.WriteLine("enter your Gender:");
        string Gender = Console.ReadLine();
        Console.WriteLine("gender is:" + Gender);

        Console.WriteLine("enter your address:");
        string address = (Console.ReadLine());
        Console.WriteLine("address is:" + address);

        Console.WriteLine("enter your consultant:");
        string consultant= Console.ReadLine();
        Console.WriteLine("consultant is:" + consultant);

        Display();
    }

   
   public void deletedata(int id)
    {
       ls.Clear();
        Display();
    }
    /*  public void searchdata(int id)
      {
          bool b = Convert.ToInt32(ls.Contains(id));
          if (b)
          {
              Console.WriteLine($" found");
          }
          else
          {
              Console.WriteLine($"not found");
          }
          Display();

      }*/

    store obj = new store();
}



