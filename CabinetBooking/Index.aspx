<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CabinetBooking.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
     <!-- Slider -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="images/333.jpg" />
            </div>
            <div class="item">
                <img src="images/444.jpg" />
            </div>
            <div class="item">
                <img src="images/555.jpg" />
                <%--  <div class="carousel-caption">
                    <h2>
                        Slide Three</h2>
                    <h3>
                        Bootstrap is completely free to download and use!</h3>
                </div>--%>
            </div>
        </div>
        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">
                Previous</span> </a><a class="right carousel-control" href="#myCarousel" role="button"
                    data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true">
                    </span><span class="sr-only">Next</span> </a>
    </div>
    <!-- Start Our Services -->
    <div id="our-services">
        <div class="container padding-top padding-bottom">
            <div class="row section-title text-center">
                <div class="col-sm-8 col-sm-offset-2">
                    <h1>
                        <span>Our</span> Services</h1>
                    <p>
                        There is a saying “Time and tide waits for none”. The saying is indeed true. Time waits 
                        for none. It comes and goes. Time is absolutely unbound able. Neither money nor position 
                        can buy it. Nothing on earth can subdue or conquer it. Make an appointment with our 
                        professional doctors so you can take care of your health to save precious time of your life.
                    </p>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-desktop"></i>
                        <h2>
                            Online Booking</h2>
                        <p>
                            Make appointments from the confort of your own home or anywhere using your smartphone.

                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-bell"></i>
                        <h2>
                            Email Notifications</h2>
                        <p>
                            Receive email notifications with a couple of hours before the appointment.
                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-coffee"></i>
                        <h2>
                            Beautiful Environment</h2>
                        <p>
                            Our environment is top class, just by being here you will feel better.

                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-bug"></i>
                        <h2>
                            Last Hour Scanning Technology</h2>
                        <p>
                            The most remarkable feature of time is its preciousness. Its value is unfathomable
                            and its power is inestimable.
                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-copyright"></i>
                        <h2>
                            Certified</h2>
                        <p>
                            We are up to date with all medical certifications.
                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-power-off"></i>
                        <h2>
                            Cancelation</h2>
                        <p>
                            You can cancel your appointments anytime before 24h of your appointment time.
                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-adjust"></i>
                        <h2>
                            24/7 Booking Service</h2>
                        <p>
                            You can book appointments at any time of day and night.
                        </p>
                    </div>
                </div>
                <div class="col-sm-6 col-md-3 service">
                    <div class="service-content">
                        <i class="fa fa-briefcase"></i>
                        <h2>
                            Full Detailed Reports</h2>
                        <p>
                            Our doctors provide full reports of your health status and will guide you for the best
                            solutions for your problems.
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class="height">
        </div>
    </div>
    <!-- /# Our Services -->
</asp:Content>
