namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            List<GreetingBase> list = [
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
    class GrretingMorning:GreetingBase {
        public override string GetMessage()=> "おはよう";
    }
    class GrretingAfternoon:GreetingBase {
        public override string GetMessage() => "こんにちは";
    }
    class GrretingEvening:GreetingBase {
        public override string GetMessage() => "こんばんは";
    }
}
