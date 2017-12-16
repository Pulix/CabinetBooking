<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CabinetBooking.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2 style="padding-bottom: 30px;">Log In</h2>
			<div class="box-body">
				<div class="form-group">
					<label for="txtUsername">Username</label>
					<input type="text" placeholder="Username" class="form-control" id="txtUsername" runat="server" />
				</div>
				<div class="form-group">
					<label for="txtPassword">Password</label>
					<input type="password" placeholder="Password" id="txtPassword" class="form-control" runat="server" />
				</div>
		
				<div class="form-check">
					<label class="form-check-label" style="color: darkgreen;">
						<asp:CheckBox ID="doctorsLogIn" class="form-check-input" runat="server"></asp:CheckBox>
						Log In As Doctor
					</label>
				</div>
				<div class="form-group">
					<asp:Label ID="lblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
				</div>

				<div class="row center-block" style="padding-top: 30px; padding-bottom: 10px;">
					<asp:Button ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
					<div class="col-md-1 col-md-offset-3"></div>
				</div>
			</div>

		</div>
	</div>
</asp:Content>
