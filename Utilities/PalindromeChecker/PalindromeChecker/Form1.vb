Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        check()


        'txtNo.Visible = False
        'txtyes.Visible = False

        'Dim str1 As String = TextBox1.Text

        'Dim charRev() As Char = Nothing

        'charRev = str1.ToCharArray() 'Char array

        'Array.Reverse(charRev)  'reverse the array

        'Dim str2 As String = charRev

        'TextBox1.Text = str2

        'If (String.Equals(str1, str2)) Then

        '    txtyes.Visible = True

        'Else
        '    txtNo.Visible = True


        'End If



    End Sub


    Sub check()

        txtNo.Visible = False
        txtyes.Visible = False

        Dim str1 As String = TextBox1.Text

        Dim charRev() As Char = Nothing

        charRev = str1.ToCharArray() 'Char array

        Array.Reverse(charRev)  'reverse the array

        Dim str2 As String = charRev

        TextBox1.Text = str2

        If (String.Equals(str1, str2)) Then

            txtyes.Visible = True

        Else
            txtNo.Visible = True


        End If
    End Sub




End Class
