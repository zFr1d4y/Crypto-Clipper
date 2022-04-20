using System;
using System.Threading;

namespace Google.TOKENSs
{
	internal sealed class INTELVSAMD
	{
		public static string GetText()
		{
			string ReturnValue = string.Empty;
			try
			{
				Thread thread = new Thread(delegate ()
				{
					ReturnValue = INTELVSAMD.GetText();
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}
			catch
			{
			}
			return ReturnValue;
		}
		public static void SetText(string text)
		{
			Thread thread = new Thread(delegate ()
			{
				try
				{
					INTELVSAMD.SetText(text);
				}
				catch
				{
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
	}
}
