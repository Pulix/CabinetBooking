<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Doctors.aspx.cs" Inherits="CabinetBooking.Doctors1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2>Doctors</h2>
			<asp:table id="DoctorsTable" class="table table-bordered table-hover" runat="server" width="100%"> 
				<asp:TableRow>
					<asp:TableCell>First Name</asp:TableCell>
					<asp:TableCell>Last Name</asp:TableCell>
					<asp:TableCell>Speciality</asp:TableCell>
				</asp:TableRow>
			</asp:table>
		</div>
	</div>
</asp:Content>
