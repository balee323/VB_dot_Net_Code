

<%@ Page Language="VB"   AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="ProductWarehouse.web._Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1024px" bgcolor="#cccccc">
    <form id="form1" runat="server" style="background-color: #5879AF; height: 60%; width: 95%; margin-left: auto; margin-right: auto;">

    
    <div style="float: left; height: 3%; width: 60%; margin-left: auto; margin-right: auto;"> <p align="center"; style="width: 100%; font-size: x-large; margin-top: 1%;"> Welcome to Product Warehouse!</p> </div>
    <div style="clear: right; height: 3%; width: 15%; float:right;"> <p style="float: right"> Connection Status &nbsp;
        <asp:Image ID="Image1" runat="server" style="float: right;" />  </p>
    </div>
   

     <div style="clear:both; height: 1%; width: 100%;"> </div>
     

   <!-- <div style="float:left; height: 2%; width: 40%;"></div> -->   <div style="float: right; width: 15%;"> 
        <asp:Label style="Float:right; margin-top: 6%; margin-right: 20%;" ID="Label1" 
            runat="server" Text="Label" Visible="False" ForeColor="#00CC00"></asp:Label></div>

     <div style="clear:both; height: 1%; width: 100%;"> </div>

    <asp:Menu style="padding: 5px; margin-left: 5px;" ID="Menu1" runat="server" BackColor="#E3EAEB" 
        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" 
        ForeColor="#666666" StaticSubMenuIndent="10px" BorderStyle="Ridge" 
        BorderWidth="1px" DynamicVerticalOffset="5" Orientation="Horizontal" 
        PathSeparator="|" RenderingMode="Table" >
        <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#E3EAEB" />
        <DynamicSelectedStyle BackColor="#1C5E55" />
        <Items>
            <asp:MenuItem Text="New Order" Value="NewOrder"></asp:MenuItem>
            <asp:MenuItem Text="View Open Orders" Value="OpenOrders"></asp:MenuItem>
            <asp:MenuItem Text="Order Tracking" Value="Tracking"></asp:MenuItem>
            <asp:MenuItem Text="Customer Setup" Value="CustomerSetup"></asp:MenuItem>
            <asp:MenuItem Text="Admin Settings" Value="AdminSettings"></asp:MenuItem>
            <asp:MenuItem Text="Logout" Value="Logout"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#666666" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" 
            BorderStyle="Ridge" BorderWidth="3px" ItemSpacing="10px" />
        <StaticSelectedStyle BackColor="#1C5E55" />
    </asp:Menu>

    
    <div style="clear:both; height:2%;"></div>

    <div style="height: 138px; width: 75%" >
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
         <asp:TextBox ID="TextBox1" runat="server" Width="246px">TextBox</asp:TextBox>
         <br />
         <asp:TextBox ID="TextBox2" runat="server" Width="245px" Visible="False">TextBox</asp:TextBox>
        </div>

 
    </form>
</body>
</html>
