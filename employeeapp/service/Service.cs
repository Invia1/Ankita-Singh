using employeeapp.model;
using System;
using employeeapp.Interface1;
using System.Collections.Generic;

namespace employeeapp.service
{
    public class empservice : EmployeeInterface
       
    {
        //EmployeeInterface EI = new empservice();

        List<employee> ls = new List<employee>();    
        public int createEmployee(employee emp)
        {
            ls.Add(emp);
            return 1;
        }

      public List<employee> GetEmployeelist()
        {
           
            return ls;
        }
      

    }
}
