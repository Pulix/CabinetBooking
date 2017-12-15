<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AddSpecialities.aspx.cs" Inherits="CabinetBooking.AddSpecialities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2 style="padding-bottom: 30px;">Add a new Speciality</h2>
			<div class="box-body">
				<div class="form-group">
					<label for="txtDoctorName">New Speciality Name:</label>
					<input type="text" placeholder="New Speciality Name" class="form-control" id="txtSpecialityName" runat="server" />
				</div>
				<div class="form-group">
					<asp:Label ID="lblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
				</div>
				<div class="row center-block" style="padding-top: 30px; padding-bottom: 10px;">
					<asp:Button ID="tbtnAddSpeciality" runat="server" Text="Add Speciality" OnClick="tbtnAddSpeciality_Click" />
					<div class="col-md-4 col-md-offset-4"></div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
