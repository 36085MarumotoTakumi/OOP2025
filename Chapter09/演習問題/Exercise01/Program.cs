using System;
using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            var time1 = string.Format($"{dateTime:yyyy/MM/dd HH:mm}");
            Console.WriteLine(time1);
        }


        private static void DisplayDatePattern2(DateTime dateTime) {
            var time2 = dateTime.ToString($"{dateTime:yyyy年MM月dd日 HH時mm分}");
            Console.WriteLine(time2);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var culuture = new CultureInfo("ja-JP");
            culuture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var datestr = dateTime.ToString("ggyy", culuture);
            var dateOfWeek = culuture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

            var time3 = string.Format($"{datestr}年{dateTime.Month,2}月{dateTime.Day,2}日({dateOfWeek})");
            Console.WriteLine(time3);
        }
    }
}
