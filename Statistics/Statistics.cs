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
        double FindAvg(List<double> numbers){
            double avg = numbers.Average();
            return avg;
        }
        
        double FindMax(List<double> numbers){
            double maximum = numbers.Max();
            return maximum;
        }
        
        double FindMin(List<double> numbers){
            double minimum = numbers.Min();
            return minimum;
        }
        
        public Stats CalculateStatistics(List<double> numbers) {
            Stats myStats = new Stats();
           if(numbers.Count == 0){
                myStats.average = double.NaN;
               myStats.max = double.NaN;
               myStats.min = double.NaN;
               return myStats;
            }
            
            else {
                myStats.average = FindAvg(numbers);
                myStats.min = FindMin(numbers);
                myStats.max = FindMax(numbers);
                
                return myStats;
            }
        }
    }
}
