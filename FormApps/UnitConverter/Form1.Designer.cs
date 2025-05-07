namespace UnitConverter {
    partial class nud2 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.btChange = new System.Windows.Forms.Button();
            this.NudNum1 = new System.Windows.Forms.NumericUpDown();
            this.NudNum2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NudAnswer = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.NudAnswer2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnswer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "距離換算アプリ";
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNum1.Location = new System.Drawing.Point(119, 73);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(193, 34);
            this.tbNum1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "変換前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "変換後";
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNum2.Location = new System.Drawing.Point(119, 175);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(193, 34);
            this.tbNum2.TabIndex = 4;
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btChange.Location = new System.Drawing.Point(163, 113);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(99, 56);
            this.btChange.TabIndex = 5;
            this.btChange.Text = "変換";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // NudNum1
            // 
            this.NudNum1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudNum1.Location = new System.Drawing.Point(12, 304);
            this.NudNum1.Name = "NudNum1";
            this.NudNum1.Size = new System.Drawing.Size(120, 36);
            this.NudNum1.TabIndex = 6;
            // 
            // NudNum2
            // 
            this.NudNum2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudNum2.Location = new System.Drawing.Point(183, 304);
            this.NudNum2.Name = "NudNum2";
            this.NudNum2.Size = new System.Drawing.Size(120, 36);
            this.NudNum2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(138, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "÷";
            // 
            // NudAnswer
            // 
            this.NudAnswer.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudAnswer.Location = new System.Drawing.Point(52, 391);
            this.NudAnswer.Name = "NudAnswer";
            this.NudAnswer.Size = new System.Drawing.Size(120, 36);
            this.NudAnswer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(20, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // btCalc
            // 
            this.btCalc.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCalc.Location = new System.Drawing.Point(192, 378);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(99, 56);
            this.btCalc.TabIndex = 11;
            this.btCalc.Text = "計算";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // NudAnswer2
            // 
            this.NudAnswer2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudAnswer2.Location = new System.Drawing.Point(52, 485);
            this.NudAnswer2.Name = "NudAnswer2";
            this.NudAnswer2.Size = new System.Drawing.Size(120, 36);
            this.NudAnswer2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(63, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "あまり";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nud2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(336, 620);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NudAnswer2);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudNum2);
            this.Controls.Add(this.NudNum1);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label1);
            this.Name = "nud2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnswer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.NumericUpDown NudNum1;
        private System.Windows.Forms.NumericUpDown NudNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.NumericUpDown NudAnswer2;
        private System.Windows.Forms.Label label6;
    }
}

