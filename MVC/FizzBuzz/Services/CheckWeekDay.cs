namespace FizzBuzz.Services
{
    public class CheckWeekDay :ICheckWeekDay
    {
        public bool WeekDayWednesdayOrNot()
        {
            if (DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                return true;
            else
                return false;
        }
    }
}
