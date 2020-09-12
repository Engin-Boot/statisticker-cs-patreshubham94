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
                                
               double avg = numbers.Average();
               double miximum = numbers.Max();
               double minimum= numbers.Min();
                myStats.average = avg;
                myStats.min = minimum;
                myStats.max = maximum;
                
                return myStats;
            }
        }
    }
}
