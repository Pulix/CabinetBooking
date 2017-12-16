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

			if (Session["Error"] != null)
			{
				lblMessage.Text = Session["Error"].ToString();
				Session["Error"] = null;
			}

			if (Session["DoctorsMessage"] != null)
			{
				lblMessage.Text = Session["DoctorsMessage"].ToString();
				Session["DoctorsMessage"] = null;
			}
		}

		protected void addDoctor_Click(object sender, EventArgs e)
		{
			string firstName = txtDoctorName .Value.ToString();
			string lastName = txtDoctorLastName.Value.ToString();
			validateFirstAndLastName(firstName, lastName);
			string username = validateUsername(txtDoctorUserName.Value.ToString());
			string pin = validatePin(txtPassword.Value.ToString(), txtPassword2.Value.ToString());

			if (username == "ErrorAlreadyExist")
			{
				Session["Error"] = "Doctor's Username Already Exists";
				Response.Redirect("AddDoctors.aspx");
			}

			if (pin == "N0tMatch")
			{
				Session["Error"] = "Pin Does Not Match";
				Response.Redirect("AddDoctors.aspx");
			}
			else
			{
				if (pin == "n0Length")
				{
					Session["Error"] = "Pin number must be of 4 digits";
					Response.Redirect("AddDoctors.aspx");
				}
			}

			Doctor newDoctor = new Doctor();
			newDoctor.FirstName = firstName;
			newDoctor.LastName = lastName;
			newDoctor.UserName = username;
			newDoctor.Pin = pin;
			_dc.Doctors.InsertOnSubmit(newDoctor);
			_dc.SubmitChanges();

			Session["DoctorsMessage"] = "Doctor '" + firstName + " " + lastName + "' added Succesfully";
			Response.Redirect("AddDoctors.aspx");
		}

		private void validateFirstAndLastName(string firstName, string lastName)
		{
			if (firstName.Length < 1 || lastName.Length < 1)
			{
				Session["Error"] = "First name and Last name required";
				Response.Redirect("AddDoctors.aspx");
			}

			Doctor doc = _dc.Doctors.FirstOrDefault(d => d.FirstName == firstName && d.LastName == lastName);
			if (doc != null)
			{
				Session["Error"] = "Doctor '"+ firstName + " " + lastName + "' Already Exists";
				Response.Redirect("AddDoctors.aspx");
			}
		}

		private string validateUsername(string userName)
		{
			if (userName.Length < 1)
			{
				Session["Error"] = "Username required";
				Response.Redirect("AddDoctors.aspx");
			}

			Doctor doc = _dc.Doctors.FirstOrDefault(d => d.UserName == userName);

			if (doc == null)
			{
				return userName;
			}

			return "ErrorAlreadyExist";
		}

		private string validatePin(string password1, string password2)
		{
			if (password1 != password2)
			{
				return "N0tMatch";
			}

			if (password1.Length != 4)
			{
				return "n0Length";
			}

			return password1;

		}
	}
}