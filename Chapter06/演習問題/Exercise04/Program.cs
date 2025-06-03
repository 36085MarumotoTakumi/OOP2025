namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var array = line.Split(';');
            array[0] = array[0].Replace("Novelist=", "作家　　:");
            array[1] = array[1].Replace("BestWork=", "代表作　:");
            array[2] = array[2].Replace("Born=", "誕生年　:");

            foreach (var item in array) {
                Console.WriteLine(item);
            }
        }
    }
}


