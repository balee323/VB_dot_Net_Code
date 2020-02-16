<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AdminSettingsPage.aspx.vb" Inherits="ProductWarehouse.web.AdminSettingsPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 35%;
            padding: 10px;
            margin-left: 20%;
        }
        .style2
        {
            width: 45%;
            padding: 10px;
            margin-right: 20%;
        }
    </style>
</head>
<body bgcolor="#9a95bb" style="height: 85%; width: 90%;">
    <form id="form1" runat="server" style="background-color: #CCCCCC; height: 850px; width: 98%; padding: 5px; margin-left:auto; margin-right: auto;">


    

      <div style="height: 90%; width: 90%; margin-left: auto; margin-right: auto; margin-top: 3%;">


      <div style="height: 35px; width: 10%; margin-top: 3%; float: left; margin-bottom: 10px;">
      
      
          <asp:ImageButton ID="ImageButton1" runat="server" style="width: 65%; height: 60%;" />
      
      
      </div>

   <div style="height: 35px; width: 75%; margin-top: 3%; float: right; margin-left: 5%; margin-right: auto; margin-bottom: 10px;">
    <p align="center">Admin Settings</p>
   </div>
          <div style="height: 45%; width: 38%; float:left; margin-left: 5%; margin-top: 10px; padding: 10px; border: 1px solid Blue;" >
    
              Users<br />
             <asp:GridView ID="GridView1" runat="server" Width="100%">
             </asp:GridView>
      </div>
      <div style="height: 45%; width: 50%; Float: right; margin-right: 5%; margin-top: 10px; border: 1px solid Blue;">  
         <p>&nbsp; Add User</p>

          <table style="width: 100%;">
              <tr>
                  <td class="style1">
                      &nbsp; <asp:Label ID="Label1" runat="server" Text="User ID" Width="45%"></asp:Label>
                  </td>
                  <td class="style2">
                      &nbsp; <asp:TextBox ID="TextBox1" runat="server" Width="65%"></asp:TextBox>
                  </td>
                  </tr>

                     <tr>
                  <td class="style1">
                      &nbsp; <asp:Label ID="Label2" runat="server" Text="First Name" Width="45%"></asp:Label>
                  </td>
                  <td class="style2">
                      &nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="65%"></asp:TextBox>
                  </td>
                  </tr>

                     <tr>
                  <td class="style1">
                      &nbsp; <asp:Label ID="Label3" runat="server" Text="Last Name" Width="45%"></asp:Label>
                  </td>
                  <td class="style2">
                      &nbsp; <asp:TextBox ID="TextBox3" runat="server" Width="65%"></asp:TextBox>
                  </td>
                  </tr>

                     <tr>
                  <td class="style1">
                      &nbsp; <asp:Label ID="Label4" runat="server" Text="Password" Width="45%"></asp:Label>
                  </td>
                  <td class="style2">
                      &nbsp; <asp:TextBox ID="TextBox4" runat="server" Width="65%"></asp:TextBox>
                  </td>
                  </tr>
          </table>

          <br />
          <asp:Button ID="Button1" runat="server" Text="Save" />

         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Label" 
              Visible="False"></asp:Label>

         </div>
      </div>
    </form>
</body>
</html>
