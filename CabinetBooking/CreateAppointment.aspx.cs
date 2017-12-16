using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class CreateAppointment : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{

			if (Session["LoggedUserID"] != null)
			{
				User user = _dc.Users.FirstOrDefault(u => u.ID == Convert.ToInt32(Session["LoggedUserID"].ToString()));

				if (user.Type == 1) { Response.Redirect("Index.aspx"); }
			}


			if (!IsPostBack)
			{
				List<Doctor> doctors = _dc.Doctors.Where(d => d.IsDeleted == false).ToList();

				foreach (Doctor doctor in doctors)
				{
					ddlDoctors.Items.Add(new ListItem(doctor.FirstName + " " + doctor.LastName));
				}
			}

			if (Session["Message"] != null)
			{
				lblMessage.Text = Session["Message"].ToString();
				Session["Message"] = null;
			}
		}

		protected void ddlDoctors_SelectedIndexChanged(object sender, EventArgs e)
		{
			ddlSpecialities.Items.Clear();
			Doctor doctor = _dc.Doctors.FirstOrDefault(dc => dc.FirstName + " " + dc.LastName == ddlDoctors.SelectedValue.Trim().ToString());

			List<string> specialityList = new List<string>();

			var specLIst = _dc.Doctors.Join(_dc.DoctorsAndSpecialities, d => d.ID, ds => ds.DoctorsID, (d, ds) => new { d.ID, ds.SpecialityID }).Where(d => d.ID == doctor.ID).ToList();
			foreach (var spec in specLIst)
			{
				Speciality speciality = _dc.Specialities.FirstOrDefault(s => s.ID == spec.SpecialityID);
				specialityList.Add(speciality.SpecialityName.Trim().ToString());
			}

			foreach (string spepciality in specialityList)
			{
				ddlSpecialities.Items.Add(new ListItem(spepciality));
			}
		}

		protected void tbtnCreateAppointment_Click(object sender, EventArgs e)
		{
			string selectedDateTime = txtAppointmentDateTime.Value.ToString();

			Doctor doctor = _dc.Doctors.FirstOrDefault(dc => dc.FirstName + " " + dc.LastName == ddlDoctors.SelectedValue.Trim().ToString());
			Speciality speciality = _dc.Specialities.FirstOrDefault(s => s.SpecialityName == ddlSpecialities.SelectedValue.Trim().ToString());

			DoctorsAndSpeciality docAndSpec = _dc.DoctorsAndSpecialities.FirstOrDefault(ds => ds.DoctorsID == doctor.ID && ds.SpecialityID == speciality.ID);

			List<Appointment> appointmentsList = _dc.Appointments.Where(a => a.DoctorAndSpecialityID == docAndSpec.ID).ToList();

			DateTime myDate;
			DateTime.TryParse(selectedDateTime, out myDate);

			
			foreach (var appointment in appointmentsList)
			{
				//selectedDate > appointment.AppointmentDate 1h

				DateTime now = DateTime.Now;
				DateTime plusOneHour = appointment.AppointmentDate.AddHours(1);
				DateTime minusOneHour = appointment.AppointmentDate.AddHours(-1);

				if (myDate < plusOneHour && myDate > minusOneHour)
				{
					Session["Message"] = "The doctor is Unavailable at that time.";
					Response.Redirect("CreateAppointment.aspx");
				}
			}

			Appointment newAppointment = new Appointment();
			newAppointment.UserID = Int32.Parse(Session["LoggedUserID"].ToString());
			newAppointment.DoctorAndSpecialityID = docAndSpec.ID;
			newAppointment.AppointmentDate = myDate;
			_dc.Appointments.InsertOnSubmit(newAppointment);
			_dc.SubmitChanges();


			Session["Message"] = "Success !";
			Response.Redirect("Appointments.aspx");
		}
	}
}