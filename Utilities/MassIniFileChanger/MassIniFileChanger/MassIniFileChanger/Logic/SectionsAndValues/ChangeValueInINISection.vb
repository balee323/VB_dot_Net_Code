Public Class ChangeValueInINISection

    Private newKeyValue As String = "Value1=true"
    Private StoreNum As String = "0000"


    Public Sub New(newKeyValue As String, StoreNum As String)
        Me.newKeyValue = newKeyValue
        ' Me.valueToChange = valueToChange
        Me.StoreNum = StoreNum
        changeKeyValueINCollection()
        removeKey()

    End Sub


    'Works !!! don't touch
    Private Sub changeKeyValueINCollection()

        Dim iNISection As New InISection(StoreNum)
        Dim IndexValue As Integer = 0

        'get the index where the storeNum matches in the CollectionList
        Dim i As Integer = 0
        While i < CollectionList.InISections.Count

            If CollectionList.InISections(i).getStoreNum = StoreNum Then
                IndexValue = i
            End If
            i = i + 1
        End While

        'Find Key Index where KeyName matches
        Dim KeyName As String = FindKeyIndex(CollectionList.InISections(IndexValue).getKeys, newKeyValue)

        INIconfigUI.LstLog.Items.Add("CurrentValue and New Value :" & KeyName & " == " & newKeyValue)

        'using index of the found Object based on the StoreNum, change INI key value
        CollectionList.InISections.Item(IndexValue).changeKeyValue(newKeyValue, KeyName)

    End Sub


    Private Function FindKeyIndex(keys As List(Of String), newKeyValue As String) As String

        Dim i As Integer = 0
        Dim found As Boolean = False

        While i < keys.Count
            Dim Temp() As String = Nothing
            Dim keyName As String = ""

            If newKeyValue.Contains("=") Then
                Temp = Split(newKeyValue, "=")
            ElseIf newKeyValue.Contains("***") Then
                Temp = Split(newKeyValue, "***")
            Else
                Return String.Empty
            End If

            keyName = Temp(0)

            If keys(i).StartsWith(keyName) Then
                Return keys(i)
            End If
            i += 1
        End While

        Return String.Empty

    End Function


    Private Sub removeKey()

        Dim iNISection As New InISection(StoreNum)
        Dim IndexValue As Integer = 0

        'consider using a for-loop here
        Dim i As Integer = 0
        While i < CollectionList.InISections.Count
            If CollectionList.InISections(i).getStoreNum = StoreNum Then
                IndexValue = i
            End If
            i = i + 1
        End While

    End Sub


End Class
