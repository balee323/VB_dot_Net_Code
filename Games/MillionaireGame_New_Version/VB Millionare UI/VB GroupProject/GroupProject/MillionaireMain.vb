Imports System.IO

Public Class FrmWhoMillionare
    'global variables - because it makes this so much easier
    Dim InputStr(14) As String  'each question loaded up. 
    Dim CorrectAns As String = "" 'stores correct answer
    Dim PlayGame As Boolean = True
    Dim GameRound As Integer = 0  'keeps up with game rounds, has many uses such as question loading, cash

    Private Sub FrmWhoMillionare_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()  'show the visual basic UI form in background of file select box

        Dim i As Integer = 0
        BtnPlay.Visible = False

        BtnFinal.Visible = False
        BtnNew.Visible = False


        Btn50_50.Visible = False
        BtnPhone.Visible = False
        BtnAudience.Visible = False
        BtnNext.Visible = False

    End Sub


    Private Sub BtnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlay.Click

        BtnFinal.Visible = True
        BtnPlay.Visible = False

        Btn50_50.Visible = True
        BtnPhone.Visible = True
        BtnAudience.Visible = True


        BtnLoad.Visible = False
        BtnCreate.Visible = False
        'BtnNew.Visible = True
        ' Dim Question(5) As String 'to store each question in  parts


       
        ShowQuestions()  'parameters not needed, since global variables used


    End Sub


    Sub ShowQuestions()



        Dim Question(5) As String 'to store each question in  parts

        Question = Split(InputStr(GameRound), "/")

        ' MessageBox.Show(Question(0))

        'sets the quest to the question textbox
        TxtQuestion.Text = (Question(0))

        'sets each answer to a radio button text property
        RadA.Text = (Question(1))
        RadB.Text = (Question(2))
        RadC.Text = (Question(3))
        RadD.Text = (Question(4))

        CorrectAns = (Question(5)) 'correct answer in class-level variable

        'clears previous button selections
        RadA.Checked = False
        RadB.Checked = False
        RadC.Checked = False
        RadD.Checked = False



    End Sub

    'this sub procedure checks for correct answer and is the core of the program logic and uses a
    'function and several sub procedures

    Private Sub BtnFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFinal.Click

        'checking final answer

        ' RadA.Checked = False

        If (RadA.Checked) Then

            If (RadA.Text) = CorrectAns Then

                PlaySoundYes() 'plays sound for win
                MessageBox.Show("You're Right!!")
                GameRound = GameRound + 1 'increments game round as global(class) variable
                PlayGame = True 'boolean value to continue game
                BtnNext.Visible = True 'shows next button to load next question set
                CashDisplay() 'removes won cash label as each question correct
                TxtCash.Text = CashWon() 'function displays cash won 
                BtnLock() 'locks button so incorrect answer wont be selected after correct one
                BtnFinal.Visible = False 'fix a bug


            Else
                PlaySoundNo()
                MessageBox.Show("Sorry, Incorrect")
                MessageBox.Show("The correct answer was: " & CorrectAns)
                PlayGame = False
            End If

        ElseIf (RadB.Checked) Then

            If (RadB.Text) = CorrectAns Then

                PlaySoundYes() 'plays sound for win
                MessageBox.Show("You're Right!!")
                GameRound = GameRound + 1 'increments game round as global(class) variable
                PlayGame = True
                BtnNext.Visible = True
                CashDisplay() 'removes won cash label as each question correct
                TxtCash.Text = CashWon() 'displays won cash!!
                BtnLock() 'locks button so incorrect answer wont be selected after correct one
                BtnFinal.Visible = False 'fix a bug


            Else
                PlaySoundNo()
                MessageBox.Show("Sorry, Incorrect")
                MessageBox.Show("The correct answer was: " & CorrectAns)
                PlayGame = False
            End If

        ElseIf (RadC.Checked) Then

            If (RadC.Text) = CorrectAns Then

                PlaySoundYes() 'plays sound for win
                MessageBox.Show("You're Right!!")
                GameRound = GameRound + 1 'increments game round as global(class) variable
                PlayGame = True
                BtnNext.Visible = True
                CashDisplay() 'removes won cash label as each question correct
                TxtCash.Text = CashWon() 'displays won cash!!
                BtnLock() 'locks button so incorrect answer wont be selected after correct one
                BtnFinal.Visible = False 'fix a bug


            Else
                PlaySoundNo()
                MessageBox.Show("Sorry, Incorrect")
                MessageBox.Show("The correct answer was: " & CorrectAns)
                PlayGame = False
            End If

        ElseIf (RadD.Checked) Then

            If (RadD.Text) = CorrectAns Then

                PlaySoundYes() 'plays sound for win
                MessageBox.Show("You're Right!!")
                GameRound = GameRound + 1 'increments game round as global(class) variable
                PlayGame = True
                BtnNext.Visible = True
                CashDisplay() 'removes won cash label as each question correct
                TxtCash.Text = CashWon() 'displays won cash!!
                BtnLock() 'locks button so incorrect answer wont be selected after correct one
                BtnFinal.Visible = False 'fix a bug


            Else
                PlaySoundNo()
                MessageBox.Show("Sorry, Incorrect")
                MessageBox.Show("The correct answer was: " & CorrectAns)
                PlayGame = False

            End If

        Else
            MessageBox.Show("We need a final answer!")

        End If

        If (PlayGame = False) Then  'ends game
            MessageBox.Show("Sorry, Game Over!")
            End

        End If


    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub

    'this sub procedure occurs when user clicks next button

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click


        If (GameRound <= 15) And (PlayGame = True) Then

            'ShowQuestions(InputStr, GameRound)  'parameters not needed
            ShowQuestions()           'displays next question(s)

            RadC.Visible = True
            RadB.Visible = True
            RadA.Visible = True
            RadD.Visible = True



        ElseIf (GameRound >= 16) Then  'redudant code to end game

            MessageBox.Show("Game Over")

        End If

        BtnNext.Visible = False 'hides next button until correct answer is selected
        BtnUnlock() 'unlocks buttons
        BtnFinal.Visible = True 'show final button once next set of questions appears

    End Sub
    'this sub procedure causes the cash labels to be invisible when correct answer for each round is selected

    Sub CashDisplay()
        If GameRound <= 1 Then 'will be become invisible if gameround is less than or equal to 1 
            lbl100.Visible = False
        End If

        If GameRound = 2 Then 'will be become invisible if gameround is equal to 2
            Lbl200.Visible = False
        End If

        If GameRound = 3 Then 'will be become invisible if gameround is equal to 3, etc..
            Lbl300.Visible = False
        End If

        If GameRound = 4 Then
            Lbl500.Visible = False
        End If


        If GameRound = 5 Then
            Lbl1k.Visible = False
        End If

        If GameRound = 6 Then
            Lbl2k.Visible = False
        End If

        If GameRound = 7 Then
            Lbl4k.Visible = False
        End If


        If GameRound = 8 Then
            Lbl8k.Visible = False
        End If


        If GameRound = 9 Then
            Lbl16k.Visible = False
        End If


        If GameRound = 10 Then
            Lbl32k.Visible = False
        End If


        If GameRound = 11 Then
            Lbl64k.Visible = False
        End If


        If GameRound = 12 Then
            Lbl125k.Visible = False
        End If


        If GameRound = 13 Then
            Lbl250k.Visible = False
        End If


        If GameRound = 14 Then
            Lbl500k.Visible = False
        End If



        If GameRound = 15 Then 'will be become invisible if gameround is equal to 15
            lblMillion.Visible = False
            PlaySoundWin() 'winning Sound!!
            MessageBox.Show("Congratulations!! Too bad the money isn't real, but the fun was, right?!")
            End 'game ends
        End If

    End Sub

    ' function displays won cash
    Function CashWon() As String
        Dim Cash As String = ""

        If GameRound = 1 Then  'cash string ref variable set to $100
            Cash = "$100"
        End If

        If GameRound = 2 Then 'cash string ref variable set to $200, etc for next statements
            Cash = "$200"

        End If

        If GameRound = 3 Then
            Cash = "$300"

        End If

        If GameRound = 4 Then
            Cash = "$500"

        End If


        If GameRound = 5 Then
            Cash = "$1,000"

        End If

        If GameRound = 6 Then
            Cash = "$2,000"

        End If

        If GameRound = 7 Then
            Cash = "$4,000"

        End If


        If GameRound = 8 Then
            Cash = "$8,000"

        End If


        If GameRound = 9 Then
            Cash = "$16,000"

        End If


        If GameRound = 10 Then
            Cash = "$32,000"

        End If


        If GameRound = 11 Then
            Cash = "$64,000"

        End If


        If GameRound = 12 Then
            Cash = "$125,000"

        End If


        If GameRound = 13 Then
            Cash = "$250,000"

        End If


        If GameRound = 14 Then
            Cash = "$500,000"

        End If


        If GameRound = 15 Then
            Cash = "$1,000,000"

        End If

        Return Cash  'String is returned

    End Function

    'locks buttons
    Sub BtnLock()

        RadA.Enabled = False
        RadB.Enabled = False
        RadC.Enabled = False
        RadD.Enabled = False
    End Sub

    'unlocks buttons
    Sub BtnUnlock()

        RadA.Enabled = True
        RadB.Enabled = True
        RadC.Enabled = True
        RadD.Enabled = True
    End Sub

    Private Sub BtnPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPhone.Click

        MessageBox.Show("Call a Friend...")


        BtnPhone.Visible = False


    End Sub

    Private Sub Btn50_50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn50_50.Click


        If RadA.Text = CorrectAns Then
            RadC.Visible = False
            RadB.Visible = False

        ElseIf RadB.Text = CorrectAns Then
            RadA.Visible = False
            RadD.Visible = False

        ElseIf RadC.Text = CorrectAns Then
            RadB.Visible = False
            RadD.Visible = False

        ElseIf RadD.Text = CorrectAns Then
            RadC.Visible = False
            RadB.Visible = False

        End If

        Btn50_50.Visible = False


    End Sub



    Private Sub BtnAudience_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAudience.Click

        MessageBox.Show("Ask the audience...")


        If RadA.Text = CorrectAns Then
            MessageBox.Show("Audience voted:" & vbCrLf & "75% A, 25% B")


        ElseIf RadB.Text = CorrectAns Then
            MessageBox.Show("Audience voted:" & vbCrLf & "75% B, 25% B")

        ElseIf RadC.Text = CorrectAns Then
            MessageBox.Show("Audience voted:" & vbCrLf & "75% C, 25% B")

        ElseIf RadD.Text = CorrectAns Then
            MessageBox.Show("Audience voted:" & vbCrLf & "75% D, 25% B")

        End If

        BtnAudience.Visible = False



    End Sub



    Sub PlaySoundYes()

        My.Computer.Audio.Play(My.Resources.yes, _
           AudioPlayMode.Background)

    End Sub



    Sub PlaySoundNo()

        My.Computer.Audio.Play(My.Resources.no, _
           AudioPlayMode.Background)

      
    End Sub



    Sub PlaySoundWin()


        My.Computer.Audio.Play(My.Resources.million, _
           AudioPlayMode.Background)


    End Sub


    Private Sub BtnRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRules.Click

        Rules.Show()

        'Rules.ShowDialog()  'wont shift focus until box is closed

    End Sub

    'function returns file name of user selected file
    Private Function ReturnFileName() As String


        Dim openFD As New OpenFileDialog()

        Dim StrFileName As String = ""

        StrFileName = openFD.FileName


        openFD.InitialDirectory() = "Environment.SpecialFolder.Documents"
        openFD.Title = "Welcome!  Please Open a Text File for Questions"
        openFD.Filter = "Text Files|*.txt"
        openFD.ShowDialog()
        StrFileName = openFD.FileName


        Return StrFileName

    End Function


    Private Sub BtnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoad.Click

        Dim i As Integer = 0


        'MessageBox.Show(StrFileName)

        Dim FileName As String = ""

        FileName = ReturnFileName() 'runs filename search function and assings filename to string

        'loop continues until a text file is selected

        'for getting name of file
        Do While FileName = "" And i <= 3

            MessageBox.Show("Please select a proper file!")
            FileName = ReturnFileName() 'runs filename search function and assings filename to string
            i = i + 2
        Loop



        If i >= 3 Then
            'End
            ' MessageBox.Show("Application Ending")
            MessageBox.Show("No file selected")
        Else   'loads all the data from text file
            InputStr = IO.File.ReadAllLines(FileName) 'loaded into array, each element used
            BtnPlay.Visible = True
        End If
        
        'inputStr = IO.File.ReadAllLines(StrFileName) 'loaded into array, each element used

        ' InputStr = IO.File.ReadAllLines("Questions.txt") 'loaded into array, each element used


        'BtnPlay.Visible = True

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        BtnPlay.Visible = True
        BtnLoad.Visible = True
    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click

        CreateQuestions.Show()



    End Sub
End Class
