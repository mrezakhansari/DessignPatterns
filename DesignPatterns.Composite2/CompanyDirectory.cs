using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite2
{
    public class CompanyDirectory : IEmployee
    {
        private List<IEmployee> employeeList = new List<IEmployee>();  
        public void ShowEmployeeDetails()
        {
            foreach (IEmployee em in employeeList) 
            {
                em.ShowEmployeeDetails();
            }
        }
        public void AddEmployee(IEmployee employee)
        {
            employeeList.Add(employee);
        }
        public void RemoveEmployee(IEmployee employee) 
        {
            employeeList.Remove(employee);
        }
    }
}