<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SetDoctorSpeciality.aspx.cs" Inherits="CabinetBooking.SetDoctorSpeciality" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2 style="padding-bottom: 30px;">Register</h2>
			<div class="box-body">
				<div class="form-group">
					<label for="ddlDoctors">Doctor</label>
					<asp:DropDownList id="ddlDoctors" class="form-control" runat="server"  DataValueField="Key" DataTextField="Value"></asp:DropDownList>
				</div>
				<div class="form-group">
					<label for="ddlSpecialities">Specialities</label>
					<asp:DropDownList id="ddlSpecialities" class="form-control" runat="server"></asp:DropDownList>
				</div>
				<div class="form-group">
					<asp:Label ID="lblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
				</div>
				<div class="row center-block" style="padding-top: 30px; padding-bottom: 10px;">
					<asp:Button runat="server" ID="btnRegister" OnClick="btnRegister_Click" Text="Add Speciality" />
					<div class="col-md-1 col-md-offset-3"></div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
