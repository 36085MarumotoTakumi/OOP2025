using System.Threading.Tasks;

namespace Section04 {
    internal class Program {
        static async Task Main(string[] args) {
            HttpClient client = new HttpClient();
            await GetHtmlExample(client);
        }
        static async Task GetHtmlExample(HttpClient httpClient) {
            var url = "https://www.debian.or.jp/";
            var text = await httpClient.GetStringAsync(url);
            Console.WriteLine(text);
        }
    }
}
