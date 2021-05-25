using System;
using System.Globalization;


namespace Extension_Methods.Extensions
{
    static class DateTimeExtensions
    {
        public static  string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); //Tem um objeto aux TimeSpan representando uma duração representando qto tempo passou agora em relação datetime

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "Days";
            }
        }
    }
}
