namespace Zdjeciosorter
{
    partial class Form
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
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceFolderBtn = new System.Windows.Forms.Button();
            this.destinyFolderBtn = new System.Windows.Forms.Button();
            this.selectedSourceFolderLabel = new System.Windows.Forms.Label();
            this.selectedDestinationFolderLabel = new System.Windows.Forms.Label();
            this.takeSubFoldersChkbx = new System.Windows.Forms.CheckBox();
            this.disclaimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(47, 206);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Rozpocznij";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(44, 268);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(423, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(176, 206);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Przerwij";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(44, 249);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(40, 13);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "Postęp";
            this.progressLabel.Visible = false;
            // 
            // sourceFolderBtn
            // 
            this.sourceFolderBtn.Location = new System.Drawing.Point(44, 75);
            this.sourceFolderBtn.Name = "sourceFolderBtn";
            this.sourceFolderBtn.Size = new System.Drawing.Size(102, 23);
            this.sourceFolderBtn.TabIndex = 7;
            this.sourceFolderBtn.Text = "Folder źródłowy";
            this.sourceFolderBtn.UseVisualStyleBackColor = true;
            this.sourceFolderBtn.Click += new System.EventHandler(this.sourceFolderBtn_Click);
            // 
            // destinyFolderBtn
            // 
            this.destinyFolderBtn.Location = new System.Drawing.Point(44, 114);
            this.destinyFolderBtn.Name = "destinyFolderBtn";
            this.destinyFolderBtn.Size = new System.Drawing.Size(102, 23);
            this.destinyFolderBtn.TabIndex = 8;
            this.destinyFolderBtn.Text = "Folder docelowy";
            this.destinyFolderBtn.UseVisualStyleBackColor = true;
            this.destinyFolderBtn.Click += new System.EventHandler(this.destinyFolderBtn_Click);
            // 
            // selectedSourceFolderLabel
            // 
            this.selectedSourceFolderLabel.AutoSize = true;
            this.selectedSourceFolderLabel.Location = new System.Drawing.Point(153, 84);
            this.selectedSourceFolderLabel.Name = "selectedSourceFolderLabel";
            this.selectedSourceFolderLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedSourceFolderLabel.TabIndex = 9;
            // 
            // selectedDestinationFolderLabel
            // 
            this.selectedDestinationFolderLabel.AutoSize = true;
            this.selectedDestinationFolderLabel.Location = new System.Drawing.Point(153, 123);
            this.selectedDestinationFolderLabel.Name = "selectedDestinationFolderLabel";
            this.selectedDestinationFolderLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedDestinationFolderLabel.TabIndex = 10;
            // 
            // takeSubFoldersChkbx
            // 
            this.takeSubFoldersChkbx.AutoSize = true;
            this.takeSubFoldersChkbx.Location = new System.Drawing.Point(44, 160);
            this.takeSubFoldersChkbx.Name = "takeSubFoldersChkbx";
            this.takeSubFoldersChkbx.Size = new System.Drawing.Size(129, 17);
            this.takeSubFoldersChkbx.TabIndex = 11;
            this.takeSubFoldersChkbx.Text = "Uwzględnij podfoldery";
            this.takeSubFoldersChkbx.UseVisualStyleBackColor = true;
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Location = new System.Drawing.Point(41, 30);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(426, 13);
            this.disclaimer.TabIndex = 13;
            this.disclaimer.Text = "Program kopiuje zdjęcia i wideo do katalogu docelowego grupując je po roku utworz" +
    "enia.";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 331);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.takeSubFoldersChkbx);
            this.Controls.Add(this.selectedDestinationFolderLabel);
            this.Controls.Add(this.selectedSourceFolderLabel);
            this.Controls.Add(this.destinyFolderBtn);
            this.Controls.Add(this.sourceFolderBtn);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Name = "Form";
            this.Text = "Zdjęciosorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderBrowserDialog;
        private System.Windows.Forms.Button sourceFolderBtn;
        private System.Windows.Forms.Button destinyFolderBtn;
        private System.Windows.Forms.Label selectedSourceFolderLabel;
        private System.Windows.Forms.Label selectedDestinationFolderLabel;
        private System.Windows.Forms.CheckBox takeSubFoldersChkbx;
        private System.Windows.Forms.Label disclaimer;
    }
}

