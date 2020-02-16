<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DBConnErrorPage.aspx.vb" Inherits="DBConnErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 850px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server" style="background-color: #999999; height: 550px;">
    <div style="clear: both; Height: 100px;"></div>
    <div style="float: none; margin-top: 100px;">
    <p style="font-size: large; color: #FF0000; float: none; text-align: center;">  Error Connecting to the Database! </p>
    </div>
  <div style="clear: both; Height: 50px;"></div>
    <p style="font-size: large; color: #FF0000; float: none; text-align: center;"> 
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  </p>
    </form>
</body>
</html>
