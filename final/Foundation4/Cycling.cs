using System;

namespace FitnessCenter
{
    /* defining the Cycling class as a subclass of the Sport class, meaning that Cycling inherits all the properties and methods of the sport class*/
    public class Cycling : Sport
    {
        private double distance;

        // Constructor
        public Cycling(DateTime date, int seconds, double distance) : base(date, seconds)
        {
            this.distance = distance;
        }

        // Override the GetDistanceMiles method to return the distance of the cycling event
        public override double GetDistanceMiles()
        {
            return distance;
        }

        // Override the GetSummary method to produce a summary string for cycling
        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} Cycling ({Seconds} sec)- Distance {GetDistanceMiles():F1} miles, Speed {GetSpeedMPH():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
