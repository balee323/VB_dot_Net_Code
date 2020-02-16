
Namespace ProductWarehouse.web



    Partial Class _Default
        Inherits System.Web.UI.Page

        Private IsLoggedIn As Boolean = False
        Private User As String = ""
        Private ErrorMsg As String = ""

        Dim DBConn As Connection

        Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            TextBox1.Visible = False

            DBConn = New Connection(False)


            If DBConn.test() Then
                '  TextBox1.Text = "Connected to Database"
                Image1.ImageUrl = "images/Connected1.png"
            Else
                '   TextBox1.Text = "Error Connected to Database"
                Session("ErrorMsg") = DBConn.getErrorMsg()
                Response.Redirect("DBConnErrorPage.ASPX")
            End If


            ' If Not IsPostBack Then
            If Session("IsLoggedIn") <> Nothing Then

                IsLoggedIn = CType(Session("IsLoggedIn"), Boolean)
                If IsLoggedIn Then
                    '   TextBox2.Text = "Logged in"
                Else
                    '    TextBox2.Text = "Not Logged in, redirecting to Login Page"
                    Response.Redirect("LoginPage.ASPX")
                End If

            Else
                TextBox2.Text = "Not Logged in, redirecting to Login Page"
                Response.Redirect("LoginPage.ASPX")
            End If

            If Session("IsLoggedIn") <> Nothing Then
                User = Session("User").ToString
                Label1.Visible = True
                Label1.Text = "Welcome: " + User
            End If


        End Sub




        Sub NavigationMenu_MenuItemDataBound(ByVal sender As Object, ByVal e As MenuEventArgs) Handles Menu1.MenuItemClick

            If e.Item.Value = "AdminSettings" Then

                Response.Redirect("AdminSettingsPage.aspx")

            ElseIf e.Item.Text = "Logout" Then

                Response.Redirect("LoginPage.ASPX")

            End If




        End Sub



    End Class





End Namespace
