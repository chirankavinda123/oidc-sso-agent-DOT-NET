<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-image:url('cover.jpeg');background-size: 1170px 640px;height:530px;">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms letsuild sophisticated, powerful UI-driven sites with data access.
            </p>
            <div class="center-elem">
                <p >
                    <a class="btn btn-default" href="/oidcsso">Learn more &raquo;</a>
                </p>
            </div>
        </div>
    </div>
    <IFRAME id="rpIFrame" frameborder="0" width="1000" height="1000" runat="server"></IFRAME>
</asp:Content>
