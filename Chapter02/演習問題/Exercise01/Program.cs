using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            //2.1.3

            List<string> titles = new List<string>();
            List<string> artistNames = new List<string>();
            List<int> lengths = new List<int>();
            Console.WriteLine("*****曲の登録*****");
            while (true) {
                Console.WriteLine("タイトルを入力 (終了するには 'end' と入力):");
                string title = Console.ReadLine();
                if (title.ToLower() == "end") {
                    break;
                }
                titles.Add(title);

                Console.WriteLine("アーティストを入力:");
                string artistName = Console.ReadLine();
                artistNames.Add(artistName);

                Console.WriteLine("曲の長さを入力（秒）:");
                int length = int.Parse(Console.ReadLine());
                lengths.Add(length);
            }
            var songs = new List<Song>();
            for (int i = 0; i < titles.Count; i++) {
                songs.Add(new Song(titles[i], artistNames[i], lengths[i]));
            }
            printSongs(songs.ToArray());
        }
        //2.1.4
        private static void printSongs(Song[] songs) {
#if false
            foreach(var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length & 60;
                Console.WriteLine($"{song.Title},{song.ArtistName},{minutes}{seconds:00}");
            }

            //TimeSpan構造体を使った場合
            foreach (var song in songs) {
                var timespan = TimeSpan.FromSeconds(song.Length);
                Console.WriteLine($"{song.Title},{song.ArtistName},{timespan.Minutes}{timespan.Seconds:00}");
            }
#else
            Console.WriteLine("*****登録曲一覧*****");
            //または、以下でも可
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1} {2:m\:ss}",
                song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
#endif
           
        }
    }
}
