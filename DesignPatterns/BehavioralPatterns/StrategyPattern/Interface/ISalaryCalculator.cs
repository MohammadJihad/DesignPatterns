using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.StrategyPattern
{
    public interface ISalaryCalculator
    {
        double CalculateSalary(Employee employee);
    }
}
