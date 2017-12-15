using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CabinetBooking.Helpers;

namespace CabinetBooking
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["Error"] != null)
			{
				lblMessage.Text = Session["Error"].ToString();
				Session["Error"] = null;
			}
		}

		protected void btnRegister_Click(object sender, EventArgs e)
		{
			string firstName = txtFirstName.Value.ToString();
			string lastName = txtLastName.Value.ToString();
			string username = validateUsername(txtUsername.Value.ToString());
			string password = validatePassword(txtPassword.Value.ToString(), txtRepeatPassword.Value.ToString());


			if (firstName.Length < 1 || lastName.Length < 1)
			{
				Session["Error"] = "Please provide Username or Password";
				Response.Redirect("Register.aspx");
			}

			if (password == "")
			{
				Session["Error"] = "Password does not match";
				Response.Redirect("Register.aspx"); 
			}

			User newUser = new User();
			newUser.FirstName = firstName;
			newUser.LastName = lastName;
			newUser.Username = username;
			newUser.Password = password;
			newUser.Type = 3;
			_dc.Users.InsertOnSubmit(newUser);
			_dc.SubmitChanges();
			lblMessage.Text = "Registration succesful!";
		}

		private string validateUsername(string userName)
		{
			if (userName.Length < 13 || userName.Length > 13)
			{
				Session["Error"] = "Invalid CNP Format";
				Response.Redirect("Register.aspx");
				return "";
			}
			else
			{
				if (ValidateCNP(userName))
				{
					return userName;
				}
				else
				{
					Session["Error"] = "Invalid CNP";
					Response.Redirect("Register.aspx");
					return "";
				}
			}
		}

		private string validatePassword(string password1, string password2)
		{
			if (password1 == password2)
			{
				string hash = "";

				using (MD5 md5Hash = MD5.Create())
				{
					hash = GetMd5Hash(md5Hash, password1);
				}
					return hash;
			}

			return "";

		}

		static string GetMd5Hash(MD5 md5Hash, string input)
		{

			// Convert the input string to a byte array and compute the hash.
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

			// Create a new Stringbuilder to collect the bytes
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data 
			// and format each one as a hexadecimal string.
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			// Return the hexadecimal string.
			return sBuilder.ToString();
		}


		private bool ValidateCNP(string cnp)
		{
			string controlNumber = "279146358279";
			int sum = 0;


			char[] cnpNumbers = cnp.ToCharArray();
			char[] controlNumbers = controlNumber.ToCharArray();

			for (int i = 0; i < 12; i++)
			{
				sum += (Int32.Parse(cnpNumbers[i].ToString()) * Int32.Parse(controlNumbers[i].ToString()));
			}

			//If sum % 11 is 10, then the validation number should be 1
			int validControlNumber = (sum % 11 == 10) ? 1 : sum % 11;

			int cnpLastNumber;
			bool result = Int32.TryParse(cnp[12].ToString(), out cnpLastNumber);

			if (cnpLastNumber == validControlNumber)
			{
				return true;
			}

			return false;
		}
	}
}