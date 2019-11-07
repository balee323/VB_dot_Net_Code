Public Class Form1

    Dim StrTestWord As String = "VISUALBASIC"
    Dim StrTestWordChar() As Char
    'Dim GuessedLetter As String = ""  'THIS IS THE GUESSED LETTER
    Dim BlankWord As String = ""  'This is the word replaced with underscores
    Dim Hanged As Integer = 0
    'Dim SingleWordArray As String 'String array for blankword
    Dim BlankCharArray() As Char






    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click

        'Dim StrTestWord As String = "VisualBasic"

        ' Dim GuessedLetter As String = ""  'THIS IS THE GUESSED LETTER

        'all function calls should only occur once when BtnStart is clicked


        PIC1.Visible = True
        PIC2.Visible = True
        PIC3.Visible = True
        PIC4.Visible = True
        PIC5.Visible = True

        Hanged = 0

        Dim WordLength As Integer = 0
        Dim iterator As Integer = 0

        WordLength = StrTestWord.Length()  '

        BlankWord = UnderScores(StrTestWord)  'CONVERTS THE WORD TO UNDERSCORES

        BlankCharArray = ToSingleBlanks()  'setting char array to blanks  (also appears to work!)  

        StrTestWordChar = ToSingleLetters()  'convert the test word to characters




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


    Sub CheckLetter(ByVal letter As String)

        Dim LetterCheck As String = ""
        ' Dim CharWord(StrTestWord.Length() - 1) As Char  'Character array
        Dim i As Integer = 0
        Dim Found As Boolean = False

        Do While i < StrTestWord.Length()

            If StrTestWord.Chars(i) = letter Then
                'LetterCheck = StrTestWord.Chars(i)
                '  MessageBox.Show("found one!")
                Found = True
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

    Function UnderScores(ByVal Word As String) As String

        Dim LetterCount As Integer = 0
        Dim i As Integer = 0
        Dim BlankWord As String = ""


        LetterCount = Word.Length()

        Do While i < LetterCount

            BlankWord = BlankWord + "_"

            i = i + 1
        Loop

        'TxtWordBox.Text = BlankWord0

        Return BlankWord


    End Function

    'converts all the blanks to characters.
    Function ToSingleBlanks() As Char()     'do not need to send byval, blankword is a class variable

        Dim Space As Char = " "c  'allows declaration  of char variable.  EX.  ="A"c

        Dim i As Integer = 0   'for iterating the array elements
        Dim j As Integer = 1   'for iterating the spaces
        Dim k As Integer = 0  'for iterating the word

        Dim ArrayLength As Integer = (((StrTestWord.Length()) * 2) - 1)  'shopuld be 21 spaces
        Dim SingleLetter(ArrayLength) As Char    'setting ArrayLength larger to account for spaces, should be 21

        '   MessageBox.Show(CStr(ArrayLength)) '21 is right!

        Do
            ' SingleLetter(i) = StrTestWord.Chars(k)  'only showing half of the word...

            SingleLetter(i) = BlankWord.Chars(k)

            Do While j < (ArrayLength) 'appears to work now..

                SingleLetter(j) = Space
                j = j + 2
            Loop

            i = i + 2
            k = k + 1
        Loop While i <= (ArrayLength)



        ' MessageBox.Show("Number of chacters is: " & CStr(SingleLetter.Length()))  'correct  says 11! right, oh but counting spaces I Bet!
        '  MessageBox.Show(SingleLetter)  'display the character array.

        TxtWordBox.Text = SingleLetter

        Return SingleLetter  'array


    End Function


    Sub ShowLetter(ByVal Letter As Char)

        Dim ArrayLength As Integer = (((StrTestWord.Length()) * 2) - 1)  'shopuld be 21 spaces
        Dim i As Integer = 0

        Do While (i <= ArrayLength)
            If Letter = StrTestWordChar(i) Then
                BlankCharArray(i) = Letter
            End If

            i = i + 1
        Loop

        TxtWordBox.Text = (BlankCharArray)

    End Sub


    'converts A String to characters.
    Function ToSingleLetters() As Char()     'do not need to send byval, blankword is a class variable
        Dim Space As Char = " "c  'allows declaration  of char variable.  EX.  ="A"c

        Dim i As Integer = 0   'for iterating the array elements
        Dim j As Integer = 1   'for iterating the spaces
        Dim k As Integer = 0  'for iterating the word

        Dim ArrayLength As Integer = (((StrTestWord.Length()) * 2) - 1)  'shopuld be 21 spaces
        Dim SingleLetter(ArrayLength) As Char    'setting ArrayLength larger to account for spaces, should be 21

        '    MessageBox.Show(CStr(ArrayLength)) '21 is right!

        Do
            ' SingleLetter(i) = StrTestWord.Chars(k)  'only showing half of the word...

            SingleLetter(i) = StrTestWord.Chars(k)

            Do While j < (ArrayLength) 'appears to work now..

                SingleLetter(j) = Space
                j = j + 2
            Loop

            i = i + 2
            k = k + 1
        Loop While i <= (ArrayLength)



        ' MessageBox.Show("Number of chacters is: " & CStr(SingleLetter.Length()))  'correct  says 11! right, oh but counting spaces I Bet!
        '  MessageBox.Show(SingleLetter)  'display the character array.

        '    TxtWordBox.Text = SingleLetter

        Return SingleLetter


    End Function




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

    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
        End
    End Sub
End Class
