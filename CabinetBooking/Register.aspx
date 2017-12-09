<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CabinetBooking.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		#password1 {
			margin-bottom: 3px;
		}

		#password2 {
			margin-bottom: 0px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<br />
	<br />
    &nbsp;&nbsp;&nbsp;
	<asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
	&nbsp;<input type="text" placeholder="name" id="txtFirstName" runat="server" />&nbsp;
	<asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
	&nbsp;<input type="text" placeholder="name" id="txtLastName" runat="server" />
	<br />
	<br />
	&nbsp;&nbsp;&nbsp;
	<asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
	&nbsp;&nbsp;<input type="text" placeholder="name" id="txtUsername" runat="server" />
	<br />
	<br />
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
	&nbsp;<input type="password" placeholder="password" id="txtPassword" runat="server" /><br />
	<br />
	&nbsp;&nbsp;&nbsp;
	<asp:Label ID="lblRepeatPassword" runat="server" Text="Repeat Password"></asp:Label>
    &nbsp;
	<input type="password" placeholder="password" id="txtRepeatPassword" runat="server" /><br />
	<br />
	<br />
    &nbsp;&nbsp;&nbsp;
	<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
	<br />
    &nbsp;&nbsp;&nbsp;
	<asp:Button runat="server" ID="btnRegister" OnClick="btnRegister_Click" Text="Register" />
	<br />
	<br />
	Already registered? <a href="#">Sign In</a><p class="message">&nbsp;</p>
	<p class="message">&nbsp;</p>
</asp:Content>
