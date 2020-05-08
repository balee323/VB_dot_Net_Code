''' <summary>
''' creates a list of files, allows for file selection, and moves files to working directory
''' </summary>
Public Class ViewAndSelectOrginalFiles

    Private Files_in_FilePath As List(Of String)

    'where the original INI files are
    Private OriginalIniFilePath As String

    'File spec such as .txt, etc.
    Private filespec As String = "*.ini"

    Private RawFileList As List(Of String) 'contains all files in INI folder or INI config location(s)


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

        checkForSlash()

        Dim tempCollection As New List(Of String)
        Try
            tempCollection.AddRange(System.IO.Directory.GetFiles(OriginalIniFilePath, filespec))
        Catch ex As Exception
            MessageBox.Show("Ini Files cannot be located.")
        End Try


        For Each file As String In tempCollection
            'remove the full path and only have file name & extension
            RawFileList.Add(FileNameWithoutExtension(file) & ".ini")
        Next

    End Sub

    'remove file path
    Public Function FileNameWithoutExtension(ByVal FullPath As String) As String

        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)

    End Function


    Private Sub CreateRawFileList()

        Dim file As String
        For Each file In RawFileList
            CollectionList.WorkingFileList.Add(file) 'add to collection
        Next

    End Sub

    ''' <summary>
    ''' this functions seems to be repeated in this application...
    ''' </summary>
    Private Sub checkForSlash()

        If OriginalIniFilePath.Substring(OriginalIniFilePath.Length - 1, 1) <> "\" Then
            OriginalIniFilePath = OriginalIniFilePath + "\"
        End If

    End Sub

    'and this on too (function is repeated in program)
    Sub checkForSlash(FilePath)

        If FilePath.Substring(FilePath.Length - 1, 1) <> "\" Then
            FilePath = FilePath + "\"

        End If

    End Sub

    Public Function getRawFileList() As List(Of String)
        Return RawFileList
    End Function

End Class
