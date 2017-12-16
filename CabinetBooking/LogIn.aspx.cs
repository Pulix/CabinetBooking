using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class LogIn : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["Error"] != null)
			{
				lblMessage.Text = Session["Error"].ToString();
				Session["Error"] = null;
			}

			if (Session["Message"] != null)
			{
				lblMessage.Text = Session["Message"].ToString();
				Session["Message"] = null;
			}

			txtPassword.Visible = true;
			txtUsername.Visible = true;
			btnLogIn.Visible = true;
			//lblMessage.Visible = false;
		}

		protected void btnLogIn_Click(object sender, EventArgs e)
		{

			string username = txtUsername.Value.ToLower().Trim();
			string password = getPasswordHash(txtPassword.Value);

			if (doctorsLogIn.Checked == false)
			{
				//User Login

				User user = _dc.Users.FirstOrDefault(u => u.Username.ToLower() == username && u.Password == password);

				if (user == null)
				{
					Session["Error"] = "Invalid Username or Password";
					Response.Redirect("LogIn.aspx");
				}
				else
				{
					Session["LoggedUserID"] = user.ID.ToString();
					Server.Transfer("Index.aspx");
				}

				if (user != null)
				{
					txtPassword.Visible = false;
					txtUsername.Visible = false;
					btnLogIn.Visible = false;
				}
				else
				{
					txtPassword.Visible = true;
					txtUsername.Visible = true;
					btnLogIn.Visible = true;
					lblMessage.Visible = true;
					lblMessage.ForeColor = Color.Red;
					lblMessage.Text = " Worng username or password";
				}
			}
			else
			{
				//Doctor Login
				Doctor doctor = _dc.Doctors.FirstOrDefault(u => u.UserName.ToLower() == username && u.Pin == txtPassword.Value);

				if (doctor == null)
				{
					Session["Error"] = "Invalid Username or Password";
					Response.Redirect("LogIn.aspx");
				}
				else
				{
					Session["IsDoctor"] = true;
					Server.Transfer("Index.aspx");
				}
			}
		}

		private string getPasswordHash(string password)
		{
			using (MD5 md5Hash = MD5.Create())
			{
				return GetMd5Hash(md5Hash, password);
			}
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
	}
}