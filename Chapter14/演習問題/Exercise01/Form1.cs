using System.Threading.Tasks;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            Async("./ëñÇÍÉÅÉçÉX.txt");
        }

        private async Task Async(string filepath) {
            listBox1.Items.Clear();
            using (var reader = new System.IO.StreamReader(filepath)) {
                string line;
                int cnt = 1;
                while ((line = await reader.ReadLineAsync()) != null) {
                    listBox1.Items.Add(line);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                Async(ofd.FileName);
            }
        }
    }
}



