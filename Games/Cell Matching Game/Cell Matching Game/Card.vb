Imports System.Windows.Forms.Form

Public Class Card


    Public Sub New(imageNum As Integer, cardImage As Image, pictureBox As PictureBox)
        Me.ImageNumber = imageNum
        Me.CardImage = cardImage
        Me.PictureBox = pictureBox
        Me.PictureBox = pictureBox
    End Sub

    Property PictureBox As PictureBox

    Property ImageNumber As Integer = 0

    Property CardImage As Image = Nothing

    Property IsFlippedOver As Boolean = False

    Property IsMatched As Boolean = False

End Class
