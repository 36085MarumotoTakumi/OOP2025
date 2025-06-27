using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecord.DataSource = listCarReports;
        }
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPictures.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btRecordDelete_Click(object sender, EventArgs e) {
            pbPictures.Image = null;
        }
        private void btRecordAdd_Click(object sender, EventArgs e) {
            var carReport = new CarReport {
                Author = "’r“c‚Ð‚ë‚µ",
                CarName = "ƒNƒ‰ƒEƒ“",
            };
            listCarReports.Add(carReport);
        }


    }
}
