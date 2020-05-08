Imports System.Windows.Forms

Public Class FolderSelectDialog

    Dim showDefaultLocation As Boolean = False
    Dim UseDefault As Boolean = False
    Dim UseOtherLocation As Boolean = False
    Dim FileLocation As String = ""


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        LayoutSetup()
    End Sub

    Public Sub New(showDefaultLocation As Boolean)
        Me.showDefaultLocation = showDefaultLocation

        ' This call is required by the designer.
        InitializeComponent()
        LayoutSetup()
    End Sub


    Private Sub LayoutSetup()
        Panel2.Parent = Me

        If showDefaultLocation Then
            Me.Panel1.Visible = True
            Me.Panel2.Visible = False
            Me.Text = "Select source INI directory."
        ElseIf showDefaultLocation = False Then
            Me.Panel1.Visible = False
            Me.Panel2.Visible = True
            Me.Text = "Select working directory."
        End If
    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Panel1.Visible Then
            If RBtnUseESD.Checked Then
                UseDefault = True
            ElseIf RBtnChooseLocation.Checked Then
                UseOtherLocation = True
            End If
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Public Function GetLocation() As String
        If UseDefault Then
            FileLocation = "C:\temp\IniFileChanger\"
        End If

        checkForSlash(FileLocation)
        Return FileLocation

    End Function

    'more repeated code...
    Private Sub checkForSlash(directory As String)
        If directory.Substring(directory.Length - 1, 1) <> "\" Then
            directory = directory + "\"
        End If
    End Sub


    Private Sub RBtnChooseLocation_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBtnChooseLocation.CheckedChanged
        If RBtnChooseLocation.Checked Then
            Dim fileSelectDialog As New FolderBrowserDialog
            fileSelectDialog.ShowDialog()
            FileLocation = fileSelectDialog.SelectedPath
        End If
    End Sub


    Private Sub BtnChoose_Click(sender As System.Object, e As System.EventArgs)
        Dim fileSelectDialog As New FolderBrowserDialog
        fileSelectDialog.ShowDialog()
        FileLocation = fileSelectDialog.SelectedPath
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        FileLocation = "C:\temp\IniFileChanger\WorkingFolder\"
    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Dim fileSelectDialog As New FolderBrowserDialog
            fileSelectDialog.ShowDialog()
            FileLocation = fileSelectDialog.SelectedPath
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            FileLocation = "C:\temp\IniFileChanger\WorkingFolder\"
        End If
    End Sub


End Class
