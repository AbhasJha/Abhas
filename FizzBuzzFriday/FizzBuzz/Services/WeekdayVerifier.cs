namespace FizzBuzz.Services
{
    public class WeekdayVerifier : IWeekdayVerifier
    {
        private readonly string currentDay = string.Empty;
        public WeekdayVerifier(string currentDay)
        {
            this.currentDay = currentDay;
        }
        public bool IsWednesday()
        {
            return DayOfWeek.Wednesday.ToString().Equals(this.currentDay);
        }
        
    }
}
