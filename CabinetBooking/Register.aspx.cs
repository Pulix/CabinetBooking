using System;
using System.Collections.Generic;
using System.Linq;
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

		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			string firstName = txtFirstName.Value.ToString();
			string lastName = txtLastName.Value.ToString();
			string username = validateUsername(txtUsername.Value.ToString()); //txtUsername.Value.ToString();
			string password = validatePassword(txtpassword1.Value.ToString(), txtpassword2.Value.ToString());

			if (password == "")
			{
				password = "Parola schimbatoareeeee!";
			}

			Label1.Text = firstName + " " + lastName + " " + username + " " + password;

			User newUser = new User();
			newUser.FirstName = firstName;
			newUser.LastName = lastName;
			newUser.Username = username;
			newUser.Password = password;
			newUser.Type = 3;
			_dc.Users.InsertOnSubmit(newUser);
			_dc.SubmitChanges();
		}

		private string validateUsername(string userName)
		{
			return userName;
		}

		private string validatePassword(string password1, string password2)
		{
			if (password1 == password2)
			{
				return password1;
			}

			return "";

		}
	}
}