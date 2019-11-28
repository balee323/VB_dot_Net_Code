Public Class GameMain

    Dim LoadedString() As String 'for the text file string line by line
    Dim LoadedWords(200) As String 'for loading words into
    Dim LoadedHints(200) As String ' for loading of hints
    Dim FileName As String = ""
    Dim GameCounter As Integer = 0
    Dim WordArrayElements As Integer = 0 'the number of elements in the array
    Dim BlankWord As String = ""  'This is the word replaced with underscores, gets reset each round.
    Dim FoundCount As Integer = 0
    Dim Score As Double = 0

    Dim CurrentWord As String = ""   'this is the current word in use.
    Dim WordAsCharacters(200) As Char   'keep this as gobal, gets reset later
    Dim WrongGuess As Integer = 0
    Dim CurrentWordLength As Integer = 0
    Dim BlankCharArray(200) As Char  'keep as global. gets reset each round, I give up will just make 200 spots..

    Dim ContinueGame As Boolean = False 'accepts keystokes, false=no, true=yes
    Dim HighScore() As String
    Dim HighestScore As String = ""

    Dim PigImages As List(Of Image)
    Dim SadPigImages As List(Of Image)

    'VARIABLES for ensuring that only 1 keystroke is registered
    Dim PressedA As Boolean = False
    Dim PressedB As Boolean = False
    Dim PressedC As Boolean = False
    Dim PressedD As Boolean = False
    Dim PressedE As Boolean = False
    Dim PressedF As Boolean = False
    Dim PressedG As Boolean = False
    Dim PressedH As Boolean = False
    Dim PressedI As Boolean = False
    Dim PressedJ As Boolean = False
    Dim PressedK As Boolean = False
    Dim PressedL As Boolean = False
    Dim PressedM As Boolean = False
    Dim PressedN As Boolean = False
    Dim PressedO As Boolean = False
    Dim PressedP As Boolean = False
    Dim PressedQ As Boolean = False
    Dim PressedR As Boolean = False
    Dim PressedS As Boolean = False
    Dim PressedT As Boolean = False
    Dim PressedU As Boolean = False
    Dim PressedV As Boolean = False
    Dim PressedW As Boolean = False
    Dim PressedX As Boolean = False
    Dim PressedY As Boolean = False
    Dim PressedZ As Boolean = False




    'for Each Round
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        LblWinner.Hide()
        LblGameOver.Hide()

        PicBoxPig.Image = Nothing

        TxtHighScore.Text = (HighestScore)


        FoundCount = 0 'redudant clear

        CheckFileLoad() 'loads one word into LoadedWord Array

        PlayRound() 'plays each round using a string element from LoadedWords()

        GameCounter = GameCounter + 1 'tracks the game iterations

        'resets counter back to first word
        If GameCounter = WordArrayElements Then

            GameCounter = 0

        End If

    End Sub


    Sub CheckFileLoad()


        WrongGuess = 0 ' reset
        BlankWord = "" 'reset
        ClearCharArray() 'reset
        CurrentWord = ""
        TxtWordBox.Text = ("")
        TxtHint.Text = ("")
        FoundCount = 0


        'only occurs if no loaded file is selected before the player clicks start
        If FileName = "" Then
            DefaultLoad() 'loads the word VISUALBASIC if no file is selected

        Else

            WordArrayElements = LoadedString.Length() 'this is to interate the game rounds

        End If



        'this all deals with a file not being loaded and the default word being used
        If FileName = "" And GameCounter <= WordArrayElements Then
            GameCounter = 0 'restarts from the begining of word list if there are no more words in the list
        End If


        If FileName <> "" Then
            CurrentWord = LoadedWords(GameCounter) 'sets the current word (must do first)
            CurrentWordLength = CurrentWord.Length()

        Else
            CurrentWordLength = CurrentWord.Length()

        End If

        '  MessageBox.Show("Current Word Length: " & CStr(CurrentWordLength))





    End Sub



    Sub PlayRound()


        ContinueGame = True

        TxtHint.Text = LoadedHints(GameCounter)

        'RESET VISIBLITY OF LABELS EACH ROUND
        A.Visible() = True
        B.Visible() = True
        C.Visible() = True
        D.Visible() = True
        EE.Visible() = True
        F.Visible() = True
        G.Visible() = True
        H.Visible() = True
        I.Visible() = True
        J.Visible() = True
        K.Visible() = True
        L.Visible() = True
        M.Visible() = True
        N.Visible() = True
        O.Visible() = True
        P.Visible() = True
        Q.Visible() = True
        R.Visible() = True
        S.Visible() = True
        T.Visible() = True
        U.Visible() = True
        V.Visible() = True
        W.Visible() = True
        X.Visible() = True
        Y.Visible() = True
        Z.Visible() = True

        'RESET HANGMAN PICTURES EACH ROUND
        PIC1.Visible = True
        PIC2.Visible = True
        PIC3.Visible = True
        PIC4.Visible = True
        PIC5.Visible = True

        'RESET KEYSTROKES EACH ROUND
        PressedA = False
        PressedB = False
        PressedC = False
        PressedD = False
        PressedE = False
        PressedF = False
        PressedG = False
        PressedH = False
        PressedI = False
        PressedJ = False
        PressedK = False
        PressedL = False
        PressedM = False
        PressedN = False
        PressedO = False
        PressedP = False
        PressedQ = False
        PressedR = False
        PressedS = False
        PressedT = False
        PressedU = False
        PressedV = False
        PressedW = False
        PressedX = False
        PressedY = False
        PressedZ = False


        UnderScores()  'CONVERTS THE WORD TO UNDERSCORES, seems ok., dont think I need?

        ToSingleBlanks()  'setting char array to blanks  (also appears to work!)  

        ToSingleLetters()  'Returns the current word as an character array

    End Sub

    Sub UnderScores()

        Dim i As Integer = 0


        Do While i < CurrentWordLength

            BlankWord = BlankWord + "_"

            i = i + 1
        Loop

    End Sub


    'converts all the blanks to characters, returns the underscore String as characters with a space between each character.

    Sub ToSingleBlanks()     'do not need to send byval, blankword is a class variable

        Dim Space As Char = " "c  'allows declaration  of char variable.  EX.  ="A"c

        Dim i As Integer = 0   'for iterating the array elements
        Dim j As Integer = 1   'for iterating the spaces
        Dim k As Integer = 0  'for iterating the word

        Dim ArrayLength As Integer = (((CurrentWord.Length()) * 2) - 1)   'shopuld be 21 spaces for the test word


        '    MessageBox.Show(CStr(ArrayLength)) 'says 9
        '    MessageBox.Show(CStr(BlankCharArray.Length())) 'just made BlankCharArray 200 elements...


        Do

            BlankCharArray(i) = BlankWord.Chars(k)

            Do While j < (ArrayLength) 'appears to work now..

                BlankCharArray(j) = Space
                j = j + 2
            Loop

            i = i + 2
            k = k + 1
        Loop While i <= (ArrayLength)


        TxtWordBox.Text = BlankCharArray  'displays the blanks


    End Sub



    'converts A String to characters.
    Sub ToSingleLetters()      'do not need to send byval, 
        Dim Space As Char = " "c  'allows declaration  of char variable.  EX.  ="A"c

        Dim i As Integer = 0   'for iterating the array elements
        Dim j As Integer = 1   'for iterating the spaces
        Dim k As Integer = 0  'for iterating the word


        '    MessageBox.Show(CStr(ArrayLength)) '21 is right!

        Do

            WordAsCharacters(i) = CurrentWord.Chars(k)

            Do While j < ((CurrentWordLength * 2) - 1) 'appears to work now..

                WordAsCharacters(j) = Space
                j = j + 2
            Loop

            i = i + 2
            k = k + 1
        Loop While i <= ((CurrentWordLength * 2) - 1)

    End Sub



    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress


        Dim Letter As Char




        If ContinueGame = True Then

            If e.KeyChar = ChrW(65) Or e.KeyChar = ChrW(97) Then


                Do While PressedA = False
                    CheckLetter("A")
                    KillStickMan()
                    Letter = "A"c
                    ShowLetter(Letter)
                    PressedA = True
                    A.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(66) Or e.KeyChar = ChrW(98) Then

                Do While PressedB = False
                    CheckLetter("B")
                    KillStickMan()
                    Letter = "B"c
                    ShowLetter(Letter)
                    PressedB = True
                    B.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(67) Or e.KeyChar = ChrW(99) Then

                Do While PressedC = False
                    CheckLetter("C")
                    KillStickMan()
                    Letter = "C"c
                    ShowLetter(Letter)
                    PressedC = True
                    C.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(68) Or e.KeyChar = ChrW(100) Then

                Do While PressedD = False
                    CheckLetter("D")
                    KillStickMan()
                    Letter = "D"c
                    ShowLetter(Letter)
                    PressedD = True
                    D.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(69) Or e.KeyChar = ChrW(101) Then

                Do While PressedE = False
                    CheckLetter("E")
                    KillStickMan()
                    Letter = "E"c
                    ShowLetter(Letter)
                    PressedE = True
                    EE.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(70) Or e.KeyChar = ChrW(102) Then

                Do While PressedF = False
                    CheckLetter("F")
                    KillStickMan()
                    Letter = "F"c
                    ShowLetter(Letter)
                    PressedF = True
                    F.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(71) Or e.KeyChar = ChrW(103) Then

                Do While PressedG = False
                    CheckLetter("G")
                    KillStickMan()
                    Letter = "G"c
                    ShowLetter(Letter)
                    PressedG = True
                    G.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(72) Or e.KeyChar = ChrW(104) Then

                Do While PressedH = False
                    CheckLetter("H")
                    KillStickMan()
                    Letter = "H"c
                    ShowLetter(Letter)
                    PressedH = True
                    H.Visible = False
                Loop



            ElseIf e.KeyChar = ChrW(73) Or e.KeyChar = ChrW(105) Then

                Do While PressedI = False
                    CheckLetter("I")
                    KillStickMan()
                    Letter = "I"c
                    ShowLetter(Letter)
                    PressedI = True
                    I.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(74) Or e.KeyChar = ChrW(106) Then

                Do While PressedJ = False
                    CheckLetter("J")
                    KillStickMan()
                    Letter = "J"c
                    ShowLetter(Letter)
                    PressedJ = True
                    J.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(75) Or e.KeyChar = ChrW(107) Then

                Do While PressedK = False
                    CheckLetter("K")
                    KillStickMan()
                    Letter = "K"c
                    ShowLetter(Letter)
                    PressedK = True
                    K.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(76) Or e.KeyChar = ChrW(108) Then

                Do While PressedL = False
                    CheckLetter("L")
                    KillStickMan()
                    Letter = "L"c
                    ShowLetter(Letter)
                    PressedL = True
                    L.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(77) Or e.KeyChar = ChrW(109) Then
                Do While PressedM = False
                    CheckLetter("M")
                    KillStickMan()
                    Letter = "M"c
                    ShowLetter(Letter)
                    PressedM = True
                    M.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(78) Or e.KeyChar = ChrW(110) Then
                Do While PressedN = False
                    CheckLetter("N")
                    KillStickMan()
                    Letter = "N"c
                    ShowLetter(Letter)
                    PressedN = True
                    N.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(79) Or e.KeyChar = ChrW(111) Then
                Do While PressedO = False
                    CheckLetter("O")
                    KillStickMan()
                    Letter = "O"c
                    ShowLetter(Letter)
                    PressedO = True
                    O.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(80) Or e.KeyChar = ChrW(112) Then
                Do While PressedP = False
                    CheckLetter("P")
                    KillStickMan()
                    Letter = "P"c
                    ShowLetter(Letter)
                    PressedP = True
                    P.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(81) Or e.KeyChar = ChrW(113) Then
                Do While PressedQ = False
                    CheckLetter("Q")
                    KillStickMan()
                    Letter = "Q"c
                    ShowLetter(Letter)
                    PressedQ = True
                    Q.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(82) Or e.KeyChar = ChrW(114) Then
                Do While PressedR = False
                    CheckLetter("R")
                    KillStickMan()
                    Letter = "R"c
                    ShowLetter(Letter)
                    PressedR = True
                    R.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(83) Or e.KeyChar = ChrW(115) Then
                Do While PressedS = False
                    CheckLetter("S")
                    KillStickMan()
                    Letter = "S"c
                    ShowLetter(Letter)
                    PressedS = True
                    S.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(84) Or e.KeyChar = ChrW(116) Then
                Do While PressedT = False
                    CheckLetter("T")
                    KillStickMan()
                    Letter = "T"c
                    ShowLetter(Letter)
                    PressedT = True
                    T.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(85) Or e.KeyChar = ChrW(117) Then
                Do While PressedU = False
                    CheckLetter("U")
                    KillStickMan()
                    Letter = "U"c
                    ShowLetter(Letter)
                    PressedU = True
                    U.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(86) Or e.KeyChar = ChrW(118) Then
                Do While PressedV = False
                    CheckLetter("V")
                    KillStickMan()
                    Letter = "V"c
                    ShowLetter(Letter)
                    PressedV = True
                    V.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(87) Or e.KeyChar = ChrW(119) Then
                Do While PressedW = False
                    CheckLetter("W")
                    KillStickMan()
                    Letter = "W"c
                    ShowLetter(Letter)
                    PressedW = True
                    W.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(88) Or e.KeyChar = ChrW(120) Then
                Do While PressedX = False
                    CheckLetter("X")
                    KillStickMan()
                    Letter = "X"c
                    ShowLetter(Letter)
                    PressedX = True
                    X.Visible = False
                Loop


            ElseIf e.KeyChar = ChrW(89) Or e.KeyChar = ChrW(121) Then
                Do While PressedY = False
                    CheckLetter("Y")
                    KillStickMan()
                    Letter = "Y"c
                    ShowLetter(Letter)
                    PressedY = True
                    Y.Visible = False
                Loop

            ElseIf e.KeyChar = ChrW(90) Or e.KeyChar = ChrW(122) Then
                Do While PressedZ = False
                    CheckLetter("Z")
                    KillStickMan()
                    Letter = "Z"c
                    ShowLetter(Letter)
                    PressedZ = True
                    Z.Visible = False
                Loop
            End If

        End If 'StartGame = true/false

    End Sub





    Sub CheckLetter(ByVal letter As String)

        Dim Found As Boolean = False

        Dim LetterCheck As String = ""
        ' Dim CharWord(StrTestWord.Length() - 1) As Char  'Character array
        Dim i As Integer = 0





        Do While i < CurrentWord.Length()

            If CurrentWord.Chars(i) = letter Then
                'LetterCheck = StrTestWord.Chars(i)
                '  MessageBox.Show("found one!")
                Found = True
                FoundCount = FoundCount + 1
                'BlankWord.Chars(i) = StrTestWord.Chars(i)

                'ConvertedWord.Substring = letter
            End If
            i = i + 1
        Loop

        ' MessageBox.Show(LetterCheck)  'works

        If Found = False Then
            WrongGuess = WrongGuess + 1
        End If
        ' MessageBox.Show(CStr(Hanged)) 'works too



    End Sub



    Sub ShowLetter(ByVal Letter As Char)

        Dim ArrayLength As Integer = (((CurrentWord.Length()) * 2) - 1)  '
        Dim i As Integer = 0

        Do While (i <= ArrayLength)
            If Letter = WordAsCharacters(i) Then
                BlankCharArray(i) = Letter
            End If

            i = i + 1

        Loop


        TxtWordBox.Text = (BlankCharArray)

        If FoundCount = CurrentWordLength Then  'check FoundCount
            ContinueGame = False 'ends keyboard input
            Score = Score + (FoundCount * 25)
            TxtScore.Text = (CStr(Score))
            LblWinner.Show()


            Dim random = New Random(DateTime.Now.Second).Next(PigImages.Count - 1)
            PicBoxPig.Image = PigImages.Item(random)

        End If


    End Sub


    Sub KillStickMan()

        '   MessageBox.Show(CStr(Hanged) & " Strikes")  'works here too...

        Dim difficultyFactor As Integer = CInt((GetDifficultyTries() / 5))




        If WrongGuess >= difficultyFactor * 1 Then
            PIC1.Visible = False
        End If


        If WrongGuess >= difficultyFactor * 2 Then
            PIC2.Visible = False
        End If


        If WrongGuess >= difficultyFactor * 3 Then
            PIC3.Visible = False
        End If


        If WrongGuess >= difficultyFactor * 4 Then
            PIC4.Visible = False
        End If


        If WrongGuess >= difficultyFactor * 5 Then
            PIC5.Visible = False

            Dim random = New Random(DateTime.Now.Second).Next(SadPigImages.Count - 1)
            PicBoxPig.Image = SadPigImages.Item(random)
            PicBoxPig.Show()

            LblGameOver.Show()
            ContinueGame = False 'ends keyboard input
        End If


    End Sub



    Function GetDifficultyTries() As Integer

        Dim difficulty As String = ComboBox1.SelectedItem.ToString()

        If difficulty.ToLower() = "easy" Then
            Return 15
        ElseIf difficulty.ToLower() = "medium" Then
            Return 8
        ElseIf difficulty.ToLower() = "hard" Then
            Return 5
        End If

    End Function


    Sub ClearCharArray()

        Dim i As Integer = 0

        'clears arrays
        Array.Clear(BlankCharArray, BlankCharArray.GetLowerBound(0), BlankCharArray.Length())
        Array.Clear(WordAsCharacters, WordAsCharacters.GetLowerBound(0), WordAsCharacters.Length())


    End Sub


    'loads user selected txt file
    Sub LoadFile()

        Dim openFD As New OpenFileDialog()

        openFD.InitialDirectory() = Environment.CurrentDirectory + "\WordList"
        openFD.Title = "Please Open a Text File for HANGMAN GAME"
        openFD.Filter = "Text Files|*.txt"
        openFD.ShowDialog()
        FileName = openFD.FileName



        If FileName = "" Then
            MessageBox.Show("No file selected, default Test file loaded.")
        Else
            ParseWords()
            ComboBox1.Enabled = True
        End If

        GameCounter = 0 'since loaded a file

    End Sub


    Sub DefaultLoad()


        MessageBox.Show("No file selected, default Test file loaded.")
        CurrentWord = "VISUALBASIC"
        WordArrayElements = 1 'since only 1 word is loaded.


    End Sub




    Sub ParseWords()

        'LoadedWords = IO.File.ReadAllLines(FileName) 'loaded into array, each element used

        LoadedString = IO.File.ReadAllLines(FileName) 'loaded into array, each element used

        Dim i As Integer = 0

        While i < LoadedString.Length()

            LoadedWords(i) = LoadedString(i).Substring(0, (LoadedString(i).IndexOf("/")))
            LoadedHints(i) = "Hint: " & LoadedString(i).Substring((LoadedString(i).IndexOf("/")) + 1)

            i = i + 1

        End While

    End Sub



    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
        End
    End Sub

    Private Sub BtnLoadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadFile.Click

        FileName = "" 'resets so a new file can be loaded on each button click

        LoadFile()


    End Sub

    Private Sub GameMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LblWinner.Hide()
        LblGameOver.Hide()

        PigImages = New List(Of Image)
        PigImages.Add(My.Resources.Pig1)
        PigImages.Add(My.Resources.pig2)
        PigImages.Add(My.Resources.pig3)


        SadPigImages = New List(Of Image)
        SadPigImages.Add(My.Resources.Pig1Sad)
        SadPigImages.Add(My.Resources.pig2Sad)
        SadPigImages.Add(My.Resources.pig3Sad)


        Me.Focus()
        Me.KeyPreview = True  'important


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted

        BtnStart.Enabled = True

    End Sub

End Class
