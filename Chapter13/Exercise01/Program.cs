
using System.Diagnostics;

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
                .OrderBy(b => b.Key)
                .Select(b => new {
                    PublishedYear = b.Key,
                    Count = b.Count(),
                });

            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear}:{book.Count}");
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenBy(b => b.CategoryId)
                .ThenBy(b => b.Price);
            foreach (var book in books) {
                Console.WriteLine(book);
            }

        }

        private static void Exercise1_5() {
            var books = Library.Books
                .Where(b => b.PublishedYear == 2022)
                .Join(Library.Categories,
                    book => book.CategoryId,
                    Category => Category.Id,
                    (book, Category) => Category.Name)
                .Distinct();
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
            var books = Library.Books
                .Join(Library.Categories,
                    book => book.CategoryId,
                    Category => Category.Id,
                    (book, Category) => new {
                        CategoryName = Category.Name,
                        book.Title,
                    })
                .GroupBy(z => z.CategoryName)
                .OrderBy(z => z.Key);
            foreach (var book in books) {
                Console.WriteLine($"# {book.Key}");
                foreach (var item in book) {
                    Console.WriteLine(item.Title);
                }

            }
        }

        private static void Exercise1_7() {
            var books = Library.Categories
                .Where(c => c.Name.Equals("Development"))
                .Join(Library.Books,
                    c => c.Id,
                    b => b.CategoryId,
                    (c, b) => new {
                        b.Title,
                        b.PublishedYear,
                    })
                .GroupBy(x => x.PublishedYear)
                .OrderBy(x => x.Key);
            ;
            foreach (var book in books) {
                Console.WriteLine($"# {book.Key}");
                foreach (var item in book) {
                    Console.WriteLine(item.Title);
                }

            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                             .GroupJoin(Library.Books
                             , c => c.Id
                             , b => b.PublishedYear,
                             (c, books) => new {
                                 CategoryName = c.Name,
                                 Count = books.Count(),
                             }).Where(x=>x.Count>=4)
                             .Select(x=>x.CategoryName);

            foreach (var name in groups) {
                Console.WriteLine(name);
                }
            }
        }
    }

