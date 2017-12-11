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
            List<Appointment> AppointmentsList = _dc.Appointments.ToList();

            foreach (Appointment Appointmnet in AppointmentsList)
            {
                TableRow row = new TableRow();

                TableCell userCell = new TableCell();
                TableCell doctorCell = new TableCell();
                TableCell specialityCell = new TableCell();

                //userCell.Text = Appointment.User.ToString();
                //doctorCell.Text = Doctor.doctor.toString();
                specialityCell.Text = "Speciality";

                row.Cells.Add(userCell);
                row.Cells.Add(doctorCell);
                row.Cells.Add(specialityCell);

                AppointmentsTable.Rows.Add(row);
            }
        }
    }
}