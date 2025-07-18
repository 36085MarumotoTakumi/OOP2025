using System;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        public Form1() {
            InitializeComponent();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            try {
                using (var hc = new HttpClient()) {

                    XDocument xdoc = XDocument.Parse(await hc.GetStringAsync(cbUrl.Text));
                    //var url = hc.OpenRead(tbUrl.Text);
                    //XDocument xdoc = XDocument.Load(url);//RSSÇÃéÊìæ

                    items = xdoc.Root.Descendants("item").Select(x =>
                    new ItemData {
                        Title = (string)x.Element("title"),
                        link = (string)x.Element("link"),
                    }).ToList();

                    cbTitles.Items.Clear();
                    items.ForEach(item => cbTitles.Items.Add(item.Title));
                }
            }
            catch {
                MessageBox.Show("ê≥ÇµÇ¢URLÇì¸óÕÇµÇƒÇ≠ÇæÇ≥Ç¢", "ÉGÉâÅ[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTitles_SelectedIndexChanged(object sender, EventArgs e) {

            var selectitem = cbTitles.SelectedItem;
            foreach (var item in items) {
                if (item.Title == selectitem) {
                    webView21.Source = new Uri(item.link);
                }
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
            if (!cbUrl.Items.Contains(cbUrl.Text)) {
                cbUrl.Items.Add(cbUrl.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            GoFowardBtEnableSet();
        }

        private void GoFowardBtEnableSet() {
            Back.Enabled = webView21.CanGoBack;
            Move.Enabled = webView21.CanGoForward;
        }
    }
}