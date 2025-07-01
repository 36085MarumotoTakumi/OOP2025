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
                return CarReport.MakerGroup.�z���_;
            } else if (rdMAZDA.Checked) {
                return CarReport.MakerGroup.�}�c�_;
            } else if (rdNISSAN.Checked) {
                return CarReport.MakerGroup.���Y;
            } else if (rdOther.Checked) {
                return CarReport.MakerGroup.���̑�;
            } else if (rdSUBARU.Checked) {
                return CarReport.MakerGroup.�X�o��;
            } else if (rdSUZUKI.Checked) {
                return CarReport.MakerGroup.�X�Y�L;
            } else if (rdTOYOTA.Checked) {
                return CarReport.MakerGroup.�g���^;
            } else {
                return CarReport.MakerGroup.�Ȃ�;
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
                case MakerGroup.�g���^:
                    rdTOYOTA.Checked = true;
                    break;
                case MakerGroup.�X�Y�L:
                    rdSUZUKI.Checked = true;
                    break;
                case MakerGroup.�X�o��:
                    rdSUBARU.Checked = true;
                    break;
                case MakerGroup.�z���_:
                    rdHONDA.Checked = true;
                    break;
                case MakerGroup.�}�c�_:
                    rdMAZDA.Checked = true;
                    break;
                case MakerGroup.���Y:
                    rdNISSAN.Checked = true;
                    break;
                case MakerGroup.�A����:
                    rdYUNYU.Checked = true;
                    break;
                case MakerGroup.���̑�:
                    rdOther.Checked = true;
                    break;
                case MakerGroup.�Ȃ�:
                    break;
            }
        }




    }
}
