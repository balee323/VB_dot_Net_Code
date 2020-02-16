Imports System.Data
Imports System.Data.SqlClient  ' for dataSource

Namespace ProductWarehouse.web

    Public Class Connection

        '****************************************
        '****************************************
        'Pick a connection
        '****************************************


        '****************************************
        'for using database file

        'for SQL Express
        '   Private ConnString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\temp\ProductWarehouse.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        '   Private ConnString As String = "Data Source=.\SQLEXPRESS10;AttachDbFilename=C:\temp\ProductWarehouse.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"

        'for MSSQLSERVER   -->  might have to change the permissions on the .mdf and .ldf - set to read& write 
        Private ConnString As String = "Data Source=.\SQLDEV;AttachDbFilename=C:\temp\ProductWarehouse.mdf;Integrated Security=True;Connect Timeout=30;"


        '****************************************

        '****************************************
        'For Using DB File included in Project
        'For .\SqlExpress
        'Private ConnString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ProductWarehouse.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        'For .\SqlExpress10
        ' Private ConnString As String = "Data Source=.\SQLEXPRESS10;AttachDbFilename=|DataDirectory|\ProductWarehouse.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        '****************************************


        '****************************************
        'for using a live Sql Instance
        ' Private ConnString As String = "Data Source=.\SQLEXPRESS;Database=ProductWarehouse;Integrated Security=True"
        'For .\sqlexpress10
        'Private ConnString As String = "Data Source=.\SQLEXPRESS10;Database=ProductWarehouse;Integrated Security=True"

        '   Private ConnString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\blee6\Desktop\ProductWarehouse\ProductWarehouse\ProductWarehouse\ProductWarehouse.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"


        '****************************************
        '****************************************




        'Private SqlConn As SqlConnection
        Private Shared SqlConn As SqlConnection
        Private Shared IsOpen As Boolean = False

        Private ShowConnStatus As Boolean
        Private ErrorMsg As String = ""


        'constructor with Connection String Param
        Public Sub New(ByVal ConnString As String, ByVal showConnStatus As Boolean)
            SqlConn = New SqlConnection()
            Me.ShowConnStatus = showConnStatus
            Me.ConnString = ConnString
            ' DBConn_Open()
        End Sub

        'default
        Public Sub New(ByVal showConnStatus As Boolean)

            SqlConn = New SqlConnection()

            Me.ShowConnStatus = showConnStatus
            ' DBConn_Open()

        End Sub

        Public Function test() As Boolean
            Dim ConnectionStatus As Boolean = False

            Try
                DBConn_Open()
                ConnectionStatus = getConnStatus()
                DBConn_close()
            Catch ex As Exception
                ConnectionStatus = False
            End Try


         

            Return ConnectionStatus
        End Function


        Private Sub DBConn_close()
            Try
                SqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                ErrorMsg = ex.Message
            End Try

        End Sub

        Private Sub DBConn_Open()

            If IsOpen = False Then
                Try
                    SqlConn.ConnectionString = ConnString
                    SqlConn.Open()
                Catch ex As Exception
                    'Error handling code here....
                    MsgBox(ex.Message)
                    ErrorMsg = ex.Message
                End Try
            End If

            If ShowConnStatus Then
                '   MsgBox("Connection is Open = " & CBool(SqlConn.State()))
            End If

        End Sub


        Private Function getConnStatus() As Boolean
            Return CBool(SqlConn.State)
        End Function


        Public Function getErrorMsg() As String
            Return ErrorMsg
        End Function

        Public Function SqlCmdSingleReturn(ByVal cmdText As String) As String

            DBConn_Open()

            Dim sqlDataAdapter As New SqlDataAdapter()

            Dim reader As SqlDataReader

            Dim cmd As New SqlCommand()
            cmd.CommandText = cmdText

            cmd.CommandType = CommandType.Text
            cmd.Connection = SqlConn

            reader = cmd.ExecuteReader()

            Dim returnedPass As String = ""

            If reader.HasRows Then
                reader.Read()
                returnedPass = reader.GetString(0)

            End If

            reader.Close()
            SqlConn.Close()

            Return returnedPass

        End Function


        Public Function SqlCmdReturn(ByVal cmdText As String) As DataSet

            DBConn_Open()

            Dim sqlDataAdapter As New SqlDataAdapter()
            Dim dataSet As New DataSet()

            Dim cmd As New SqlCommand()
            cmd.CommandText = cmdText

            cmd.CommandType = CommandType.Text
            cmd.Connection = SqlConn

            sqlDataAdapter.SelectCommand = cmd

            Try
                sqlDataAdapter.Fill(dataSet, "Data")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            SqlConn.Close()

            Return dataSet

        End Function


        Public Sub InsertUpdateDB(ByVal cmdText As String)

            DBConn_Open()


            Dim cmd As New SqlCommand()
            cmd.CommandText = cmdText

            cmd.CommandType = CommandType.Text
            cmd.Connection = SqlConn
            cmd.ExecuteScalar()

            SqlConn.Close()

        End Sub



    End Class
End Namespace
