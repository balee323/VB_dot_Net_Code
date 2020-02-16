Imports System.Diagnostics
Imports System.IO
Imports System.Random



Public Class INIconfigUI

    Dim copyFilesToWorkingFolder As CopyFilesToWorkingFolder
    Dim populateInISections As PopulateInISectionCollection


    Dim changeValue As ChangeValueInINISection
    Dim replaceText As ReplaceText
    Dim checkToggle As Boolean = True
    Dim runOnce As Boolean = False
    Dim AreSectionValuesSaved As Boolean = False
    Dim AddingNewKey As Boolean = False
    Dim newKeyList As List(Of String)
    Private Sub INIconfigUI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine("Form Loaded")
        Btn_workingPath.Enabled = False

        LstLog.Items.Add("Application Loaded..." & Date.Now.ToString())
    End Sub






    Private Sub BtnINI_Source_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnINI_Source.Click

     

        Dim dialog As New FolderSelectDialog(True)
        dialog.ShowDialog()

    

        LstLog.Items.Add("Source Folder Dialog result: " + dialog.DialogResult.ToString)

        If dialog.DialogResult.ToString.ToUpper = "OK" Then
            CollectionList.SourceFolder = dialog.GetLocation()
            LstLog.Items.Add("Source Folder: " + dialog.GetLocation())

            Btn_workingPath.Enabled = True
        End If



        If dialog.DialogResult.ToString.ToUpper = "CANCEL" Then
            Btn_workingPath.Enabled = False
            Exit Sub
        End If





    End Sub

    Private Sub Btn_workingPath_Click_1(sender As System.Object, e As System.EventArgs) Handles Btn_workingPath.Click


        Dim dialog As New FolderSelectDialog(False)
        dialog.ShowDialog()





        LstLog.Items.Add("Working Folder Dialog result: " + dialog.DialogResult.ToString)

        If dialog.DialogResult.ToString.ToUpper = "OK" Then
            CollectionList.WorkingFolder = dialog.GetLocation()
            LstLog.Items.Add("Working Folder: " + dialog.GetLocation())
        End If

        If dialog.DialogResult.ToString.ToUpper = "CANCEL" Then
            Exit Sub
        End If



        completeFiltering()





    End Sub


    Private Sub completeFiltering()

        CheckLstBox_SelectionFiles.Items.Clear()
        Dim rawFileList As List(Of String)

        Dim viewAndSelectOrginalFiles As New ViewAndSelectOrginalFiles(CollectionList.SourceFolder)


        rawFileList = viewAndSelectOrginalFiles.getRawFileList()

        For Each fileName In rawFileList
            CheckLstBox_SelectionFiles.Items.Add(fileName)  'Adding to CheckBoxList
        Next

        Me.BtnCheckUncheck.PerformClick() 'toggle all as true

        If rawFileList.Count < 1 Then
            MsgBox("No INI files Found in source directory.")
        End If

    End Sub



    Private Sub BtnSave_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click


        If CheckLstBox_INI_Section_values.CheckedItems.Count < 1 And AddingNewKey = False Then
            MessageBox.Show("error, no Key/value pair selected")
            Exit Sub
        Else


        'Repopulates Collection for INI sections for each File(s)
        'Makes change to INI section key/value pair

        runOnce = False
        ChkBox_withoutComments.Enabled = False

        'Saves to collection List

        Dim ErrorLevel As Integer = 0

        Dim WithComments As Boolean = True

        'Occurs first Time Function is run, unless reset
        If AreSectionValuesSaved = False Then
            populateInISections = New PopulateInISectionCollection
            populateInISections.clearSectionValueCollection() 'Clears collection
            AreSectionValuesSaved = True
        End If


        If ChkBox_withoutComments.Checked Then
            WithComments = False
        End If



        'TODO -- implement CreateMissingSesctionAndValue 
        Dim CreateMissingSectionAndvalue As Boolean = False
        If CheckBox2.Checked Then
            CreateMissingSectionAndvalue = True
        End If

       

        'repopulate INI sections in Collection List
        ErrorLevel = populateInISections.Start(CollectionList.WorkingFolder, TxtBoxSection.Text, CollectionList.WorkingFileList, WithComments, AddingNewKey, TxtBoxKeyAndValue.Text)
        ' ErrorLevel = populateInISections.AddNewValues(TxtBoxKeyAndValue.Text)



        'If CheckLstBox_INI_Section_values.CheckedItems.Count < 1 And AddingNewKey = False Then
        '    MessageBox.Show("error, no Key/value pair selected")
        '    Exit Sub
        'Else


        For Each File In CollectionList.WorkingFileList
            Me.LstLog.Items.Add("Searching for values to Change")
            changeValue = New ChangeValueInINISection(TxtBoxKeyAndValue.Text, getStoreNum(File))
        Next


        Me.LstLog.Items.Add("Errorlevel: " + ErrorLevel.ToString())
        If ErrorLevel < 1 Then
            btnRun.Enabled = True
            BtnAddKey.Enabled = True
            TxtBoxKeyAndValue.Enabled = False

            BtnClearSectionSelection.PerformClick()

            MsgBox("Saved")
            LstLog.Items.Add("Key value saved: " + TxtBoxKeyAndValue.Text)
        End If

        End If

        AddingNewKey = False
        LstLog.Items.Add("INI key Collection List Object count: " + CollectionList.InISections.Count.ToString())



    End Sub

    Private Sub addNewValues()

        newKeyList.Add(TxtBoxKeyAndValue.Text)

    End Sub

    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click

        Dim ErrorLevel As Integer = 0

        btnRun.Enabled = False


        replaceText = New ReplaceText()
        ErrorLevel = ErrorLevel + replaceText.Start(CollectionList.WorkingFolder, CollectionList.Section)


        If ErrorLevel < 1 Then
            MsgBox("Complete")
        Else
            MsgBox("An Error has occured")
        End If



    End Sub

    Private Sub BtnExit_Click(sender As System.Object, e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub


    Private Function getStoreNum(FileName As String) As String
        Dim storeNum As String = "0000"
        Dim tempArray As String()

        tempArray = FileName.Split(".")

        storeNum = tempArray(0)
        '  MessageBox.Show(tempArray(0))


        Return storeNum
    End Function


    Private Sub BtnViewValuesForSection_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnViewValuesForSection.Click

        BtnClearSectionSelection.PerformClick()

        BtnAddKey.Enabled = True

        If CheckLstBox_SelectionFiles.CheckedItems.Count < 1 Then
            MsgBox("Error, no files selected.")
            Return
        ElseIf TxtBoxSection.Text.Length < 1 Then
            MsgBox("Error, INI section not Entered.")
            Return
        End If



        CheckLstBox_INI_Section_values.Items.Clear()

        CollectionList.Section = IsSection(TxtBoxSection.Text)

        Dim ErrorLevel As Integer = 0

        populateInISections = New PopulateInISectionCollection


        ErrorLevel = populateInISections.Start(CollectionList.WorkingFolder, CollectionList.Section, CollectionList.WorkingFileList, True, AddingNewKey)


        Dim i As Integer = 0
        While i < CollectionList.InISections(0).getKeys.Count


            'Instead of doing this, create template file, then read it in.
            '  Dim key As String = ""
            ' key = getKeyOrValue(CollectionList.InISections(0).getKeys(i), 0)
            ' CheckLstBox_INI_Section_values.Items.Add(key) 'Select Top file, get keys
            '================================================================================

            CheckLstBox_INI_Section_values.Items.Add(CollectionList.InISections(0).getKeys(i)) 'Select Top file, get keys


            i = i + 1
        End While




        If ErrorLevel < 1 Then
            '   MessageBox.Show("Complete")

        Else
            MessageBox.Show("An Error has occured")
        End If


    End Sub


    Private Function IsSection(section As String) As String

        Dim ends As String = (section.Substring(0, 1) + section.Substring(section.Length - 1, 1))

        If Not ends = "[]" Then
            LstLog.Items.Add("section not in proper format, adding brackets.")
            section = ("[" + section + "]").ToUpper()
            LstLog.Items.Add(section)
        End If


        Return section
    End Function




    Private Function getKeyOrValue(keyAndValue As String, ReturnedSplitElement As Integer) As String

        Dim Key As String = ""

        Dim tempStrSplit As String()
        tempStrSplit = keyAndValue.Split("=")


        If ReturnedSplitElement <= tempStrSplit.Length Then
            Key = tempStrSplit(ReturnedSplitElement)

        End If


        Return Key
    End Function


    Private Sub CheckLstBox_INI_Section_values_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckLstBox_INI_Section_values.SelectedIndexChanged



        If CheckLstBox_INI_Section_values.SelectedItems.Count > 0 Then
            BtnAddKey.Enabled = False

            If runOnce = False Then

                BtnRemoveKey.Enabled = True
                TxtBoxKeyAndValue.Enabled = True

                TxtBoxKeyAndValue.Text = CheckLstBox_INI_Section_values.SelectedItem.ToString
                ' lblKey.Text = CheckLstBox_INI_Section_values.SelectedItem.ToString


                For i As Integer = 0 To CheckLstBox_INI_Section_values.Items.Count - 1 Step 1
                    If CheckLstBox_INI_Section_values.Items(i).ToString = TxtBoxKeyAndValue.Text Then
                        '  If CheckLstBox_INI_Section_values.Items(i).ToString = lblKey.Text Then
                        runOnce = True
                        CheckLstBox_INI_Section_values.SetItemChecked(i, True)
                    End If
                Next

                runOnce = True
                CheckLstBox_INI_Section_values.Enabled = False
            End If


        End If







    End Sub

    Private Sub TxtBoxSection_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBoxKeyAndValue.TextChanged
        CollectionList.Section = TxtBoxSection.Text

    End Sub

    Private Sub BtnCheckUncheck_Click(sender As System.Object, e As System.EventArgs) Handles BtnCheckUncheck.Click

        Dim i As Integer = 0


        While i < CheckLstBox_SelectionFiles.Items.Count
            CheckLstBox_SelectionFiles.SetItemChecked(i, checkToggle)
            i = i + 1
        End While


        If checkToggle Then
            checkToggle = False
        Else
            checkToggle = True
        End If




    End Sub


    Private Sub BtnCompleteFileSelections_Click_1(sender As System.Object, e As System.EventArgs) Handles BtnCompleteFileSelections.Click

        Dim i As Integer = 0
        Dim count As Integer = CheckLstBox_SelectionFiles.Items.Count

        While i < count
            If CheckLstBox_SelectionFiles.GetItemCheckState(i) = CheckState.Unchecked Then
                CheckLstBox_SelectionFiles.Items.RemoveAt(i)
                count = count - 1  'remove 1 from total count since 1 item is removed
                i = i - 1  'iteration starts back at zero because 1 item is removed
            End If
            i = i + 1
        End While

        Dim selectionFileList As New List(Of String)

        For Each item In CheckLstBox_SelectionFiles.Items
            selectionFileList.Add(item)
        Next

        '  Dim copyFilesToWorkingFolder As New CopyFilesToWorkingFolder("C:\temp\IniFileChanger", selectionFileList)
        '  Dim copyFilesToWorkingFolder As New CopyFilesToWorkingFolder("C:\temp\IniFileChanger", selectionFileList)
        Dim copyFilesToWorkingFolder As New CopyFilesToWorkingFolder(CollectionList.SourceFolder, selectionFileList, CollectionList.WorkingFolder)

        BtnViewValuesForSection.Enabled = True


        If selectionFileList.Count > 0 Then

            Dim coolStuff As New CoolStuff()

            coolStuff.TransitionEffect1(LblFileMovedStatus, "Files copied to working folder", Me)
            
        End If

    End Sub

    Private Sub BtnClearSectionSelection_Click(sender As System.Object, e As System.EventArgs) Handles BtnClearSectionSelection.Click
        TxtBoxKeyAndValue.Clear()
        TxtBoxKeyAndValue.Enabled = False
        CheckLstBox_INI_Section_values.Enabled = True
        runOnce = False
        AddingNewKey = False
        BtnAddKey.Enabled = True
        BtnRemoveKey.Enabled = False

        If AreSectionValuesSaved = False Then
            ChkBox_withoutComments.Enabled = True
            ChkBox_withoutComments.Checked = False
        End If


        Dim i As Integer = 0
        While i < CheckLstBox_INI_Section_values.Items.Count
            CheckLstBox_INI_Section_values.SetItemChecked(i, False)
            i = i + 1
        End While

    End Sub




    Private Sub BtnClearLog_Click(sender As System.Object, e As System.EventArgs) Handles BtnClearLog.Click
        LstLog.Items.Clear()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnRemoveKey_Click(sender As System.Object, e As System.EventArgs) Handles BtnRemoveKey.Click

        BtnRemoveKey.Enabled = False

        TxtBoxKeyAndValue.Text = TxtBoxKeyAndValue.Text + "***REMOVE"

    End Sub

    Private Sub BtnAddKey_Click(sender As System.Object, e As System.EventArgs) Handles BtnAddKey.Click

        BtnAddKey.Enabled = False
        newKeyList = New List(Of String)


        CheckLstBox_INI_Section_values.Enabled = False
        TxtBoxKeyAndValue.Enabled = True
        AddingNewKey = True

        TxtBoxKeyAndValue.Clear()



    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As System.Object, e As System.EventArgs)

    End Sub
End Class

