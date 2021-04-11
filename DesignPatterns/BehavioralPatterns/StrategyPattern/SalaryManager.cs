using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class SalaryManager
    {
        Dictionary<EmployeeType, ISalaryCalculator> salaryStrategies = 
            new Dictionary<EmployeeType, ISalaryCalculator>();
        public SalaryManager()
        {
            salaryStrategies.Add(EmployeeType.FullTime, new FullTimeEmployeeSalaryCalculator());
            salaryStrategies.Add(EmployeeType.PartTime, new PartTimeEmployeeSalaryCalculator());
            salaryStrategies.Add(EmployeeType.Contractor, new ContractorSalaryCalculator());
        }

        public double CalculateSalary(Employee employee)
        {
            return salaryStrategies[employee.Type].CalculateSalary(employee);
        }
    }
}
