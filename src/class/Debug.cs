using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Backup_Utility
{
	static class Debug
	{
		public static void Log(string log, bool stop = false)
		{
			Console.WriteLine(log);

			if (stop)
				Console.ReadKey();
		}
	}
}
