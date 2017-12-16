<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Appointments.aspx.cs" Inherits="CabinetBooking.Appointments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-10 col-md-offset-1">
			<h2 id="appointments" runat="server">My Appointments</h2>
			<asp:table id="AppointmentsTable" class="table table-bordered table-hover table-striped" runat="server" width="100%"> 
				<asp:TableRow class="warning">
					<asp:TableCell>#</asp:TableCell>
					<asp:TableCell>Doctor</asp:TableCell>
					<asp:TableCell>Speciality</asp:TableCell>
					<asp:TableCell>Appointment Date</asp:TableCell>
					<asp:TableCell style="width:20%;">Actions</asp:TableCell>
				</asp:TableRow>
			</asp:table>
			<div class="form-group">
					<asp:Label ID="lblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
				</div>
			<div class="form-group">
				<a id="btnCreateAppointment" runat="server" visible="false" class="btn btn-success" href="CreateAppointment.aspx">Create appointment</a>
			</div>
		</div>
	</div>
</asp:Content>
