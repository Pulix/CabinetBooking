using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{

	public partial class Statistics : System.Web.UI.Page
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

				List<Appointment> appointmentsList = _dc.Appointments.Where(ap => ap.IsDeleted == false).ToList();
				List<DoctorsAndSpeciality> doctorsAndSpecialities = new List<DoctorsAndSpeciality>();
				List<Doctor> DoctorsList = new List<Doctor>();


				foreach (var appointment in appointmentsList)
				{
					doctorsAndSpecialities.Add(_dc.DoctorsAndSpecialities.FirstOrDefault(ap => ap.ID == appointment.DoctorAndSpecialityID));
				}

				foreach (var docandspec in doctorsAndSpecialities)
				{
					DoctorsList.Add(_dc.Doctors.FirstOrDefault(d => d.ID == docandspec.DoctorsID));
				}

				//var ass = DoctorsList.Select

				//foreach (var doctor in DoctorsList)
				//{

				//}



				//foreach (var doctor in DoctorsList)
				//{
				//	Appointments appointment = _dc.Appointments.Where(a => a.DoctorAndSpecialityID)
				//}

			}
			else
			{
				Response.Redirect("Index.aspx");
			}
		}
	}
}