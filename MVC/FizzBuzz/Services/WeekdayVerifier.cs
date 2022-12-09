using System.Xml.Linq;

namespace FizzBuzz.Services
{
    public class WeekdayVerifier : IWeekdayVerifier
    {
        private readonly string day;
        public WeekdayVerifier(string day)
        {
            this.day= day;
        }
        public bool IsWednesday()
        {
            return Enum.IsDefined(typeof(Matchday), day);
        }
        enum Matchday
        {
            Wednesday
        }
    }
}
