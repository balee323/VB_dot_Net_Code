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
    Dim Hanged As Integer = 0
    Dim CurrentWordLength As Integer = 0
    Dim BlankCharArray(200) As Char  'keep as global. gets reset each round, I give up will just make 200 spots..


    'for Each Round
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click


        CheckFileLoad() 'loads one word into LoadedWord Array

        PlayRound() 'plays each round using a string element from LoadedWords()


        GameCounter = GameCounter + 1 'tracks the game iterations

        If GameCounter = WordArrayElements Then

            GameCounter = 0

        End If

    End Sub


    Sub CheckFileLoad()


        Hanged = 0 ' reset
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
            'else a file is selected
            'WordArrayElements = LoadedWords.Length() 'this is to interate the game rounds
            WordArrayElements = LoadedString.Length() 'this is to interate the game rounds


        End If





        'this all deals with a file not being loaded and the default word being used

        If FileName = "" And GameCounter <= WordArrayElements Then
            GameCounter = 0 'restarts from the begining of word list if there are no more words in the list
            '   MessageBox.Show("There are :" & WordArrayElements & "  Words loaded")
        Else
            '   MessageBox.Show("There are :" & WordArrayElements & "  Words loaded")

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

        TxtHint.Text = LoadedHints(GameCounter)


        PIC1.Visible = True
        PIC2.Visible = True
        PIC3.Visible = True
        PIC4.Visible = True
        PIC5.Visible = True

     
        UnderScores()  'CONVERTS THE WORD TO UNDERSCORES, seems ok., dont think I need?

        ToSingleBlanks()  'setting char array to blanks  (also appears to work!)  

        ToSingleLetters()  'Returns the current word as an character array


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


       

    End Sub



    
    Sub UnderScores()

        Dim i As Integer = 0



        Do While i < CurrentWordLength

            BlankWord = BlankWord + "_"

            i = i + 1
        Loop

        '  MessageBox.Show(BlankWord)




    End Sub




    'converts all the blanks to characters, returns the underscore String as characters with a space between each character.

    Sub ToSingleBlanks()     'do not need to send byval, blankword is a class variable

        Dim Space As Char = " "c  'allows declaration  of char variable.  EX.  ="A"c

        Dim i As Integer = 0   'for iterating the array elements
        Dim j As Integer = 1   'for iterating the spaces
        Dim k As Integer = 0  'for iterating the word

        Dim ArrayLength As Integer = (((CurrentWord.Length()) * 2) - 1)   'shopuld be 21 spaces for the test word

        ' Dim ArrayLength As Integer = (30)   'shopuld be 21 spaces for the test word


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



        ' MessageBox.Show("Number of chacters is: " & CStr(SingleLetter.Length()))  'correct  says 11! right, oh but counting spaces I Bet!
        '  MessageBox.Show(SingleLetter)  'display the character array.

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
            ' SingleLetter(i) = StrTestWord.Chars(k)  'only showing half of the word...

            WordAsCharacters(i) = CurrentWord.Chars(k)

            Do While j < ((CurrentWordLength * 2) - 1) 'appears to work now..

                WordAsCharacters(j) = Space
                j = j + 2
            Loop

            i = i + 2
            k = k + 1
        Loop While i <= ((CurrentWordLength * 2) - 1)



        ' MessageBox.Show("Number of chacters is: " & CStr(SingleLetter.Length()))  'correct  says 11! right, oh but counting spaces I Bet!
        '    MessageBox.Show(WordAsCharacters(0)) 'h
        '    MessageBox.Show(WordAsCharacters(1))
        '   MessageBox.Show(WordAsCharacters(2)) 'e
        '   MessageBox.Show(WordAsCharacters(3))
        '    MessageBox.Show(WordAsCharacters(4)) 'l
        '    MessageBox.Show(WordAsCharacters(5))
        '   MessageBox.Show(WordAsCharacters(6)) 'l  stops after this...
        '   MessageBox.Show(WordAsCharacters(7))
        '   MessageBox.Show(WordAsCharacters(8)) 'o

        '    TxtWordBox.Text = SingleLetter



    End Sub





    Private Sub A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A.Click
        CheckLetter("A")
        KillStickMan()
        Dim Letter As Char = "A"c
        ShowLetter(Letter)
        A.Visible = False
    End Sub

    Private Sub B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B.Click
        CheckLetter("B")
        KillStickMan()
        Dim Letter As Char = "B"c
        ShowLetter(Letter)
        B.Visible = False
    End Sub

    Private Sub C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.Click
        CheckLetter("C")
        KillStickMan()
        Dim Letter As Char = "C"c
        ShowLetter(Letter)
        C.Visible = False
    End Sub

    Private Sub D_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D.Click
        CheckLetter("D")
        KillStickMan()
        Dim Letter As Char = "D"c
        ShowLetter(Letter)
        D.Visible = False
    End Sub

    Private Sub EE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EE.Click
        CheckLetter("E")
        KillStickMan()
        Dim Letter As Char = "E"c
        ShowLetter(Letter)
        EE.Visible = False
    End Sub

    Private Sub F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F.Click
        CheckLetter("F")
        KillStickMan()
        Dim Letter As Char = "F"c
        ShowLetter(Letter)
        F.Visible = False
    End Sub

    Private Sub G_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G.Click
        CheckLetter("G")
        KillStickMan()
        Dim Letter As Char = "G"c
        ShowLetter(Letter)
        G.Visible = False
    End Sub

    Private Sub H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H.Click
        CheckLetter("H")
        KillStickMan()
        Dim Letter As Char = "H"c
        ShowLetter(Letter)
        H.Visible = False
    End Sub

    Private Sub I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I.Click
        CheckLetter("I")
        KillStickMan()
        Dim Letter As Char = "I"c
        ShowLetter(Letter)
        I.Visible = False
    End Sub

    Private Sub J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J.Click
        CheckLetter("J")
        KillStickMan()
        Dim Letter As Char = "J"c
        ShowLetter(Letter)
        J.Visible = False
    End Sub

    Private Sub K_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles K.Click
        CheckLetter("K")
        KillStickMan()
        Dim Letter As Char = "K"c
        ShowLetter(Letter)
        K.Visible = False
    End Sub

    Private Sub L_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.Click
        CheckLetter("L")
        KillStickMan()
        Dim Letter As Char = "L"c
        ShowLetter(Letter)
        L.Visible = False
    End Sub

    Private Sub M_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M.Click
        CheckLetter("M")
        KillStickMan()
        Dim Letter As Char = "M"c
        ShowLetter(Letter)
        M.Visible = False
    End Sub

    Private Sub N_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N.Click
        CheckLetter("N")
        KillStickMan()
        Dim Letter As Char = "N"c
        ShowLetter(Letter)
        N.Visible = False
    End Sub

    Private Sub O_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O.Click
        CheckLetter("O")
        KillStickMan()
        Dim Letter As Char = "O"c
        ShowLetter(Letter)
        O.Visible = False
    End Sub

    Private Sub P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P.Click
        CheckLetter("P")
        KillStickMan()
        Dim Letter As Char = "P"c
        ShowLetter(Letter)
        P.Visible = False
    End Sub

    Private Sub Q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Q.Click
        CheckLetter("Q")
        KillStickMan()
        Dim Letter As Char = "Q"c
        ShowLetter(Letter)
        Q.Visible = False
    End Sub

    Private Sub R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R.Click
        CheckLetter("R")
        KillStickMan()
        Dim Letter As Char = "R"c
        ShowLetter(Letter)
        R.Visible = False
    End Sub

    Private Sub S_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S.Click
        CheckLetter("S")
        KillStickMan()
        Dim Letter As Char = "S"c
        ShowLetter(Letter)
        S.Visible = False
    End Sub

    Private Sub T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T.Click
        CheckLetter("T")
        KillStickMan()
        Dim Letter As Char = "T"c
        ShowLetter(Letter)
        T.Visible = False
    End Sub

    Private Sub U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles U.Click
        CheckLetter("U")
        KillStickMan()
        Dim Letter As Char = "U"c
        ShowLetter(Letter)
        U.Visible = False
    End Sub

    Private Sub V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V.Click
        CheckLetter("V")
        KillStickMan()
        Dim Letter As Char = "V"c
        ShowLetter(Letter)
        V.Visible = False
    End Sub

    Private Sub W_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles W.Click
        CheckLetter("W")
        KillStickMan()
        Dim Letter As Char = "W"c
        ShowLetter(Letter)
        W.Visible = False
    End Sub

    Private Sub X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X.Click
        CheckLetter("X")
        KillStickMan()
        Dim Letter As Char = "X"c
        ShowLetter(Letter)
        X.Visible = False
    End Sub

    Private Sub Y_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Y.Click
        CheckLetter("Y")
        KillStickMan()
        Dim Letter As Char = "Y"c
        ShowLetter(Letter)
        Y.Visible = False
    End Sub

    Private Sub Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Z.Click
        CheckLetter("Z")
        KillStickMan()
        Dim Letter As Char = "Z"c
        ShowLetter(Letter)
        Z.Visible = False
    End Sub

    Sub CheckLetter(ByVal letter As String)

        Dim LetterCheck As String = ""
        ' Dim CharWord(StrTestWord.Length() - 1) As Char  'Character array
        Dim i As Integer = 0
        Dim Found As Boolean = False



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
            Hanged = Hanged + 1
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


        If FoundCount = CurrentWordLength Then

            MessageBox.Show("Winner")
            Score = Score + (FoundCount * 25)
            TxtScore.Text = (CStr(Score))
        End If


    End Sub





    Sub KillStickMan()

        '   MessageBox.Show(CStr(Hanged) & " Strikes")  'works here too...

        If Hanged >= 1 Then
            PIC1.Visible = False
            'MessageBox.Show("First If Works")
        End If


        If Hanged >= 2 Then
            PIC2.Visible = False
            'MessageBox.Show("Second If Works")
        End If


        If Hanged >= 3 Then
            PIC3.Visible = False
        End If


        If Hanged >= 4 Then
            PIC4.Visible = False
        End If


        If Hanged >= 5 Then
            PIC5.Visible = False
        End If


        If Hanged >= 6 Then
            MessageBox.Show("Game Over!")
        End If




    End Sub





    Sub ClearCharArray()

        Dim i As Integer = 0

        'clears arrays
        Array.Clear(BlankCharArray, BlankCharArray.GetLowerBound(0), BlankCharArray.Length())
        Array.Clear(WordAsCharacters, WordAsCharacters.GetLowerBound(0), WordAsCharacters.Length())


    End Sub




    'loads user selected txt file
    Sub LoadFile()

        Dim i As Integer = 0

        Dim openFD As New OpenFileDialog()

        'Dim StrFileName As String = ""

        'StrFileName = openFD.FileName

        Do While FileName = "" And i <= 2

            openFD.InitialDirectory() = "Environment.SpecialFolder.Documents"
            openFD.Title = "Please Open a Text File for HANGMAN GAME"
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
End Class
