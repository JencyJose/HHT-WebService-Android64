'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKEmptyTransferBP
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:48 PM
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
    Public Class dalTabKEmptyTransferBP

        Private ConnectionString As String

        Public Shared Function CreateNewTabKEmptyTransferBP(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String) As Integer

            If objTabKEmptyTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyTransferBP.TransferDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.TransferBy)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.Status)
            db.AddParamToSQLCmd(sqlCmd, "@InTransitQty", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.InTransitQuantity)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabKEmptyTransferBP")

            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKEmptyTransferBP(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean

            If objTabKEmptyTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EBPOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.EBPOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.CompanyID)
            'db.AddParamToSQLCmd(sqlCmd, "@FromCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyTransferBP.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyTransferBP.TransferDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.TransferBy)
            db.AddParamToSQLCmd(sqlCmd, "@InTransitQty", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.InTransitQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@PrevQty", SqlDbType.Int, 0, ParameterDirection.Input, PrevQty)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.Status)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKEmptyTransferBP")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Shared Function DeleteTabKEmptyTransferBP(ByVal EBPOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EBPOrderID", SqlDbType.Int, 0, ParameterDirection.Input, EBPOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DeleteTabKEmptyTransferBP")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function
        Public Shared Function UpdateTabKEmptyReceiveBPtoBP(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String) As Boolean

            If objTabKEmptyTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EBPOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.EBPOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveDate)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveQty", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveQty)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.Status)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKEmptyReceiveBPtoBP")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Shared Function UpdateTabKEmptyReceiveBPtoBP_Edit(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean

            If objTabKEmptyTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EBPOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.EBPOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveDate)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveBy)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiveQty", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveQty)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.Status)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ModifiedBy)
            db.AddParamToSQLCmd(sqlCmd, "@PrevQty", SqlDbType.Int, 0, ParameterDirection.Input, PrevQty)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabKEmptyReceiveBPtoBP_Edit")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Shared Function GetTabKEmptyTransferBPByID(ByVal valEBPOrderID As Int32) As PropertyTabKEmptyTransferBP
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EBPOrderID", valEBPOrderID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKEmptyTransferBPByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP = New PropertyTabKEmptyTransferBP
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EBPOrderID")) Then
                        objTabKEmptyTransferBP.EBPOrderID = dr.GetInt32(dr.GetOrdinal("EBPOrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("FromBranchID")) Then
                        objTabKEmptyTransferBP.FromBranchID = dr.GetInt32(dr.GetOrdinal("FromBranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ToBranchID")) Then
                        objTabKEmptyTransferBP.ToBranchID = dr.GetInt32(dr.GetOrdinal("ToBranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKEmptyTransferBP.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKEmptyTransferBP.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
                        objTabKEmptyTransferBP.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKEmptyTransferBP.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKEmptyTransferBP.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
                        objTabKEmptyTransferBP.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TransferDate")) Then
                        objTabKEmptyTransferBP.TransferDate = dr.GetDateTime(dr.GetOrdinal("TransferDate"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TransferBy")) Then
                        objTabKEmptyTransferBP.TransferBy = dr.GetInt32(dr.GetOrdinal("TransferBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceiveDate")) Then
                        objTabKEmptyTransferBP.ReceiveDate = dr.GetDateTime(dr.GetOrdinal("ReceiveDate"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceiveBy")) Then
                        objTabKEmptyTransferBP.ReceiveBy = dr.GetInt32(dr.GetOrdinal("ReceiveBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceiveQty")) Then
                        objTabKEmptyTransferBP.ReceiveQty = dr.GetInt32(dr.GetOrdinal("ReceiveQty"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ContainerNumber")) Then
                        objTabKEmptyTransferBP.ContainerNumber = dr.GetString(dr.GetOrdinal("ContainerNumber"))
                    End If
                End While
                dr.Close()
                Return objTabKEmptyTransferBP
            Else
                dr.Close()
                Return New PropertyTabKEmptyTransferBP
            End If
        End Function

        Public Shared Function GetALLTabKEmptyTransferBP(ByVal valUserName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyTransferBP")
            Return ds
        End Function

        Public Shared Function GetALLTabKEmptyTransferBPDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKEmptyTransferBPDrop")
            Return dr
        End Function

        Public Shared Function GetTabKEmptyTransferBPByFromBranchID(ByVal valFromBranchID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@FromBranchID", valFromBranchID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyTransferBPByFromBranchID")
            Return ds
        End Function
        Public Shared Function GetTabKEmptyTransferBPByFromToBranchID(ByVal valFromBranchID As Int32, ByVal valToBranchID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@FromBranchID", valFromBranchID))
            db.Parameters.Add(New SqlParameter("@ToBranchID", valToBranchID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyTransferBPByFromToBranchID")
            Return ds
        End Function
        Public Shared Function GetTabKEmptyTransferBPByFromToBranchIDHHT(ByVal valFromBranchID As Int32, ByVal valToBranchID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@FromBranchID", valFromBranchID))
            db.Parameters.Add(New SqlParameter("@ToBranchID", valToBranchID))

            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyTransferBPByFromToBranchIDHHT")
            Return ds
        End Function
        Public Shared Function GetAllTabKEmptyTransferBPByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKEmptyTransferBPByCompanyID")
            Return ds
        End Function
        Public Shared Function GetAllTabKEmptyReceiveBPByCompanyID(ByVal valCompanyID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyReceiveBPByCompanyID")
            Return ds
        End Function
        Public Shared Function CreateNewTabKEmptyTransferBPHHT(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal schemaName As String) As Integer

            If objTabKEmptyTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@FromCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ToCompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ToCompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyTransferBP.Barcode)
            db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyTransferBP.TransferDate)
            db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.TransferBy)
            db.AddParamToSQLCmd(sqlCmd, "@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyTransferBP.Status)
            db.AddParamToSQLCmd(sqlCmd, "@InTransitQty", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.InTransitQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, schemaName)
            db.AddParamToSQLCmd(sqlCmd, "@Trnum", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.TransactionNumber)

            'db.AddParamToSQLCmd(sqlCmd, "@ReceiveDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveDate)
            'db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveBy)
            'db.AddParamToSQLCmd(sqlCmd, "@ReceiveQty", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ReceiveQty)
            'db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyTransferBP.ContainerNumber)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, schemaName + ".TIT_CreateNewTabKEmptyTransferBPHHT")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function ValidateforOpeningBal(ByVal CompanyID As Int32, ByVal EntityID As Int32, ByVal EntityType As Int32, ByVal ItemID As Int32, ByVal Quantity As Int32, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, EntityID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityType", SqlDbType.Int, 0, ParameterDirection.Input, EntityType)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, Quantity)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_ValidateforOpeningBal")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function validateBPOpeningBalance(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal schemaname As String) As Integer
            If objTabKEmptyTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKEmptyCustomer")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityType", SqlDbType.Int, 0, ParameterDirection.Input, 1)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyTransferBP.Quantity)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, schemaname + ".TIT_ValidateforOpeningBal")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function GetAllTransactionNumbersByCompanyID(ByVal valCompanyID As Int32, ByVal valFromBranchID As Int32, ByVal valToBranchID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@FromBranchID", valFromBranchID))
            db.Parameters.Add(New SqlParameter("@ToBranchID", valToBranchID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTransactionNumbersByCompanyID")
            Return ds
        End Function
        Public Shared Function GetAllEmptyKegReceiveBPtoBP_Search(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String, ByVal Status As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            db.Parameters.Add(New SqlParameter("@ItemCode", ItemCode))
            db.Parameters.Add(New SqlParameter("@Status", Status))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllEmptyKegReceiveBPtoBP")
            Return ds
        End Function

        Public Shared Function ValidateforNegativeOpeningBal(ByVal CompanyID As Int32, ByVal EntityID As Int32, ByVal EntityType As Int32, ByVal ItemID As Int32, ByVal Quantity As Int32, ByVal TransactionDate As Date, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityID", SqlDbType.Int, 0, ParameterDirection.Input, EntityID)
            db.AddParamToSQLCmd(sqlCmd, "@EntityType", SqlDbType.Int, 0, ParameterDirection.Input, EntityType)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, TransactionDate)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_ValidateforNegativeOpeningBal")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function


    End Class
End Namespace
