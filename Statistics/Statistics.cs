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
            Stats myStats1 = new Stats();
                
               myStats1.average = double.NaN;
               myStats1.max = double.NaN;
               myStat1s.min = double.NaN;
               return myStats1;
            }
            
           
              Stats myStats2 = new Stats();  
            
               double avg = numbers.Average();
               double maximum = numbers.Max();
               double minimum= numbers.Min();
            
                myStats2.average = avg;
                myStats2.min = minimum;
                myStats2.max = maximum;
                
                return myStats2;
           
        
    }
}
