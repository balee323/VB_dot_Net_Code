Public Class PopulateInISectionCollection

    Private WorkingFolder As String
    Private Section As String
    Private StoreNum As String
    Private TxtLinesRead As Integer = 0
    Private WithComments As Boolean = True
    Private WorkingFileList As List(Of String)
    Private IsNewKeyValue As Boolean = False
    Private newKey As String = ""
    Private inISection As InISection
    Private RunOnce As Boolean = False
    Private keys As New List(Of String) 'keys

    Public Function Start(WorkingFolder As String, Section As String, WorkingFileList As List(Of String), WithComments As Boolean, IsNewKeyValue As Boolean, Optional newKey As String = "") As Integer


        Me.WorkingFolder = WorkingFolder
        Me.Section = Section
        Me.WithComments = WithComments
        Me.WorkingFileList = WorkingFileList
        Me.IsNewKeyValue = IsNewKeyValue
        Me.newKey = newKey

        Try
            getData()
        Catch ex As Exception
            MessageBox.Show("reading files and creating collection list failed")
            Return 1

        End Try

        Return 0

    End Function

    Public Function AddNewKeys(newKey As String) As Integer

        Me.newKey = newKey

        'TODO -- Not yet implemented.  Will take significant work...


        Try
            addNewKeys()
        Catch ex As Exception
            MessageBox.Show("Adding new key(s) failed.")
            Return 1

        End Try





        Return 0

    End Function






    Public Sub clearSectionValueCollection()
        CollectionList.InISections.Clear() 'clear for repopulations
    End Sub



    Private Sub getData()

        Dim RunAddNewFilesOnce As Boolean = False


        For Each fileName As String In CollectionList.WorkingFileList

            'Dim keys As New List(Of String) 'keys



            If RunOnce = False Then
                keys.AddRange(gatherKeys(WorkingFolder, fileName))
                RunOnce = True
            End If



            'adds new key to bottom
            If IsNewKeyValue And RunAddNewFilesOnce = False Then
                keys.Add(newKey)
                RunAddNewFilesOnce = True
            End If


            Dim i As Integer = 0
            While i < keys.Count

                'unit testing
                'If i < keys.Count Then
                '    INIconfigUI.LstLog.Items.Add("Added Values: " & keys.Item(i))
                'End If
                '-----------

                i = i + 1
            End While



            'create code to see if INISection Object Exists for Store
            If CollectionList.InISections.Count > 0 Then
                Dim ExistingINIsectionFound As Boolean = False
                For Each ExistingINIsection In CollectionList.InISections
                    If ExistingINIsection.getStoreNum = getStoreNum(fileName) Then
                        inISection = ExistingINIsection
                        ExistingINIsectionFound = True
                    End If
                Next
                If ExistingINIsectionFound = False Then 'Addes new INIsection object if Object not found above
                    inISection = New InISection(Section, keys, getStoreNum(fileName))

                    'add TxtLines Read
                    inISection.SetTxtLinesRead(TxtLinesRead)

                    'add object to collection
                    CollectionList.InISections.Add(inISection)

                End If
            Else
                'create INISection Object (runs only once)
                inISection = New InISection(Section, keys, getStoreNum(fileName))

                'add TxtLines Read
                inISection.SetTxtLinesRead(TxtLinesRead)

                'add object to collection
                CollectionList.InISections.Add(inISection)


            End If



            'add TxtLines Read
            'inISection.SetTxtLinesRead(TxtLinesRead)

            'add object to collection
            ' CollectionList.InISections.Add(inISection)

        Next

    End Sub

    'HACK -- Gather Keys per File
    'Per File
    Private Function gatherKeys(WorkingFolder As String, FileName As String) As List(Of String)

        Dim FoundKeyValuePairs As New List(Of String)
        'Unit testing
        ' INIconfigUI.LstLog.Items.Add("File: " & FileName & "  Section: " & Section)
        '----------------

        Dim CurrentLine As String = ""

        Dim r As System.IO.StreamReader = New System.IO.StreamReader(WorkingFolder & "\" & FileName)

        Do While r.EndOfStream = False
            CurrentLine = r.ReadLine
            If CurrentLine.ToUpper = (Section.ToUpper) Then 'start at the section and add each line
                CurrentLine = ""
                Do While r.EndOfStream = False
                    CurrentLine = r.ReadLine ' advances to next line
                    TxtLinesRead = TxtLinesRead + 1 'iterates for each line read
                    'Unit testing
                    'INIconfigUI.LstLog.Items.Add("Current Line: " & CurrentLine)
                    If WithComments = True Then
                        If Not ((CurrentLine.Contains("[") Or CurrentLine = "")) Then 'Will add comment line
                            FoundKeyValuePairs.Add(CurrentLine)
                            'unit testing
                            INIconfigUI.LstLog.Items.Add("Line Added: " & CurrentLine)
                        Else
                            'Unit testing
                            INIconfigUI.LstLog.Items.Add("Line Not added")
                            '-------------
                        End If
                    ElseIf WithComments = False Then
                        If Not (CurrentLine.Contains("[") Or CurrentLine.Contains(";") Or CurrentLine = "") Then 'Will skip comment line
                            FoundKeyValuePairs.Add(CurrentLine)
                            'unit testing
                            INIconfigUI.LstLog.Items.Add("Line Added: " & CurrentLine)
                        Else
                            'Unit testing
                            INIconfigUI.LstLog.Items.Add("Line Not added")
                            '-------------
                        End If

                    End If
                    If CurrentLine.Contains("[") Then 'Works
                        'Unit testing
                        ' INIconfigUI.LstLog.Items.Add("Next Section Found")
                        '--------------
                        r.Close() 'close the stream reader
                        Return FoundKeyValuePairs 'since at the end of the Section
                    End If

                Loop
            End If
        Loop

        r.Close() 'close the stream reader
        Return FoundKeyValuePairs
    End Function




    Private Function getStoreNum(FileName As String) As String
        Dim storeNum As String = "0000"
        Dim tempArray As String()

        tempArray = FileName.Split(".")

        storeNum = tempArray(0)
        '  INIconfigUI.LstLog.Items.Add(tempArray(0))


        Return storeNum
    End Function

    Private Sub addNewKeys()
        Throw New NotImplementedException
    End Sub





End Class
