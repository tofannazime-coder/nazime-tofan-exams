using System;

namespace Odev07_StepCounter.Models
{
    public class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Günlük adım hedefinizi girin:");
            int dailyGoal = Convert.ToInt32(Console.ReadLine());

            StepCounter stepCounter = new StepCounter(dailyGoal, 0);

            while (true)
            {
                Console.WriteLine("Atılan adım sayısını girin (çıkmak için -1):");
                int steps = Convert.ToInt32(Console.ReadLine());

                if (steps == -1)
                {
                    break;
                }

                stepCounter.AddSteps(steps);
                stepCounter.IsGoalReached();
            }

   
        }

    }

}
