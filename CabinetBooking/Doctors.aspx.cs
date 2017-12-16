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
			List<Doctor> DoctorsList = _dc.Doctors.Where(u => u.IsDeleted == false).ToList();

			int count = 1;

			foreach (Doctor Doctor in DoctorsList)
			{
				TableRow row = new TableRow();

				TableCell countNumber = new TableCell();
				TableCell firstNameCell = new TableCell();
				TableCell lastNameCell = new TableCell();
				TableCell specialityCell = new TableCell();

				countNumber.Text = count.ToString();
				firstNameCell.Text = Doctor.FirstName.ToString();
				lastNameCell.Text = Doctor.LastName.ToString();

				List<string> specialityList = new List<string>();

				var specLIst = _dc.Doctors.Join(_dc.DoctorsAndSpecialities, d => d.ID, ds => ds.DoctorsID, (d, ds) => new { d.ID, ds.SpecialityID }).Where(d => d.ID == Doctor.ID).ToList();
				foreach (var spec in specLIst)
				{
					Speciality speciality = _dc.Specialities.FirstOrDefault(s => s.ID == spec.SpecialityID);
					specialityList.Add(speciality.SpecialityName.Trim().ToString());
				}

				string result = String.Join(", ", specialityList.ToArray());

				specialityCell.Text = result;

				row.Cells.Add(countNumber);
				row.Cells.Add(firstNameCell);
				row.Cells.Add(lastNameCell);
				row.Cells.Add(specialityCell);

				DoctorsTable.Rows.Add(row);
				count++;
			}
		}
	}
}