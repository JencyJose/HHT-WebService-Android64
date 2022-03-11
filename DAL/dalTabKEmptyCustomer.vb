'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKEmptyCustomer
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:44 PM
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
    Public Class dalTabKEmptyCustomer

        Private ConnectionString As String
        Public Shared Function CreateNewTabKEmptyCustomerApprovalHHT(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As String

            If objTabKEmptyCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.NVarChar, 100, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@ToItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ToItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.CollectionDate)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.SerialNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Status)
            db.AddParamToSQLCmd(sqlCmd, "@OUTParam", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyKegReturnApprovalHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@OUTParam").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function CreateNewTabKEmptyCustomer(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As Integer

            If objTabKEmptyCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
            'db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@FromCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.FromCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.CollectionDate)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.SerialNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Status)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyCustomer")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function CreateNewTabKEmptyCustomerCR(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As String

            If objTabKEmptyCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
            'db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@FromCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.FromCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.CollectionDate)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.SerialNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Status)
            db.AddParamToSQLCmd(sqlCmd, "@OUTParam", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyCustomer")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@OUTParam").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If

        End Function

        Public Shared Function UpdateTabKEmptyCustomer(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean

            If objTabKEmptyCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.EOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.CollectionDate)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.SerialNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@PrevQty", SqlDbType.Int, 0, ParameterDirection.Input, PrevQty)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Status)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKEmptyCustomer")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKEmptyCustomer(ByVal EOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EOrderID", SqlDbType.Int, 0, ParameterDirection.Input, EOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DeleteTabKEmptyCustomer")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTabKEmptyCustomerByID(ByVal valEOrderID As Int32, ByVal SchemaName As String) As PropertyTabKEmptyCustomer
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EOrderID", valEOrderID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabKEmptyCustomerByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKEmptyCustomer As PropertyTabKEmptyCustomer = New PropertyTabKEmptyCustomer
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EOrderID")) Then
                        objTabKEmptyCustomer.EOrderID = dr.GetInt32(dr.GetOrdinal("EOrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
                        objTabKEmptyCustomer.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKEmptyCustomer.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabKEmptyCustomer.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKEmptyCustomer.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
                        objTabKEmptyCustomer.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKEmptyCustomer.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKEmptyCustomer.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
                        objTabKEmptyCustomer.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
                    End If
                    'If Not dr.IsDBNull(dr.GetOrdinal("ReceiveDate")) Then
                    '    objTabKEmptyCustomer.ReceiveDate = dr.GetDateTime(dr.GetOrdinal("ReceiveDate"))
                    'End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceiveBy")) Then
                        objTabKEmptyCustomer.ReceiveBy = dr.GetInt32(dr.GetOrdinal("ReceiveBy"))
                    End If
                End While
                dr.Close()
                Return objTabKEmptyCustomer
            Else
                dr.Close()
                Return New PropertyTabKEmptyCustomer
            End If
        End Function
        Public Shared Function GetTabKEmptyCustomerByID(ByVal SchemaName As String, ByVal fromdate As String) As PropertyTabKEmptyCustomer
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@fromdate", fromdate))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabKEmptyCustomerByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKEmptyCustomer As PropertyTabKEmptyCustomer = New PropertyTabKEmptyCustomer
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EOrderID")) Then
                        objTabKEmptyCustomer.EOrderID = dr.GetInt32(dr.GetOrdinal("EOrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
                        objTabKEmptyCustomer.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKEmptyCustomer.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabKEmptyCustomer.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKEmptyCustomer.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
                        objTabKEmptyCustomer.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKEmptyCustomer.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKEmptyCustomer.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
                        objTabKEmptyCustomer.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
                    End If
                    'If Not dr.IsDBNull(dr.GetOrdinal("ReceiveDate")) Then
                    '    objTabKEmptyCustomer.ReceiveDate = dr.GetDateTime(dr.GetOrdinal("ReceiveDate"))
                    'End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceiveBy")) Then
                        objTabKEmptyCustomer.ReceiveBy = dr.GetInt32(dr.GetOrdinal("ReceiveBy"))
                    End If
                End While
                dr.Close()
                Return objTabKEmptyCustomer
            Else
                dr.Close()
                Return New PropertyTabKEmptyCustomer
            End If
        End Function
        Public Shared Function GetALLTabKEmptyCustomer(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustomer")
            Return ds
        End Function

        Public Shared Function GetALLTabKEmptyCustomerDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKEmptyCustomerDrop")
            Return dr
        End Function

        Public Shared Function GetTabKEmptyCustomerByCustomerID(ByVal valCustomerID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CustomerID", valCustomerID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustomerByCustomerID")
            Return ds
        End Function
        Public Shared Function GetAllTabKEmptyCustomerByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyCustomerByCompanyID")
            Return ds
        End Function
        Public Shared Function UpdateEmptyKegsQuantity(ByVal CompanyID As Int32, ByVal FromEntityID As Int32, ByVal FromEntityType As Int32, ByVal ToEntityID As Int32, ByVal ToEntityType As Int32, ByVal Quantity As Int32, ByVal ItemID As Int32, ByVal UOMID As Int32, ByVal IntransitQty As Int32, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@FromEntityID", SqlDbType.Int, 0, ParameterDirection.Input, FromEntityID)
            db.AddParamToSQLCmd(sqlCmd, "@FromEntityType", SqlDbType.Int, 0, ParameterDirection.Input, FromEntityType)
            db.AddParamToSQLCmd(sqlCmd, "@ToEntityID", SqlDbType.Int, 0, ParameterDirection.Input, ToEntityID)
            db.AddParamToSQLCmd(sqlCmd, "@ToEntityType", SqlDbType.Int, 0, ParameterDirection.Input, ToEntityType)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@IntransitQty", SqlDbType.Int, 0, ParameterDirection.Input, IntransitQty)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateEmptyKegsQuantity")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function GetMaxTransactionNumber(ByVal SchemaName As String, ByVal type As Int32, ByVal CompanyID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EntityType", type))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetMaxTransactionNumber")
            Return ds
        End Function
        Public Shared Function CreateNewTabKEmptyCustomerHHT(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As String

            If objTabKEmptyCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.NVarChar, 100, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@ToItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ToItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.CollectionDate)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.SerialNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TransNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustomer.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Status)
            db.AddParamToSQLCmd(sqlCmd, "@OUTParam", SqlDbType.NVarChar, 100, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyCustomerHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@OUTParam").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function
        Public Shared Function validateCustomerOpeningBalance(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal schemaname As String) As Integer
            If objTabKEmptyCustomer Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityType", SqlDbType.Int, 0, ParameterDirection.Input, 2)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, schemaname + ".TIT_ValidateforOpeningBal")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)

        End Function
        Public Shared Function GetAllTabKEmptyCustomerByCompanyID_Search(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyCustomerByCompanyID_Search")
            Return ds
        End Function
        Public Shared Function ItemBarcodeValidation(ByVal valItemID As Int32, ByVal valFromCompanyID As Int32, ByVal valBarcode As String, ByVal SchemaName As String) As Integer
            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, valItemID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, valFromCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, valBarcode)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_ItemBarcodeValidation")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            Return returnValue
            'If returnValue = 0 Then
            '    Return True
            'Else
            '    Return False
            'End If
        End Function

        Public Shared Function GetAllTabKEmptyCustomerApprovalHHT(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal ItemCode As String, ByVal TransactionNumber As String, ByVal ApprovalStatus As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            db.Parameters.Add(New SqlParameter("@ApprovalStatus", ApprovalStatus))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyCustomerReturnsHHT")
            Return ds
        End Function

        Public Shared Function GetAllTabKEmptyCustomerApprovalCRHHT(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal ItemCode As String, ByVal AprovalStatus As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            db.Parameters.Add(New SqlParameter("@AprovalStatus", AprovalStatus))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyCustomerReturnsApprovedHHT")
            Return ds
        End Function

        Public Shared Function GetTabKCustomerDumpApprovedQty(ByVal schemaName As String, ByVal FromDate As Date, ByVal ItemCodes As String, ByVal EmployeeID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@FromDate", FromDate))
            db.Parameters.Add(New SqlParameter("@EmpID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@MultipleItemCodes", ItemCodes))
            Dim ds As DataSet = db.ExecuteDataSet(schemaName + ".TIT_GetCustomerApprovedQtyDump")
            Return ds
        End Function

        Public Shared Function UpdateTabKEmptyKegCustomerReturnsHHT(ByVal TransactionNum As String, ByVal FromCompanyID As Int32, ByVal ToCompanyID As Int32, ByVal FromItemID As Int32, ByVal ToItemID As Int32, ByVal ApprovedQuantity As Int32, ByVal UserComments As String, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNo", SqlDbType.NVarChar, 100, ParameterDirection.Input, TransactionNum)
            db.AddParamToSQLCmd(sqlCmd, "@FromCompID", SqlDbType.Int, 0, ParameterDirection.Input, FromCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompID", SqlDbType.Int, 0, ParameterDirection.Input, ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@FromItmID", SqlDbType.Int, 0, ParameterDirection.Input, FromItemID)
            db.AddParamToSQLCmd(sqlCmd, "@ToItmID", SqlDbType.Int, 0, ParameterDirection.Input, ToItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Web_ApprovedQty_Total", SqlDbType.NVarChar, 250, ParameterDirection.Input, ApprovedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@UserComments", SqlDbType.NVarChar, 250, ParameterDirection.Input, UserComments)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKEmptyKegCustomerReturnsHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function GetAllUsers(ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllUsers")
            Return ds
        End Function
    End Class
End Namespace
