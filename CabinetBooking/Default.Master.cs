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
			if (Session["LoggedUserID"] == null)
			{
				btnLogIn.Visible = true;
			}
			else
			{
				User user = _dc.Users.FirstOrDefault(u => u.ID == Int32.Parse(Session["LoggedUserID"].ToString()));
				if (user != null)
				{
					lblUsername.Text = user.Username.ToString();
				}
			}

		}
	}
}