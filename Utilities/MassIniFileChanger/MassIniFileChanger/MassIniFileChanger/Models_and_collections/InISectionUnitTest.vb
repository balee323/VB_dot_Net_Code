Public Class InISectionUnitTest


    'this will be a collection class at some point??


    'Members
    'Collection?


    Dim INIs As List(Of InISection)




    'unit testing  --comment out in Production
    'Dim InIsection = "Section1"
    'Dim Store = "9999"
    'Dim keys As List(Of String)
    '---------------------------------------




    Public Sub New()


        INIs = New List(Of InISection)

        INIs.AddRange(CollectionList.InISections)

        'Unit test for 1 object
        'keys = New List(Of String)
        'keys.Add("Key1")
        'keys.Add("key2")
        'Dim iniSection1 As New InISection(InISection, Keys, Store)
        'INIs.Add(iniSection1)
        '----------------

    End Sub

    'test method.. 
    Public Sub DisplayINIsections()

        Dim resultList As String = ""
        Dim i As Integer = 0
        While i < 4 And i < resultList.Count 'dont want to get too many StoreINISections
            'only getting first key item
            '  System.Diagnostics.Debug.WriteLine("Unit Testing for DataLayer: InI collection class")
            'System.Diagnostics.Debug.WriteLine(INIs.Item(i).getStoreNum & " " & INIs.Item(i).getINISection & " " & INIs.Item(i).getKeys.Item(i))
            resultList = resultList + (INIs.Item(i).getStoreNum & " " & INIs.Item(i).getINISection & vbCrLf)

            Dim j As Integer = 0

            While j < 5 'limit the amount of keys shown
                resultList = resultList & INIs.Item(i).getKeys(j) & vbCrLf
                j = j + 1
            End While

            resultList = resultList + "Last key: " + INIs.Item(i).getKeys(INIs.Item(i).getKeys.Count - 1)
            resultList = resultList & vbCrLf
            i = i + 1
        End While


        INIconfigUI.LstLog.Items.Add(resultList)


    End Sub








    Public Sub addTableItem()



    End Sub






End Class
