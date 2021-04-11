using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public enum EmployeeType
    {
        FullTime,
        PartTime,
        Contractor
    }
    public class Employee
    {
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public EmployeeType Type { get; set; }
    }

    /// <summary>
    /// Before refactoring
    /// </summary>
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            double salary = 0;
            switch (employee.Type)
            {
                case EmployeeType.FullTime:
                    salary = 200;
                    break;
                case EmployeeType.PartTime:
                    salary = 100;
                    break;
                case EmployeeType.Contractor:
                    salary = 50;
                    break;
                default:
                    break;
            }
            return salary;
        }
    }
}