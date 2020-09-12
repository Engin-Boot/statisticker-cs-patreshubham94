using System;
using Statistics;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    
  
  
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;
               
        public StatsComputer CalculateStatistics(List<double> numbers) {
            StatsComputer myStats = new StatsComputer();
           if(numbers.Count == 0){
                myStats.average = double.NaN;
               myStats.max = double.NaN;
               myStats.min = double.NaN;
               return myStats;
            }
            
            else {
                myStats.average = numbers.Average();
                myStats.min = numbers.Min();
                myStats.max = numbers.Max();
                
                return myStats;
            }
        }
    }
}
