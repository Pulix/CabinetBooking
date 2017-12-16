using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class SetDoctorSpeciality : System.Web.UI.Page
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

			List<Speciality> specialitiesList = _dc.Specialities.Where(s => s.IsDeleted == false).ToList();
			List<Doctor> doctors = _dc.Doctors.Where(d => d.IsDeleted == false).ToList();

			foreach (Speciality speciality in specialitiesList)
			{
				ddlSpecialities.Items.Add(new ListItem(speciality.SpecialityName.ToString()));
			}

			foreach (Doctor doctor in doctors)
			{
				ddlDoctors.Items.Add(new ListItem(doctor.FirstName + " " + doctor.LastName));
			}

			if (Session["Message"] != null)
			{
				lblMessage.Text = Session["Message"].ToString();
				Session["Message"] = null;
			}
		}

		protected void btnRegister_Click(object sender, EventArgs e)
		{
			Doctor doctor = _dc.Doctors.FirstOrDefault(dc => dc.FirstName + " " + dc.LastName == ddlDoctors.SelectedValue.Trim().ToString());
			Speciality speciality = _dc.Specialities.FirstOrDefault(s => s.SpecialityName == ddlSpecialities.SelectedValue.Trim().ToString());

			DoctorsAndSpeciality CheckDoc = _dc.DoctorsAndSpecialities.FirstOrDefault(ds => ds.DoctorsID == doctor.ID && ds.SpecialityID == speciality.ID);

			if (CheckDoc == null)
			{
				DoctorsAndSpeciality docAndSpec = new DoctorsAndSpeciality();
				docAndSpec.DoctorsID = doctor.ID;
				docAndSpec.SpecialityID = speciality.ID;
				_dc.DoctorsAndSpecialities.InsertOnSubmit(docAndSpec);
				_dc.SubmitChanges();

				Session["Message"] = "Success !";
				Response.Redirect("SetDoctorSpeciality.aspx");
			}
			else
			{
				Session["Message"] = "The Doctor already has that speciality added";
				Response.Redirect("SetDoctorSpeciality.aspx");
			}
		}
	}
}