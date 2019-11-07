


Public Class CountingChamber

    Dim TempCounter As Integer = 0
    Dim Square As Integer = 1

    Dim BL1 As Integer = 0
    Dim BL2 As Integer = 0
    Dim BR1 As Integer = 0
    Dim BR2 As Integer = 0
    Dim TR1 As Integer = 0
    Dim TR2 As Integer = 0
    Dim TL1 As Integer = 0
    Dim TL2 As Integer = 0
    Dim Dil As Double = 20
    Dim Depth As Double = 0.1
    Dim WbcCount As Double = 0
    Dim Side1 As Integer = 0
    Dim Side2 As Integer = 0
    Dim Avg As Double = 0


    Private Sub CountingChamber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TempCounter = 0
        Square = 1


    End Sub

    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(32) Then
            LblStart.Visible = False
            'MessageBox.Show("You pressed '/'  = seg ")
            TempCounter = TempCounter + 1
            'TxtInput.Text = ""

        End If

        If Square = 1 Then
            TxtBL1.Text = CStr(TempCounter)
            ' TxtBL1.Text = TempCounter
        End If

        If Square = 2 Then
            TxtBR1.Text = CStr(TempCounter)
        End If

        If Square = 3 Then
            TxtTL1.Text = CStr(TempCounter)
        End If

        If Square = 4 Then
            TxtTR1.Text = CStr(TempCounter)
        End If

        If Square = 5 Then
            TxtBL2.Text = CStr(TempCounter)
        End If

        If Square = 6 Then
            TxtBR2.Text = CStr(TempCounter)
        End If

        If Square = 7 Then
            TxtTL2.Text = CStr(TempCounter)
        End If

        If Square = 8 Then
            TxtTR2.Text = CStr(TempCounter)
        End If









    End Sub


    Private Sub BtnDone1_Click(sender As Object, e As EventArgs) Handles BtnDone1.Click

        BtnDone1.Visible = False
        BtnDone2.Visible = True
        TxtBR1.Visible = True

        Side1 = Side1 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1 '2
        BtnClearSide1.Visible = True
        Me.Focus()

    End Sub


    Private Sub BtnDone2_Click(sender As Object, e As EventArgs) Handles BtnDone2.Click


        BtnDone2.Visible = False
        BtnDone3.Visible = True
        TxtTL1.Visible = True

        Side1 = Side1 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1 '3
        Me.Focus()


    End Sub

    Private Sub BtnDone3_Click(sender As Object, e As EventArgs) Handles BtnDone3.Click


        BtnDone3.Visible = False
        BtnDone4.Visible = True
        TxtTR1.Visible = True

        Side1 = Side1 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1
        Me.Focus()

    End Sub

    Private Sub BtnDone4_Click(sender As Object, e As EventArgs) Handles BtnDone4.Click

        BtnDone4.Visible = False
        BtnDone5.Visible = True
        TxtBL2.Visible = True

        Side1 = Side1 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1

        TxtSide1.Text = (Str(Side1))

        Me.Focus()

    End Sub


    Private Sub BtnDone5_Click(sender As Object, e As EventArgs) Handles BtnDone5.Click
        BtnDone5.Visible = False
        BtnDone6.Visible = True
        TxtBR2.Visible = True

        Side2 = Side2 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1

        BtnClearSide2.Visible = True
        Me.Focus()

    End Sub

    Private Sub BtnDone6_Click(sender As Object, e As EventArgs) Handles BtnDone6.Click
        BtnDone6.Visible = False
        BtnDone7.Visible = True
        TxtTL2.Visible = True

        Side2 = Side2 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1
        Me.Focus()
    End Sub

    Private Sub BtnDone7_Click(sender As Object, e As EventArgs) Handles BtnDone7.Click
        BtnDone7.Visible = False
        BtnDone8.Visible = True
        TxtTR2.Visible = True

        Side2 = Side2 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1
        Me.Focus()

    End Sub

    Private Sub BtnDone8_Click(sender As Object, e As EventArgs) Handles BtnDone8.Click

        BtnDone8.Visible = False




        Side2 = Side2 + TempCounter
        TempCounter = 0 'resets for next square
        Square = Square + 1
        TxtSide2.Text = (Str(Side2))

        BtnRecalc.Visible = True


        If Side1 < Side2 And Side1 / Side2 >= 0.9 Then

            TxtPass.Text = "Yes"

        ElseIf Side1 > Side2 And Side2 / Side1 >= 0.9 Then

            TxtPass.Text = "Yes"

        Else
            TxtPass.Text = "No"

        End If


        If Side1 = Side2 Then
            TxtPass.Text = "Yes"
        End If

        'TxtPass.Visible = True


        Avg = ((Side1 + Side2) / 2)

        TxtAVG.Text = (CStr(Avg))
        TxtAVG.Visible = True

        CalculateWBC()

        Me.Focus()

    End Sub

    Private Sub BtnClearSide1_Click(sender As Object, e As EventArgs) Handles BtnClearSide1.Click



        Square = 1
        BL1 = 0
        BR1 = 0
        TL1 = 0
        TR1 = 0
        Side1 = 0
        TempCounter = 0
        Avg = 0


        TxtBL1.Text = ""
        TxtBR1.Text = ""
        TxtTL1.Text = ""
        TxtTR1.Text = ""
        TxtSide1.Text = ""
        TxtAVG.Text = ""

        TxtBL1.Visible = True
        TxtBR1.Visible = False
        TxtTL1.Visible = False
        TxtTR1.Visible = False


        BtnDone1.Visible = True
        BtnDone2.Visible = False
        BtnDone3.Visible = False
        BtnDone4.Visible = False

        BtnRecalc.Visible = False
        BtnClearSide1.Visible = False
        BtnClearAll.Visible = True
        Me.Focus()


    End Sub

    Private Sub BtnClearSide2_Click(sender As Object, e As EventArgs) Handles BtnClearSide2.Click

        Me.Focus()
        Square = 5
        BL2 = 0
        BR2 = 0
        TL2 = 0
        TR2 = 0
        Side2 = 0
        TempCounter = 0
        Avg = 0
        TxtPass.Text = ""


        TxtBL2.Text = ""
        TxtBR2.Text = ""
        TxtTL2.Text = ""
        TxtTR2.Text = ""
        TxtSide2.Text = ""


        TxtBR2.Visible = False
        TxtTL2.Visible = False
        TxtTR2.Visible = False


        BtnRecalc.Visible = False
        BtnDone6.Visible = False
        BtnDone7.Visible = False
        BtnDone8.Visible = False



        If Side1 = 0 Then

            BtnDone5.Visible = False 'won't display BtnDone5 if not count was done on side1
            TxtBL2.Visible = False
            Square = 1
        Else
            BtnDone5.Visible = True
            TxtBL2.Visible = True
        End If

        BtnClearSide2.Visible = False
        BtnClearAll.Visible = True
        Me.Focus()








    End Sub

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click

        Square = 1
        BL1 = 0
        BR1 = 0
        TL1 = 0
        TR1 = 0

        BL2 = 0
        BR2 = 0
        TL2 = 0
        TR2 = 0

        Side1 = 0
        Side2 = 0
        TempCounter = 0
        Avg = 0
        TxtPass.Text = ""


        TxtBL1.Text = ""
        TxtBR1.Text = ""
        TxtTL1.Text = ""
        TxtTR1.Text = ""
        TxtSide1.Text = ""

        TxtBL2.Text = ""
        TxtBR2.Text = ""
        TxtTL2.Text = ""
        TxtTR2.Text = ""
        TxtSide2.Text = ""

        TxtBL1.Visible = True
        TxtBR1.Visible = False
        TxtTL1.Visible = False
        TxtTR1.Visible = False

        TxtBL2.Visible = False
        TxtBR2.Visible = False
        TxtTL2.Visible = False
        TxtTR2.Visible = False

        BtnDone1.Visible = True
        BtnDone2.Visible = False
        BtnDone3.Visible = False
        BtnDone4.Visible = False

        BtnDone5.Visible = False
        BtnDone6.Visible = False
        BtnDone7.Visible = False
        BtnDone8.Visible = False

        BtnRecalc.Visible = False
        BtnClearSide1.Visible = True
        BtnClearSide2.Visible = True
        BtnClearAll.Visible = False
        Me.Focus()



    End Sub







    Private Sub BtnChangeDil_Click(sender As Object, e As EventArgs) Handles BtnChangeDil.Click

        Dim TempStr As String

        TempStr = InputBox("Enter new dilution")

        If IsNumeric(TempStr) Then

            Dil = CDbl(TempStr)
            TxtDil.Text = (CStr(Dil))
        Else
            MessageBox.Show("Please Enter a number.")

        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim TempStr As String

        TempStr = InputBox("Enter new dilution")

        If IsNumeric(TempStr) Then

            Depth = CDbl(TempStr)
            TxtDepth.Text = (CStr(Depth))
        Else
            MessageBox.Show("Please Enter a number.")

        End If


    End Sub

    Private Sub BtnRecalc_Click(sender As Object, e As EventArgs) Handles BtnRecalc.Click

        CalculateWBC()


    End Sub

    Sub CalculateWBC()

        WbcCount = ((Avg * Dil) / (4 * Depth))

        TxtCount.Text = (CStr(WbcCount))

    End Sub


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click

        'see pg. 321 murach's VB 2010
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close the program?", "Close Program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'if no is selected then the program ends
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

        'else nothing happens


    End Sub




    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        FrmDeveloper.Show()
        FrmDeveloper.Focus()


    End Sub
End Class
