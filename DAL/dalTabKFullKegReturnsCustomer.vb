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
    Public Class dalTabKFullKegReturnsCustomer

        Private ConnectionString As String
       
        Public Shared Function CreateNewTabKFullKegReturnsCustomer(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String) As String

            If objTabKFullKegReturnCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKFullKegReturnCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKFullKegReturnCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReturnBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnBy)
            db.AddParamToSQLCmd(sqlCmd, "@ReturnDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKFullKegReturnCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@OUTParam", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKFullKegReturnsCustomer")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@OUTParam").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
            '      Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function CreateNewTabKFullCustomerHHT(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String) As String

            If objTabKFullKegReturnCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.NVarChar, 100, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@ToItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ToItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKFullKegReturnCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnBy)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnDate)
            'db.AddParamToSQLCmd(sqlCmd, "@SerialNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKFullKegReturnCustomer.SerialNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKFullKegReturnCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            'db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKFullKegReturnCustomer.Status)
            db.AddParamToSQLCmd(sqlCmd, "@OUTParam", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKFullReturnCustomerHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@OUTParam").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function
        Public Shared Function UpdateTabKFullKegReturnsCustomer(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean

            If objTabKFullKegReturnCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKFullKegReturnCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@FCOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.FCOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKFullKegReturnCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReturnBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnBy)
            db.AddParamToSQLCmd(sqlCmd, "@ReturnDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKFullKegReturnCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@PrevQty", SqlDbType.Int, 0, ParameterDirection.Input, PrevQty)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ToCompanyID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKFullKegReturnsCustomer")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function GetAllTabKFullKegReturnsCustomerByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKFullKegReturnsCustomerByCompanyID")
            Return ds
        End Function
        Public Shared Function GetAllTabKFullKegReturnsCustomerByCompanyID_Search(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKFullKegReturnsCustomerByCompanyID_Search")
            Return ds
        End Function
        Public Shared Function BarcodeValidationFullKegReturn(ByVal valItemID As Int32, ByVal valCompanyID As Int32, ByVal valCustomerID As Int32, ByVal valBarcode As String, ByVal SchemaName As String) As Integer
            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, valItemID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, valCustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, valBarcode)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_BarcodeValidationFullKeg")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            Return returnValue
        End Function

        Public Shared Function GetAllTabKFullKegReturnCustomerByCompanyID_Search_Bulk(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal SOrderID As String, ByVal OrderNumber As String, ByVal CustomerID As String, ByVal ItemCode As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@SOrderID", SOrderID))

            db.Parameters.Add(New SqlParameter("@OrderNumber", OrderNumber))
            db.Parameters.Add(New SqlParameter("@CustomerID", CustomerID))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".GetAllTabKFullKegReturnsCustomerByCompanyID_Search_Bulk")
            Return ds
        End Function

        Public Shared Function CreateNewTabKFullKegReturnsCustomer_Bulk(ByVal objTabKFullKegReturnCustomer As PropertyTabKFullKegReturnsCustomer, ByVal SchemaName As String) As String

            If objTabKFullKegReturnCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKFullKegReturnCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKFullKegReturnCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReturnBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnBy)
            db.AddParamToSQLCmd(sqlCmd, "@ReturnDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ReturnDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKFullKegReturnCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKFullKegReturnCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@OUTParam", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKFullKegReturnsCustomer_Bulk")
            db.ExecuteScalarCmd(sqlCmd)

            Dim returnValue As String = sqlCmd.Parameters("@OUTParam").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If

            'Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

    End Class
End Namespace
