using System.IO;
using System.Windows.Forms;

namespace Backup_Utility
{
	struct Config
	{
		public string filePath;
		public string backupDir;
		public int delaySec;

		public bool Valid()
		{
			return (filePath != "" && filePath != null) && (backupDir != "" && backupDir != null) && delaySec > 0;
		}
	}

	static class IO
	{
		public static void CreateConfig(Config config)
		{
			if (ConfigExists())
				File.Delete(ConfigPath());

			string[] lines =
			{
				$"filePath = {config.filePath}",
				$"backupDir = {config.backupDir}",
				$"delaySec = {config.delaySec}",
			};

			File.WriteAllLines(ConfigPath(), lines);
		}

		public static bool ConfigExists()
		{
			return File.Exists(ConfigPath());
		}

		public static bool ReadConfig(out Config config)
		{
			bool exists = ConfigExists();
			config = new Config();

			if (exists)
			{
				string delayText = "";
				bool[] done = { false, false, false };

				string[] lines = File.ReadAllLines(ConfigPath());
				foreach (string line in lines)
				{

					if (!done[0])
						done[0] = LineContains(line, "filePath", out config.filePath);
					if (!done[1])
						done[1] = LineContains(line, "backupDir", out config.backupDir);
					if (!done[2])
						done[2] = LineContains(line, "delaySec", out delayText);

					if (done[0] && done[1] && done[2])
						break;
				}

				config.delaySec = int.Parse(delayText);
			}

			return exists;
		}		

		static string ConfigPath()
		{
			string path = Application.ExecutablePath;
			path = path.Remove(path.LastIndexOf('.') + 1);
			path += "cfg";

			return path;
		}

		static bool LineContains(string line, string contains, out string value)
		{
			value = "";

			if (line.Contains(contains))
			{
				value = line.Substring(line.LastIndexOf('=') + 1).Trim();
				return true;
			}
			else
				return false;
		}
	}
}
