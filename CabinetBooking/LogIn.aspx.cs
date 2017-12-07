using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
			txtPassword.Visible = true;
			txtUsername.Visible = true;
			btnLogIn.Visible = true;
			btnLogOut.Visible= false;
			lblMassage.Visible = false;
		}

		protected void bntLogIn_Click(object sender, EventArgs e)
		{			
			User user = _dc.Users.FirstOrDefault(u => u.Username.ToLower() == txtUsername.Value.ToLower().Trim() && u.Password == txtPassword.Value);
			if (user != null)
			{
				txtPassword.Visible = false;
				txtUsername.Visible = false;
				btnLogIn.Visible = false;
				btnLogOut.Visible = true;
				lblMassage.Visible = true;
				lblMassage.ForeColor = Color.Black;
				lblMassage.Text = user.Username;
			}
			else
			{
				txtPassword.Visible = true;
				txtUsername.Visible = true;
				btnLogIn.Visible = true;
				btnLogOut.Visible = false;
				lblMassage.Visible = true;
				lblMassage.ForeColor = Color.Red;
				lblMassage.Text = " Worng username or password";
			}
		}

		protected void btnLogOut_Click(object sender, EventArgs e)
		{
			txtPassword.Visible = true;
			txtUsername.Visible = true;
			btnLogIn.Visible = true;
			btnLogOut.Visible = false;
			lblMassage.Visible = false;
			txtUsername.Value = "";
		}
	}
}