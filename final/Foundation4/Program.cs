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
            List<Sport> activities = new List<Sport>();

            // Add some activities to the list
            activities.Add(new Running(new DateTime(2022, 11, 3), 3412, 6.2));
            activities.Add(new Cycling(new DateTime(2022, 11, 24), 20200, 100));
            activities.Add(new Swimming(new DateTime(2022, 12, 7), 310, 10));

            // Display the summary of each activity
            foreach (Sport activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
