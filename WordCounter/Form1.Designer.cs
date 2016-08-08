namespace WordCounter
{
    partial class WordCounter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtNoOfWords = new System.Windows.Forms.TextBox();
            this.lblNoOfWords = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblPreOutput = new System.Windows.Forms.Label();
            this.lblCleansed = new System.Windows.Forms.Label();
            this.txtCleansed = new System.Windows.Forms.TextBox();
            this.lblNoOfWordsAfter = new System.Windows.Forms.Label();
            this.txtNoOfWordsAfter = new System.Windows.Forms.TextBox();
            this.txtUnwanted = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.lblDuplicateFilter = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectFile.Location = new System.Drawing.Point(33, 58);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(128, 185);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "ファイルを選択";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtNoOfWords
            // 
            this.txtNoOfWords.Enabled = false;
            this.txtNoOfWords.Location = new System.Drawing.Point(431, 34);
            this.txtNoOfWords.Name = "txtNoOfWords";
            this.txtNoOfWords.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfWords.TabIndex = 1;
            // 
            // lblNoOfWords
            // 
            this.lblNoOfWords.AutoSize = true;
            this.lblNoOfWords.Location = new System.Drawing.Point(382, 35);
            this.lblNoOfWords.Name = "lblNoOfWords";
            this.lblNoOfWords.Size = new System.Drawing.Size(47, 13);
            this.lblNoOfWords.TabIndex = 2;
            this.lblNoOfWords.Text = "ワード数";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(190, 58);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(433, 187);
            this.txtResult.TabIndex = 3;
            // 
            // lblPreOutput
            // 
            this.lblPreOutput.AutoSize = true;
            this.lblPreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOutput.Location = new System.Drawing.Point(191, 27);
            this.lblPreOutput.Name = "lblPreOutput";
            this.lblPreOutput.Size = new System.Drawing.Size(168, 26);
            this.lblPreOutput.TabIndex = 4;
            this.lblPreOutput.Text = "出力 （オリジナル）";
            // 
            // lblCleansed
            // 
            this.lblCleansed.AutoSize = true;
            this.lblCleansed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleansed.Location = new System.Drawing.Point(645, 27);
            this.lblCleansed.Name = "lblCleansed";
            this.lblCleansed.Size = new System.Drawing.Size(157, 26);
            this.lblCleansed.TabIndex = 8;
            this.lblCleansed.Text = "出力（重複なし）";
            // 
            // txtCleansed
            // 
            this.txtCleansed.Location = new System.Drawing.Point(640, 58);
            this.txtCleansed.Multiline = true;
            this.txtCleansed.Name = "txtCleansed";
            this.txtCleansed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCleansed.Size = new System.Drawing.Size(433, 187);
            this.txtCleansed.TabIndex = 7;
            // 
            // lblNoOfWordsAfter
            // 
            this.lblNoOfWordsAfter.AutoSize = true;
            this.lblNoOfWordsAfter.Location = new System.Drawing.Point(833, 35);
            this.lblNoOfWordsAfter.Name = "lblNoOfWordsAfter";
            this.lblNoOfWordsAfter.Size = new System.Drawing.Size(47, 13);
            this.lblNoOfWordsAfter.TabIndex = 10;
            this.lblNoOfWordsAfter.Text = "ワード数";
            // 
            // txtNoOfWordsAfter
            // 
            this.txtNoOfWordsAfter.Enabled = false;
            this.txtNoOfWordsAfter.Location = new System.Drawing.Point(882, 33);
            this.txtNoOfWordsAfter.Name = "txtNoOfWordsAfter";
            this.txtNoOfWordsAfter.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfWordsAfter.TabIndex = 9;
            // 
            // txtUnwanted
            // 
            this.txtUnwanted.Enabled = false;
            this.txtUnwanted.Location = new System.Drawing.Point(272, 25);
            this.txtUnwanted.Multiline = true;
            this.txtUnwanted.Name = "txtUnwanted";
            this.txtUnwanted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUnwanted.Size = new System.Drawing.Size(355, 51);
            this.txtUnwanted.TabIndex = 13;
            this.txtUnwanted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnwanted.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(33, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 85);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "以下の重複は自動的に削除されました：";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnReset);
            this.grpSettings.Controls.Add(this.btnRemove);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.txtRemove);
            this.grpSettings.Controls.Add(this.txtUnwanted);
            this.grpSettings.Controls.Add(this.lblDuplicateFilter);
            this.grpSettings.Location = new System.Drawing.Point(275, 259);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(749, 94);
            this.grpSettings.TabIndex = 18;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "重複フィルター";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(659, 42);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 21);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(142, 42);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 21);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "削除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Enabled = false;
            this.txtRemove.Location = new System.Drawing.Point(11, 42);
            this.txtRemove.Multiline = true;
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(111, 23);
            this.txtRemove.TabIndex = 19;
            this.txtRemove.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDuplicateFilter
            // 
            this.lblDuplicateFilter.AutoSize = true;
            this.lblDuplicateFilter.Location = new System.Drawing.Point(12, 20);
            this.lblDuplicateFilter.Name = "lblDuplicateFilter";
            this.lblDuplicateFilter.Size = new System.Drawing.Size(250, 13);
            this.lblDuplicateFilter.TabIndex = 18;
            this.lblDuplicateFilter.Text = "この表現は二回目発生したら、自動的に削除します";
            // 
            // WordCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 376);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNoOfWordsAfter);
            this.Controls.Add(this.txtNoOfWordsAfter);
            this.Controls.Add(this.lblCleansed);
            this.Controls.Add(this.txtCleansed);
            this.Controls.Add(this.lblPreOutput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblNoOfWords);
            this.Controls.Add(this.txtNoOfWords);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "WordCounter";
            this.Text = "KeikoKounter";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtNoOfWords;
        private System.Windows.Forms.Label lblNoOfWords;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPreOutput;
        private System.Windows.Forms.Label lblCleansed;
        private System.Windows.Forms.TextBox txtCleansed;
        private System.Windows.Forms.Label lblNoOfWordsAfter;
        private System.Windows.Forms.TextBox txtNoOfWordsAfter;
        private System.Windows.Forms.TextBox txtUnwanted;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label lblDuplicateFilter;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
    }
}

