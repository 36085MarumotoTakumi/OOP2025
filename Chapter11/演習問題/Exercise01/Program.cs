using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise01 {
    internal class Program {    
        static void Main(string[] args) {

            Console.WriteLine(IsPhoneNumber("090-9111-1234"));
            Console.WriteLine(IsPhoneNumber("090-9111-1234"));
            Console.WriteLine(IsPhoneNumber("080-9111-1234"));
            Console.WriteLine(IsPhoneNumber("070-9111-1234"));
            Console.WriteLine(IsPhoneNumber("A060-9111-1234"));
            Console.WriteLine(IsPhoneNumber("060-9111-1234"));




           // var text = "private List<string> result = new List<string>();";
            //bool isMatch = IsPatternText(text, @"$private");
            
            static bool IsPhoneNumber(string telnum) {

                return Regex.IsMatch(telnum,@"^0[7-9]0-\d{4}-\d{4}$");

                //var regex = new Regex(@"^0(9|8|7)0");
                //if (regex.IsMatch(telnum)) {
                //    Console.Write(telnum+" ");
                //    return true;
                //} else {
                //    Console.Write(telnum+" ");
                //    return false;
                //}
          
            }
        }
    }
}
