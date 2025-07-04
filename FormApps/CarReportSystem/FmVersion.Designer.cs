namespace CarReportSystem {
    partial class FmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btOK = new Button();
            label1 = new Label();
            lbVersion = new Label();
            SuspendLayout();
            // 
            // btOK
            // 
            btOK.Location = new Point(276, 173);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 0;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "カーレポート管理システム";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbVersion.Location = new Point(12, 62);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(0, 25);
            lbVersion.TabIndex = 2;
            // 
            // FmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 219);
            Controls.Add(lbVersion);
            Controls.Add(label1);
            Controls.Add(btOK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FmVersion";
            Text = "FmVersion";
            Load += FmVersion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btOK;
        private Label label1;
        private Label lbVersion;
    }
}