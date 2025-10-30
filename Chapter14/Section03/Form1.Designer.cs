namespace Section03 {
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
            button1 = new Button();
            toolStripStatusLabel1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2 });
            toolStripStatusLabel1.Location = new Point(0, 428);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(800, 22);
            toolStripStatusLabel1.TabIndex = 1;
            toolStripStatusLabel1.Text = "statusStrip1";
            toolStripStatusLabel1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripStatusLabel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            toolStripStatusLabel1.ResumeLayout(false);
            toolStripStatusLabel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private StatusStrip toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
