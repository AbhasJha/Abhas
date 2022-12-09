namespace FizzBuzz.Services
{
    public class Weekdayverfier : IWeekdayverfier
    {
       
        public bool IsWednesday()
        {
            return  (DateTime.Now.DayOfWeek.ToString()=="Wednesday") ? true : false;
           

        }
    }
}
