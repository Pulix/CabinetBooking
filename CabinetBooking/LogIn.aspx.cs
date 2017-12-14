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
			lblMessage.Visible = false;
		}

		protected void btnLogIn_Click(object sender, EventArgs e)
		{			
			User user = _dc.Users.FirstOrDefault(u => u.Username.ToLower() == txtUsername.Value.ToLower().Trim() && u.Password == txtPassword.Value);
			if (user != null)
			{
				txtPassword.Visible = false;
				txtUsername.Visible = false;
				btnLogIn.Visible = false;
				lblMessage.Style.Add("font-weight", "bold");
				Session["LoggedUserID"] = user.ID.ToString();
				Server.Transfer("Index.aspx");

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
		
	}
}