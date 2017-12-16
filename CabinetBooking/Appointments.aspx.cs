using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class Appointments : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{


			if (Session["LoggedUserID"] != null)
			{
				User user = _dc.Users.FirstOrDefault(u => u.ID == Convert.ToInt32(Session["LoggedUserID"].ToString()));

				if (Session["Message"] != null)
				{
					lblMessage.Text = Session["Message"].ToString();
					Session["Message"] = null;
				}

				if (user.Type != 1)
				{
					//Normal User

					btnCreateAppointment.Visible = true;

					List<Appointment> userAppointmentsList = _dc.Appointments.Where(a => a.UserID == Convert.ToInt32(Session["LoggedUserID"].ToString()) && a.IsDeleted == false).ToList();

					int count = 1;

					foreach (Appointment userAppointment in userAppointmentsList)
					{

						Button btnDelete = new Button() { ID = userAppointment.ID.ToString()+"D", Text = "Delete", CssClass= "btn btn-danger" };
						btnDelete.Click += buttonDelete_Click;

						Button btnEdit = new Button() { ID = userAppointment.ID.ToString()+"E", Text = "Edit", CssClass = "btn btn-warning" };
						btnEdit.Click += buttonEdit_Click;

						TableRow row = new TableRow();

						TableCell countNumber = new TableCell();
						TableCell doctorCell = new TableCell();
						TableCell specialityCell = new TableCell();
						TableCell appointmentDateCell = new TableCell();
						TableCell actionsCell = new TableCell();



						//appointment date/time

						DateTime appointmentDate = userAppointment.AppointmentDate;

						DoctorsAndSpeciality docAndSpecs = _dc.DoctorsAndSpecialities.FirstOrDefault(d => d.ID == userAppointment.DoctorAndSpecialityID);

						// Doctor name

						Doctor doctorsName = _dc.Doctors.FirstOrDefault(d => d.ID == docAndSpecs.DoctorsID);

						//Speciality

						Speciality specialityName = _dc.Specialities.FirstOrDefault(d => d.ID == docAndSpecs.SpecialityID);

						countNumber.Text = count.ToString();
						doctorCell.Text = doctorsName.FirstName.ToString() + " " + doctorsName.LastName.ToString();
						specialityCell.Text = specialityName.SpecialityName.ToString();
						appointmentDateCell.Text = appointmentDate.ToString();

						actionsCell.Controls.Add(btnEdit);

						DateTime now = DateTime.Now;
						DateTime tomorrow = now.AddDays(1);
						if (appointmentDate > tomorrow)
						{
							actionsCell.Controls.Add(btnDelete);
						}

						row.Cells.Add(countNumber);
						row.Cells.Add(doctorCell);
						row.Cells.Add(specialityCell);
						row.Cells.Add(appointmentDateCell);
						row.Cells.Add(actionsCell);

						AppointmentsTable.Rows.Add(row);
						count++;
					}
				}
				else
				{
					//Admin
					List<Appointment> userAppointmentsList = _dc.Appointments.Where(a => a.IsDeleted == false).ToList();

					int count = 1;

					foreach (Appointment userAppointment in userAppointmentsList)
					{

						Button btnDelete = new Button() { ID = userAppointment.ID.ToString() + "D", Text = "Delete", CssClass = "btn btn-danger" };
						btnDelete.Click += buttonDelete_Click;

						Button btnEdit = new Button() { ID = userAppointment.ID.ToString() + "E", Text = "Edit", CssClass = "btn btn-warning" };
						btnEdit.Click += buttonEdit_Click;

						TableRow row = new TableRow();

						TableCell countNumber = new TableCell();
						TableCell doctorCell = new TableCell();
						TableCell specialityCell = new TableCell();
						TableCell appointmentDateCell = new TableCell();
						TableCell actionsCell = new TableCell();



						//appointment date/time

						DateTime appointmentDate = userAppointment.AppointmentDate;

						DoctorsAndSpeciality docAndSpecs = _dc.DoctorsAndSpecialities.FirstOrDefault(d => d.ID == userAppointment.DoctorAndSpecialityID);

						// Doctor name

						Doctor doctorsName = _dc.Doctors.FirstOrDefault(d => d.ID == docAndSpecs.DoctorsID);

						//Speciality

						Speciality specialityName = _dc.Specialities.FirstOrDefault(d => d.ID == docAndSpecs.SpecialityID);

						countNumber.Text = count.ToString();
						doctorCell.Text = doctorsName.FirstName.ToString() + " " + doctorsName.LastName.ToString();
						specialityCell.Text = specialityName.SpecialityName.ToString();
						appointmentDateCell.Text = appointmentDate.ToString();

						actionsCell.Controls.Add(btnEdit);

						DateTime now = DateTime.Now;
						if (appointmentDate > now)
						{
							actionsCell.Controls.Add(btnDelete);
						}

						row.Cells.Add(countNumber);
						row.Cells.Add(doctorCell);
						row.Cells.Add(specialityCell);
						row.Cells.Add(appointmentDateCell);
						row.Cells.Add(actionsCell);

						AppointmentsTable.Rows.Add(row);
						count++;
					}
				}
			}
			else
			{
				Response.Redirect("Index.aspx");
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string[] buttonId = button.ID.Split('D');

			Appointment appointment = _dc.Appointments.FirstOrDefault(a => a.ID == Convert.ToInt32(buttonId[0].ToString()));

			appointment.IsDeleted = true;
			_dc.SubmitChanges();
			Response.Redirect("Appointments.aspx");
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string[] buttonId = button.ID.Split('E');

			Session["AppointmentID"] = Convert.ToInt32(buttonId[0].ToString());
			Response.Redirect("EditAppointment.aspx");
		}

	}
}