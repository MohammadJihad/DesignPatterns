using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public class PartTimeEmployeeSalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return 100;
        }
    }
}
