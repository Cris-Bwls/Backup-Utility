using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Backup_Utility
{
	static class Backup
	{
		public static async void Run(Config config)
		{
			DateTime lastTime = File.GetLastWriteTime(config.filePath);
			string fileName = config.filePath.Substring(config.filePath.LastIndexOf('\\') + 1);
			string ext = fileName.Substring(fileName.LastIndexOf('.'));

			fileName = fileName.Remove(fileName.LastIndexOf('.'));
			string outPath = config.backupDir + '\\' + fileName;

			while(true)
			{
				DateTime currTime = File.GetLastWriteTime(config.filePath);
				if (currTime > lastTime)
				{
					lastTime = currTime;
					File.Copy(config.filePath, outPath + TimeStamp(currTime) + ext);
				}
				await Task.Delay(config.delaySec * 10000);
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
