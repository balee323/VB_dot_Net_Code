Imports System
Imports System.Text
Imports System.Collections
Imports System.DirectoryServices
Imports System.Security.Principal

Public Class LdapAuthentication

    'private fields
    Dim _filterAttribute As String

    Dim username As String
    Dim password1 As String
    Dim password2 As String
    Dim oldPass As String
    Dim Domain As String
    Dim path As String

    Dim entry As DirectoryEntry

    '1 instance
    Dim myLog As EventLog


    'constructor
    Public Sub New(ByVal path As String)
        Me.path = path
        ' MessageBox.Show("Constructor invoked")
    End Sub

    'constructor
    Public Sub New(ByVal domain As String, ByVal username As String, ByVal oldPass As String, ByVal newPass1 As String, ByVal newPass2 As String)

        Me.username = username
        Me.oldPass = oldPass
        Me.password1 = newPass1
        Me.password2 = newPass2
        Me.Domain = domain



        myLog = New EventLog()

        If Not EventLog.SourceExists("SBS Active Directory Password Changer") Then
            EventLog.CreateEventSource("SBS Active Directory Password Changer", "SBS Password Changer")
            ' Console.WriteLine("CreatingEventSource")
        End If


        entry = New DirectoryEntry()

        ' entry.UsePropertyCache = True 'not sure what this does yet... 
        entry.Username = Me.username
        entry.Password = Me.oldPass
        '    MessageBox.Show("Default Constructor invoked")
    End Sub

    Public Function IsAuthenticated() As Boolean

        Try
            'Bind to the native AdsObject to force authentication.	
            Dim obj As Object = entry.NativeObject

            Dim search As DirectorySearcher = New DirectorySearcher(entry)
            search.Filter = "(SAMAccountName=" & username & ")"
            search.PropertiesToLoad.Add("cn")

            Dim result As SearchResult = search.FindOne()
            If (result Is Nothing) Then
                Return False
            End If

            'Update the new path to the user in the directory.
            path = result.Path
            '        MessageBox.Show(path)
            '  result.GetDirectoryEntry()  '?

            '        MessageBox.Show("domain: " + Domain)
            _filterAttribute = CType(result.Properties("cn")(0), String)

        Catch ex As Exception
            'Throw New Exception(ex.Message)
            MessageBox.Show("Error authenticating user. " & ex.Message)
            myLog.Source = "SBS Active Directory Password Changer"
            myLog.WriteEntry("Error authenticating user. " & ex.Message)
            Return False

        End Try

        Return True
    End Function

    Public Function GetGroups() As String


        '  Dim search As DirectorySearcher = New DirectorySearcher(path)
        Dim search As DirectorySearcher = New DirectorySearcher(entry.Path)
        search.Filter = "(cn=" & username & _filterAttribute & ")"
        '   search.Filter = "(ou=Terminal Services" & _filterAttribute & ")"  '

        search.PropertiesToLoad.Add("memberOf")
        Dim groupNames As StringBuilder = New StringBuilder()

        Try
            Dim result As SearchResult = search.FindOne()
            Dim propertyCount As Integer = result.Properties("memberOf").Count

            Dim dn As String
            Dim equalsIndex As Integer
            Dim commaIndex As Integer

            Dim propertyCounter As Integer

            For propertyCounter = 0 To propertyCount - 1
                dn = CType(result.Properties("memberOf")(propertyCounter), String)

                equalsIndex = dn.IndexOf("=", 1)
                commaIndex = dn.IndexOf(",", 1)
                If (equalsIndex = -1) Then
                    Return Nothing
                End If

                groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
                groupNames.Append("|")
            Next

        Catch ex As Exception
            '  Throw New Exception("Error obtaining group names. " & ex.Message)

            myLog.Source = "SBS Active Directory Password Changer"
            myLog.WriteEntry("Error obtaining group names. " & ex.Message)
        End Try

        Return groupNames.ToString()
    End Function

    Function ChangePass() As Boolean



        Try

            If password1 = password2 And password1 <> Nothing Then

                '  MessageBox.Show(path)
                '  Dim entry As DirectoryEntry = New DirectoryEntry("LDAP://OU=SBSASP,DC=LOCAL", "LOCAL\" & login, password1)
                '   Dim entry As DirectoryEntry = New DirectoryEntry(path, Domain & login, oldPass)
                '  entry.Username = "LOCAL\" & login

                entry.Path = path
                entry.Username = Domain + "\" + username


                entry.AuthenticationType = AuthenticationTypes.Secure
                entry.Options.Referral = ReferralChasingOption.All
                entry.RefreshCache()

                'inner try
                Try

                    'entry.Properties("LockOutTime").Value = 0 'removes the lockout
                    'entry.Properties("pwdLastSet").Value = 0   '(-1) makes user reset password at next login. to turn on set to 0
                    'entry.Properties("Minimum password age").Value = 0
                    'entry.Properties("Password must meet complexity requirements").Value = "disabled"
                    'entry.Properties("Enforce password history").Value = 0
                    ' entry.Invoke("SetPassword", password1) 'access is denied

                    entry.Invoke("ChangePassword", oldPass, password1)
                    entry.CommitChanges()
                    ' lblSuccess.Visible = True
                    entry.Close() 'did not have this before
                    MessageBox.Show("Change Successful")
                    MessageBox.Show("You will now be logged off.")
                    System.Diagnostics.Process.Start("ShutDown", "/l")


                Catch ex As Exception

                    MessageBox.Show("Password Change error 1: " & ex.InnerException.Message)
                    myLog.Source = "SBS Active Directory Password Changer"
                    myLog.WriteEntry("Password Change error 1: " & ex.InnerException.Message)

                    Return False

                End Try
                'inner try


            Else
                ' lblPassError.Visible = True
                MessageBox.Show("Change Unsuccessful, password verification mismatch, or blank")

                myLog.Source = "SBS Active Directory Password Changer"
                myLog.WriteEntry("Change Unsuccessful, password verification mismatch, or blank")


                Return False
            End If

        Catch ex As IO.IOException

            MessageBox.Show("Other Password Change error 2: " & ex.InnerException.Message)

            myLog.Source = "SBS Active Directory Password Changer"
            myLog.WriteEntry("Other Password Change error 2: " & ex.InnerException.Message)


            Return False
        End Try

        Return True

    End Function




End Class
