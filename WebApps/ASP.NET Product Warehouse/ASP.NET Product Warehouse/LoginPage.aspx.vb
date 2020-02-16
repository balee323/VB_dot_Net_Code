Namespace ProductWarehouse.web
    Partial Class Default2
        Inherits System.Web.UI.Page

        Dim LoginTries As Integer


        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click



            Dim login As New Login(TextBox1.Text, TextBox2.Text)

            If login.getAuthStatus() Then
                Session("IsLoggedIn") = True
                Session("User") = login.getUser()
                Label3.Visible = True
                Label3.Text = "Login Successful"
                System.Threading.Thread.Sleep(1000)
                Response.Redirect("Default.ASPX")
            Else
                Session("IsLoggedIn") = False
                Label3.Visible = True
                Label3.Text = "Login Failed"
            End If


            LoginTries = LoginTries + 1
            Session("LoginTries") = LoginTries

            If LoginTries > 5 Then
                Label3.Visible = True
                Label3.Text = "Too many Login attempts.  Account Locked"
                Button1.Enabled = False
            End If

        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


            Session("IsLoggedIn") = Nothing
            Session("User") = Nothing


            If IsPostBack Then
                LoginTries = CInt(Session("LoginTries"))
            ElseIf Not IsPostBack Then
                LoginTries = 0
            End If



            'If LoginTries > 5 Then
            '    Label3.Visible = True
            '    Label3.Text = "Too many Login attempts.  Account Locked"
            '    Button1.Enabled = False
            'End If

        End Sub
    End Class
End Namespace