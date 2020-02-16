
Imports System.Data
Imports System.Data.SqlClient  ' for dataSource

Namespace ProductWarehouse.web

    Partial Class AdminSettingsPage
        Inherits System.Web.UI.Page


        Dim DBConn As New Connection(False)

        Dim dataSet As DataSet

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            populateGridView()

            ImageButton1.ImageUrl = "images/returnArrow.png"


        End Sub

        Private Sub populateGridView()
            Dim sql As String = "Select * from TblAdmin"

            'returns values
            dataSet = DBConn.SqlCmdReturn(sql)


            GridView1.AutoGenerateColumns = True
            GridView1.DataSource = dataSet
            GridView1.DataBind()
        End Sub


        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

            Dim sqlInsert As String = ""

            Dim UserID As String = TextBox1.Text
            Dim FName As String = TextBox2.Text
            Dim LName As String = TextBox3.Text
            Dim Password As String = TextBox4.Text


            sqlInsert = "Insert Into TblAdmin (UserLogin, UserLName, UserFName, Password)  Values ('" + UserID + "','" + FName + "','" + LName + "','" + Password + "');"


            ' TextBox1.Text = sqlInsert


            If validateEntry() Then
                DBConn.InsertUpdateDB(sqlInsert)
                clearForm()
                populateGridView()
            End If







        End Sub

        Private Function validateEntry() As Boolean
            ' Dim IsValidated As Boolean = False

            Label5.Text = ""

            'early returns
            If (TextBox1.Text = Nothing) Then
                Label5.Visible = True
                Label5.Text = "UserId cannot be blank"
                Return False
            ElseIf (TextBox2.Text = Nothing) Then
                Label5.Visible = True
                Label5.Text = Label5.Text + "First Name cannot be blank"
                Label5.Visible = True
                Return False
            ElseIf (TextBox3.Text = Nothing) Then
                Label5.Text = Label5.Text + "Last Name cannot be blank"
                Label5.Visible = True
                Return False
            ElseIf (TextBox4.Text = Nothing) Then
                Label5.Visible = True
                Label5.Text = Label5.Text + "Password Cannot be blank"
                Return False
            End If

            'if validated
            Label5.Visible = False

            Return True

        End Function


        Private Sub clearForm()

            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            TextBox3.Text = Nothing
            TextBox4.Text = Nothing

        End Sub


        Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click



            Response.Redirect("Default.aspx")

        End Sub
    End Class

End Namespace