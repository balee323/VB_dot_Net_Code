''' <summary>
''' creates a list of files that match file spec (.ini) and puts the raw file 
''' </summary>
Public Class CopyFilesToWorkingFolder

    'TODO  --  separate out the logic for populating INI collections

    Private ListOfWorkingFiles As List(Of String)

    'where the original INI files are
    Private OriginalIniFilePath As String

    'File spec such as .txt, etc.
    Private filespec As String = "*.ini"

    'object that searches for criteria in file and if met, adds to collectionList
    Private searchFiles As CheckFile

    'where the files that will be modified are stored
    Private workingFolder As String = ""

    'Ini Section
    Private Section As String = ""

    Public Sub New(OriginalIniFilePath As String, ListOfWorkingFiles As List(Of String), WorkingFolder As String)

        Me.ListOfWorkingFiles = ListOfWorkingFiles
        Me.OriginalIniFilePath = OriginalIniFilePath
        Me.workingFolder = WorkingFolder
        Section = CollectionList.Section

        'TODO -- Consider put file check in different area...    
        searchFiles = New CheckFile()

        CollectionList.InISections.Clear()
        CollectionList.WorkingFileList.Clear()

        checkForSlash()
        CreateWorkingFileList() 'add working files to collectionList
        CopyWorkingFiles() 'copys selected working files to work directory

    End Sub

    Public Sub SetFileLocation(fileLocation As String)
        Me.OriginalIniFilePath = fileLocation
    End Sub


    'remove file path
    Public Function FileNameWithoutExtension(ByVal FullPath As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function


    Private Sub CreateWorkingFileList()

        Dim file As String
        For Each file In ListOfWorkingFiles

            'TODO -- Fix ore redesign the Section check for files in CreateWorkingFiles
            ' If searchFiles.VerifyFile(OriginalIniFilePath, file, Section) = True Then
            CollectionList.WorkingFileList.Add(file) 'add to collection
            '  End If
        Next

    End Sub

    ''' <summary>
    ''' makes a working folder directory and copy all files in the workingFile Collection to that folder
    ''' </summary>
    Private Sub CopyWorkingFiles()

        Dim File As String

        If My.Computer.FileSystem.DirectoryExists(workingFolder) = False Then
            My.Computer.FileSystem.CreateDirectory(workingFolder)
        End If

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(workingFolder)
            My.Computer.FileSystem.DeleteFile(foundFile)
        Next

        For Each File In CollectionList.WorkingFileList
            My.Computer.FileSystem.CopyFile(OriginalIniFilePath & File, workingFolder & File)
        Next

    End Sub


    Private Sub checkForSlash()

        If OriginalIniFilePath.Substring(OriginalIniFilePath.Length - 1, 1) <> "\" Then
            OriginalIniFilePath = OriginalIniFilePath + "\"
        End If

        If workingFolder.Substring(workingFolder.Length - 1, 1) <> "\" Then
            workingFolder = workingFolder + "\"
        End If

    End Sub


    Sub checkForSlash(FilePath)
        If FilePath.Substring(FilePath.Length - 1, 1) <> "\" Then
            FilePath = FilePath + "\"

        End If
    End Sub


End Class
