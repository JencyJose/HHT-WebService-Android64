'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKSaleOrders
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:51 PM
'Description        :This file contains data access logic details from database...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Configuration
Imports [Property].TrackITKTS

Namespace TrackITKTS
    Public Class dalTabKSaleOrders

        Private ConnectionString As String

        Public Shared Function CreateNewTabKSaleOrders(ByVal objTabKSaleOrders As PropertyTabKSaleOrders) As Integer

            If objTabKSaleOrders Is Nothing Then
                Throw New ArgumentNullException("objTabKSaleOrders")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKSaleOrders.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@OrderType", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderType)
            db.AddParamToSQLCmd(sqlCmd, "@OrderNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderNumber)
            db.AddParamToSQLCmd(sqlCmd, "@OrderDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSaleOrders.OrderDate)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKSaleOrders")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKSaleOrders(ByVal objTabKSaleOrders As PropertyTabKSaleOrders) As Boolean

            If objTabKSaleOrders Is Nothing Then
                Throw New ArgumentNullException("objTabKSaleOrders")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.SOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKSaleOrders.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@OrderType", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderType)
            db.AddParamToSQLCmd(sqlCmd, "@OrderNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderNumber)
            db.AddParamToSQLCmd(sqlCmd, "@OrderDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSaleOrders.OrderDate)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKSaleOrders")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKSaleOrders(ByVal SOrderID As Int32) As String

            If SOrderID <= 0 Then
                Throw New ArgumentOutOfRangeException("SOrderID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, SOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKSaleOrders")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTabKSaleOrdersByID(ByVal valSOrderID As Int32) As PropertyTabKSaleOrders
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@SOrderID", valSOrderID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKSaleOrdersByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKSaleOrders As PropertyTabKSaleOrders = New PropertyTabKSaleOrders
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("SOrderID")) Then
                        objTabKSaleOrders.SOrderID = dr.GetInt32(dr.GetOrdinal("SOrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
                        objTabKSaleOrders.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKSaleOrders.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabKSaleOrders.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKSaleOrders.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
                        objTabKSaleOrders.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKSaleOrders.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKSaleOrders.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrderType")) Then
                        objTabKSaleOrders.OrderType = dr.GetString(dr.GetOrdinal("OrderType"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrderNumber")) Then
                        objTabKSaleOrders.OrderNumber = dr.GetString(dr.GetOrdinal("OrderNumber"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OrderDate")) Then
                        objTabKSaleOrders.OrderDate = dr.GetDateTime(dr.GetOrdinal("OrderDate"))
                    End If
                End While
                dr.Close()
                Return objTabKSaleOrders
            Else
                dr.Close()
                Return New PropertyTabKSaleOrders
            End If
        End Function

        Public Shared Function GetALLTabKSaleOrders(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrders")
            Return ds
        End Function

        Public Shared Function GetALLTabKSaleOrdersDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKSaleOrdersDrop")
            Return dr
        End Function

        Public Shared Function GetTabKSaleOrdersByCustomerID(ByVal valCustomerID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CustomerID", valCustomerID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrdersByCustomerID")
            Return ds
        End Function
        Public Shared Function GetAllTabKSaleOrdersByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String, ByVal SaleOrderNumber As String, ByVal ItemCode As String, ByVal ItemBarcode As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@SaleOrderNumber", SaleOrderNumber))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            db.Parameters.Add(New SqlParameter("@ItemBarcode", ItemBarcode))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKSaleOrdersByCompanyID")
            Return ds
        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeIDSearch(ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal SaleOrderNumber As String, ByVal ItemCode As String, ByVal ItemBarcode As String, BranchID As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@SaleOrderNumber", SaleOrderNumber))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            db.Parameters.Add(New SqlParameter("@ItemBarcode", ItemBarcode))
            db.Parameters.Add(New SqlParameter("@BranchID", BranchID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKSaleOrdersByEmployeeIDSearch")
            Return ds
        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKSaleOrdersByEmployeeID")
            Return ds
        End Function
        'HHT Methods
        Public Shared Function GetSaleOrderNoByBarcodeHHT(ByVal barcode As String, ByVal CompanyID As Integer, ByVal schema As String) As Object
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@barcode", barcode))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            Dim ds As Object = db.ExecuteScalar(schema + ".TIT_GetSaleOrderNoByBarcodeHHT")
            Return ds
        End Function

        Public Shared Function GetSaleOrderNoByCompanyIDHHT(ByVal CompanyID As Integer, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_GetAllTabKSaleOrderListByCompanyID")
            Return ds
        End Function

        Public Shared Function GetSaleOrderDetailsByOrderIDHHT(ByVal CompanyID As Integer, ByVal schema As String, ByVal OrderID As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            'db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@OrderID", OrderID))

            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_GetAllTabKSaleOrderDetialsBYOrderID")
            Return ds
        End Function

        Public Shared Function VerifySaleOrderHHT(ByVal CompanyID As Integer, ByVal EntityID As Integer, ByVal OnHandQuantity As Integer, ByVal SOrderID As Integer, ByVal ItemID As Integer, ByVal schema As String, ByVal BarCode As String) As Integer

            Dim i As Integer = 0

            If ItemID <= 0 Then
                Throw New ArgumentOutOfRangeException("ItemID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, SOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@BarCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, BarCode)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, EntityID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, schema + ".TIT_VerifySaleOrderItemsHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return 1
            End If

        End Function

        Public Shared Function GetCountVerifiedSaleOrderHHT(ByVal SOrderID As Integer, ByVal schema As String) As Integer

            Dim i As Integer = 0


            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, SOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@count", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, schema + ".GetCountVerifiedSaleOrderHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = sqlCmd.Parameters("@count").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return 0
            End If

        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeIDHHT(ByVal valEmployeeID As Int32, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_NewGetAllTabKSaleOrdersByEmployeeIDHHT")
            Return ds
        End Function
        Public Shared Function GetItemsByCompBarcodeDHHT(ByVal Barcode As String, ByVal CompanyID As Integer, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@Barcode", Barcode))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_GetItemDetailsByBarcodeHHT")
            Return ds
        End Function

        Public Shared Function GetItemsByCompBarcodeNewHHT(ByVal Barcode As String, ByVal EmployeeID As Integer, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@Barcode", Barcode))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_GetItemDetailsByBarcodeNewHHT")
            Return ds
        End Function

        Public Shared Function UpdateRePrintStatusSO(OrderNumber As String, ItemID As Integer, ItemBarcode As String, schema As String) As Boolean


            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@OrderNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, OrderNumber)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemBarcode", SqlDbType.NVarChar, 100, ParameterDirection.Input, ItemBarcode)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, schema + ".TIT_UpdateRePrintSOStatus")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class
End Namespace
