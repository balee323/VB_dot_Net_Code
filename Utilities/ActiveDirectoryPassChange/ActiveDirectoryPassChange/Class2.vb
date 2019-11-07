'Imports System
'Imports System.Text
'Imports System.Collections
'Imports System.DirectoryServices
'Imports System.Exception


'Public Class ChangePassword

'    Dim password1 As String
'    Dim password2 As String
'    Dim oldPass As String
'    Dim login As String
'    Dim Domain As String = "sbs.com\"
'    Dim path As String

'    '  Const path = "LDAP://OU=SBSASP,DC=LOCAL"

'    'constructor
'    Public Sub New(ByVal path As String, ByVal login As String, ByVal password1 As String, ByVal password2 As String, ByVal oldPass As String)

'        Me.path = path
'        Me.login = login
'        Me.password1 = password1
'        Me.password2 = password2
'        Me.oldPass = oldPass


'    End Sub


'    Function ChangePass()





'        Try

'            If password1 = password2 Then

'                MessageBox.Show(path)

'                '  Dim entry As DirectoryEntry = New DirectoryEntry("LDAP://OU=SBSASP,DC=LOCAL", "LOCAL\" & login, password1)
'                Dim entry As DirectoryEntry = New DirectoryEntry(path, Domain & login, oldPass)

'                '  entry.Username = "LOCAL\" & login
'                entry.Username = Domain & login
'                entry.Password = oldPass
'                entry.AuthenticationType = AuthenticationTypes.Secure
'                entry.Options.Referral = ReferralChasingOption.All
'                entry.Invoke("ChangePassword", oldPass, password1)
'                entry.CommitChanges()
'                ' lblSuccess.Visible = True
'                MessageBox.Show("Change Successful")
'                MessageBox.Show("Computer will restart")
'                System.Diagnostics.Process.Start("ShutDown", "/r /t 10")

'            Else
'                ' lblPassError.Visible = True
'                MessageBox.Show("Change Unsuccessful, password verification mismatch")
'                Return False
'            End If

'        Catch ex As IO.IOException
'            '  lblCatch.Text = "Error message: " + ex.InnerException.Message
'            '  lblCatch.Visible = True
'            '   MessageBox.Show(ex.Message)
'            MessageBox.Show("Password Change error" & ex.InnerException.Message)
'            Return False
'        End Try

'        Return True

'    End Function


'End Class
