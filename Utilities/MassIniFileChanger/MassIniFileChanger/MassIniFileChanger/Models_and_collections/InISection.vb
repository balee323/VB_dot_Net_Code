Public Class InISection

    'keys have values, so this needs to be re-thought a bit

    Private INIsection As String
    Private Keys As List(Of String)
    Private StoreNum As String
    Private TxtLinesRead As Integer = 0


    Public Sub New(StoreNum As String)
        Me.StoreNum = StoreNum
    End Sub

    Public Sub New(InISection As String, ByRef Keys As List(Of String), StoreNum As String)

        Me.INIsection = InISection
        Me.Keys = Keys
        Me.StoreNum = StoreNum

    End Sub

    Public Function getStoreNum() As String
        Return StoreNum
    End Function

    Public Function getINISection() As String
        Return INIsection
    End Function

    Public Function getKeys() As List(Of String)
        Return Keys
    End Function

    'gathers how many lines were read from one below [Section]
    Public Sub SetTxtLinesRead(TxtLinesRead As Integer)
        Me.TxtLinesRead = TxtLinesRead

    End Sub

    Public Function getTxtLinesRead() As Integer
        Return TxtLinesRead
    End Function


    Public Sub changeKeyValue(newValue As String, currentValue As String)

        Dim i As Integer = 0
        While i < Keys.Count

            If Keys(i) = currentValue Then
                INIconfigUI.LstLog.Items.Add("Item Found")

                Keys(i) = newValue

                INIconfigUI.LstLog.Items.Add("item changed to: " & Keys(i))

                If newValue.Contains("***REMOVE") Then
                    Keys.RemoveAt(i)
                    INIconfigUI.LstLog.Items.Add("Item removed")
                End If

            End If
            i += 1
        End While

    End Sub


   

   



End Class
