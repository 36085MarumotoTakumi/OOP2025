using System.Collections.Immutable;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var obj = new MySample();

            var newList = obj.MyList.Add(6).RemoveAt(0);
            obj.MyList.ForEach(n => Console.Write($"n"));
            Console.WriteLine();
            newList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();
        }
    }
    class MySample {

        public ImmutableList<int> MyList { get; private set; }

        public MySample() {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            MyList = list.ToImmutableList();
        }
    }
}

