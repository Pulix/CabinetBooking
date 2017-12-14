<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CreateAppointment.aspx.cs" Inherits="CabinetBooking.CreateAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<script type="text/javascript" src="Scripts/jquery-1.9.1.min.js"></script>
	<script type="text/javascript" src="/scripts/moment.min.js"></script>
	<script type="text/javascript" src="/scripts/bootstrap.min.js"></script>
	<link rel="stylesheet" href="/Content/bootstrap-datetimepicker.css" />
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">

	<div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2 style="padding-bottom: 30px;">Create Appointment</h2>
			<div class="box-body">
				<div class="form-group">
					<label for="ddlDoctors">Choose Doctor</label>
					<asp:DropDownList type="text" placeholder="Doctor's Last Name" class="form-control" id="ddlDoctors" runat="server" ></asp:DropDownList>
				</div>
				<div class="form-group">
					<label for="ddlSpecialities">Choose Speciality</label>
					<asp:DropDownList type="text" placeholder="Doctor's Username" class="form-control" id="ddlSpecialities" runat="server" ></asp:DropDownList>
				</div>
				<div class="form-group">
					<label for="txtAppointmentDateTime">Choose Appointment Date</label>
					<div class="input-group date" id="datetimepicker1">
						<input type="text" class="form-control" id="txtAppointmentDateTime" runat="server" />
						<span class="input-group-addon">
							<span class="glyphicon glyphicon-calendar"></span>
						</span>
					</div>
				</div>
				<div class="row center-block" style="padding-top: 30px; padding-bottom: 10px;">
					<asp:Button ID="tbtnCreateAppointment" runat="server" Text="Create Appointment" OnClick="tbtnCreateAppointment_Click" />
					<div class="col-md-1 col-md-offset-3"></div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
	<script type="text/javascript">
		$(function () {
			$('#datetimepicker1').datetimepicker();
		});
			</script>
	<script src="Scripts/bootstrap-datetimepicker.min.js" type="text/javascript"></script>
</asp:Content>


