<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CabinetBooking.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="login-page">
		<div class="form">
			<h2>Log In</h2>
			<div class="form-group has-feedback">
				<input type="text" placeholder="Username" class="form-control" id="txtUsername" runat="server" />
				<span class="glyphicon glyphicon-envelope form-control-feedback"></span>
			</div>
			<div class="form-group has-feedback">
				<input type="password" placeholder="Password" class="form-control" id="txtPassword" runat="server" />
				<span class="glyphicon glyphicon-lock form-control-feedback"></span>
			</div>

			<asp:Button ID="btnLogIn" class="btn btn-warning btn-block btn-flat" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
			<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
			<asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" Visible="false" />
			<p class="message">Not registered? <a href="Register.aspx">Create an account</a></p>
		</div>
	</div>
</asp:Content>
