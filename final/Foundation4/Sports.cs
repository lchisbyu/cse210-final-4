using System;

namespace FitnessCenter
{
    public abstract class Sport
    {
        public DateTime Date { get; set; }
        public int Seconds { get; set; }

        public Sport(DateTime date, int seconds)
        {
            this.Date = date;
            this.Seconds = seconds;
        }

        public abstract double GetDistanceMiles();

        public virtual double GetSpeedMPH()
        {
            return GetDistanceMiles() / (Seconds / 60 / 60.0);
        }

        public virtual double GetPace()
        {
            return (Seconds / 60.0) / GetDistanceMiles();
        }

        public abstract string GetSummary();
    }
}
