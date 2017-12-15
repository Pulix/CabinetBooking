using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class AddSpecialities : System.Web.UI.Page
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

			if (Session["SpecialityMessage"] != null)
			{
				lblMessage.Text = Session["SpecialityMessage"].ToString();
				Session["SpecialityMessage"] = null;
			}
		}

		protected void btnAddSpeciality_Click(object sender, EventArgs e)
		{
			string specialityName = txtSpecialityName.Value.ToString();

			Speciality spec = _dc.Specialities.FirstOrDefault(s => s.SpecialityName == specialityName);

			if (spec == null)
			{
				Speciality speciality = new Speciality();
				speciality.SpecialityName = specialityName;
				_dc.Specialities.InsertOnSubmit(speciality);
				_dc.SubmitChanges();

				Session["SpecialityMessage"] = "Speciality '" + specialityName + "' added Succesfully";
				Response.Redirect("AddSpecialities.aspx");
			}
			else
			{
				Session["SpecialityMessage"] = "Speciality '" + specialityName + "' already exists";
				Response.Redirect("AddSpecialities.aspx");
			}
		}
	}
}