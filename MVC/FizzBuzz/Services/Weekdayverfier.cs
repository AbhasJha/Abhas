namespace FizzBuzz.Services
{
    public class WeekdayVerfier : IWeekdayVerfier
    {
       
        public bool IsWednesday()
        {
            return  (DateTime.Now.DayOfWeek.ToString()=="Wednesday") ? true : false;
           

        }
    }
}
