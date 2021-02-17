using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Backup_Utility
{
	public partial class BackupUtilityForm : Form
	{
		bool running = false;
		Config backupConfigs;

		public BackupUtilityForm(string[] args)
		{
			if (args.Contains("noGraphics"))
			{
				// If config exists run backup without graphics
				if (IO.ReadConfig(out backupConfigs))
				{
					running = true;
					Run(true);
				}
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
			this.DIrValidate.BackColor = Color.Yellow;
		}

		private void Start_Click(object sender, EventArgs e)
		{
			if (!backupConfigs.Valid())
			{
				this.BackupButton.BackColor = Color.Red;
				return;
			}

			if (running == false)
			{
				running = true;
				this.BackupButton.BackColor = Color.Green;

				IO.CreateConfig(backupConfigs);
				Run(false);
			}
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
			this.DIrValidate.BackColor = Color.Green;

			string name = BackupDirDialog.SelectedPath;
			name = name.Trim();
			this.BackupDirLabel.Text = name;
			backupConfigs.backupDir = name;
		}

		private void DelayUpDown_ValueChanged(object sender, EventArgs e)
		{
			this.backupConfigs.delaySec = (int)DelayUpDown.Value;
		}

		private async void Run(bool noGraphics)
		{
			running = await Backup.Run(backupConfigs);

			if (!running)
			{
				if (noGraphics)
					Application.Exit();
				else
					this.BackupButton.BackColor = Color.Red;
			}				
		}
	}
}
