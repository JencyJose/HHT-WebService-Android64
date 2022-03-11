'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabFullKegSupptoCust.vb
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:52 PM
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
    Public Class dalTabFullKegSuppToCust
        Private ConnectionString As String

        Public Shared Function CreateNewTabFullKegSupptoCust(ByVal objTabFullKegSupptoCust As PropertyTabFullKegSuppToCust, ByVal SchemaName As String) As Integer

            If objTabFullKegSupptoCust Is Nothing Then
                Throw New ArgumentNullException("objTabFullKegSupptoCust")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiptDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabFullKegSupptoCust.ReceiptDate)
            db.AddParamToSQLCmd(sqlCmd, "@BOLDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabFullKegSupptoCust.BOLDate)
            db.AddParamToSQLCmd(sqlCmd, "@BOLNumber", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.BOLNumber)
            db.AddParamToSQLCmd(sqlCmd, "@POType", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.POType)
            db.AddParamToSQLCmd(sqlCmd, "@PONumber", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.PONumber)
            db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.ContainerNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TrasactionDoneBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.TrasactionDoneBy)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabFullKegSupptoCust.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabFullKegSuppToCust")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function UpdateTabFullKegSuppToCust(ByVal objTabFullKegSupptoCust As PropertyTabFullKegSuppToCust, ByVal SchemaName As String) As Integer

            If objTabFullKegSupptoCust Is Nothing Then
                Throw New ArgumentNullException("objTabFullKegSupptoCust")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@FullKegID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.FullKegID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@ReceiptDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabFullKegSupptoCust.ReceiptDate)
            db.AddParamToSQLCmd(sqlCmd, "@BOLDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabFullKegSupptoCust.BOLDate)
            db.AddParamToSQLCmd(sqlCmd, "@BOLNumber", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.BOLNumber)
            db.AddParamToSQLCmd(sqlCmd, "@POType", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.POType)
            db.AddParamToSQLCmd(sqlCmd, "@PONumber", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.PONumber)
            db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabFullKegSupptoCust.ContainerNumber)
            db.AddParamToSQLCmd(sqlCmd, "@TrasactionDoneBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.TrasactionDoneBy)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabFullKegSupptoCust.TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@ModifiedBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabFullKegSupptoCust.ModifiedBy)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabFullKegSuppToCust")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function
        Public Shared Function GetAllTabFullKegSuppToCust(ByVal valCompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@TransactionNumber", TransactionNumber))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabFullKegSuppToCust")
            Return ds
        End Function
        Public Shared Function DeleteTabFullKegSuppToCust(ByVal FullKegID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@FullKegID", SqlDbType.Int, 0, ParameterDirection.Input, FullKegID)
            db.AddParamToSQLCmd(sqlCmd, "@TransactionNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, TransactionNumber)
            db.AddParamToSQLCmd(sqlCmd, "@SchemaName", SqlDbType.NVarChar, 100, ParameterDirection.Input, SchemaName)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DeleteTabFullKegSuppToCust")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function
    End Class
End Namespace

