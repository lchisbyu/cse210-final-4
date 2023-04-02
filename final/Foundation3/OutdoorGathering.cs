using System;

namespace EventPlanning
{
    // Class to represent an outdoor gathering event
    public class OutdoorGathering : Event
    {
        private string weatherStatement;

        // Constructor to initialize the outdoor gathering
        public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherStatement) : base(title, description, date, time, address)
        {
            this.weatherStatement = weatherStatement;
        }
        // Method to return a string with the full details of the outdoor gathering
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nWeather: {weatherStatement}";
        }
    }
}