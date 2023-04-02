using System;
using System.Collections.Generic;
using EventPlanning;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of activities
            List<Event> events = new List<Event>();

            // Add some activities to the list
            DateTime schedule = new DateTime(2023, 06, 07, 12, 00, 00);
            Address location = new Address("10 Downing Street", "London", "Westminster", "SW1");
            events.Add(new Lecture("My Cool Lecture", "Lecture Description", schedule, schedule, location, "Tony Blair", 500));

            events.Add(new OutdoorGathering("My Outdoor Gathering", "It's going to be fun", schedule, schedule, location, "Expect rain"));

            events.Add(new Reception("My Reception", "Be there or be square", schedule, schedule, location, "reception@fake.domin.com"));

            // Display the summary of each activity
            foreach (Event e in events)
            {
                Console.WriteLine($"Standard Details\n----------------\n{e.GetStandardDetails()}\n");
                Console.WriteLine($"Full Details\n------------\n{e.GetFullDetails()}\n");
                Console.WriteLine($"Short Description\n-----------------\n{e.GetShortDescription()}\n");
                Console.WriteLine("\n");
            }
        }
    }
}