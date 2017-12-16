<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="CabinetBooking.Statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-4 col-md-offset-4"><h1>Statistics</h1></div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<h2>Most Booked Doctors</h2>
			<asp:table id="DoctorsTable" class="table table-bordered table-hover table-striped" runat="server" width="100%"> 
				<asp:TableRow>
					<asp:TableCell>#</asp:TableCell>
					<asp:TableCell>Doctor's Name</asp:TableCell>
					<asp:TableCell>Doctor's Last Name</asp:TableCell>
					<asp:TableCell>Active Bookings</asp:TableCell>
				</asp:TableRow>
			</asp:table>
		</div>
	</div>
	<div class="row">
		<div class="col-md-12">
			<h2>Most Sick Pacient</h2>
			<asp:table id="Table1" class="table table-bordered table-hover table-striped" runat="server" width="100%"> 
				<asp:TableRow>
					<asp:TableCell>#</asp:TableCell>
					<asp:TableCell>First Name</asp:TableCell>
					<asp:TableCell>Last Name</asp:TableCell>
					<asp:TableCell>Total Appointment Bookings</asp:TableCell>
				</asp:TableRow>
			</asp:table>
		</div>
	</div>
		<div class="row">
		<div class="col-md-12">
			<h2>Future Booked Appointments</h2>
			<asp:table id="Table2" class="table table-bordered table-hover table-striped" runat="server" width="100%"> 
				<asp:TableRow>
					<asp:TableCell>Total Active Appointments</asp:TableCell>
				</asp:TableRow>
			</asp:table>
		</div>
	</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
