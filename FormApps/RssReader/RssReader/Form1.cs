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
    { "��v", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
    { "����", "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
    { "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" },
    { "�X�|�[�c", "https://news.yahoo.co.jp/rss/topics/sports.xml" },
    { "�G���^��", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
    { "�Ȋw","https://news.yahoo.co.jp/rss/topics/science.xml"}
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
            var idx = e.Index;                                                      //�`��Ώۂ̍s
            if (idx == -1) return;                                                  //�͈͊O�Ȃ牽�����Ȃ�
            var sts = e.State;                                                      //�Z���̏��
            var fnt = e.Font;                                                       //�t�H���g
            var _bnd = e.Bounds;                                                    //�`��͈�(�I���W�i��)
            var bnd = new RectangleF(_bnd.X, _bnd.Y, _bnd.Width, _bnd.Height);     //�`��͈�(�`��p)
            var txt = (string)lbTitles.Items[idx];                                  //���X�g�{�b�N�X���̕���
            var bsh = new SolidBrush(lbTitles.ForeColor);                           //�����F
            var sel = (DrawItemState.Selected == (sts & DrawItemState.Selected));   //�I���s��
            var odd = (idx % 2 == 1);                                               //��s��
            var fore = Brushes.WhiteSmoke;                                         //�����s�̔w�i�F
            var bak = Brushes.AliceBlue;                                           //��s�̔w�i�F

            e.DrawBackground();                                                     //�w�i�`��

            //����ڂ̔w�i�F��ς���i�I���s�͏����j
            if (odd && !sel) {
                e.Graphics.FillRectangle(bak, bnd);
            } else if (!odd && !sel) {
                e.Graphics.FillRectangle(fore, bnd);
            }

            //������`��
            e.Graphics.DrawString(txt, fnt, bsh, bnd);
        }

    }
}