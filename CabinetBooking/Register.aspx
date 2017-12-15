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
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2 style="padding-bottom: 30px;">Add a new Doctor</h2>
			<div class="box-body">
				<div class="form-group">
					<label for="txtFirstName">First Name</label>
					<input type="text" placeholder="First Name" class="form-control" id="txtFirstName" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtLastName">Last Name</label>
					<input type="text" placeholder="Last Name" class="form-control" id="txtLastName" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtUsername">Username</label>
					<input type="text" placeholder="Username" class="form-control" id="txtUsername" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtPassword">Password</label>
					<input type="password" placeholder="Password" id="txtPassword" class="form-control" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtRepeatPassword">Repeat Password</label>
					<input type="password" placeholder="Repeat Password" id="txtRepeatPassword" class="form-control" runat="server" />
				</div>
				<div class="form-group">
					<asp:Label ID="lblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
				</div>

				<div class="row center-block" style="padding-top: 30px; padding-bottom: 10px;">
					<asp:Button runat="server" ID="btnRegister" OnClick="btnRegister_Click" Text="Register" />
					<div class="col-md-1 col-md-offset-3"></div>
				</div>
			</div>
			<div class="form-group">
				Already registered? <a href="LogIn.aspx">Log In</a><p class="message">&nbsp;</p>
				<p class="message">&nbsp;</p>
			</div>
		</div>
	</div>
	
	
	
	<%--<br />
	<br />
	<asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
	<input type="text" placeholder="name" id="txtFirstName" runat="server" />&nbsp;
	<asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
	<input type="text" placeholder="name" id="txtLastName" runat="server" />
	<br />
	<br />
	<asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
	<input type="text" placeholder="name" id="txtUsername" runat="server" />
	<br />
	<br />
	<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
	<input type="password" placeholder="password" id="txtPassword" runat="server" /><br />
	<br />
	<asp:Label ID="lblRepeatPassword" runat="server" Text="Repeat Password"></asp:Label>
	<input type="password" placeholder="password" id="txtRepeatPassword" runat="server" /><br />
	<br />
	<br />
	<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
	<br />
	<asp:Button runat="server" ID="btnRegister" OnClick="btnRegister_Click" Text="Register" />
	<br />
	<br />--%>
</asp:Content>
