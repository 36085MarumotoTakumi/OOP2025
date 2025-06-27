using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var culture = new CultureInfo("ja-JP");

            Console.WriteLine("西暦を入力");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("月を入力");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("日を入力");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);
            var modo = new DateTime(2025,1,1);
            var today = DateTime.Today;
            string dayOfWeek = birthday.ToString("dddd", culture);
            TimeSpan dayyy = (today - birthday);

            Console.WriteLine($"{birthday.Year}年の{birthday.Month}月{birthday.Day}日は{dayOfWeek}です");
            Console.WriteLine("生まれてから" + dayyy + "日目です");

            bool uru = DateTime.IsLeapYear(birthday.Year);
            if (uru = true) {
                Console.WriteLine(birthday.Year + "はうるう年です");
            } else {
                Console.WriteLine(birthday.Year + "は平年です");
            }
            TimeSpan nwd = today - modo;
            Console.WriteLine("1月1日から"+nwd+"日目です");
            while (true) {
                Console.Write("\r" + DateTime.Now);
            }
        
        }
    }
}