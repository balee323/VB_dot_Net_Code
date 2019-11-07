Imports Microsoft.VisualBasic.ControlChars
Imports System.DirectoryServices.DirectoryEntry
Imports System.DirectoryServices
Imports System.Diagnostics.EventLog
Imports System.Security.Principal



Public Class Form2

    'private fields

    Dim userid As String
    Dim password1 As String
    Dim password2 As String
    '  Dim check As String
    Dim path_ As String
    Dim Domain As String = "sbsasp.local"

    'keep 1 instance
    Dim myLog As New EventLog()

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


    '    Dim entry As DirectoryEntry = New DirectoryEntry("LDAP://OU=SBSASP,DC=LOCAL", "LOCAL\" & userid, password)

    '    Try

    '        Dim search As DirectorySearcher = New DirectorySearcher(entry)
    '        search.SearchScope = SearchScope.Subtree
    '        search.Filter = "(SAMAccountName=" & userid & ")"
    '        Dim result As SearchResult = search.FindOne()

    '        check = CType(result.Properties("sAMAccountName")(0), String)
    '        If check <> Nothing Then

    '            If check = userid Then
    '                If txtNewPass1.Text = txtNewPass2.Text Then
    '                    entry = result.GetDirectoryEntry()
    '                    entry.Username = "LOCAL\" & check
    '                    entry.Password = txtOldPass.Text
    '                    entry.AuthenticationType = AuthenticationTypes.Secure
    '                    entry.Options.Referral = ReferralChasingOption.All
    '                    entry.Invoke("ChangePassword", txtOldPass.Text, txtNewPass1.Text)
    '                    entry.CommitChanges()
    '                    lblSuccess.Visible = True

    '                Else
    '                    lblPassError.Visible = True
    '                End If

    '            Else
    '                lblError.Visible = True
    '            End If
    '        Else
    '            lblError.Visible = True
    '        End If
    '    Catch ex As Exception
    '        lblCatch.Text = "Error message: " + ex.InnerException.Message
    '        lblCatch.Visible = True
    '    End Try


    'End Sub


    '======================

    'Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    '    userid = txtLogin.Text
    '    password = txtOldPass.Text

    'End Sub


    '<STAThread()> Shared Sub Main()




    '    Const ADS_OPTION_PASSWORD_PORTNUMBER As Long = 6
    '    Const ADS_OPTION_PASSWORD_METHOD As Long = 7

    '    Const ADS_PASSWORD_ENCODE_REQUIRE_SSL As Integer = 0
    '    Const ADS_PASSWORD_ENCODE_CLEAR As Integer = 1



    '    Dim AuthTypes As AuthenticationTypes  ' Authentication flags.
    '    Dim intPort As Integer                ' Port for instance.
    '    Dim objUser As DirectoryEntry         ' User object.
    '    Dim strPath As String                 ' Binding path.
    '    Dim strPort As String                 ' Port for instance.
    '    Dim strServer As String               ' DNS Name of the computer with 
    '    '  the AD LDS installation.
    '    Dim strUser As String                 ' User DN.



    '    ' Construct the binding string.
    '    strServer = "localhost"
    '    strPort = "389"
    '    strUser = "CN=BrianL,O=Fabrikam,C=US"
    '    strPath = String.Concat("LDAP://OU=SBSASP", _
    '                  strServer, ":", strPort, _
    '                  "/", strUser)
    '    Console.WriteLine("Bind to:  {0}", strPath)

    '    ' Set the authentication flags.
    '    ' For non-secure connection, use LDAP port and
    '    '  ADS_USE_SIGNING |
    '    '  ADS_USE_SEALING |
    '    '  ADS_SECURE_AUTHENTICATION
    '    ' For secure connection, use SSL port and
    '    '  ADS_USE_SSL | ADS_SECURE_AUTHENTICATION
    '    AuthTypes = AuthenticationTypes.Signing Or _
    '                AuthenticationTypes.Sealing Or _
    '                AuthenticationTypes.Secure

    '    ' Bind to user object using LDAP port.
    '    Try
    '        objUser = New DirectoryEntry( _
    '            strPath, Nothing, Nothing, AuthTypes)
    '        objUser.RefreshCache()
    '    Catch e As Exception
    '        Console.WriteLine("Error:   Bind failed.")
    '        Console.WriteLine("         {0}.", e.Message)
    '        Return
    '    End Try

    '    ' Set port number, method, and password.
    '    intPort = Int32.Parse(strPort)
    '    Try
    '        ' Be aware that, for security, a password should
    '        '  not be entered in code, but should be obtained
    '        '  from the user interface.
    '        objUser.Invoke("SetOption", _
    '            New Object() {ADS_OPTION_PASSWORD_PORTNUMBER, intPort})
    '        objUser.Invoke("SetOption", _
    '            New Object() {ADS_OPTION_PASSWORD_METHOD, _
    '                          ADS_PASSWORD_ENCODE_CLEAR})
    '        objUser.Invoke("SetPassword", _
    '            New Object() {"ADAMComplexPassword1234"})
    '    Catch e As Exception
    '        Console.WriteLine("Error:   Set password failed.")
    '        Console.WriteLine("         {0}.", e.Message)
    '        Return
    '    End Try

    '    Console.WriteLine("Success: Password set.")
    '    Return

    'End Sub 'Main


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        lblError.Visible = False
        lblSuccess.Visible = False
        lblPassError.Visible = False
        lblCatch.Visible = False


        txtOldPass.PasswordChar = "*"c
        txtNewPass1.PasswordChar = "*"c
        txtNewPass2.PasswordChar = "*"c

        If Not EventLog.SourceExists("SBS Active Directory Password Changer") Then
            EventLog.CreateEventSource("SBS Active Directory Password Changer", "SBS Password Changer")
            ' Console.WriteLine("CreatingEventSource")
        End If






    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        lblError.Visible = False
        userid = txtLogin.Text()
        password1 = txtNewPass1.Text()
        password2 = txtNewPass2.Text()


        Dim result As Integer = MessageBox.Show("Please be aware upon successful password change, you will be logged off.", "Password Changer", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then



            Dim Authenticated As Boolean = False
            Dim changed As Boolean = False

            Dim Auth As New LdapAuthentication(Domain, userid, txtOldPass.Text(), password1, password2)


            Authenticated = Auth.IsAuthenticated()

            If Authenticated Then

                MessageBox.Show("Authenticated")
                '  ChangePass() 'not using

                '      MessageBox.Show("User Group: " & Auth.GetGroups())

                changed = Auth.ChangePass()

                If changed Then

                    lblSuccess.Visible = True

                Else
                    lblError.Visible = True

                End If



            Else
                MessageBox.Show("Please confirm login, domain, and password")
                lblError.Visible = True


                myLog.Source = "SBS Active Directory Password Changer"
                myLog.WriteEntry("Autentication error, Please confirm login, domain, and password.")




            End If

        End If
    End Sub




    'Function AuthenticateUser(path As String, user As String, pass As String) As Boolean
    '    Dim de As New DirectoryEntry(path, user, pass, AuthenticationTypes.Secure)
    '    Try
    '        'run a search using those credentials.  
    '        'If it returns anything, then you're authenticated
    '        Dim ds As DirectorySearcher = New DirectorySearcher(de)
    '        ds.FindOne()
    '        Return True
    '    Catch
    '        'otherwise, it will crash out so return false
    '        MessageBox.Show("authentication failed")
    '        Return False
    '    End Try
    'End Function


    'Sub ChangePass()

    '    Try
    '        If password = txtNewPass2.Text() Then

    '            Dim entry As DirectoryEntry = New DirectoryEntry("LDAP://OU=SBSASP,DC=LOCAL", "LOCAL\" & userid, password)

    '            entry.Username = "LOCAL\" & txtLogin.Text()
    '            entry.Password = txtOldPass.Text
    '            entry.AuthenticationType = AuthenticationTypes.Secure
    '            entry.Options.Referral = ReferralChasingOption.All
    '            entry.Invoke("ChangePassword", txtOldPass.Text, txtNewPass1.Text)
    '            entry.CommitChanges()
    '            lblSuccess.Visible = True

    '        Else
    '            lblPassError.Visible = True
    '        End If

    '    Catch ex As Exception
    '        lblCatch.Text = "Error message: " + ex.InnerException.Message
    '        lblCatch.Visible = True
    '    End Try


    'End Sub




    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

   
    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim temp As String
        temp = InputBox("enter new domain.  " + "current domain: " + Domain, "Change Domain")

        If temp <> "" Then
            Domain = temp
        End If

    End Sub
End Class