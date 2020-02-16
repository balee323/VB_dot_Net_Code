<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LoginPage.aspx.vb" Inherits="ProductWarehouse.web.Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>


<body bgcolor="#9a95bb" style="height: 600px; width: 95%;">
    <form id="form1" runat="server" style="background-color: #CCCCCC; height: 550px; width: 55%; padding: 10px; margin-left:auto; margin-right: auto;">


    <div>

      <div style="height: 35px; width: 90%; margin-left: auto; margin-right: auto; margin-top: 10%;">
    <p align="center"> Welcome to Product Warehouse!</p>

    </div>

   <div style="height: 35px; width: 75%; margin-top: 10%; margin-left: 20px; margin-right: auto; margin-bottom: 10px;">
    
    <p> Please Login&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
       </p>
    </div>
    

    <div style="height: 138px; width: 40%; float:left; margin-left: 20px; margin-top: 10px; padding: 10px; border: 1px solid Blue;" >
    
        <asp:Label ID="Label1" runat="server" Text="Username" style="margin-left: 5px;"></asp:Label> <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="60%"></asp:TextBox>
        <br />

         <div style="clear:both"></div>
       <br />
       <div style="float:Left; margin-Top: 10px; width: 60%;">
         <asp:Label ID="Label2" runat="server" Text="Password" style="margin-left: 5px;"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
        </div>
       
        <div style="float:right; margin-Top: 30px; width: 35%;"><asp:Button ID="Button1" runat="server" Width="100%" Text="Submit" /></div>
        

      </div>
      <div style="height: 160px; width: 35%; Float: right; margin-top: 10px;">  
          <asp:Image ID="Image1" runat="server" BorderStyle="Ridge" Height="150px" 
              ImageAlign="Top" ImageUrl="~/Images/Warehouse.jpg" Width="179px"  />  </div>
      </div>
    </form>
</body>
</html>
