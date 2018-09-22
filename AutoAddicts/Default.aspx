<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutoAddicts._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %>.</h1>
        <h2>AutoAddicts is here to find all the parts for your car.</h2>
        <p class="lead"><b>The place where all safe journeys begin.</b>
                            We have a network of Tiger Wheel & Tyre fitment centers across southern Africa,
                           specialising in performance wheels, the world's best tyre brands and automotive batteries.
        </p>  
    <br />
    <div class="container">
        <div id="myCarousel" class="carousel slide" data-ride="carousel" >
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                    <li data-target="#myCarousel" data-slide-to="3"></li>
                    <li data-target="#myCarousel" data-slide-to="4"></li>
                </ol>

                
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img src="images/slideshow1.jpg" alt="Components" />
                    </div>

                    <div class="item">
                        <img src="images/slideshow2.jpg" alt="Games" />
                    </div>

                    <div class="item">
                        <img src="images/slideshow3.jpg" alt="Consoles" />
                    </div>

                    <div class="item">
                        <img src="images/slideshow4.jpg" alt="Consoles" />
                    </div>

                    <div class="item">
                        <img src="images/slideshow1.jpg" alt="Consoles" />
                    </div>
                </div>

                
                <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
    </div>  

</asp:Content>