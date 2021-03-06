﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class Default : System.Web.UI.MasterPage
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["IsDoctor"] != null)
			{
				form1.Visible = false;
				body.InnerHtml = "<h1>Congrats, You are a doctor</h1><input type=\"button\" Id=\"btnLogOut\" runat=\"server\" Text=\"Log Out\" OnClick = \"btnLogOut_Click\" ></ input>";
			}

			if (Session["LoggedUserID"] == null)
			{
				btnLogIn.Visible = true;
				btnSignUp.Visible = true;
			}
			else
			{
				User user = _dc.Users.FirstOrDefault(u => u.ID == Int32.Parse(Session["LoggedUserID"].ToString()));
				if (user != null)
				{
					lblUsername.Text = user.FirstName.ToString()+" "+user.LastName.ToString();
					btnLogOut.Visible = true;

					//Enable buttons
						if (user.Type == 1)
						{
						btnAddDoctors.Visible = true;
						btnAddSpecialities.Visible = true;
						btnStatistics.Visible = true;
						}
				}
			}

		}

		protected void btnLogOut_Click(object sender, EventArgs e)
		{
			btnLogOut.Visible = false;
			Session.Clear();
			Server.Transfer("Index.aspx");
		}
	}
}