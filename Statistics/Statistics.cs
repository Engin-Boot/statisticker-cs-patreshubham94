using System;
using System.Collections.Generic;

namespace Statistics
{
    
    public class Stats
    {
        public double average;
        public double max;
        public double min;
    }
    
    public class StatsCalculator{
        double FindAvg(List<double> numbers){
            double avg = number.Average();
            return avg;
        }
        
        double FindMax(List<double> numbers){
            double maximum = number.max();
            return maximum;
        }
        
        double FindMin(List<double> numbers){
            double minimum = number.min();
            return minimum;
        }
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            Stats myStat = new Stats();
           if(numbers.Count == 0){
                myStat.average = double.NaN;
               myStat.max = double.NaN;
               myStat.min = double.NaN;
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
