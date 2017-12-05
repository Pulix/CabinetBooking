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
		public bool ValidateCNP(string cnp)
		{
			string controlNumber = "279146358279";
			int sum = 0;

			char[] cnpNumbers = cnp.ToCharArray();
			char[] controlNumbers = controlNumber.ToCharArray();

			for (int i = 0; i< 12; i++)
			{
				sum += (Int32.Parse(cnpNumbers[i].ToString()) * Int32.Parse(controlNumbers[i].ToString()));
			}

			if ((sum % 11) == Int32.Parse(cnpNumbers[12].ToString()))
			{
				return true;
			}

			return false;
		}
	}
}