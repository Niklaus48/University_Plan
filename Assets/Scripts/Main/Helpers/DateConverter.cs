namespace Main.Helpers
{
    public class DateConverter
    {
        public static int ToDays(string date)
        {
            var split = date.Split('-');
            
            int year = int.Parse(split[0]);
            int month = int.Parse(split[1]);
            int day = int.Parse(split[2]);
            
            return (year * 365 + month * 30 + day);
        }
    }
}