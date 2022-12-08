namespace FizzBuzz.Services
{
    public class Weekdayverfier : IWeekdayverfier
    {
        public bool IsWednesday()
        {
            //return (currentday=="Wednesday") ? true : false;
            if (DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                return true;
            else
                return false;

        }
    }
}
