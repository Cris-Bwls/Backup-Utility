namespace Backup_Utility
{
	partial class BackupUtilityForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BackupButton = new System.Windows.Forms.Button();
			this.FilePath = new System.Windows.Forms.GroupBox();
			this.FilePathLabel = new System.Windows.Forms.Label();
			this.FilePathButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.BackupDir = new System.Windows.Forms.GroupBox();
			this.DIrValidate = new System.Windows.Forms.Button();
			this.BackupDirLabel = new System.Windows.Forms.Label();
			this.BackupDirTitle = new System.Windows.Forms.Label();
			this.BackupDirButton = new System.Windows.Forms.Button();
			this.Delay = new System.Windows.Forms.GroupBox();
			this.DelayUpDown = new System.Windows.Forms.NumericUpDown();
			this.FilePathDialog = new System.Windows.Forms.OpenFileDialog();
			this.BackupDirDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.FilePath.SuspendLayout();
			this.BackupDir.SuspendLayout();
			this.Delay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// BackupButton
			// 
			this.BackupButton.Location = new System.Drawing.Point(12, 287);
			this.BackupButton.Name = "BackupButton";
			this.BackupButton.Size = new System.Drawing.Size(243, 54);
			this.BackupButton.TabIndex = 0;
			this.BackupButton.Text = "Start";
			this.BackupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.BackupButton.UseVisualStyleBackColor = true;
			this.BackupButton.Click += new System.EventHandler(this.Start_Click);
			// 
			// FilePath
			// 
			this.FilePath.Controls.Add(this.FilePathLabel);
			this.FilePath.Controls.Add(this.FilePathButton);
			this.FilePath.Controls.Add(this.label2);
			this.FilePath.Location = new System.Drawing.Point(12, 12);
			this.FilePath.Name = "FilePath";
			this.FilePath.Size = new System.Drawing.Size(243, 100);
			this.FilePath.TabIndex = 2;
			this.FilePath.TabStop = false;
			this.FilePath.Text = "File Path";
			// 
			// FilePathLabel
			// 
			this.FilePathLabel.AutoSize = true;
			this.FilePathLabel.Location = new System.Drawing.Point(8, 78);
			this.FilePathLabel.Name = "FilePathLabel";
			this.FilePathLabel.Size = new System.Drawing.Size(38, 15);
			this.FilePathLabel.TabIndex = 5;
			this.FilePathLabel.Text = "label2";
			// 
			// FilePathButton
			// 
			this.FilePathButton.Location = new System.Drawing.Point(6, 22);
			this.FilePathButton.Name = "FilePathButton";
			this.FilePathButton.Size = new System.Drawing.Size(230, 23);
			this.FilePathButton.TabIndex = 0;
			this.FilePathButton.Text = "Choose File";
			this.FilePathButton.UseVisualStyleBackColor = true;
			this.FilePathButton.Click += new System.EventHandler(this.ChooseFile_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Current File Path";
			// 
			// BackupDir
			// 
			this.BackupDir.Controls.Add(this.DIrValidate);
			this.BackupDir.Controls.Add(this.BackupDirLabel);
			this.BackupDir.Controls.Add(this.BackupDirTitle);
			this.BackupDir.Controls.Add(this.BackupDirButton);
			this.BackupDir.Location = new System.Drawing.Point(12, 118);
			this.BackupDir.Name = "BackupDir";
			this.BackupDir.Size = new System.Drawing.Size(243, 100);
			this.BackupDir.TabIndex = 3;
			this.BackupDir.TabStop = false;
			this.BackupDir.Text = "Backup Directory";
			// 
			// DIrValidate
			// 
			this.DIrValidate.Location = new System.Drawing.Point(200, 22);
			this.DIrValidate.Name = "DIrValidate";
			this.DIrValidate.Size = new System.Drawing.Size(36, 23);
			this.DIrValidate.TabIndex = 4;
			this.DIrValidate.Text = "✔";
			this.DIrValidate.UseVisualStyleBackColor = true;
			this.DIrValidate.Click += new System.EventHandler(this.DirValidate_Click);
			// 
			// BackupDirLabel
			// 
			this.BackupDirLabel.AutoSize = true;
			this.BackupDirLabel.Location = new System.Drawing.Point(7, 77);
			this.BackupDirLabel.Name = "BackupDirLabel";
			this.BackupDirLabel.Size = new System.Drawing.Size(38, 15);
			this.BackupDirLabel.TabIndex = 3;
			this.BackupDirLabel.Text = "label2";
			// 
			// BackupDirTitle
			// 
			this.BackupDirTitle.AutoSize = true;
			this.BackupDirTitle.Location = new System.Drawing.Point(6, 58);
			this.BackupDirTitle.Name = "BackupDirTitle";
			this.BackupDirTitle.Size = new System.Drawing.Size(140, 15);
			this.BackupDirTitle.TabIndex = 2;
			this.BackupDirTitle.Text = "Current Backup Directory";
			// 
			// BackupDirButton
			// 
			this.BackupDirButton.Location = new System.Drawing.Point(6, 22);
			this.BackupDirButton.Name = "BackupDirButton";
			this.BackupDirButton.Size = new System.Drawing.Size(188, 23);
			this.BackupDirButton.TabIndex = 1;
			this.BackupDirButton.Text = "Choose Backup Directory";
			this.BackupDirButton.UseVisualStyleBackColor = true;
			this.BackupDirButton.Click += new System.EventHandler(this.ChooseBackupDir_Click);
			// 
			// Delay
			// 
			this.Delay.Controls.Add(this.DelayUpDown);
			this.Delay.Location = new System.Drawing.Point(12, 224);
			this.Delay.Name = "Delay";
			this.Delay.Size = new System.Drawing.Size(243, 57);
			this.Delay.TabIndex = 4;
			this.Delay.TabStop = false;
			this.Delay.Text = "Delay In Seconds";
			// 
			// DelayUpDown
			// 
			this.DelayUpDown.Location = new System.Drawing.Point(37, 22);
			this.DelayUpDown.Name = "DelayUpDown";
			this.DelayUpDown.Size = new System.Drawing.Size(120, 23);
			this.DelayUpDown.TabIndex = 0;
			this.DelayUpDown.ThousandsSeparator = true;
			this.DelayUpDown.ValueChanged += new System.EventHandler(this.DelayUpDown_ValueChanged);
			// 
			// FilePathDialog
			// 
			this.FilePathDialog.Title = "Choose File";
			this.FilePathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FilePathDialog_FileOk);
			// 
			// BackupDirDialog
			// 
			this.BackupDirDialog.Description = "Choose Backup Directory";
			// 
			// BackupUtilityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 348);
			this.Controls.Add(this.Delay);
			this.Controls.Add(this.BackupDir);
			this.Controls.Add(this.FilePath);
			this.Controls.Add(this.BackupButton);
			this.Name = "BackupUtilityForm";
			this.Text = "Backup Utility";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.FilePath.ResumeLayout(false);
			this.FilePath.PerformLayout();
			this.BackupDir.ResumeLayout(false);
			this.BackupDir.PerformLayout();
			this.Delay.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DelayUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BackupButton;
		private System.Windows.Forms.GroupBox FilePath;
		private System.Windows.Forms.GroupBox BackupDir;
		private System.Windows.Forms.GroupBox Delay;
		private System.Windows.Forms.Button FilePathButton;
		private System.Windows.Forms.Button BackupDirButton;
		private System.Windows.Forms.Label BackupDirTitle;
		private System.Windows.Forms.Label BackupDirLabel;
		private System.Windows.Forms.Label FilePathLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog FilePathDialog;
		private System.Windows.Forms.FolderBrowserDialog BackupDirDialog;
		private System.Windows.Forms.Button DIrValidate;
		private System.Windows.Forms.NumericUpDown DelayUpDown;
	}
}

