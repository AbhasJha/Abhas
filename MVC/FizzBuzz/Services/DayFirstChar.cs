namespace FizzBuzz.Services
{
    public class DayFirstChar : IDayFirstChar
    {
        string IDayFirstChar.GetChar(string input)
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(input);
            strBuilder[0] = DateTime.Now.DayOfWeek.ToString()[0];
            return strBuilder.ToString();
        }
    }
}
