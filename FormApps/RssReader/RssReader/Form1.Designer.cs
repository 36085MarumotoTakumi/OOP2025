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
            btRssGet = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Back = new Button();
            Move = new Button();
            Reload = new Button();
            cbUrl = new ComboBox();
            Favorite = new Button();
            lbTitles = new ListBox();
            tbFavorite = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Location = new Point(696, 12);
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
            webView21.Location = new Point(12, 81);
            webView21.Name = "webView21";
            webView21.Size = new Size(759, 452);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // Back
            // 
            Back.Location = new Point(12, 12);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Move
            // 
            Move.Location = new Point(174, 12);
            Move.Name = "Move";
            Move.Size = new Size(75, 23);
            Move.TabIndex = 5;
            Move.Text = "Forward";
            Move.UseVisualStyleBackColor = true;
            Move.Click += Move_Click;
            // 
            // Reload
            // 
            Reload.Location = new Point(93, 12);
            Reload.Name = "Reload";
            Reload.Size = new Size(75, 23);
            Reload.TabIndex = 7;
            Reload.Text = "Reload";
            Reload.UseVisualStyleBackColor = true;
            Reload.Click += Reload_Click;
            // 
            // cbUrl
            // 
            cbUrl.FormattingEnabled = true;
            cbUrl.Location = new Point(255, 12);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(435, 23);
            cbUrl.TabIndex = 8;
            // 
            // Favorite
            // 
            Favorite.Location = new Point(12, 41);
            Favorite.Name = "Favorite";
            Favorite.Size = new Size(75, 23);
            Favorite.TabIndex = 9;
            Favorite.Text = "Favorite";
            Favorite.UseVisualStyleBackColor = true;
            Favorite.Click += Favorite_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 15;
            lbTitles.Location = new Point(255, 41);
            lbTitles.Name = "lbTitles";
            lbTitles.RightToLeft = RightToLeft.No;
            lbTitles.Size = new Size(435, 34);
            lbTitles.TabIndex = 10;
            lbTitles.SelectedIndexChanged += lbTitles_SelectedIndexChanged;
            // 
            // tbFavorite
            // 
            tbFavorite.Location = new Point(93, 41);
            tbFavorite.Name = "tbFavorite";
            tbFavorite.Size = new Size(156, 23);
            tbFavorite.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 545);
            Controls.Add(tbFavorite);
            Controls.Add(lbTitles);
            Controls.Add(Favorite);
            Controls.Add(cbUrl);
            Controls.Add(Reload);
            Controls.Add(Move);
            Controls.Add(Back);
            Controls.Add(webView21);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btRssGet;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button Back;
        private Button Move;
        private Button Reload;
        private ComboBox cbUrl;
        private Button Favorite;
        private ListBox lbTitles;
        private TextBox tbFavorite;
    }
}
