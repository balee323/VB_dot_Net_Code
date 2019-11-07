Imports System.IO





Public Class CreateQuestions

    Dim OutputStr(14) As String  'each question loaded up.

    Dim QuestionCounter As Integer = 0
    Dim i As Integer = 0


    Private Sub BtnNextEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextEntry.Click

        'each click of BtnNextEntry acts like an iteration loop.  This was proven.  

        Dim QuestionLine As String = ""


        Dim TempStr As String = ""

        TxtQuestStatus.Text = ("Create question set " & i + 2 & " of 15")

    
            QuestionLine = TxtUserQuestion.Text & "/" & TxtUserAnswer1.Text & "/" & TxtUserAnswer2.Text & "/" & TxtUserAnswer3.Text & "/" & TxtUserAnswer4.Text


            If RbtnAnswer1.Checked Then
                TempStr = "/" & TxtUserAnswer1.Text
            ElseIf RbtnAnswer2.Checked Then
                TempStr = "/" & TxtUserAnswer2.Text
            ElseIf RbtnAnswer3.Checked Then
                TempStr = "/" & TxtUserAnswer3.Text
            ElseIf RbtnAnswer4.Checked Then
                TempStr = "/" & TxtUserAnswer4.Text

            End If

            QuestionLine = QuestionLine + TempStr




            OutputStr(i) = QuestionLine  'set to String array element
        MessageBox.Show(QuestionLine)

        i = i + 1  'Integer i is a class variable, and each click of btnNextEntry iterates i.



            TxtUserAnswer1.Clear()
            TxtUserAnswer2.Clear()
            TxtUserAnswer3.Clear()
            TxtUserAnswer4.Clear()
            TxtUserQuestion.Clear()


        If i >= 15 Then
            BtnNextEntry.Visible = False
            MessageBox.Show("All Required Question Sets have been entered, please click 'Save File'.")
        End If



    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click


        i = 0

        Dim UserFileName As String = ReturnFileName()

        'Dim OutputFile As New FileStream(UserFileName, FileMode.Create, FileAccess.Write) 'created a new file/appended existing. Goes to debug folder


        Dim theWriter As New StreamWriter(UserFileName)

        Do While i < OutputStr.Length()

            theWriter.WriteLine(OutputStr(i))

            i = i + 1
        Loop

        theWriter.Close()



    End Sub

    Private Sub CreateQuestions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtQuestStatus.Text = ("Create question set 1 of 15")

    End Sub

    Public Function ReturnFileName() As String



        'Dim UserFileName As String = "C:\QuestionGame\Questions\"  'specifies file name and Path
        Dim UserFileName As String = ""


        Dim Message As String = "Please Enter a file name."
        Dim Title As String = "Questions File Name without extension (.txt)"
        Dim DefaultValue As String = "MyQuestions"

        Dim j As Integer = 0


        MessageBox.Show("Please choose a save name for the file.  Questions will be stored...")

        UserFileName = InputBox(Message, Title, DefaultValue) + (".txt") 'user input box.  File name and .txt is appended to string

        'BtnSave.Visible = False

        TxtUserAnswer1.ReadOnly = False
        TxtUserAnswer2.ReadOnly = False
        TxtUserAnswer3.ReadOnly = False
        TxtUserAnswer4.ReadOnly = False
        TxtUserQuestion.ReadOnly = False

        ' Me.Focus()

        Return UserFileName

    End Function



    Private Sub BtnArray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArray.Click

        Dim j As Integer = 0

        Do While j < 15

            MessageBox.Show(OutputStr(j))

            j = j + 1
        Loop

    End Sub

    Private Sub BtnExitCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExitCreate.Click
        Me.Close()

    End Sub
End Class