
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class CellDiff


    'global variables


    Dim Count As Integer = 100


    Dim Seg As Integer = 0
    Dim Lym As Integer = 0
    Dim Mono As Integer = 0
    Dim Eos As Integer = 0
    Dim Baso As Integer = 0
    Dim Band As Integer = 0
    Dim Meta As Integer = 0
    Dim Myelo As Integer = 0
    Dim Promyelo As Integer = 0
    Dim Blast As Integer = 0
    Dim NRBC As Integer = 0

    Dim Total As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        ' TxtInput.Text = ""
        ' TxtInput.Focus()
        'TxtInput.Visible = False
        Me.Focus()
        Me.KeyPreview = True  'important
        Me.TransparencyKey = BackColor
    End Sub


    'Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress




        If e.KeyChar = ChrW(47) Then
            My.Computer.Audio.Play(My.Resources.click3, _
            AudioPlayMode.Background)
            'MessageBox.Show("You pressed '/'  = seg ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Seg = Seg + 1
            TxtSeg.Text = CStr(Seg)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(46) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed '.' = lym ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Lym = Lym + 1
            TxtLym.Text = CStr(Lym)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(44) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed ',' = mono ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Mono = Mono + 1
            TxtMono.Text = CStr(Mono)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(109) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'm' = Eos")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Eos = Eos + 1
            TxtEos.Text = CStr(Eos)
            ' TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(110) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'n' = Baso ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Baso = Baso + 1
            TxtBaso.Text = CStr(Baso)
            'TxtInput.Text = ""
        End If


        If e.KeyChar = ChrW(98) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'b' = band ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Band = Band + 1
            TxtBand.Text = CStr(Band)
            'TxtInput.Text = ""
        End If


        If e.KeyChar = ChrW(59) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            ' MessageBox.Show("You pressed ';' = NRBC ")
            'Total = Total + 1  'not counted in total
            TxtTotal.Text = CStr(Total)
            NRBC = NRBC + 1
            TxtNRBC.Text = CStr(NRBC)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(108) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            ' MessageBox.Show("You pressed 'l' = metamyelocyte ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Meta = Meta + 1
            TxtMeta.Text = CStr(Meta)
            'TxtInput.Text = ""
        End If



        If e.KeyChar = ChrW(107) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'k' = myelocyte ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Myelo = Myelo + 1
            Txtmyelo.Text = CStr(Myelo)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(106) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'j' = Promyelocyte ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Promyelo = Promyelo + 1
            TxtPromyelo.Text = CStr(Promyelo)
            'TxtInput.Text = ""
        End If



        If e.KeyChar = ChrW(104) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'h' = Blast Cell ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Blast = Blast + 1
            TxtBlast.Text = CStr(Blast)
            'TxtInput.Text = ""
        End If




        If Total = Count Then
            PlaySound()
            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If







        'Count(TxtInput.Text)


    End Sub






    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click


        Total = 0
        Seg = 0
        Lym = 0
        Mono = 0
        Eos = 0
        Baso = 0
        Band = 0
        NRBC = 0
        Meta = 0
        Myelo = 0
        Promyelo = 0
        Blast = 0


        TxtSeg.Clear()
        TxtTotal.Clear()
        TxtLym.Clear()
        TxtMono.Clear()
        TxtEos.Clear()
        TxtBaso.Clear()
        TxtBand.Clear()
        TxtMeta.Clear()
        TxtPromyelo.Clear()
        Txtmyelo.Clear()
        TxtBand.Clear()
        TxtNRBC.Clear()
        TxtBlast.Clear()

    End Sub

    Private Sub BtnChangeCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangeCount.Click

        TxtChangeCount.ReadOnly = False

        'MessageBox.Show("Please Enter a new count total below, press Done when finished.")

        TxtChangeCount.Focus()



        'Dim Input As String = ""
        Dim Message As String = "Please enter a count between 20 and 500."
        Dim Title As String = "Change Cell Count"
        Dim DefaultValue As String = "100"


        ' MessageBox.Show("Please enter a count between 20 and 500")

        TxtChangeCount.Text = InputBox(Message, Title, DefaultValue) 'user input box.  File name and .txt is appended to string

        'checks the value of the input
        CheckCountInput()

       
    End Sub


    Sub CheckCountInput()

        'Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click

        TxtChangeCount.ReadOnly = True
        Dim OK As Boolean = False


        If IsNumeric(TxtChangeCount.Text) Then

            If CInt(TxtChangeCount.Text) <= 500 And CInt(TxtChangeCount.Text) >= 20 Then
                Count = CInt(TxtChangeCount.Text)
                OK = True
            Else
                MessageBox.Show("please enter an Integer Between 20 and 500")
                TxtChangeCount.Text = ("100")

            End If
        Else

            MessageBox.Show("You entered a non-number, please enter an Integer")
            TxtChangeCount.Text = ("100")
        End If





    End Sub


    Private Sub BtnEditKeys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditKeys.Click

        KeyBind.Show()
        KeyBind.Focus()



    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub


    Sub PlaySound()


        If RadioButton1.Checked = True Then
            'no sound

        End If


        If RadioButton2.Checked = True Then


            My.Computer.Audio.Play(My.Resources.Regular_Ding, _
            AudioPlayMode.Background)

        End If


        If RadioButton3.Checked = True Then

            My.Computer.Audio.Play(My.Resources.Bomb, _
            AudioPlayMode.Background)

        End If


        If RadioButton4.Checked = True Then

            My.Computer.Audio.Play(My.Resources.robotic_voice, _
            AudioPlayMode.Background)

        End If





        'My.Computer.Audio.Play(My.Resources.Regular_Ding, _
        ' AudioPlayMode.Background)


    End Sub

    'taken from the google search.

    Private Sub CellDiffMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub








    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click

        'see pg. 321 murach's VB 2010
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close the program?", "Close Program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'if no is selected then the program ends
        If result = Windows.Forms.DialogResult.Yes Then
            End
        End If

        'else nothing happens


    End Sub

  

    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click

        'had to set all the variables on FrmReport to public

        FrmReport.Count = Count
        FrmReport.Seg = Seg
        FrmReport.Lym = Lym
        FrmReport.Mono = Mono
        FrmReport.Baso = Baso
        FrmReport.Eos = Eos
        FrmReport.Band = Band
        FrmReport.Meta = Meta
        FrmReport.Myelo = Myelo
        FrmReport.Promyelo = Promyelo
        FrmReport.Blast = Blast
        FrmReport.NRBC = NRBC
  



        FrmReport.Show()
        FrmReport.Focus()

        FrmReport.BtnCreate.PerformClick()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        FrmDeveloper.Show()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class
