'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabExceptionLogItems
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:41 PM
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
	Public Class dalTabExceptionLogItems

		Private ConnectionString As String

        Public Shared Function CreateNewTabExceptionLogItems(ByVal objTabExceptionLogItems As PropertyTabExceptionLogItems) As Integer

            If objTabExceptionLogItems Is Nothing Then
                Throw New ArgumentNullException("objTabExceptionLogItems")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@LogDateTime", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabExceptionLogItems.LogDateTime)
            db.AddParamToSQLCmd(sqlCmd, "@Source", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabExceptionLogItems.Source)
            db.AddParamToSQLCmd(sqlCmd, "@Message", SqlDbType.NVarChar, 1000, ParameterDirection.Input, objTabExceptionLogItems.Message)
            db.AddParamToSQLCmd(sqlCmd, "@QueryString", SqlDbType.NVarChar, 2000, ParameterDirection.Input, objTabExceptionLogItems.QueryString)
            db.AddParamToSQLCmd(sqlCmd, "@TargetSite", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.TargetSite)
            db.AddParamToSQLCmd(sqlCmd, "@StackTrace", SqlDbType.NVarChar, 4000, ParameterDirection.Input, objTabExceptionLogItems.StackTrace)
            db.AddParamToSQLCmd(sqlCmd, "@ServerName", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabExceptionLogItems.ServerName)
            db.AddParamToSQLCmd(sqlCmd, "@RequestURL", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.RequestURL)
            db.AddParamToSQLCmd(sqlCmd, "@UserAgent", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserAgent)
            db.AddParamToSQLCmd(sqlCmd, "@UserIP", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserIP)
            db.AddParamToSQLCmd(sqlCmd, "@UserAuthentication", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserAuthentication)
            db.AddParamToSQLCmd(sqlCmd, "@UserName", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabExceptionLogItems")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabExceptionLogItems(ByVal objTabExceptionLogItems As PropertyTabExceptionLogItems) As Boolean

            If objTabExceptionLogItems Is Nothing Then
                Throw New ArgumentNullException("objTabExceptionLogItems")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EventId", SqlDbType.Int, 0, ParameterDirection.Input, objTabExceptionLogItems.EventId)
            db.AddParamToSQLCmd(sqlCmd, "@LogDateTime", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabExceptionLogItems.LogDateTime)
            db.AddParamToSQLCmd(sqlCmd, "@Source", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabExceptionLogItems.Source)
            db.AddParamToSQLCmd(sqlCmd, "@Message", SqlDbType.NVarChar, 1000, ParameterDirection.Input, objTabExceptionLogItems.Message)
            db.AddParamToSQLCmd(sqlCmd, "@QueryString", SqlDbType.NVarChar, 2000, ParameterDirection.Input, objTabExceptionLogItems.QueryString)
            db.AddParamToSQLCmd(sqlCmd, "@TargetSite", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.TargetSite)
            db.AddParamToSQLCmd(sqlCmd, "@StackTrace", SqlDbType.NVarChar, 4000, ParameterDirection.Input, objTabExceptionLogItems.StackTrace)
            db.AddParamToSQLCmd(sqlCmd, "@ServerName", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabExceptionLogItems.ServerName)
            db.AddParamToSQLCmd(sqlCmd, "@RequestURL", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.RequestURL)
            db.AddParamToSQLCmd(sqlCmd, "@UserAgent", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserAgent)
            db.AddParamToSQLCmd(sqlCmd, "@UserIP", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserIP)
            db.AddParamToSQLCmd(sqlCmd, "@UserAuthentication", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserAuthentication)
            db.AddParamToSQLCmd(sqlCmd, "@UserName", SqlDbType.NVarChar, 300, ParameterDirection.Input, objTabExceptionLogItems.UserName)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabExceptionLogItems")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabExceptionLogItems(ByVal EventId As Int32) As String

			If EventId<= 0 Then
				Throw New ArgumentOutOfRangeException("EventId")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@EventId", SqlDbType.Int, 0, ParameterDirection.Input, EventId)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabExceptionLogItems")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabExceptionLogItemsByID(ByVal valEventId As Int32) As PropertyTabExceptionLogItems
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EventId", valEventId))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabExceptionLogItemsByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabExceptionLogItems As PropertyTabExceptionLogItems = New PropertyTabExceptionLogItems
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EventId")) Then
                        objTabExceptionLogItems.EventId = dr.GetInt32(dr.GetOrdinal("EventId"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("LogDateTime")) Then
                        objTabExceptionLogItems.LogDateTime = dr.GetDateTime(dr.GetOrdinal("LogDateTime"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Source")) Then
                        objTabExceptionLogItems.Source = dr.GetString(dr.GetOrdinal("Source"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Message")) Then
                        objTabExceptionLogItems.Message = dr.GetString(dr.GetOrdinal("Message"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("QueryString")) Then
                        objTabExceptionLogItems.QueryString = dr.GetString(dr.GetOrdinal("QueryString"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TargetSite")) Then
                        objTabExceptionLogItems.TargetSite = dr.GetString(dr.GetOrdinal("TargetSite"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("StackTrace")) Then
                        objTabExceptionLogItems.StackTrace = dr.GetString(dr.GetOrdinal("StackTrace"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ServerName")) Then
                        objTabExceptionLogItems.ServerName = dr.GetString(dr.GetOrdinal("ServerName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("RequestURL")) Then
                        objTabExceptionLogItems.RequestURL = dr.GetString(dr.GetOrdinal("RequestURL"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserAgent")) Then
                        objTabExceptionLogItems.UserAgent = dr.GetString(dr.GetOrdinal("UserAgent"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserIP")) Then
                        objTabExceptionLogItems.UserIP = dr.GetString(dr.GetOrdinal("UserIP"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserAuthentication")) Then
                        objTabExceptionLogItems.UserAuthentication = dr.GetString(dr.GetOrdinal("UserAuthentication"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UserName")) Then
                        objTabExceptionLogItems.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                    End If
                End While
                dr.Close()
                Return objTabExceptionLogItems
            Else
                dr.Close()
                Return New PropertyTabExceptionLogItems
            End If
        End Function

		Public Shared Function GetALLTabExceptionLogItems(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabExceptionLogItems")
			Return ds
		End Function

		Public Shared Function GetALLTabExceptionLogItemsDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabExceptionLogItemsDrop")
			Return dr
		End Function

	End Class
End Namespace
