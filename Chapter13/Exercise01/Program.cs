
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books
                            .MaxBy(b => b.Price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var selected = Library.Books
        .GroupBy(b => b.PublishedYear)
        .Select(group => group.MaxBy(b => b.Price))
        .OrderBy(b => b!.PublishedYear);

            foreach (var book in selected) {
                Console.WriteLine($"{book!.PublishedYear}年 {book!.Title.Count()}");
            }
        }

        private static void Exercise1_4() {
            var Max = Library.Books.Max(x => x.Price);
            var aboves = Library.Books
                .Where(b => b.Price > Max);
            //foreach (var book in aboves) {
            //    Console.WriteLine(book);
            //}
            Console.WriteLine(aboves);
        }

        private static void Exercise1_5() {
            
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
