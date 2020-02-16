Public Class ChangeValueInINISection

    Private newKeyValue As String = "Value1=true"
    'Private valueToChange As String = ""
    Private StoreNum As String = "0000"
    'Private iNISection As InISection



    'Public Sub New(newKeyValue As String)
    '    Me.newKeyValue = newKeyValue
    '    'Me.valueToChange = valueToChange
    '    ChangeAllStoresINIs()
    'End Sub

    Public Sub New(newKeyValue As String, StoreNum As String)
        Me.newKeyValue = newKeyValue
        ' Me.valueToChange = valueToChange
        Me.StoreNum = StoreNum
        changeKeyValueINCollection()
        removeKey()

    End Sub


    'Works !!! don't touch
    Private Sub changeKeyValueINCollection()

        'verified working!
        'CollectionList.InISections.Item(0).changeKeyValue("DeletePollFiles=" & ControlChars.Quote & "Y" & ControlChars.Quote, "DeletePollFiles=" & ControlChars.Quote & "N" & ControlChars.Quote)


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

        'unit testing
        ' INIconfigUI.LstLog.Items.Add(IndexValue)  'tested working!
        '---------------------
        'Unit testing
        'using index of the found Object based on the StoreNum, change INI key value
        '  CollectionList.InISections.Item(IndexValue).changeKeyValue("DeletePollFiles=" & ControlChars.Quote & "**Changed**" & ControlChars.Quote, "DeletePollFiles=" & ControlChars.Quote & "N" & ControlChars.Quote)
        '--------------------

        'Find Key Index where KeyName matches
        Dim KeyName As String = FindKeyIndex(CollectionList.InISections(IndexValue).getKeys, newKeyValue)

        INIconfigUI.LstLog.Items.Add("CurrentValue and New Value :" & KeyName & " == " & newKeyValue)

        'using index of the found Object based on the StoreNum, change INI key value
        CollectionList.InISections.Item(IndexValue).changeKeyValue(newKeyValue, KeyName)



    End Sub

    'Hack -- split value to find changes in key values

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
                Return ""
            End If

            keyName = Temp(0)

            If keys(i).StartsWith(keyName) Then
                Return keys(i)
            End If

            i = i + 1

        End While

        Return ""
    End Function





    'changes all INI key values
    'Private Sub ChangeAllStoresINIs()

    '    Dim i As Integer = 0
    '    While i < CollectionList.InISections.Count


    '        CollectionList.InISections.Item(i).changeKeyValue("DeletePollFiles=" & ControlChars.Quote & "**Changed**" & ControlChars.Quote, "DeletePollFiles=" & ControlChars.Quote & "N" & ControlChars.Quote)
    '        i += 1
    '    End While


    'End Sub

    Private Sub removeKey()
        ' newKeyValue


        Dim iNISection As New InISection(StoreNum)
        Dim IndexValue As Integer = 0


        Dim i As Integer = 0
        While i < CollectionList.InISections.Count

            If CollectionList.InISections(i).getStoreNum = StoreNum Then
                IndexValue = i
            End If
            i = i + 1
        End While



    End Sub





End Class
