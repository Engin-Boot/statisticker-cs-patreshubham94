using System;
using Statistics;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    
    public class Stats
    {
        public double average;
        public double max;
        public double min;
    }
  
    public class StatsComputer
    {
               
        public Stats CalculateStatistics(List<double> numbers) {
            Stats myStats = new Stats();
           if(numbers.Count == 0){
                myStats.average = double.NaN;
               myStats.max = double.NaN;
               myStats.min = double.NaN;
               return myStats;
            }
            
            else {
                myStats.average = number.Average();
                myStats.min = numbers.Min();
                myStats.max = numbers.Max();
                
                return myStats;
            }
        }
    }
}
