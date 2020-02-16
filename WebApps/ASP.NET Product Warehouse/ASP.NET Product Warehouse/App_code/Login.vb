
Namespace ProductWarehouse.web

    Public Class Login


        Private userLogin As String = ""
        Private userPassword As String = ""
        Private IsLoggedIn As Boolean = False



        Public Sub New(ByVal userLogin As String, ByVal userPassword As String)
            Me.userLogin = userLogin
            Me.userPassword = userPassword

            AuthenticateLogin()

        End Sub

        Private Sub AuthenticateLogin()
            Dim returnedPass As String = ""

            Dim DBConn As New Connection(False)
            'DBConn.DBConn_Open()

            If CheckEntry(userLogin) Then


                Dim QueryString As String = "Select Password from TblAdmin Where UserLogin = '" & userLogin & "'"

                returnedPass = DBConn.SqlCmdSingleReturn(QueryString)

                If returnedPass = userPassword And returnedPass.Length > 0 Then
                    ' MsgBox("User Authenticated")
                    IsLoggedIn = True
                Else
                    ' MsgBox("Failed to Authenticate User, verify login and/or password.")
                    IsLoggedIn = False
                    System.Threading.Thread.Sleep(1000)

                End If
            Else

                '  MsgBox("Login cannot be blank")

            End If

        End Sub


        Private Function CheckEntry(ByVal Str As String) As Boolean

            Dim NullCheck As Boolean = False

            If Str.Length > 0 Then
                NullCheck = True
            End If


            Return NullCheck
        End Function

        Public Function getAuthStatus() As Boolean

            Return IsLoggedIn
        End Function

        Public Function getUser() As String

            Return userLogin
        End Function

    End Class

End Namespace
