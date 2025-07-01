using System.ComponentModel;
using static CarReportSystem.CarReport;

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


        private void btRecordAdd_Click(object sender, EventArgs e) {
            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarName = cbCarName.Text,
                Maker = GetRadioButtonMaker(),
                Picture = pbPictures.Image,
                Report = tbReport.Text,
            };
            listCarReports.Add(carReport);
            setCbAuthor();
            setCbCarName();
            InputItemsAllClear();
        }

        private void setCbCarName() {
            if (true) {
                cbCarName.Items.Add(cbCarName.Text);
            } 
        }

        private void setCbAuthor() {
            if (true) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
        }


        private void btRecordDelete_Click(object sender, EventArgs e) {

        }

        private void InputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rdOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPictures.Image = null;
        }

        private void btDelete_Click(object sender, EventArgs e) {
            pbPictures.Image = null;
        }
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rdHONDA.Checked) {
                return CarReport.MakerGroup.ホンダ;
            } else if (rdMAZDA.Checked) {
                return CarReport.MakerGroup.マツダ;
            } else if (rdNISSAN.Checked) {
                return CarReport.MakerGroup.日産;
            } else if (rdOther.Checked) {
                return CarReport.MakerGroup.その他;
            } else if (rdSUBARU.Checked) {
                return CarReport.MakerGroup.スバル;
            } else if (rdSUZUKI.Checked) {
                return CarReport.MakerGroup.スズキ;
            } else if (rdTOYOTA.Checked) {
                return CarReport.MakerGroup.トヨタ;
            } else {
                return CarReport.MakerGroup.なし;
            }
            return GetRadioButtonMaker();
        }
        private void dgvRecord_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvRecord.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (String)dgvRecord.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((MakerGroup)dgvRecord.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (String)dgvRecord.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (String)dgvRecord.CurrentRow.Cells["Report"].Value;
            pbPictures.Image = (Image)dgvRecord.CurrentRow.Cells["Picture"].Value;
        }
        private void setRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.トヨタ:
                    rdTOYOTA.Checked = true;
                    break;
                case MakerGroup.スズキ:
                    rdSUZUKI.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rdSUBARU.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rdHONDA.Checked = true;
                    break;
                case MakerGroup.マツダ:
                    rdMAZDA.Checked = true;
                    break;
                case MakerGroup.日産:
                    rdNISSAN.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rdYUNYU.Checked = true;
                    break;
                case MakerGroup.その他:
                    rdOther.Checked = true;
                    break;
                case MakerGroup.なし:
                    break;
            }
        }




    }
}
