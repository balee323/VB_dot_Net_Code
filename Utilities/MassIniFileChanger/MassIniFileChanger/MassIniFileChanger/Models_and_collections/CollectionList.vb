Public Class CollectionList

    'Tons of static stuff... there's no reason to do this.  I need to fix this and use class-level collections
    Public Shared SourceFolder As String = ""
    Public Shared WorkingFolder As String = ""
    Public Shared Section As String = ""

    Public Shared InISections As List(Of InISection) = New List(Of InISection)
    Public Shared WorkingFileList As List(Of String) = New List(Of String) 'contains the files that have meet criteria

End Class
