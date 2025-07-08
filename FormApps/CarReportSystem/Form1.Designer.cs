namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpDate = new DateTimePicker();
            cbAuthor = new ComboBox();
            groupBox1 = new GroupBox();
            rdOther = new RadioButton();
            rdYUNYU = new RadioButton();
            rdHONDA = new RadioButton();
            rdSUZUKI = new RadioButton();
            rdSUBARU = new RadioButton();
            rdNISSAN = new RadioButton();
            rdMAZDA = new RadioButton();
            rdTOYOTA = new RadioButton();
            cbCarName = new ComboBox();
            tbReport = new TextBox();
            dgvRecord = new DataGridView();
            pbPictures = new PictureBox();
            btOpen = new Button();
            btDelete = new Button();
            btRecordAdd = new Button();
            btRecordModifi = new Button();
            btRecordDelete = new Button();
            ofdPicFileOpen = new OpenFileDialog();
            btNewInput = new Button();
            ssMessage = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            OpenReportFile = new ToolStripMenuItem();
            SaveReportFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            CBColor = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            sfdReportSaveFile = new SaveFileDialog();
            ofdReportOpenFile = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPictures).BeginInit();
            ssMessage.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F);
            label1.Location = new Point(52, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F);
            label2.Location = new Point(31, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 1;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F);
            label3.Location = new Point(36, 176);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 2;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15.75F);
            label4.Location = new Point(52, 242);
            label4.Name = "label4";
            label4.Size = new Size(55, 30);
            label4.TabIndex = 3;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15.75F);
            label5.Location = new Point(33, 289);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 4;
            label5.Text = "レポート";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F);
            label6.Location = new Point(52, 367);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 5;
            label6.Text = "一覧";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F);
            label7.Location = new Point(448, 40);
            label7.Name = "label7";
            label7.Size = new Size(55, 30);
            label7.TabIndex = 6;
            label7.Text = "画像";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(132, 40);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 35);
            dtpDate.TabIndex = 7;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(132, 105);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(197, 33);
            cbAuthor.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdOther);
            groupBox1.Controls.Add(rdYUNYU);
            groupBox1.Controls.Add(rdHONDA);
            groupBox1.Controls.Add(rdSUZUKI);
            groupBox1.Controls.Add(rdSUBARU);
            groupBox1.Controls.Add(rdNISSAN);
            groupBox1.Controls.Add(rdMAZDA);
            groupBox1.Controls.Add(rdTOYOTA);
            groupBox1.Location = new Point(132, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 56);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rdOther
            // 
            rdOther.AutoSize = true;
            rdOther.Location = new Point(203, 31);
            rdOther.Name = "rdOther";
            rdOther.Size = new Size(56, 19);
            rdOther.TabIndex = 7;
            rdOther.TabStop = true;
            rdOther.Text = "その他";
            rdOther.UseVisualStyleBackColor = true;
            // 
            // rdYUNYU
            // 
            rdYUNYU.AutoSize = true;
            rdYUNYU.Location = new Point(203, 11);
            rdYUNYU.Name = "rdYUNYU";
            rdYUNYU.Size = new Size(61, 19);
            rdYUNYU.TabIndex = 6;
            rdYUNYU.TabStop = true;
            rdYUNYU.Text = "輸入車";
            rdYUNYU.UseVisualStyleBackColor = true;
            // 
            // rdHONDA
            // 
            rdHONDA.AutoSize = true;
            rdHONDA.Location = new Point(145, 31);
            rdHONDA.Name = "rdHONDA";
            rdHONDA.Size = new Size(53, 19);
            rdHONDA.TabIndex = 5;
            rdHONDA.TabStop = true;
            rdHONDA.Text = "ホンダ";
            rdHONDA.UseVisualStyleBackColor = true;
            // 
            // rdSUZUKI
            // 
            rdSUZUKI.AutoSize = true;
            rdSUZUKI.Location = new Point(145, 11);
            rdSUZUKI.Name = "rdSUZUKI";
            rdSUZUKI.Size = new Size(52, 19);
            rdSUZUKI.TabIndex = 4;
            rdSUZUKI.TabStop = true;
            rdSUZUKI.Text = "スズキ";
            rdSUZUKI.UseVisualStyleBackColor = true;
            // 
            // rdSUBARU
            // 
            rdSUBARU.AutoSize = true;
            rdSUBARU.Location = new Point(74, 31);
            rdSUBARU.Name = "rdSUBARU";
            rdSUBARU.Size = new Size(54, 19);
            rdSUBARU.TabIndex = 3;
            rdSUBARU.TabStop = true;
            rdSUBARU.Text = "スバル";
            rdSUBARU.UseVisualStyleBackColor = true;
            // 
            // rdNISSAN
            // 
            rdNISSAN.AutoSize = true;
            rdNISSAN.Location = new Point(74, 11);
            rdNISSAN.Name = "rdNISSAN";
            rdNISSAN.Size = new Size(49, 19);
            rdNISSAN.TabIndex = 2;
            rdNISSAN.TabStop = true;
            rdNISSAN.Text = "日産";
            rdNISSAN.UseVisualStyleBackColor = true;
            // 
            // rdMAZDA
            // 
            rdMAZDA.AutoSize = true;
            rdMAZDA.Location = new Point(5, 31);
            rdMAZDA.Name = "rdMAZDA";
            rdMAZDA.Size = new Size(52, 19);
            rdMAZDA.TabIndex = 1;
            rdMAZDA.TabStop = true;
            rdMAZDA.Text = "マツダ";
            rdMAZDA.UseVisualStyleBackColor = true;
            // 
            // rdTOYOTA
            // 
            rdTOYOTA.AutoSize = true;
            rdTOYOTA.Location = new Point(5, 11);
            rdTOYOTA.Name = "rdTOYOTA";
            rdTOYOTA.Size = new Size(50, 19);
            rdTOYOTA.TabIndex = 0;
            rdTOYOTA.TabStop = true;
            rdTOYOTA.Text = "トヨタ";
            rdTOYOTA.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(132, 242);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(197, 33);
            cbCarName.TabIndex = 10;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(132, 291);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(359, 73);
            tbReport.TabIndex = 11;
            // 
            // dgvRecord
            // 
            dgvRecord.AllowUserToAddRows = false;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecord.Location = new Point(132, 368);
            dgvRecord.Name = "dgvRecord";
            dgvRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecord.Size = new Size(568, 150);
            dgvRecord.TabIndex = 12;
            dgvRecord.CellContentClick += dgvRecord_CellContentClick;
            dgvRecord.Click += dgvRecord_Click;
            // 
            // pbPictures
            // 
            pbPictures.BackColor = SystemColors.ActiveBorder;
            pbPictures.Location = new Point(455, 73);
            pbPictures.Name = "pbPictures";
            pbPictures.Size = new Size(324, 169);
            pbPictures.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictures.TabIndex = 13;
            pbPictures.TabStop = false;
            // 
            // btOpen
            // 
            btOpen.Location = new Point(623, 48);
            btOpen.Name = "btOpen";
            btOpen.Size = new Size(75, 23);
            btOpen.TabIndex = 14;
            btOpen.Text = "開く...";
            btOpen.UseVisualStyleBackColor = true;
            btOpen.Click += btOpen_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(704, 47);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 15;
            btDelete.Text = "削除";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btRecordAdd
            // 
            btRecordAdd.Location = new Point(510, 291);
            btRecordAdd.Name = "btRecordAdd";
            btRecordAdd.Size = new Size(75, 72);
            btRecordAdd.TabIndex = 16;
            btRecordAdd.Text = "追加";
            btRecordAdd.UseVisualStyleBackColor = true;
            btRecordAdd.Click += btRecordAdd_Click;
            // 
            // btRecordModifi
            // 
            btRecordModifi.Location = new Point(591, 291);
            btRecordModifi.Name = "btRecordModifi";
            btRecordModifi.Size = new Size(75, 72);
            btRecordModifi.TabIndex = 17;
            btRecordModifi.Text = "修正";
            btRecordModifi.UseVisualStyleBackColor = true;
            btRecordModifi.Click += btRecordModifi_Click;
            // 
            // btRecordDelete
            // 
            btRecordDelete.Location = new Point(672, 290);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(75, 72);
            btRecordDelete.TabIndex = 18;
            btRecordDelete.Text = "削除";
            btRecordDelete.UseVisualStyleBackColor = true;
            btRecordDelete.Click += btRecordDelete_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // btNewInput
            // 
            btNewInput.Location = new Point(338, 126);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(111, 35);
            btNewInput.TabIndex = 19;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = true;
            // 
            // ssMessage
            // 
            ssMessage.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            ssMessage.Location = new Point(0, 527);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(791, 22);
            ssMessage.TabIndex = 20;
            ssMessage.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(791, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenReportFile, SaveReportFile, toolStripSeparator1, CBColor, tsmiExit });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(67, 20);
            ファイルToolStripMenuItem.Text = "ファイル(&F)";
            ファイルToolStripMenuItem.Click += ファイルToolStripMenuItem_Click;
            // 
            // OpenReportFile
            // 
            OpenReportFile.Name = "OpenReportFile";
            OpenReportFile.Size = new Size(180, 22);
            OpenReportFile.Text = "開く";
            OpenReportFile.Click += OpenReportFile_Click;
            // 
            // SaveReportFile
            // 
            SaveReportFile.Name = "SaveReportFile";
            SaveReportFile.Size = new Size(180, 22);
            SaveReportFile.Text = "保存...";
            SaveReportFile.Click += SaveReportFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // CBColor
            // 
            CBColor.Name = "CBColor";
            CBColor.Size = new Size(180, 22);
            CBColor.Text = "色設定...";
            CBColor.Click += CBColor_Click;
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmiExit.Size = new Size(180, 22);
            tsmiExit.Text = "終了";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(155, 22);
            tsmiAbout.Text = "このアプリについて";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // ofdReportOpenFile
            // 
            ofdReportOpenFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(791, 549);
            Controls.Add(ssMessage);
            Controls.Add(menuStrip1);
            Controls.Add(btNewInput);
            Controls.Add(btRecordDelete);
            Controls.Add(btRecordModifi);
            Controls.Add(btRecordAdd);
            Controls.Add(btDelete);
            Controls.Add(btOpen);
            Controls.Add(pbPictures);
            Controls.Add(dgvRecord);
            Controls.Add(tbReport);
            Controls.Add(cbCarName);
            Controls.Add(groupBox1);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート";
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPictures).EndInit();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpDate;
        private ComboBox cbAuthor;
        private GroupBox groupBox1;
        private RadioButton rdNISSAN;
        private RadioButton rdMAZDA;
        private RadioButton rdTOYOTA;
        private RadioButton rdHONDA;
        private RadioButton rdSUZUKI;
        private RadioButton rdSUBARU;
        private ComboBox cbCarName;
        private TextBox tbReport;
        private DataGridView dgvRecord;
        private PictureBox pbPictures;
        private Button btOpen;
        private Button btDelete;
        private Button btRecordAdd;
        private Button btRecordModifi;
        private Button btRecordDelete;
        private RadioButton rdYUNYU;
        private RadioButton rdOther;
        private OpenFileDialog ofdPicFileOpen;
        private Button btNewInput;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel tsslbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripMenuItem OpenReportFile;
        private ToolStripMenuItem SaveReportFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem CBColor;
        private ToolStripMenuItem tsmiExit;
        private ColorDialog colorDialog1;
        private SaveFileDialog sfdReportSaveFile;
        private OpenFileDialog ofdReportOpenFile;
    }
}
