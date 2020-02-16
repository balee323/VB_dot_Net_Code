Imports System.Data

Namespace ProductWarehouse.web

    Public Class OpenOrders

        Private OrdersDataSet As DataSet
        Private CustomersDataSet As DataSet
        Private ErrorMsg As String = ""
        Dim DBConn As Connection

        Public Sub New()
            DBConn = New Connection(False)

            GetOrders()
            getCustomers()
        End Sub


        Private Sub getCustomers()



            Dim QueryString As String = "select CustomerID, (CustomerLname + ', ' + CustomerFname) as CustomerName from TBL_customer"
            'Dim QueryString As String = ""


            Try
                CustomersDataSet = DBConn.SqlCmdReturn(QueryString)
            Catch ex As Exception
                ErrorMsg = ex.Message

            End Try


            If OrdersDataSet.Tables(0).Rows.Count < 1 Then
                ErrorMsg = "No Data"
            End If


        End Sub



        Private Sub GetOrders()


            Dim QueryString As String = "exec getCustomerOrders"
            'Dim QueryString As String = ""


            Try
                OrdersDataSet = DBConn.SqlCmdReturn(QueryString)
            Catch ex As Exception
                ErrorMsg = ex.Message

            End Try


            If OrdersDataSet.Tables(0).Rows.Count < 1 Then
                ErrorMsg = "No Data"
            End If




        End Sub


        Public Sub GetOrders(ByVal parameters As List(Of String))


            Dim QueryString As String = "exec getCustomerOrders"   'need to modify this to for optional params or create another stored proc, or used ugly sql
            'Dim QueryString As String = ""


            'Try
            '    OrdersDataSet = DBConn.SqlCmdReturn(QueryString)
            'Catch ex As Exception
            '    ErrorMsg = ex.Message

            'End Try


            'If OrdersDataSet.Tables(0).Rows.Count < 1 Then
            '    ErrorMsg = "No Data"
            'End If




        End Sub



        Public Function GetOrdersData() As DataSet

            Return OrdersDataSet
        End Function


        Public Function GetCustomersData() As DataSet

            Return CustomersDataSet
        End Function



        Public Function getErrorMsg() As String
            Return ErrorMsg
        End Function


    End Class
End Namespace
