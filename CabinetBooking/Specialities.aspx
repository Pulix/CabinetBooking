﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Specialities.aspx.cs" Inherits="CabinetBooking.Specialities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
		<div class="col-md-4 col-md-offset-4">
			<h2>Doctors</h2>
			<asp:table id="SpecialitiesTable" class="table table-bordered" runat="server" width="100%"> 
				<asp:TableRow>
					<asp:TableCell>Doctor</asp:TableCell>
					<asp:TableCell>Speciality</asp:TableCell>
				</asp:TableRow>
			</asp:table>
		</div>
	</div>
</asp:Content>