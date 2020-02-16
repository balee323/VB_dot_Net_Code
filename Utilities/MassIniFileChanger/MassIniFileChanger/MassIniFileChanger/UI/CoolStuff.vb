Public Class CoolStuff

    Private form As Windows.Forms.Form


    Public Sub New()

    End Sub


    Public Sub New(form As Windows.Forms.Form)
        Me.form = form
    End Sub



    Public Sub TransitionEffect1(control As Object, text As String, form As Windows.Forms.Form)

        If (control.GetType() Is GetType(System.Windows.Forms.Label)) Then
            'Create a transition effect 
            control.Visible = False
            form.Refresh()
            System.Threading.Thread.Sleep(30)
            control.Visible = True
            form.Refresh()
            control.Text = "Files copied to working folder."

        End If

    End Sub



    Public Sub TransitionEffect2(control As Object, text As String, form As Windows.Forms.Form)

        If (control.GetType() Is GetType(System.Windows.Forms.Label)) Then
            'Create a transition effect 
            control.Visible = False
            form.Refresh()
            System.Threading.Thread.Sleep(30)
            control.Visible = True
            form.Refresh()
            Dim tempStr As String = control.text
            Dim AddSingleCharAtTime As String = ""

            For i As Integer = 0 To tempStr.Count Step 1
                '      AddSingleCharAtTime = AddSingleCharAtTime + 


            Next


            'control.Text = "Files copied to working folder."

        End If

    End Sub

End Class
