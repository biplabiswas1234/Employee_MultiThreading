using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_MultiThreading
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeDetails> employeeDatalist = new List<EmployeeDetails>();
        public void AddEmployee(List<EmployeeDetails> employeeDatalist)
        {
            employeeDatalist.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.Name);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.Name);
            }
            );
            Console.WriteLine(this.employeeDatalist.ToString());
        }
        public void AddEmployeePayroll(EmployeeDetails employee)
        {
            employeeDatalist.Add(employee);
        }
    }
}
