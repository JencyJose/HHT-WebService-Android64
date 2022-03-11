'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKEmptyToSupplier
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:47 PM
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
    Public Class dalTabKEmptyToSupplier

        Private ConnectionString As String

        Public Shared Function CreateNewTabKEmptyToSupplier(ByVal objTabKEmptyToSupplier As PropertyTabKEmptyToSupplier, ByVal SchemaName As String) As Integer

            If objTabKEmptyToSupplier Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyToSupplier")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyToSupplier.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyToSupplier.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyToSupplier.TransferDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.TransferBy)
            db.AddParamToSQLCmd(sqlCmd, "@ShippingLine", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.ShippingLine)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNo", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyToSupplier.SerialNo)
            db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.ContainerNumber)
            db.AddParamToSQLCmd(sqlCmd, "@PortFrom", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.PortFrom)
            db.AddParamToSQLCmd(sqlCmd, "@PortTo", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.PortTo)
            db.AddParamToSQLCmd(sqlCmd, "@BOLDate", SqlDbType.DateTime, 100, ParameterDirection.Input, objTabKEmptyToSupplier.BOLDate)
            db.AddParamToSQLCmd(sqlCmd, "@BOLNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.BOLNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.Status)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyToSupplier")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKEmptyToSupplier(ByVal objTabKEmptyToSupplier As PropertyTabKEmptyToSupplier, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean

            If objTabKEmptyToSupplier Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyToSupplier")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ESOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.ESOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyToSupplier.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyToSupplier.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyToSupplier.TransferDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.TransferBy)
            db.AddParamToSQLCmd(sqlCmd, "@ShippingLine", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.ShippingLine)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNo", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyToSupplier.SerialNo)
            db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.ContainerNumber)
            db.AddParamToSQLCmd(sqlCmd, "@PortFrom", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.PortFrom)
            db.AddParamToSQLCmd(sqlCmd, "@PortTo", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.PortTo)
            db.AddParamToSQLCmd(sqlCmd, "@BOLDate", SqlDbType.DateTime, 100, ParameterDirection.Input, objTabKEmptyToSupplier.BOLDate)
            db.AddParamToSQLCmd(sqlCmd, "@BOLNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.BOLNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyToSupplier.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@PrevQty", SqlDbType.Int, 0, ParameterDirection.Input, PrevQty)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyToSupplier.Status)


            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKEmptyToSupplier")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKEmptyToSupplier(ByVal ESOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ESOrderID", SqlDbType.Int, 0, ParameterDirection.Input, ESOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DeleteTabKEmptyToSupplier")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTabKEmptyToSupplierByID(ByVal valESOrderID As Int32) As PropertyTabKEmptyToSupplier
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ESOrderID", valESOrderID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKEmptyToSupplierByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKEmptyToSupplier As PropertyTabKEmptyToSupplier = New PropertyTabKEmptyToSupplier
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("ESOrderID")) Then
                        objTabKEmptyToSupplier.ESOrderID = dr.GetInt32(dr.GetOrdinal("ESOrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SupplierID")) Then
                        objTabKEmptyToSupplier.SupplierID = dr.GetInt32(dr.GetOrdinal("SupplierID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKEmptyToSupplier.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabKEmptyToSupplier.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKEmptyToSupplier.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
                        objTabKEmptyToSupplier.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKEmptyToSupplier.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKEmptyToSupplier.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
                        objTabKEmptyToSupplier.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TransferDate")) Then
                        objTabKEmptyToSupplier.TransferDate = dr.GetDateTime(dr.GetOrdinal("TransferDate"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TransferBy")) Then
                        objTabKEmptyToSupplier.TransferBy = dr.GetInt32(dr.GetOrdinal("TransferBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("DocumentNumber")) Then
                        objTabKEmptyToSupplier.DocumentNumber = dr.GetString(dr.GetOrdinal("DocumentNumber"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ShippingLine")) Then
                        objTabKEmptyToSupplier.ShippingLine = dr.GetString(dr.GetOrdinal("ShippingLine"))
                    End If
                End While
                dr.Close()
                Return objTabKEmptyToSupplier
            Else
                dr.Close()
                Return New PropertyTabKEmptyToSupplier
            End If
        End Function

        Public Shared Function GetALLTabKEmptyToSupplier(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyToSupplier")
            Return ds
        End Function

        Public Shared Function GetALLTabKEmptyToSupplierDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKEmptyToSupplierDrop")
            Return dr
        End Function

        Public Shared Function GetTabKEmptyToSupplierBySupplierID(ByVal valSupplierID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@SupplierID", valSupplierID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyToSupplierBySupplierID")
            Return ds
        End Function
        Public Shared Function GetAllTabKEmptyToSupplierByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyToSupplierByCompanyID")
            Return ds
        End Function
        Public Shared Function GetAllTabKEmptyToSupplierByCompanyID_Search(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyToSupplierByCompanyID_Search")
            Return ds
        End Function
    End Class
End Namespace
