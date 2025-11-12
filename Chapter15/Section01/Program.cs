namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            List<IGreeting> list = [
                new GrretingMorning(),
                new GrretingAfternoon(),
                new GrretingEvening(),
                ];
            foreach (var obj in list) {
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
               
            }
        }
    }
    class GrretingMorning:IGreeting {
        public string GetMessage()=> "おはよう";
    }
    class GrretingAfternoon:IGreeting {
        public  string GetMessage() => "こんにちは";
    }
    class GrretingEvening:IGreeting {
        public string GetMessage() => "こんばんは";
    }
}
