<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INIconfigUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblFileMovedStatus = New System.Windows.Forms.Label()
        Me.BtnCompleteFileSelections = New System.Windows.Forms.Button()
        Me.CheckLstBox_SelectionFiles = New System.Windows.Forms.CheckedListBox()
        Me.BtnCheckUncheck = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Btn_workingPath = New System.Windows.Forms.Button()
        Me.BtnINI_Source = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAddKey = New System.Windows.Forms.Button()
        Me.BtnRemoveKey = New System.Windows.Forms.Button()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.BtnClearSectionSelection = New System.Windows.Forms.Button()
        Me.BtnViewValuesForSection = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ChkBox_withoutComments = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxKeyAndValue = New System.Windows.Forms.TextBox()
        Me.TxtBoxSection = New System.Windows.Forms.TextBox()
        Me.CheckLstBox_INI_Section_values = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabLog = New System.Windows.Forms.TabPage()
        Me.BtnClearLog = New System.Windows.Forms.Button()
        Me.LstLog = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabLog)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1333, 752)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.GroupBox4)
        Me.TabPage.Controls.Add(Me.GroupBox3)
        Me.TabPage.Controls.Add(Me.GroupBox2)
        Me.TabPage.Controls.Add(Me.GroupBox1)
        Me.TabPage.Controls.Add(Me.BtnExit)
        Me.TabPage.Controls.Add(Me.btnRun)
        Me.TabPage.Location = New System.Drawing.Point(4, 22)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage.Size = New System.Drawing.Size(1325, 726)
        Me.TabPage.TabIndex = 0
        Me.TabPage.Text = "INI changer "
        Me.TabPage.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(921, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 155)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Options"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(8, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(192, 17)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Create Section and Value if missing"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblFileMovedStatus)
        Me.GroupBox3.Controls.Add(Me.BtnCompleteFileSelections)
        Me.GroupBox3.Controls.Add(Me.CheckLstBox_SelectionFiles)
        Me.GroupBox3.Controls.Add(Me.BtnCheckUncheck)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 480)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "File Selection FineTune"
        '
        'LblFileMovedStatus
        '
        Me.LblFileMovedStatus.AutoSize = True
        Me.LblFileMovedStatus.Location = New System.Drawing.Point(17, 453)
        Me.LblFileMovedStatus.Name = "LblFileMovedStatus"
        Me.LblFileMovedStatus.Size = New System.Drawing.Size(0, 13)
        Me.LblFileMovedStatus.TabIndex = 23
        '
        'BtnCompleteFileSelections
        '
        Me.BtnCompleteFileSelections.Location = New System.Drawing.Point(6, 427)
        Me.BtnCompleteFileSelections.Name = "BtnCompleteFileSelections"
        Me.BtnCompleteFileSelections.Size = New System.Drawing.Size(206, 23)
        Me.BtnCompleteFileSelections.TabIndex = 22
        Me.BtnCompleteFileSelections.Text = "Complete File Selection"
        Me.BtnCompleteFileSelections.UseVisualStyleBackColor = True
        '
        'CheckLstBox_SelectionFiles
        '
        Me.CheckLstBox_SelectionFiles.FormattingEnabled = True
        Me.CheckLstBox_SelectionFiles.Location = New System.Drawing.Point(17, 62)
        Me.CheckLstBox_SelectionFiles.Name = "CheckLstBox_SelectionFiles"
        Me.CheckLstBox_SelectionFiles.Size = New System.Drawing.Size(186, 349)
        Me.CheckLstBox_SelectionFiles.TabIndex = 9
        '
        'BtnCheckUncheck
        '
        Me.BtnCheckUncheck.Location = New System.Drawing.Point(17, 28)
        Me.BtnCheckUncheck.Name = "BtnCheckUncheck"
        Me.BtnCheckUncheck.Size = New System.Drawing.Size(186, 23)
        Me.BtnCheckUncheck.TabIndex = 21
        Me.BtnCheckUncheck.Text = "Check/Uncheck All"
        Me.BtnCheckUncheck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.Btn_workingPath)
        Me.GroupBox2.Controls.Add(Me.BtnINI_Source)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 177)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File Setup"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(6, 151)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox6.TabIndex = 26
        Me.CheckBox6.Text = "Manual Files"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(6, 128)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox5.TabIndex = 25
        Me.CheckBox5.Text = "Filter 3"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 105)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "Filter 2"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 82)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "Filter 1"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Btn_workingPath
        '
        Me.Btn_workingPath.Enabled = False
        Me.Btn_workingPath.Location = New System.Drawing.Point(6, 53)
        Me.Btn_workingPath.Name = "Btn_workingPath"
        Me.Btn_workingPath.Size = New System.Drawing.Size(118, 23)
        Me.Btn_workingPath.TabIndex = 8
        Me.Btn_workingPath.Text = "INI Working Path"
        Me.Btn_workingPath.UseVisualStyleBackColor = True
        '
        'BtnINI_Source
        '
        Me.BtnINI_Source.Location = New System.Drawing.Point(6, 24)
        Me.BtnINI_Source.Name = "BtnINI_Source"
        Me.BtnINI_Source.Size = New System.Drawing.Size(118, 23)
        Me.BtnINI_Source.TabIndex = 7
        Me.BtnINI_Source.Text = "INI Source Path"
        Me.BtnINI_Source.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAddKey)
        Me.GroupBox1.Controls.Add(Me.BtnRemoveKey)
        Me.GroupBox1.Controls.Add(Me.lblKey)
        Me.GroupBox1.Controls.Add(Me.BtnClearSectionSelection)
        Me.GroupBox1.Controls.Add(Me.BtnViewValuesForSection)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.ChkBox_withoutComments)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtBoxKeyAndValue)
        Me.GroupBox1.Controls.Add(Me.TxtBoxSection)
        Me.GroupBox1.Controls.Add(Me.CheckLstBox_INI_Section_values)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(315, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 675)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section and Key/Value"
        '
        'BtnAddKey
        '
        Me.BtnAddKey.Enabled = False
        Me.BtnAddKey.Location = New System.Drawing.Point(220, 477)
        Me.BtnAddKey.Name = "BtnAddKey"
        Me.BtnAddKey.Size = New System.Drawing.Size(136, 23)
        Me.BtnAddKey.TabIndex = 26
        Me.BtnAddKey.Text = "Add Key"
        Me.BtnAddKey.UseVisualStyleBackColor = True
        '
        'BtnRemoveKey
        '
        Me.BtnRemoveKey.Enabled = False
        Me.BtnRemoveKey.Location = New System.Drawing.Point(372, 477)
        Me.BtnRemoveKey.Name = "BtnRemoveKey"
        Me.BtnRemoveKey.Size = New System.Drawing.Size(136, 23)
        Me.BtnRemoveKey.TabIndex = 25
        Me.BtnRemoveKey.Text = "Remove Key"
        Me.BtnRemoveKey.UseVisualStyleBackColor = True
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.Location = New System.Drawing.Point(102, 523)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(41, 16)
        Me.lblKey.TabIndex = 24
        Me.lblKey.Text = "key="
        Me.lblKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnClearSectionSelection
        '
        Me.BtnClearSectionSelection.Location = New System.Drawing.Point(368, 558)
        Me.BtnClearSectionSelection.Name = "BtnClearSectionSelection"
        Me.BtnClearSectionSelection.Size = New System.Drawing.Size(140, 32)
        Me.BtnClearSectionSelection.TabIndex = 23
        Me.BtnClearSectionSelection.Text = "Clear Selection"
        Me.BtnClearSectionSelection.UseVisualStyleBackColor = True
        '
        'BtnViewValuesForSection
        '
        Me.BtnViewValuesForSection.Enabled = False
        Me.BtnViewValuesForSection.Location = New System.Drawing.Point(105, 93)
        Me.BtnViewValuesForSection.Name = "BtnViewValuesForSection"
        Me.BtnViewValuesForSection.Size = New System.Drawing.Size(182, 23)
        Me.BtnViewValuesForSection.TabIndex = 15
        Me.BtnViewValuesForSection.Text = "View Values For Section"
        Me.BtnViewValuesForSection.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(368, 609)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(140, 49)
        Me.BtnSave.TabIndex = 22
        Me.BtnSave.Text = "Save "
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ChkBox_withoutComments
        '
        Me.ChkBox_withoutComments.AutoSize = True
        Me.ChkBox_withoutComments.Location = New System.Drawing.Point(27, 558)
        Me.ChkBox_withoutComments.Name = "ChkBox_withoutComments"
        Me.ChkBox_withoutComments.Size = New System.Drawing.Size(186, 17)
        Me.ChkBox_withoutComments.TabIndex = 10
        Me.ChkBox_withoutComments.Text = "Create Section withOut comments"
        Me.ChkBox_withoutComments.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter Section   (Must be done manually)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Values for Section"
        '
        'TxtBoxKeyAndValue
        '
        Me.TxtBoxKeyAndValue.Enabled = False
        Me.TxtBoxKeyAndValue.Location = New System.Drawing.Point(220, 519)
        Me.TxtBoxKeyAndValue.Name = "TxtBoxKeyAndValue"
        Me.TxtBoxKeyAndValue.Size = New System.Drawing.Size(288, 20)
        Me.TxtBoxKeyAndValue.TabIndex = 17
        '
        'TxtBoxSection
        '
        Me.TxtBoxSection.Location = New System.Drawing.Point(6, 39)
        Me.TxtBoxSection.Name = "TxtBoxSection"
        Me.TxtBoxSection.Size = New System.Drawing.Size(298, 20)
        Me.TxtBoxSection.TabIndex = 12
        Me.TxtBoxSection.Text = "[CONTROL]"
        '
        'CheckLstBox_INI_Section_values
        '
        Me.CheckLstBox_INI_Section_values.FormattingEnabled = True
        Me.CheckLstBox_INI_Section_values.Location = New System.Drawing.Point(9, 122)
        Me.CheckLstBox_INI_Section_values.Name = "CheckLstBox_INI_Section_values"
        Me.CheckLstBox_INI_Section_values.Size = New System.Drawing.Size(514, 349)
        Me.CheckLstBox_INI_Section_values.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 494)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Enter New Key and Value"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(1112, 290)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 56)
        Me.BtnExit.TabIndex = 28
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Enabled = False
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(947, 290)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(128, 56)
        Me.btnRun.TabIndex = 27
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1325, 726)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INI research"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabLog
        '
        Me.TabLog.Controls.Add(Me.BtnClearLog)
        Me.TabLog.Controls.Add(Me.LstLog)
        Me.TabLog.Location = New System.Drawing.Point(4, 22)
        Me.TabLog.Name = "TabLog"
        Me.TabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLog.Size = New System.Drawing.Size(1325, 726)
        Me.TabLog.TabIndex = 2
        Me.TabLog.Text = "Log"
        Me.TabLog.UseVisualStyleBackColor = True
        '
        'BtnClearLog
        '
        Me.BtnClearLog.Location = New System.Drawing.Point(1151, 6)
        Me.BtnClearLog.Name = "BtnClearLog"
        Me.BtnClearLog.Size = New System.Drawing.Size(117, 23)
        Me.BtnClearLog.TabIndex = 1
        Me.BtnClearLog.Text = "Clear Log"
        Me.BtnClearLog.UseVisualStyleBackColor = True
        '
        'LstLog
        '
        Me.LstLog.FormattingEnabled = True
        Me.LstLog.Location = New System.Drawing.Point(21, 35)
        Me.LstLog.Name = "LstLog"
        Me.LstLog.Size = New System.Drawing.Size(1262, 628)
        Me.LstLog.TabIndex = 0
        '
        'INIconfigUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 824)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "INIconfigUI"
        Me.Text = "Config File Changer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabLog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCompleteFileSelections As System.Windows.Forms.Button
    Friend WithEvents CheckLstBox_SelectionFiles As System.Windows.Forms.CheckedListBox
    Friend WithEvents BtnCheckUncheck As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_workingPath As System.Windows.Forms.Button
    Friend WithEvents BtnINI_Source As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClearSectionSelection As System.Windows.Forms.Button
    Friend WithEvents BtnViewValuesForSection As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ChkBox_withoutComments As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxKeyAndValue As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxSection As System.Windows.Forms.TextBox
    Friend WithEvents CheckLstBox_INI_Section_values As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabLog As System.Windows.Forms.TabPage
    Friend WithEvents LstLog As System.Windows.Forms.ListBox
    Friend WithEvents BtnClearLog As System.Windows.Forms.Button
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveKey As System.Windows.Forms.Button
    Friend WithEvents BtnAddKey As System.Windows.Forms.Button
    Friend WithEvents LblFileMovedStatus As System.Windows.Forms.Label

End Class
