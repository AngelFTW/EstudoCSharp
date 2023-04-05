using System;

namespace BaltaDatas// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime(2019, 10, 10, 10, 10, 10);
            var data2 = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data2);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.DayOfWeek);

            var format = String.Format("{0:yyyy}", data2);
            var format = String.Format("{0:yy}", data2);
            var format = String.Format("{0:y}", data2);
            var format = String.Format("{0:M}", data2);
            var format = String.Format("{0:yyyy-MM-dd}", data2);
            var format = String.Format("{0:dd-MM-yyyy hh:mm:ss ff z}", data2);
            var format = String.Format("{0:t}", data2);
            var format = String.Format("{0:d}", data2);
            var format = String.Format("{0:T}", data2);
            var format = String.Format("{0:D}", data2);
            var format = String.Format("{0:g}", data2);
            var format = String.Format("{0:f}", data2);
            var format = String.Format("{0:r}", data2);
            var format = String.Format("{0:s}", data2);
            var format = String.Format("{0:u}", data2);

            Console.WriteLine(data.AddDays(1));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));

            Console.WriteLine(format);

            DateTime? data3 = null;

            var data4 = DateTime.Now;
            var data4 = DateTime.UtcNow;
            var timezones = TimeZoneInfo.GetSystemTimeZones();

            if (data4.Date == DateTime.Now.Date)
            {
                Console.WriteLine("São iguais");
            }

            var pt = new System.Globalization.CultureInfo("pt-BR");

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(string.Format("{0:0}", DateTime.Now));
            Console.WriteLine(data4.ToLocalTime());

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);
            Console.WriteLine(DateTime.DaysInMonth(2019, 2));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());


        }
    }
}