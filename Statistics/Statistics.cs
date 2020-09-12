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
    
    public class StatsComputer{ 
        public Stats CalculateStatistics(List<double> numbers) {
            
         
            if(numbers.Count == 0){
            Stats myStats = new Stats();
                
               myStats.average = double.NaN;
               myStats.max = double.NaN;
               myStats.min = double.NaN;
               return myStats;
            }
                     
              Stats myStats1 = new Stats();  
            
               double avg = numbers.Average();
               double maximum = numbers.Max();
               double minimum= numbers.Min();
            
                myStats1.average = avg;
                myStats1.min = minimum;
                myStats1.max = maximum;
                
                return myStats1;
        }
     }
}
