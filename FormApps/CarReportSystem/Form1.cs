using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using static CarReportSystem.CarReport;
using System.Xml;


namespace CarReportSystem {
    [Serializable]
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        Settings settings = new Settings();

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
            if (cbCarName.Text == String.Empty || cbAuthor.Text == String.Empty) {
                tsslbMessage.Text = ("記録者、または車名が未入力です");

            } else {
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
        }

        private void setCbCarName() {
            if (!cbCarName.Items.Contains(cbCarName.Text)) {
                cbCarName.Items.Add(cbCarName.Text);
            }
        }

        private void setCbAuthor() {
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
        }



        private void btRecordModifi_Click(object sender, EventArgs e) {
            if (dgvRecord.Rows.Count == 0) return;
            listCarReports[dgvRecord.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvRecord.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvRecord.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvRecord.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvRecord.CurrentRow.Index].Picture = pbPictures.Image;
            listCarReports[dgvRecord.CurrentRow.Index].Report = tbReport.Text;

            dgvRecord.Refresh();
        }

        private void btRecordDelete_Click(object sender, EventArgs e) {
            if ((dgvRecord.CurrentRow == null)
                || (!dgvRecord.CurrentRow.Selected)) return;
            int index = dgvRecord.CurrentRow.Index;
            listCarReports.RemoveAt(index);
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

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e) {


        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmiAbout_Click(object sender, EventArgs e) {
            FmVersion FmVersion = new FmVersion();
            FmVersion.Show();
        }

        private void CBColor_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                this.BackColor = cd.Color;

                settings.MainFormColor = cd.Color.ToArgb();

            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            InputItemsAllClear();
            dgvRecord.RowsDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;

        }


        private void reportOpenFile() {
            if (ofdReportOpenFile.ShowDialog() == DialogResult.OK) {
                try {
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011

                    using (FileStream fs = File.Open(
                        ofdReportOpenFile.FileName, FileMode.Open, FileAccess.Read)) {

                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecord.DataSource = listCarReports;
                        foreach (var report in listCarReports) {
                           // setCbAuthor(report.Author);
                           // setCbCarName(report.CarName);
                        }
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル読み込みエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reportSaveFile() {

            if (sfdReportSaveFile.ShowDialog() == DialogResult.OK) {
                try {
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011

                    using (FileStream fs = File.Open(
                        sfdReportSaveFile.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveReportFile_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        private void OpenReportFile_Click(object sender, EventArgs e) {
            reportOpenFile();
        }
        private void Form1_FormClosed(object sender, EventArgs e) {

            XmlWriter.Create("settings.xml");
        }
    }
}