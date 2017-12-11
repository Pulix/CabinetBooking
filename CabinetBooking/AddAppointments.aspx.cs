using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
    public partial class AddAppointments : System.Web.UI.Page
    {
        CabinetBookingDataContext _dc = new CabinetBookingDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addAppointment_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Value.ToString();
            string doctorUsername = txtDoctorUsername.Value.ToString();
            //DateTime dateTime = dateTime.Value

            Appointment newAppointment = new Appointment();
            newAppointment.UserID = userID;
            newAppointment.DoctorAndSpecility = doctorUsername;
            _dc.Appointments.InsertOnSubmit(newAppointment);
            _dc.SubmitChanges();
        }
    }
}