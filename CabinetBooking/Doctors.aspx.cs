using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CabinetBooking
{
	public partial class Doctors1 : System.Web.UI.Page
	{
		CabinetBookingDataContext _dc = new CabinetBookingDataContext();

		protected void Page_Load(object sender, EventArgs e)
		{
			List<User> DoctorsList = _dc.Users.Where(u => u.Type == 2 && u.IsDeleted == false).ToList();

			foreach (User Doctor in DoctorsList)
			{
				TableRow row = new TableRow();

				TableCell firstNameCell = new TableCell();
				TableCell lastNameCell = new TableCell();
				TableCell specialityCell = new TableCell();

				firstNameCell.Text = Doctor.FirstName.ToString();
				lastNameCell.Text = Doctor.LastName.ToString();
				specialityCell.Text = "Speciality";


				row.Cells.Add(firstNameCell);
				row.Cells.Add(lastNameCell);
				row.Cells.Add(specialityCell);


				DoctorsTable.Rows.Add(row);
			}
		}
	}
}