<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AddAppointments.aspx.cs" Inherits="CabinetBooking.AddAppointments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
		<div class="col-md-4 col-md-offset-4">
			<div class="box-body">
				<div class="form-group">
					<label for="txtUserID">User's ID</label>
					<input type="text" placeholder="User's ID" class="form-control" id="txtUserID" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtDoctorUsername">Doctor's Username</label>
					<input type="text" placeholder="Doctor's Username" class="form-control" id="txtDoctorUsername" runat="server" />
				</div>
                <div class="form-group">
					<label for="dateTime">Date & Time</label><br />
                    Select Date & Time:&nbsp<input type="dateTime-local" name="dateTime" id="dateTime" /><br /><br />
				</div>
				<div class="row">
					<asp:Button ID="addAppointment" runat="server" Text="Add Appointment" OnClick="addAppointment_Click" />
					<div class="col-md-1 col-md-offset-4"></div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
