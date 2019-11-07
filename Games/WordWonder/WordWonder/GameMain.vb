

Public Class FrmMain

    Dim LoadedWords() As String 'for loading words into
    Dim FileName As String = ""
    Dim GameCounter As Integer = 0

    Dim LoadedArrayLength As Integer = 0
    Dim CurrentArrayElements As Integer = 0
    Dim UserInput As String = ""

    Dim CurrentWord As String = ""   'this is the current word in use.
    Dim BlankWords(50) As String  'This is the possible words with underscores, gets reset each round.
    Dim CharCurrentWord(50) As Char
    Dim Score As Double = 0

    Dim PossibleWords(50) As String 'for all the possible words/most important part, can have 50
    'Dim PossibleWords() As String 'for all the possible words



    '===================================================================================================================================
    'for Each Round 

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click

        '  ArrayElements = LoadedWords.Length()  may need to manually enter this?????


        '========================================================================
        'this all deals with a file not being loaded and the default word being used
        If FileName = "" Then
            DefaultLoad() 'loads the word VISUALBASIC (and all subwords) if no file is selected
        End If


        'this all deals with a file not being loaded and the default word being used
        If FileName = "" And GameCounter <= LoadedArrayLength Then
            GameCounter = 0 'restarts from the begining of word list if there are no more words in the list 
        End If
        '========================================================================

    
        TxtInput.Focus()
        Me.KeyPreview = True

        If FileName <> "" Then
            CurrentWord = LoadedWords(GameCounter) 'sets the current word (must do first)
        End If




        PlayRound() 'void function

        GameCounter = GameCounter + 1 'tracks the game iterations

        If GameCounter = LoadedArrayLength Then
            GameCounter = 0 'resets counter and start game at first array element
        End If

    End Sub


    Sub PlayRound()


        '  ShowMainWord()
        ToSingleLetters()
        ScrambleMain()

        Dim i As Integer = 0

        Do While i < CurrentArrayElements
            BlankWords(i) = UnderScores(PossibleWords(i))  'CONVERTS THE WORD TO UNDERSCORES
            i = i + 1
        Loop

        ShowPossibleWords() 'shows the possible words


        PassRound()



    End Sub

    'used during debugging
    Sub ShowMainWord()

        ' TxtMainWord.Text = (CurrentWord)


    End Sub

    Sub ToSingleLetters()      'do not need to send byval, 


        Dim i As Integer = 0   'for iterating the array elements


        '  CharCurrentWord(0) = CurrentWord.Chars(0)
        ' MessageBox.Show(CharCurrentWord(0))


        Do While i < (CurrentWord.Length())
            CharCurrentWord(i) = CurrentWord.Chars(i)
            i = i + 1
        Loop

        '   MessageBox.Show(CharCurrentWord)


    End Sub


    Sub ScrambleMain()

        Dim TempChar1 As Char
        Dim TempChar2 As Char
        Dim RandNum1 As Integer = 0
        Dim RandNum2 As Integer = 0
        Dim i As Integer = 0





        ' Generate random value between 0 and Character length. 

        Do While i < 30 'does 10 iterations


            RandNum1 = CInt(Int(((CurrentWord.Length()) * Rnd()) + 0))
            RandNum2 = CInt(Int(((CurrentWord.Length()) * Rnd()) + 0))

            TempChar1 = CharCurrentWord(RandNum1)
            TempChar2 = CharCurrentWord(RandNum2)
            CharCurrentWord(RandNum1) = TempChar2
            CharCurrentWord(RandNum2) = TempChar1

            i = i + 1
        Loop

        '  MessageBox.Show(CStr(CharCurrentWord))
        TxtMainWord.Text = (CStr(CharCurrentWord)) 'shows scrambled word


    End Sub





    Sub ShowPossibleWords()



        If PossibleWords(0) <> "" Then
            TxtWord1.Visible = True
            TxtWord1.Text = BlankWords(0)
        End If

        If PossibleWords(1) <> "" Then
            TxtWord2.Visible = True
            TxtWord2.Text = BlankWords(1)
        End If

        If PossibleWords(2) <> "" Then
            TxtWord3.Visible = True
            TxtWord3.Text = BlankWords(2)
        End If

        If PossibleWords(3) <> "" Then
            TxtWord4.Visible = True
            TxtWord4.Text = BlankWords(3)
        End If

        If PossibleWords(4) <> "" Then
            TxtWord5.Visible = True
            TxtWord5.Text = BlankWords(4)
        End If

        If PossibleWords(5) <> "" Then
            TxtWord6.Visible = True
            TxtWord6.Text = BlankWords(5)
        End If




    End Sub





    Function UnderScores(ByVal SentWord As String) As String

        Dim i As Integer = 0

        Dim BlankWord As String = ""

        Do While i < SentWord.Length()

            BlankWord = BlankWord + "_" + " " 'underscore and spaces

            i = i + 1
        Loop

        ' MessageBox.Show(BlankWord)

        Return BlankWord



    End Function


    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        CheckWord()

    End Sub


    Private Sub TxtInput_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Private Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress


        If e.KeyChar = ChrW(13) Then
            ' BtnSubmit.PerformClick()
            CheckWord()
        End If


        ' Me.KeyPreview = False
        'Me.Focus()

    End Sub





    Sub CheckWord()

        Me.KeyPreview = False

        UserInput = ""

        UserInput = ((TxtInput.Text()).ToUpper)
        TxtInput.Clear()

        MessageBox.Show(UserInput)


        If UserInput = PossibleWords(0) Then
            TxtWord1.Text = UserInput

        ElseIf UserInput = PossibleWords(1) Then
            TxtWord2.Text = UserInput

        ElseIf UserInput = PossibleWords(2) Then
            TxtWord3.Text = UserInput

        ElseIf UserInput = PossibleWords(3) Then
            TxtWord4.Text = UserInput

        ElseIf UserInput = PossibleWords(4) Then
            TxtWord5.Text = UserInput

        ElseIf UserInput = PossibleWords(5) Then
            TxtWord6.Text = UserInput

        ElseIf UserInput = PossibleWords(6) Then
            TxtWord7.Text = UserInput

        ElseIf UserInput = PossibleWords(7) Then
            TxtWord8.Text = UserInput

        End If


    End Sub




    Sub PassRound()


    End Sub






    'loads user selected txt file
    Sub LoadFile()

        Dim i As Integer = 0

        Dim openFD As New OpenFileDialog()

        'Dim StrFileName As String = ""

        'StrFileName = openFD.FileName

        Do While FileName = "" And i <= 2

            openFD.InitialDirectory() = "Environment.SpecialFolder.Documents"
            openFD.Title = "Please Open a Text File for Word Wonder!"
            openFD.Filter = "Text Files|*.txt"
            openFD.ShowDialog()
            FileName = openFD.FileName

            i = i + 2
        Loop

        If FileName = "" Then
            ' FileName = "Test.txt"
            MessageBox.Show("No file selected, default Test file loaded.")
            'LoadedWords(0) = "VISUALBASIC"
        Else
            ParseWords()
        End If

        GameCounter = 0 'since loaded a file

    End Sub


    Sub DefaultLoad()


        MessageBox.Show("No file selected, default Test file loaded.")
        CurrentWord = "VISUALBASIC"
        PossibleWords(0) = "VISUALBASIC"
        PossibleWords(1) = "BASIC"
        PossibleWords(2) = "BAIL"
        PossibleWords(3) = "SAIL"
        PossibleWords(4) = "BASS"
        PossibleWords(5) = "VISUAL"

        'only current array elements since just dealing with 1 load for the PossibleWords array
        CurrentArrayElements = 6 'since only 1 word is loaded.
        LoadedArrayLength = 1


    End Sub




    Sub ParseWords()

        LoadedWords = IO.File.ReadAllLines(FileName) 'loaded into array, each element used

        LoadedArrayLength = LoadedWords.Length() 'get a count of total words and subwords before the split


    End Sub



    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
        End
    End Sub

    Private Sub BtnLoadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadFile.Click

        LoadFile()

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLoadFile.Visible = False 'for right now..


        'Me.KeyPreview = True



    End Sub


    Private Sub BtnShuffle_Click(sender As Object, e As EventArgs) Handles BtnShuffle.Click
        ScrambleMain()
    End Sub

    Private Sub TxtInput_Click(sender As Object, e As EventArgs) Handles TxtInput.Click
        TxtInput.Clear()
    End Sub
End Class
