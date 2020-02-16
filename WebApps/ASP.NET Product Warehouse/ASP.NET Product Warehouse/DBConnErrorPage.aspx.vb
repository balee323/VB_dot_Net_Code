
Partial Class DBConnErrorPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Label1.Text = Session("ErrorMsg").ToString()

    End Sub
End Class
