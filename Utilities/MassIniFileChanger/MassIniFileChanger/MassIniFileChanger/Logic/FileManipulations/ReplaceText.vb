Imports File = System.IO
Imports System.Text

Public Class ReplaceText



    Private WorkingFolder As String
    Private Section As String
    Private StoreNum As String


    Public Function Start(WorkingFolder As String, Section As String) As Integer
        Me.WorkingFolder = WorkingFolder
        Me.Section = Section

        checkForSlash()

        Try
            UpdateAllTextFiles()
        Catch ex As Exception
            MessageBox.Show("Modifying InI file(s) failed")
            Return 1

        End Try

        Return 0

    End Function

    'Reads form a file starting at a certain line "[Section]" and adds all lines to a collection list.  
    'Stops reading lines at a stop point "["



    Private Sub UpdateAllTextFiles()



        For Each inISection As InISection In CollectionList.InISections

            Dim keys As New List(Of String) 'keys

            keys.AddRange(inISection.getKeys) 'get all the keys for InISection Object
            StoreNum = inISection.getStoreNum
            Dim FileName As String = StoreNum + ".ini"

            'run update code...
            UpDateText(WorkingFolder, FileName, keys)


        Next

    End Sub

    Private Sub UpDateText(WorkingFolder As String, FileName As String, Keys As List(Of String))


        'Unit testing
        INIconfigUI.LstLog.Items.Add("File: " & FileName & "  Section: " & Section)
        '----------------

        Dim CurrentLine As String = ""
        Dim NewFile As New StringBuilder

        Dim iniFile As System.IO.StreamReader = New System.IO.StreamReader(WorkingFolder & FileName)

        'Building out the StringBuilder for the new File.



        Do While iniFile.Peek > -1
            CurrentLine = iniFile.ReadLine() 'advances next line
            NewFile.Append(CurrentLine & vbCrLf) 'Adds current line to StringBuilder

            If CurrentLine.ToUpper = (Section.ToUpper) Then 'start at the section and add each line
                CurrentLine = "" 'reset
                CurrentLine = iniFile.ReadLine()

                Do While iniFile.EndOfStream = False

                    If CurrentLine.Contains("[") Then 'Works
                        'Unit testing
                        INIconfigUI.LstLog.Items.Add("Next Section Found")
                        '--------------
                        NewFile.Append(vbCrLf)
                        Exit Do
                    Else

                        For Each value As String In Keys
                            If IsMatch(CurrentLine, value) = False Then  'If Current line in INI is not match current to INI section in Collection than just add INI key/value to string builder, loop to next INI section and next read line
                                NewFile.Append(value & vbCrLf)
                                CurrentLine = iniFile.ReadLine() 'skipping to next line in INI file after populating string builder with Current INI key/value
                            Else
                                NewFile.Append(CurrentLine & vbCrLf)  'If Current Line in INI file is match for a Key, then Add the key to StringBuilder
                            End If

                        Next

                        Do While Not CurrentLine.Contains("[")
                            CurrentLine = iniFile.ReadLine() 'removes extra lines if No comments option is selected.
                        Loop

                    End If

                    If CurrentLine.Contains("[") Then
                        NewFile.Append(vbCrLf) 'add blank line
                        NewFile.Append(CurrentLine) 'Adds current line to StringBuilder
                    End If
                Loop
            Else
                'Continue copying file lines to StringBuilder        
                CurrentLine = iniFile.ReadLine() 'advances next line
                NewFile.Append(CurrentLine & vbCrLf) 'Adds current line to StringBuilder
            End If
        Loop


        iniFile.Close() 'close the stream reader

        ' INIconfigUI.LstLog.Items.Add("String builder section Content: " + vbNewLine + NewFile.ToString())


        Try

            If Not My.Computer.FileSystem.DirectoryExists(WorkingFolder & "modified\") Then
                My.Computer.FileSystem.CreateDirectory(WorkingFolder & "modified\")
            End If

            'Create New File
            System.IO.File.WriteAllText(WorkingFolder & "modified\" & FileName, NewFile.ToString)

        Catch ex As Exception
            INIconfigUI.LstLog.Items.Add("error: " + ex.Message)
        End Try



    End Sub


  

    Private Function IsMatch(CurrentLine As String, LineToAppend As String) As Boolean

        If CurrentLine = LineToAppend Then
            Return True
        End If

        Return False
    End Function





    Private Function getStoreNum(FileName As String) As String
        Dim storeNum As String = "0000"
        Dim tempArray As String()

        tempArray = FileName.Split(".")

        storeNum = tempArray(0)
        '  MessageBox.Show(tempArray(0))


        Return storeNum
    End Function


    Private Sub checkForSlash()


        '   MessageBox.Show(IniFilePath)

        If WorkingFolder.Substring(WorkingFolder.Length - 1, 1) <> "\" Then
            WorkingFolder = WorkingFolder + "\"
        End If




        '  MessageBox.Show(IniFilePath)

    End Sub


End Class
