using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.Hours < 24)
            {
                return duration.Hours.ToString("F1", CultureInfo.InvariantCulture ) + " Hours";
            }

            return duration.Days.ToString("F1 " , CultureInfo.InvariantCulture) + " Days";

            
        }

    }
}
