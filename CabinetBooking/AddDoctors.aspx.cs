using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class Doctors : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["LoggedUserID"] != null)
			{
				User user = _dc.Users.FirstOrDefault(u => u.ID == Convert.ToInt32(Session["LoggedUserID"].ToString()));

				if (user.Type != 1)
				{
					Response.Redirect("Index.aspx");
				}
			}
			else
			{
				Response.Redirect("Index.aspx");
			}
		}

		protected void addDoctor_Click(object sender, EventArgs e)
		{

			string firstName = txtDoctorName .Value.ToString();
			string lastName = txtDoctorLastName.Value.ToString();
			string username = validateUsername(txtDoctorName.Value.ToString()); //txtUsername.Value.ToString();
			string password = validatePassword(txtPassword.Value.ToString(), txtPassword2.Value.ToString());

			if (password == "")
			{
				password = "123";
			}


			User newDoctor = new User();
			newDoctor.FirstName = firstName;
			newDoctor.LastName = lastName;
			newDoctor.Username = username;
			newDoctor.Password = password;
			newDoctor.Type = 2;
			_dc.Users.InsertOnSubmit(newDoctor);
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