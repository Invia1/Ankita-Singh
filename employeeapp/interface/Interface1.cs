using employeeapp.model;
using System;


namespace employeeapp.Interface1
{
   public interface EmployeeInterface
    { 
        int createEmployee(employee emp);

        List<employee> GetEmployeelist();
    }
}
