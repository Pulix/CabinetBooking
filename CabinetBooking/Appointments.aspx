<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Appointments.aspx.cs" Inherits="CabinetBooking.Appointments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-10 col-md-offset-1">
			<h2>My Appointments</h2>
			<asp:table id="AppointmentsTable" class="table table-bordered table-hover" runat="server" width="100%"> 
				<asp:TableRow>
					<asp:TableCell>Doctor</asp:TableCell>
					<asp:TableCell>Speciality</asp:TableCell>
					<asp:TableCell>Appointment Date</asp:TableCell>
					<asp:TableCell style="width:25%;">Actions</asp:TableCell>
				</asp:TableRow>
			</asp:table>
		</div>
	</div>
</asp:Content>
