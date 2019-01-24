using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MuseumLog
{
	public class Validate
	{
		public static bool ValidateEmpty(string value)
		{
			if (value != string.Empty)
			{
				return true;

			}
			return false;

		}

		public static bool ValidateNumber(string value)
		{
			if (Regex.IsMatch(value, "^[0-9]+$"))
			{
				return true;
			}
			return false;
		}

		public static bool ValidateEmailFormat(string value)
		{
			string MatchEmailPattern =
			  @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
	   + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
	   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
	   + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";


			if (value != null)
			{
				return Regex.IsMatch(value, MatchEmailPattern);
			}
			else
			{
				return false;
			}

		}

	}
}
