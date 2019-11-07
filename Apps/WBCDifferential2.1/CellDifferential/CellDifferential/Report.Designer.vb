<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Me.LstReport = New System.Windows.Forms.ListBox()
        Me.BtnCloseReport = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstReport
        '
        Me.LstReport.ColumnWidth = 30
        Me.LstReport.Font = New System.Drawing.Font("Courier New", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstReport.FormattingEnabled = True
        Me.LstReport.ItemHeight = 20
        Me.LstReport.Location = New System.Drawing.Point(7, 9)
        Me.LstReport.Name = "LstReport"
        Me.LstReport.ScrollAlwaysVisible = True
        Me.LstReport.Size = New System.Drawing.Size(943, 484)
        Me.LstReport.TabIndex = 0
        '
        'BtnCloseReport
        '
        Me.BtnCloseReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCloseReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseReport.Location = New System.Drawing.Point(858, 499)
        Me.BtnCloseReport.Name = "BtnCloseReport"
        Me.BtnCloseReport.Size = New System.Drawing.Size(92, 70)
        Me.BtnCloseReport.TabIndex = 2
        Me.BtnCloseReport.Text = "Close Report"
        Me.BtnCloseReport.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(133, 499)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(92, 70)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.Text = "Print "
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(7, 499)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(92, 70)
        Me.BtnCreate.TabIndex = 5
        Me.BtnCreate.Text = "Create Report"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WBCDifferential.My.Resources.Resources.Background2
        Me.ClientSize = New System.Drawing.Size(962, 575)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnCloseReport)
        Me.Controls.Add(Me.LstReport)
        Me.Name = "FrmReport"
        Me.Text = "Patient Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstReport As System.Windows.Forms.ListBox
    Friend WithEvents BtnCloseReport As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
End Class
