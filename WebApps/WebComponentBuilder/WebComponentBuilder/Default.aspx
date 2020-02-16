<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebComponentBuilder._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Component Builder and Tester</h1>
        <p class="lead">Click any of the below buttons to see a component.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h2>Grid View Components</h2>
            
        </div>
        <div class="col-md-4">

              <p>
                See a GridView with a Drop down menu
            </p>

            <p>
                <asp:Button ID="BtnGridView" runat="server" Text="Click here" />
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
