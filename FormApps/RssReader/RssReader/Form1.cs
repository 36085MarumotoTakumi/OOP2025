using System;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;
        Dictionary<string, string> urls = new Dictionary<string, string> {
    { "主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
    { "国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
    { "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
    { "スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
    { "エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" }
};
        Dictionary<string, string> UserUrls = new Dictionary<string, string> {

        };



        public Form1() {
            InitializeComponent();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            try {
                string url;
                if (urls.ContainsKey(cbUrl.Text)) {
                    url = urls[cbUrl.Text];
                } else {
                    url = cbUrl.Text;
                }


                using (var hc = new HttpClient()) {
                    XDocument xdoc = XDocument.Parse(await hc.GetStringAsync(url));

                    items = xdoc.Root.Descendants("item").Select(x =>
                        new ItemData {
                            Title = (string)x.Element("title"),
                            link = (string)x.Element("link"),
                        }).ToList();

                    lbTitles.Items.Clear();
                    items.ForEach(item => lbTitles.Items.Add(item.Title));
                }
            }
            catch (Exception ex) {
                try {
            //        webView21.Source = new Uri(cbUrl.Text);
                }
                catch (Exception) {
                }
                MessageBox.Show("正しいURLを入力してください\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e) {
            webView21.GoBack();
        }

        private void Move_Click(object sender, EventArgs e) {
            webView21.GoForward();
        }

        private void Reload_Click(object sender, EventArgs e) {
            try {
                webView21.Reload();
            }
            catch (Exception) {
            }
        }

        private void Favorite_Click(object sender, EventArgs e) {
            urls.Add(tbFavorite.Text, webView21.CoreWebView2.Source);
            cbUrl.Items.Add(urls.Keys.Last());
        }

        private void Form1_Load(object sender, EventArgs e) {
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
            CombUrl();
            GoFowardBtEnableSet();

        }

        private void CombUrl() {
            cbUrl.Items.Clear();
            foreach (var key in urls.Keys) {
                cbUrl.Items.Add(key);
            }
        }



        private void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e) {
            GoFowardBtEnableSet();
        }
        private void GoFowardBtEnableSet() {
            Back.Enabled = webView21.CanGoBack;
            Move.Enabled = webView21.CanGoForward;

        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {


            var selectitem = lbTitles.SelectedItem;
            foreach (var item in items) {
                if (item.Title == selectitem) {
                    webView21.Source = new Uri(item.link);
                }
            }
        }
    }
}