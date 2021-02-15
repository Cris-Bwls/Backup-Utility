using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Utility
{
	public partial class BackupUtilityForm : Form
	{
		Config backupConfigs;

		public BackupUtilityForm(string[] args)
		{
			if (args.Contains("noGraphics"))
			{
				// If config exists run backup without graphics
				if (IO.ReadConfig(out backupConfigs))
					Backup.Run(backupConfigs);
			}
			else
			{ 
				InitializeComponent();
				Init();
			}
		}

		private void Init()
		{
			if (IO.ReadConfig(out backupConfigs))
			{
				FilePathDialog.InitialDirectory = backupConfigs.filePath;
				FilePathLabel.Text = backupConfigs.filePath;

				BackupDirDialog.SelectedPath = backupConfigs.backupDir;
				BackupDirLabel.Text = backupConfigs.backupDir;

				DelayUpDown.Value = backupConfigs.delaySec;
			}
			else
			{
				FilePathDialog.InitialDirectory = Application.StartupPath;
				FilePathLabel.Text = "";

				BackupDirDialog.SelectedPath = Application.StartupPath;
				BackupDirLabel.Text = "";

				DelayUpDown.Value = 0;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void ChooseFile_Click(object sender, EventArgs e)
		{
			this.FilePathDialog.ShowDialog();
		}

		private void ChooseBackupDir_Click(object sender, EventArgs e)
		{
			this.BackupDirDialog.ShowDialog();
		}

		private void Start_Click(object sender, EventArgs e)
		{
			if (!backupConfigs.Valid())
			{
				this.BackupButton.BackColor = Color.Red;
				return;
			}

			this.BackupButton.BackColor = Color.Green;
			IO.CreateConfig(backupConfigs);
			Backup.Run(backupConfigs);
		}

		private void FilePathDialog_FileOk(object sender, CancelEventArgs e)
		{
			string name = FilePathDialog.FileName;
			name = name.Trim();
			this.FilePathLabel.Text = name;
			backupConfigs.filePath = name;
		}

		private void DirValidate_Click(object sender, EventArgs e)
		{
			string name = BackupDirDialog.SelectedPath;
			name = name.Trim();
			this.BackupDirLabel.Text = name;
			backupConfigs.backupDir = name;
		}

		private void DelayUpDown_ValueChanged(object sender, EventArgs e)
		{
			this.backupConfigs.delaySec = (int)DelayUpDown.Value;
		}
	}
}
