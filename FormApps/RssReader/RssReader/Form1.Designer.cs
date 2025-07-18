namespace RssReader {
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
            tbUrl = new TextBox();
            btRssGet = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Back = new Button();
            Move = new Button();
            cbTitles = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(12, 12);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(435, 23);
            tbUrl.TabIndex = 0;
            // 
            // btRssGet
            // 
            btRssGet.Location = new Point(453, 12);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(75, 23);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 99);
            webView21.Name = "webView21";
            webView21.Size = new Size(516, 387);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // Back
            // 
            Back.Location = new Point(12, 70);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Move
            // 
            Move.Location = new Point(93, 70);
            Move.Name = "Move";
            Move.Size = new Size(75, 23);
            Move.TabIndex = 5;
            Move.Text = "Forward";
            Move.UseVisualStyleBackColor = true;
            Move.Click += Move_Click;
            // 
            // cbTitles
            // 
            cbTitles.FormattingEnabled = true;
            cbTitles.Location = new Point(12, 41);
            cbTitles.Name = "cbTitles";
            cbTitles.Size = new Size(435, 23);
            cbTitles.TabIndex = 6;
            cbTitles.SelectedIndexChanged += cbTitles_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 498);
            Controls.Add(cbTitles);
            Controls.Add(Move);
            Controls.Add(Back);
            Controls.Add(webView21);
            Controls.Add(btRssGet);
            Controls.Add(tbUrl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUrl;
        private Button btRssGet;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button Back;
        private Button Move;
        private ComboBox cbTitles;
    }
}
