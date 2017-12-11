<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AddDoctors.aspx.cs" Inherits="CabinetBooking.Doctors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<div class="box-body">
				<div class="form-group">
					<label for="txtDoctorName">Doctor's Name</label>
					<input type="text" placeholder="Doctor's Name" class="form-control" id="txtDoctorName" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtDoctorLastName">Doctor's Last Name</label>
					<input type="text" placeholder="Doctor's Last Name" class="form-control" id="txtDoctorLastName" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtDoctorUserName">Doctor's Username</label>
					<input type="text" placeholder="Doctor's Username" class="form-control" id="txtDoctorUserName" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtPassword">Password</label>
					<input type="password" placeholder="password" id="txtPassword" class="form-control" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtPassword2">Repeat Password</label>
					<input type="password" placeholder="password" id="txtPassword2" class="form-control" runat="server" />
				</div>
				<div class="row">
					<asp:Button ID="addDoctor" runat="server" Text="Add Doctor" OnClick="addDoctor_Click" />
					<div class="col-md-1 col-md-offset-4"></div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
