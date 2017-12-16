using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class EditAppointment : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();


		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["Message"] != null)
			{
				lblMessage.Text = Session["Message"].ToString();
				Session["Message"] = null;
			}

			if (Session["AppointmentID"] != null)
			{
				Appointment appointment = _dc.Appointments.FirstOrDefault(a => a.ID == Convert.ToInt32(Session["AppointmentID"].ToString()));


				DoctorsAndSpeciality docAndSpecs = _dc.DoctorsAndSpecialities.FirstOrDefault(d => d.ID == appointment.DoctorAndSpecialityID);
				// Doctor name

				Doctor doctorsName = _dc.Doctors.FirstOrDefault(d => d.ID == docAndSpecs.DoctorsID);

				//Speciality

				Speciality specialityName = _dc.Specialities.FirstOrDefault(d => d.ID == docAndSpecs.SpecialityID);



				lblDoctorsName.Text = doctorsName.FirstName.ToString() + " " + doctorsName.LastName.ToString();
				lblDoctorSpeciality.Text = specialityName.SpecialityName.ToString();
			}
		}

		protected void tbtnCreateAppointment_Click(object sender, EventArgs e)
		{
			if (txtAppointmentDateTime.Value != null )
			{
				string selectedDateTime = txtAppointmentDateTime.Value.ToString();
				DateTime myDate;
				DateTime.TryParse(selectedDateTime, out myDate);

				//get edited appointment
				Appointment appointment = _dc.Appointments.FirstOrDefault(a => a.ID == Convert.ToInt32(Session["AppointmentID"].ToString()));

				DoctorsAndSpeciality docAndSpec = _dc.DoctorsAndSpecialities.FirstOrDefault(ds => ds.ID == appointment.DoctorAndSpecialityID);

				List<Appointment> appointmentsList = _dc.Appointments.Where(a => a.DoctorAndSpecialityID == docAndSpec.ID).ToList();

				foreach (var appt in appointmentsList)
				{
					//selectedDate > appointment.AppointmentDate 1h

					DateTime now = DateTime.Now;
					DateTime plusOneHour = appt.AppointmentDate.AddHours(1);
					DateTime minusOneHour = appt.AppointmentDate.AddHours(-1);

					if (myDate < plusOneHour && myDate > minusOneHour)
					{
						Session["Message"] = "The doctor is Unavailable at that time.";
						Response.Redirect("EditAppointment.aspx");
					}
				}


				appointment.AppointmentDate = myDate;
				_dc.SubmitChanges();
			}

			Response.Redirect("Appointments.aspx");
		}
	}
}