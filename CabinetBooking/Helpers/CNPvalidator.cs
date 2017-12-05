using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CabinetBooking.Helpers
{
	public class Validators
	{

		/// <summary>
		/// Validate the CNP
		/// </summary>
		/// <param name="cnp"></param>
		/// <returns></returns>
		public static bool ValidateCNP(string cnp)
		{
			string controlNumber = "279146358279";
			int sum = 0;
			

			char[] cnpNumbers = cnp.ToCharArray();
			char[] controlNumbers = controlNumber.ToCharArray();

			for (int i = 0; i< 12; i++)
			{
				sum += (Int32.Parse(cnpNumbers[i].ToString()) * Int32.Parse(controlNumbers[i].ToString()));
			}

			//If sum % 11 is 10, then the validation number should be 1
			int validControlNumber = (sum % 11 == 10) ? 1 : sum % 11;
		

			if (cnp[12] ==  validControlNumber)
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Get the User's gender from CNP
		/// </summary>
		/// <param name="cnp"></param>
		/// <returns></returns>
		public static string getUserGender(string cnp)
		{
			if (cnp[0].ToString() == "1" || cnp[0].ToString() == "5")
			{
				return "Male";
			}
			else
			{
				if (cnp[0].ToString() == "2" || cnp[0].ToString() == "6")
				{
					return "Female";
				}
				return "Alien?";
			}
		}

		/// <summary>
		/// Get User's date of birth form CNP
		/// </summary>
		/// <param name="cnp"></param>
		/// <returns></returns>
		public static DateTime getDateOfBirth(string cnp)
		{
			string dateString = cnp[5].ToString() + cnp[6].ToString() + "/" + cnp[3].ToString() + cnp[4].ToString() + "/" + cnp[1].ToString() + cnp[2].ToString();
			return DateTime.Parse(dateString);
		}
	}
}