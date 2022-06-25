using Employee_MultiThreading;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EmpTest
{
    public class Tests
    {
        List<EmployeeDetails> employeeDetails;
        EmployeePayrollOperation emppayroll;
        [SetUp]
        public void Setup()
        {
            employeeDetails = new List<EmployeeDetails>();
            emppayroll = new EmployeePayrollOperation();
        }

        [Test]
        public void CheckingTime_Required_For_Inserting_Details()
        {
            employeeDetails.Add(new EmployeeDetails(ID: 1, Name: "Biplab", StartDate: Convert.ToDateTime("2022-03-01"), Gender: "M", PhoneNumber: 9987856958, Address: "Pune", Department: "IT", BasicPay: 70000, Deduction: 100, TaxablePay: 100, IncomeTax: 100, NetPay: 69700));
            employeeDetails.Add(new EmployeeDetails(ID: 2, Name: "Binita", StartDate: Convert.ToDateTime("2022-01-09"), Gender: "F", PhoneNumber: 9920331100, Address: "Pune", Department: "IT", BasicPay: 70000, Deduction: 100, TaxablePay: 100, IncomeTax: 100, NetPay: 69700));
            employeeDetails.Add(new EmployeeDetails(ID: 3, Name: "Kenny", StartDate: Convert.ToDateTime("2022-06-29"), Gender: "F", PhoneNumber: 9920331100, Address: "Pune", Department: "IT", BasicPay: 70000, Deduction: 100, TaxablePay: 100, IncomeTax: 100, NetPay: 69700));
            employeeDetails.Add(new EmployeeDetails(ID: 4, Name: "Hades", StartDate: Convert.ToDateTime("2022-05-19"), Gender: "M", PhoneNumber: 9920331100, Address: "Pune", Department: "IT", BasicPay: 70000, Deduction: 100, TaxablePay: 100, IncomeTax: 100, NetPay: 69700));
            employeeDetails.Add(new EmployeeDetails(ID: 5, Name: "Gigi", StartDate: Convert.ToDateTime("2022-03-02"), Gender: "F", PhoneNumber: 9920331100, Address: "Pune", Department: "IT", BasicPay: 70000, Deduction: 100, TaxablePay: 100, IncomeTax: 100, NetPay: 69700));

            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(employeeDetails);
            DateTime StopDateTimes = DateTime.Now;
            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));

            DateTime StartDateTimeThread = DateTime.Now;
            emppayroll.AddEmployeePayrollThread(employeeDetails);
            DateTime StopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with threads: " + (StopDateTimeThread - StartDateTimeThread));
        }
    }
}