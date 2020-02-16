Public Class ViewAndSelectOrginalFiles


    'Class creates a list of files, allows for file selection, and moves files to working directory

    'members

    Private Files_in_FilePath As List(Of String)

    'where the original INI files are
    Private OriginalIniFilePath As String

    'File spec such as .txt, etc.
    Private filespec As String = "*.ini"

    '
    Private RawFileList As List(Of String) 'contains all files in INI folder or INI config location(s)


    'parameter constructor
    Public Sub New(OriginalIniFilePath As String)

        Me.OriginalIniFilePath = OriginalIniFilePath

        RawFileList = New List(Of String)

        checkForSlash()
        FindRawFiles() 'add raw files in InI file directory
        CreateRawFileList() 'add working files to collectionList


    End Sub

    Public Sub SetFileLocation(fileLocation As String)

        Me.OriginalIniFilePath = fileLocation


    End Sub


    Private Sub FindRawFiles()
        'Me.IniFilePath = IniFilePath

        checkForSlash()


        Dim tempCollection As New List(Of String)

        tempCollection.AddRange(System.IO.Directory.GetFiles(OriginalIniFilePath, filespec))



        For Each file As String In tempCollection
            'remove the full path and only have file name & extension
            RawFileList.Add(FileNameWithoutExtension(file) & ".ini")
            ' INIconfigUI.LstLog.Items.Add("Added file: " + file.ToString())
        Next



    End Sub

    'remove file path
    Public Function FileNameWithoutExtension(ByVal FullPath _
        As String) As String

        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)


    End Function


    Private Sub CreateRawFileList()

        Dim file As String
        For Each file In RawFileList
            CollectionList.WorkingFileList.Add(file) 'add to collection
        Next


    End Sub


    Private Sub checkForSlash()


        '   INIconfigUI.LstLog.Items.Add(IniFilePath)

        If OriginalIniFilePath.Substring(OriginalIniFilePath.Length - 1, 1) <> "\" Then
            OriginalIniFilePath = OriginalIniFilePath + "\"
        End If


        '  INIconfigUI.LstLog.Items.Add(IniFilePath)

    End Sub


    Sub checkForSlash(FilePath)


        '  INIconfigUI.LstLog.Items.Add(FilePath)

        If FilePath.Substring(FilePath.Length - 1, 1) <> "\" Then
            FilePath = FilePath + "\"

        End If

        '   INIconfigUI.LstLog.Items.Add(FilePath)

    End Sub

    Public Function getRawFileList() As List(Of String)
        Return RawFileList
    End Function

End Class
