'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalATSAssets
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :5/12/2008 3:00:27 PM
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
Imports System.Web.UI.WebControls

Imports TrackIT.ExceptionHandler
Namespace TrackITKTS

    Public Class dalValidations
        Public Shared Function ValidateTable(ByVal objValidations As clsValidations, ByVal SchemaName As String) As Boolean
            Try
                Dim db As DBAccess = New DBAccess
                Dim sqlCmd As SqlCommand = New SqlCommand()
                db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
                db.AddParamToSQLCmd(sqlCmd, "@Name", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.Name)
                db.AddParamToSQLCmd(sqlCmd, "@NameVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.NameVal))
                db.AddParamToSQLCmd(sqlCmd, "@ID", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.ID)
                db.AddParamToSQLCmd(sqlCmd, "@IDVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.IDVal))
                db.AddParamToSQLCmd(sqlCmd, "@TableName", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.Table)
                db.AddParamToSQLCmd(sqlCmd, "@FName", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.FName)
                db.AddParamToSQLCmd(sqlCmd, "@FNameVal", SqlDbType.NVarChar, 5, ParameterDirection.Input, Trim(objValidations.FNameVal))
                db.AddParamToSQLCmd(sqlCmd, "@FName1", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.FName1)
                db.AddParamToSQLCmd(sqlCmd, "@FNameVal1", SqlDbType.NVarChar, 25, ParameterDirection.Input, Trim(objValidations.FNameVal1))
                db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DoValidation")
                db.ExecuteScalarCmd(sqlCmd)
                Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
                If returnValue > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
                dbErrorLogging.LogError(ex)
            End Try
        End Function
        Public Shared Function ValidateTableByUserName(ByVal objValidations As clsValidations, ByVal SchemaName As String) As Boolean
            Try
                Dim db As DBAccess = New DBAccess
                Dim sqlCmd As SqlCommand = New SqlCommand()
                db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
                db.AddParamToSQLCmd(sqlCmd, "@Name", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.Name)
                db.AddParamToSQLCmd(sqlCmd, "@NameVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.NameVal))
                db.AddParamToSQLCmd(sqlCmd, "@ID", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.ID)
                db.AddParamToSQLCmd(sqlCmd, "@IDVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.IDVal))
                db.AddParamToSQLCmd(sqlCmd, "@TableName", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.Table)
                db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DoValidationByUserName")
                db.ExecuteScalarCmd(sqlCmd)
                Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
                If returnValue > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
                dbErrorLogging.LogError(ex)
            End Try
        End Function
    End Class
End Namespace