<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateQuestions
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
        Me.TxtUserQuestion = New System.Windows.Forms.TextBox()
        Me.TxtQuestStatus = New System.Windows.Forms.TextBox()
        Me.RbtnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.RbtnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.RbtnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.RbtnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUserAnswer1 = New System.Windows.Forms.TextBox()
        Me.TxtUserAnswer2 = New System.Windows.Forms.TextBox()
        Me.TxtUserAnswer3 = New System.Windows.Forms.TextBox()
        Me.TxtUserAnswer4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNextEntry = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnArray = New System.Windows.Forms.Button()
        Me.BtnExitCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtUserQuestion
        '
        Me.TxtUserQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserQuestion.Location = New System.Drawing.Point(12, 111)
        Me.TxtUserQuestion.Multiline = True
        Me.TxtUserQuestion.Name = "TxtUserQuestion"
        Me.TxtUserQuestion.Size = New System.Drawing.Size(482, 124)
        Me.TxtUserQuestion.TabIndex = 0
        '
        'TxtQuestStatus
        '
        Me.TxtQuestStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuestStatus.Location = New System.Drawing.Point(12, 51)
        Me.TxtQuestStatus.Name = "TxtQuestStatus"
        Me.TxtQuestStatus.ReadOnly = True
        Me.TxtQuestStatus.Size = New System.Drawing.Size(302, 27)
        Me.TxtQuestStatus.TabIndex = 1
        '
        'RbtnAnswer1
        '
        Me.RbtnAnswer1.AutoSize = True
        Me.RbtnAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnAnswer1.Location = New System.Drawing.Point(12, 317)
        Me.RbtnAnswer1.Name = "RbtnAnswer1"
        Me.RbtnAnswer1.Size = New System.Drawing.Size(108, 24)
        Me.RbtnAnswer1.TabIndex = 2
        Me.RbtnAnswer1.TabStop = True
        Me.RbtnAnswer1.Text = "Answer 1"
        Me.RbtnAnswer1.UseVisualStyleBackColor = True
        '
        'RbtnAnswer2
        '
        Me.RbtnAnswer2.AutoSize = True
        Me.RbtnAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnAnswer2.Location = New System.Drawing.Point(12, 378)
        Me.RbtnAnswer2.Name = "RbtnAnswer2"
        Me.RbtnAnswer2.Size = New System.Drawing.Size(108, 24)
        Me.RbtnAnswer2.TabIndex = 3
        Me.RbtnAnswer2.TabStop = True
        Me.RbtnAnswer2.Text = "Answer 2"
        Me.RbtnAnswer2.UseVisualStyleBackColor = True
        '
        'RbtnAnswer3
        '
        Me.RbtnAnswer3.AutoSize = True
        Me.RbtnAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnAnswer3.Location = New System.Drawing.Point(12, 443)
        Me.RbtnAnswer3.Name = "RbtnAnswer3"
        Me.RbtnAnswer3.Size = New System.Drawing.Size(108, 24)
        Me.RbtnAnswer3.TabIndex = 4
        Me.RbtnAnswer3.TabStop = True
        Me.RbtnAnswer3.Text = "Answer 3"
        Me.RbtnAnswer3.UseVisualStyleBackColor = True
        '
        'RbtnAnswer4
        '
        Me.RbtnAnswer4.AutoSize = True
        Me.RbtnAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtnAnswer4.Location = New System.Drawing.Point(12, 508)
        Me.RbtnAnswer4.Name = "RbtnAnswer4"
        Me.RbtnAnswer4.Size = New System.Drawing.Size(108, 24)
        Me.RbtnAnswer4.TabIndex = 5
        Me.RbtnAnswer4.TabStop = True
        Me.RbtnAnswer4.Text = "Answer 4"
        Me.RbtnAnswer4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose the correct answer!"
        '
        'TxtUserAnswer1
        '
        Me.TxtUserAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserAnswer1.Location = New System.Drawing.Point(146, 311)
        Me.TxtUserAnswer1.Name = "TxtUserAnswer1"
        Me.TxtUserAnswer1.Size = New System.Drawing.Size(535, 30)
        Me.TxtUserAnswer1.TabIndex = 7
        '
        'TxtUserAnswer2
        '
        Me.TxtUserAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserAnswer2.Location = New System.Drawing.Point(146, 372)
        Me.TxtUserAnswer2.Name = "TxtUserAnswer2"
        Me.TxtUserAnswer2.Size = New System.Drawing.Size(535, 30)
        Me.TxtUserAnswer2.TabIndex = 8
        '
        'TxtUserAnswer3
        '
        Me.TxtUserAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserAnswer3.Location = New System.Drawing.Point(146, 443)
        Me.TxtUserAnswer3.Name = "TxtUserAnswer3"
        Me.TxtUserAnswer3.Size = New System.Drawing.Size(535, 30)
        Me.TxtUserAnswer3.TabIndex = 9
        '
        'TxtUserAnswer4
        '
        Me.TxtUserAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserAnswer4.Location = New System.Drawing.Point(146, 508)
        Me.TxtUserAnswer4.Name = "TxtUserAnswer4"
        Me.TxtUserAnswer4.Size = New System.Drawing.Size(535, 30)
        Me.TxtUserAnswer4.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Enter the question below!"
        '
        'BtnNextEntry
        '
        Me.BtnNextEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNextEntry.Location = New System.Drawing.Point(500, 187)
        Me.BtnNextEntry.Name = "BtnNextEntry"
        Me.BtnNextEntry.Size = New System.Drawing.Size(197, 48)
        Me.BtnNextEntry.TabIndex = 12
        Me.BtnNextEntry.Text = "Next Entry"
        Me.BtnNextEntry.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(505, 12)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(192, 66)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "Save File"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnArray
        '
        Me.BtnArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArray.Location = New System.Drawing.Point(12, 582)
        Me.BtnArray.Name = "BtnArray"
        Me.BtnArray.Size = New System.Drawing.Size(79, 48)
        Me.BtnArray.TabIndex = 14
        Me.BtnArray.Text = "Show Array"
        Me.BtnArray.UseVisualStyleBackColor = True
        Me.BtnArray.Visible = False
        '
        'BtnExitCreate
        '
        Me.BtnExitCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExitCreate.Location = New System.Drawing.Point(534, 582)
        Me.BtnExitCreate.Name = "BtnExitCreate"
        Me.BtnExitCreate.Size = New System.Drawing.Size(163, 48)
        Me.BtnExitCreate.TabIndex = 15
        Me.BtnExitCreate.Text = "Exit"
        Me.BtnExitCreate.UseVisualStyleBackColor = True
        '
        'CreateQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 642)
        Me.Controls.Add(Me.BtnExitCreate)
        Me.Controls.Add(Me.BtnArray)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNextEntry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUserAnswer4)
        Me.Controls.Add(Me.TxtUserAnswer3)
        Me.Controls.Add(Me.TxtUserAnswer2)
        Me.Controls.Add(Me.TxtUserAnswer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbtnAnswer4)
        Me.Controls.Add(Me.RbtnAnswer3)
        Me.Controls.Add(Me.RbtnAnswer2)
        Me.Controls.Add(Me.RbtnAnswer1)
        Me.Controls.Add(Me.TxtQuestStatus)
        Me.Controls.Add(Me.TxtUserQuestion)
        Me.Name = "CreateQuestions"
        Me.Text = "Create 15 Questions!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtUserQuestion As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuestStatus As System.Windows.Forms.TextBox
    Friend WithEvents RbtnAnswer1 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnAnswer2 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnAnswer3 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnAnswer4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUserAnswer1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserAnswer3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserAnswer4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnNextEntry As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnArray As System.Windows.Forms.Button
    Friend WithEvents BtnExitCreate As System.Windows.Forms.Button
End Class
