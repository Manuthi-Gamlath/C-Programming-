using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Q3
{
 public class TemperatureTracker
        {
            private double[] temperature=new double[7];

            public void dailyTemperature()
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"Enter temperature for day {i + 1}: ");
                    Temperature[i]=double.Parse( Console.ReadLine() );
                }
            }

        public void Report()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
            }
        }
        }
    }
}
