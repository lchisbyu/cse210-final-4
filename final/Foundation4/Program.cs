using System;
using System.Collections.Generic;
using FitnessCenter;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of activities
            List<Activity> activities = new List<Activity>();

            // Add some activities to the list
            activities.Add(new Running(new DateTime(2022, 11, 3), 38, 6.2));
            activities.Add(new Cycling(new DateTime(2022, 11, 24), 320, 100));
            activities.Add(new Swimming(new DateTime(2022, 12, 7), 19, 10));

            // Display the summary of each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
