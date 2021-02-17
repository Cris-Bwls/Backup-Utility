using System;
using System.IO;
using System.Threading.Tasks;

namespace Backup_Utility
{
	static class Backup
	{
		public static async Task<bool> Run(Config config)
		{
			DateTime lastTime = File.GetLastWriteTime(config.filePath);
			string fileName = config.filePath.Substring(config.filePath.LastIndexOf('\\') + 1);
			string ext = fileName.Substring(fileName.LastIndexOf('.'));

			fileName = fileName.Remove(fileName.LastIndexOf('.'));
			string outPath = config.backupDir + '\\' + fileName;

			int tryTime = 0;

			while(true)
			{
				try
				{
					tryTime = 0;

					DateTime currTime = File.GetLastWriteTime(config.filePath);
					if (currTime > lastTime)
					{
						lastTime = currTime;
						File.Copy(config.filePath, outPath + TimeStamp(currTime) + ext);
					}

					await Task.Delay(config.delaySec * 10000);

				}
				catch (Exception)
				{
					tryTime++;

					if (tryTime > 20)
						return false;

					await Task.Delay(tryTime * 10000);
				}
			}
		}

		static string TimeStamp(DateTime time)
		{
			string date = time.ToShortDateString();
			date = date.Replace('/', '-');

			string timeOfDay = time.TimeOfDay.ToString();
			timeOfDay = timeOfDay.Remove(timeOfDay.LastIndexOf('.'));
			timeOfDay = timeOfDay.Replace(':', '-');

			return date + '-' + timeOfDay;
		}
	}
}
