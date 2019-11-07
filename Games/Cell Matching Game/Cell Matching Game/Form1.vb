

Public Class Form1

    Dim FirstCard As Integer = 0 'starting values
    Dim SecondCard As Integer = 0







    Private Sub Top1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top1.Click

        ' Dim CheckMatch As Boolean
        Dim CardPicked As Integer = 1

        Top1.Visible = False

        Bottom1.Visible = True



        If FirstCard = 0 Then 'chooses first card to be marker
            FirstCard = CardPicked
        Else
            SecondCard = CardPicked
        End If



        If FirstCard <> 0 And SecondCard <> 0 Then
            If FirstCard = SecondCard Then
                MessageBox.Show("Match")
                'Bottom1.Visible = False
                FirstCard = 0
                SecondCard = 0

            Else
                MessageBox.Show("Not a Match")
                Top1.Visible = True
                Bottom1.Visible = False
                FirstCard = 0
                SecondCard = 0
            End If
        End If





    End Sub




    Private Sub Top4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top4.Click

        Dim CardPicked As Integer = 1 'matching

        Top4.Visible = False

        Bottom4.Visible = True

        If FirstCard = 0 Then 'chooses first card to be marker
            FirstCard = CardPicked
        Else
            SecondCard = CardPicked
        End If



        If FirstCard <> 0 And SecondCard <> 0 Then
            If FirstCard = SecondCard Then
                MessageBox.Show("Match")
                'Bottom4.Visible = False
                FirstCard = 0
                SecondCard = 0
            Else
                MessageBox.Show("Not a Match")
                Top4.Visible = True
                Bottom4.Visible = False
                FirstCard = 0
                SecondCard = 0
            End If
        End If





    End Sub

    Private Sub Top2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top2.Click
        Dim CardPicked As Integer = 3

        Top2.Visible = False

        Bottom2.Visible = True


      If FirstCard = 0 Then 'chooses first card to be marker
            FirstCard = CardPicked
        Else
            SecondCard = CardPicked
        End If


        If FirstCard <> 0 And SecondCard <> 0 Then
            If FirstCard = SecondCard Then
                MessageBox.Show("Match")
                'Bottom2.Visible = False
                FirstCard = 0
                SecondCard = 0
            Else
                MessageBox.Show("Not a Match")
                Top2.Visible = True
                Bottom2.Visible = False
                FirstCard = 0
                SecondCard = 0
            End If
        End If








    End Sub

    Private Sub Top3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top3.Click

        Dim CardPicked As Integer = 3
        Dim TopCard As String = "Top3"

        Top3.Visible = False

        Bottom3.Visible = True


      If FirstCard = 0 Then 'chooses first card to be marker
            FirstCard = CardPicked
        Else
            SecondCard = CardPicked
        End If


        If FirstCard <> 0 And SecondCard <> 0 Then
            If FirstCard = SecondCard Then
                MessageBox.Show("Match")
                'Bottom3.Visible = False
                FirstCard = 0
                SecondCard = 0
            Else
                MessageBox.Show("Not a Match")
                Top3.Visible = True
                Bottom3.Visible = False
                FirstCard = 0
                SecondCard = 0

            End If
        End If




    End Sub

    Sub Recover(ByVal TopCardnum As String)




        ' TopCardnum.Visible = True



    End Sub




End Class
