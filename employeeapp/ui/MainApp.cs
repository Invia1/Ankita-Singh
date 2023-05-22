using System;
using employeeapp.model;
using employeeapp.service;
using employeeapp.Interface1;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace employeeapp.ui
{
   public class entry
    {
        public static void Main()
        {
            List<employee> ls = new List<employee>();
           employee obj = new employee();

          //empservice obj= new empservice();
            obj.EId = 100;
            obj.Eage = 22;
            obj.EName = "ankita";
         
         


         EmployeeInterface EI= new empservice();  //encapsulation
            EI.createEmployee(obj);
          

            employee obj1 = new employee();

            obj1.EId = 101;
            obj1.Eage = 22;
            obj1.EName = "sona";
            EI.createEmployee(obj1);
          
           // EI.createEmployee(obj1);

            List<employee> obj1list = EI.GetEmployeelist();

            

            foreach (employee item in obj1list)
            {
                Console.WriteLine(item.EId+" "+item.Eage+" "+item.EName);
            }


          
              
        }
    }
}
