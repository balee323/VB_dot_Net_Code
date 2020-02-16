Public Class CheckFile

    'load criteria from INI file or from the user interface...

    'checks citeria for 1 file at a time, if passed, moves the file to working folder


    Private InIFilePath As String = ""
    Private FileSpec As String = ".ini"

    Private File As String = ""
    Private Section As String = ""


    'no param constructor
    Public Sub New()

    End Sub

  

    'per file with single Section
    Public Function VerifyFile(IniFilePath As String, File As String, Section As String) As Boolean

        Me.File = File
        Me.InIFilePath = IniFilePath
        Me.Section = Section

        ' Dim Passed As Boolean = False

        Dim itemsFound As Integer = 0
        Dim FileToAdd As String = ""

        'run the validation for the INI section
        itemsFound = CheckForDuplicates()


        If itemsFound > 0 And itemsFound < 2 Then  'can only find one

            FileToAdd = File
            INIconfigUI.LstLog.Items.Add("File added to working folder: " & File)
            Return True
        Else
            INIconfigUI.LstLog.Items.Add("File was not added to working folder: " & File)
        End If

        Return False

    End Function

    'For single Section
    Private Function CheckForDuplicates() As Integer


        Dim EndOfITems As Boolean = False
        Dim CurrentLine As String = ""
        Dim itemsFound As Integer

        checkForSlash()

        Using r As System.IO.StreamReader = New System.IO.StreamReader(InIFilePath & File)

            Do While r.EndOfStream = False
                CurrentLine = r.ReadLine
                If CurrentLine.ToUpper = (Section.ToUpper) Then


                    itemsFound = itemsFound + 1

                End If

            Loop
        End Using

        Return itemsFound

    End Function

   


    Private Sub checkForSlash()


        '    INIconfigUI.LstLog.Items.Add(InIFilePath)

        If InIFilePath.Substring(InIFilePath.Length - 1, 1) <> "\" Then
            InIFilePath = InIFilePath + "\"

        End If

        '     INIconfigUI.LstLog.Items.Add(InIFilePath)

    End Sub


End Class
