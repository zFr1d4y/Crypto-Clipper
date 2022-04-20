using System;
using System.Text;
internal class FRIDAY
{
public static string qUSxo(string A_0)
{
	short num = 0;
	do
	{
		if (num == 0)
		{
			num = 1;
		}
	}
	while (num != 1);
	string result;
	try
	{
		result = Encoding.UTF8.GetString(Convert.FromBase64String(A_0));
	}
	catch (Exception)
	{
		result = null;
	}
	return result;
}
}
