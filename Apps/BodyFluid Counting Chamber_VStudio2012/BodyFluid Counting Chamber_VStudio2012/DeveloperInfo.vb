Public Class FrmDeveloper

    Private Sub FrmDeveloper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Link_Clicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub 'Link_Clicked


    Private Sub BtnCLoseDeveloper_Click(sender As Object, e As EventArgs) Handles BtnCLoseDeveloper.Click
        Me.Close()
    End Sub
End Class