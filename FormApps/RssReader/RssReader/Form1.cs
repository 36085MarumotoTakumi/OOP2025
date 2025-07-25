using System;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;
        Dictionary<string, string> urls = new Dictionary<string, string> {
    { "主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
    { "国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
    { "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
    { "スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
    { "エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
    { "科学","https://news.yahoo.co.jp/rss/topics/science.xml"}
};
        private List<ItemData> UserItems;
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
                    //  cbUrl.DataSource=urls.Select(x=>x.Key).ToList();
                }
            }
            catch (Exception ex) {
                try {
                    webView21.Source = new Uri(cbUrl.Text);
                }
                catch (Exception) {
                }
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            try {

               
                
                
                        //UserUrls.Add(tbFavorite.Text, items.Select());
                        //cbUrl.Items.Add(UserUrls.Keys.Last());
                    
                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DeleteFavorite_Click(object sender, EventArgs e) {
            try {
               
                cbUrl.Items.Remove(UserUrls.Keys.Last());
            }
            catch (Exception ex) {

            }
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





        private void lbTitles_DrawItem(object sender, DrawItemEventArgs e) {
            var idx = e.Index;                                                      //描画対象の行
            if (idx == -1) return;                                                  //範囲外なら何もしない
            var sts = e.State;                                                      //セルの状態
            var fnt = e.Font;                                                       //フォント
            var _bnd = e.Bounds;                                                    //描画範囲(オリジナル)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //描画範囲(描画用)
            var txt = (string)lbTitles.Items[idx];                                  //リストボックス内の文字
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //文字色
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //選択行か
            var odd = (idx % 2 == 1);                                               //奇数行か
            var fore = Brushes.WhiteSmoke;                                         //偶数行の背景色
            var bak = Brushes.AliceBlue;                                           //奇数行の背景色

            e.DrawBackground();                                                     //背景描画

            //奇数項目の背景色を変える（選択行は除く）
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //文字を描画
            e.Graphics.DrawString(txt, fnt, bsh, bnd);
        }

    }
}