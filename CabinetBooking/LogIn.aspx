<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CabinetBooking.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="login-page">
		<div class="form">
			
				<input type="text" placeholder="Username" id="txtUsername" runat="server" />
				<input type="password" placeholder="Password" id="txtPassword" runat="server" />
				<asp:Button ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
				<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label> 
				<p class="message">Not registered? <a href="Register.aspx">Create an account</a></p>
			
		</div>
	</div>
</asp:Content>
