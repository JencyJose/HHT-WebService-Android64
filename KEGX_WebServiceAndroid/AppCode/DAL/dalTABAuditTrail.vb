'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTABAuditTrail
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :2/17/2009 12:12:37 PM
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


Namespace TrackITKTS
    Public Class dalTABAuditTrail

        Public Shared Function CreateNewTABAuditTrail(ByVal objTABAuditTrail As clsTABAuditTrail, ByVal SchemaName As String) As Integer

            If objTABAuditTrail Is Nothing Then
                Throw New ArgumentNullException("objTABAuditTrail")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@UserID", SqlDbType.Int, 0, ParameterDirection.Input, objTABAuditTrail.UserID)
            db.AddParamToSQLCmd(sqlCmd, "@ActionName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTABAuditTrail.ActionName)
            db.AddParamToSQLCmd(sqlCmd, "@FunctionName", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTABAuditTrail.FunctionName)
            db.AddParamToSQLCmd(sqlCmd, "@ActionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTABAuditTrail.ActionDate)

            db.AddParamToSQLCmd(sqlCmd, "@PrimaryID", SqlDbType.Int, 0, ParameterDirection.Input, objTABAuditTrail.PrimaryID)
            db.AddParamToSQLCmd(sqlCmd, "@TableName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTABAuditTrail.TableName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTABAuditTrail")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTABAuditTrail(ByVal objTABAuditTrail As clsTABAuditTrail) As Boolean

            If objTABAuditTrail Is Nothing Then
                Throw New ArgumentNullException("objTABAuditTrail")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@AuditID", SqlDbType.Int, 0, ParameterDirection.Input, objTABAuditTrail.AuditID)
            db.AddParamToSQLCmd(sqlCmd, "@UserID", SqlDbType.Int, 0, ParameterDirection.Input, objTABAuditTrail.UserID)
            db.AddParamToSQLCmd(sqlCmd, "@ActionName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTABAuditTrail.ActionName)
            db.AddParamToSQLCmd(sqlCmd, "@FunctionName", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTABAuditTrail.FunctionName)
            db.AddParamToSQLCmd(sqlCmd, "@ActionDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTABAuditTrail.ActionDate)

            db.AddParamToSQLCmd(sqlCmd, "@PrimaryID", SqlDbType.Int, 0, ParameterDirection.Input, objTABAuditTrail.PrimaryID)
            db.AddParamToSQLCmd(sqlCmd, "@TableName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTABAuditTrail.TableName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTABAuditTrail")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTABAuditTrail(ByVal AuditID As Int32) As String

            If AuditID <= 0 Then
                Throw New ArgumentOutOfRangeException("AuditID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@AuditID", SqlDbType.Int, 0, ParameterDirection.Input, AuditID)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTABAuditTrail")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTABAuditTrailByID(ByVal valAuditID As Int32) As clsTABAuditTrail
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@AuditID", valAuditID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTABAuditTrailByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTABAuditTrail As clsTABAuditTrail = New clsTABAuditTrail
                While dr.Read
                    objTABAuditTrail.AuditID = dr.GetInt32(dr.GetOrdinal("AuditID"))
                    objTABAuditTrail.UserID = dr.GetInt32(dr.GetOrdinal("UserID"))
                    objTABAuditTrail.ActionName = dr.GetString(dr.GetOrdinal("ActionName"))
                    objTABAuditTrail.FunctionName = dr.GetString(dr.GetOrdinal("FunctionName"))
                    objTABAuditTrail.ActionDate = dr.GetDateTime(dr.GetOrdinal("ActionDate"))
                End While
                dr.Close()
                Return objTABAuditTrail
            Else
                dr.Close()
                Return New clsTABAuditTrail
            End If
        End Function

        Public Shared Function GetALLTABAuditTrail(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            Dim paramUsername As SqlParameter
            paramUsername = New SqlParameter("@EmployeeID", SqlDbType.Int, 20)
            paramUsername.Direction = ParameterDirection.Input
            paramUsername.Value = valEmployeeID
            db.Parameters.Add(paramUsername)
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTABAuditTrail")
            Return ds
        End Function

        Public Shared Function GetALLTABAuditTrailDrop() As SqlDataReader
            Dim db As DBAccess = New DBAccess
            Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTABAuditTrailDrop")
            Return dr
        End Function

        Public Shared Function GetTABAuditTrailByUserID(ByVal valUserID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@UserID", valUserID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABAuditTrailByUserID")
            Return ds
        End Function

    End Class
End Namespace
