<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CabinetBooking.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="login-page">
		<div class="form">
			<form class="login-form">&nbsp;
				<input type="text" placeholder="Username" id="txtUsername" runat="server" />
				<input type="password" placeholder="Password" id="txtPassword" runat="server" />
				<asp:Button ID="bntLogIn" runat="server" Text="Log In" OnClick="bntLogIn_Click" />
				<p class="message">Not registered? <a href="#">Create an account</a></p>
			</form>
		</div>
	</div>
</asp:Content>
