namespace FizzBuzz.Services
{
    public class Weekdayverfier : IWeekdayverfier
    {
        //private readonly string today;
        //public Weekdayverfier(string today)
        //{
        //    this.today = today;
        //}

        public bool IsWednesday()
        {
            return true;// (currentday=="Wednesday") ? true : false;
            //if (today == "Wednesday")
            //    return true;
            //else
            //    return false;

        }
    }
}
