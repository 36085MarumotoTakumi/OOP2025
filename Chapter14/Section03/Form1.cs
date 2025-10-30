using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async Task Form1_Load(object sender, EventArgs e) {
        }

        private async void button1_Click(object sender, EventArgs e) {
            toolStripStatusLabel2.Text = "";
            var elapsed = await DoLongTimeWorkAsync(4000);
            toolStripStatusLabel2.Text = $"{elapsed}";
        }

        private async Task<long> DoLongTimeWorkAsync(int milliseconds) {
            var sw = new Stopwatch();
            await Task.Run(() => {
                System.Threading.Thread.Sleep(milliseconds);
            });
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        //戻り値のある同期メソッド
        private async Task DoLongTimeWork() {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e) {

        }
    }
}
