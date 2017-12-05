<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CabinetBooking.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<div class="login-page">
		<div class="form">

			<div class="login-box">
				<div class="login-logo">
					<a href="../../index2.html"><b>Medic</b>-All</a>
				</div>
				<!-- /.login-logo -->
				<div class="login-box-body">
					<p class="login-box-msg">Sign in to start your session</p>
						<div class="form-group has-feedback">
							<input type="email" class="form-control" placeholder="Email">
							<span class="glyphicon glyphicon-envelope form-control-feedback"></span>
						</div>
						<div class="form-group has-feedback">
							<input type="password" class="form-control" placeholder="Password">
							<span class="glyphicon glyphicon-lock form-control-feedback"></span>
						</div>
						<div class="row">
							<!-- /.col -->
							<div class="col-md-4 offset-4">
								<button type="submit" class="btn btn-primary btn-block btn-flat">Sign In</button>
							</div>
							<!-- /.col -->
						</div>


					<a href="#">I forgot my password</a><br>
					<a href="register.html" class="text-center">Register a new membership</a>

				</div>
				<!-- /.login-box-body -->
			</div>
		</div>
	</div>
</asp:Content>
