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
            await Task.Run(() => DoLongTimeWork());
            toolStripStatusLabel1.Text = "èIóπ";
        }

        private void DoLongTimeWork() {
            System.Threading.Thread.Sleep(5000);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e) {

        }
    }
}
