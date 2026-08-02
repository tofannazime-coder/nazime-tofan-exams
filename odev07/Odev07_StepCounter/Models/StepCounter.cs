using System;

namespace Odev07_StepCounter.Models
{
    public class StepCounter
    {
      public int DailyGoal { get; set; }
      public int Steps { get; set; }

        public StepCounter(int dailyGoal, int steps)
        {
            DailyGoal = dailyGoal;
            Steps = 0;
        }

        public void AddSteps(int steps)
        {
            Steps += steps;
        }
        public void IsGoalReached()
        {
            if (Steps >= DailyGoal)
            {
                Console.WriteLine("Tebrikler! Günlük hedefinize ulaştınız.");
            }
            else
            {
                Console.WriteLine($"Günlük hedefinize ulaşmak için {DailyGoal - Steps} adım daha atmanız gerekiyor.");
            }
        }
    }
}