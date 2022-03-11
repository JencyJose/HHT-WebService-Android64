'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalsysdiagrams
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:40 PM
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
	Public Class dalsysdiagrams

		Private ConnectionString As String

		Public Shared Function CreateNewsysdiagrams(ByVal objsysdiagrams As clssysdiagrams) As Integer

			If objsysdiagrams Is Nothing Then
				Throw New ArgumentNullException("objsysdiagrams")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@name", SqlDbType.NVarChar, 128, ParameterDirection.Input, objsysdiagrams.name)
			db.AddParamToSQLCmd(sqlCmd, "@principal_id", SqlDbType.Int, 0, ParameterDirection.Input, objsysdiagrams.principal_id)
			db.AddParamToSQLCmd(sqlCmd, "@version", SqlDbType.Int, 0, ParameterDirection.Input, objsysdiagrams.version)
			db.AddParamToSQLCmd(sqlCmd, "@definition", SqlDbType.varbinary, 0, ParameterDirection.Input, objsysdiagrams.definition)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewsysdiagrams")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function Updatesysdiagrams(ByVal objsysdiagrams As clssysdiagrams) As Boolean

			If objsysdiagrams Is Nothing Then
				Throw New ArgumentNullException("objsysdiagrams")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@name", SqlDbType.NVarChar, 128, ParameterDirection.Input, objsysdiagrams.name)
			db.AddParamToSQLCmd(sqlCmd, "@principal_id", SqlDbType.Int, 0, ParameterDirection.Input, objsysdiagrams.principal_id)
			db.AddParamToSQLCmd(sqlCmd, "@diagram_id", SqlDbType.Int, 0, ParameterDirection.Input, objsysdiagrams.diagram_id)
			db.AddParamToSQLCmd(sqlCmd, "@version", SqlDbType.Int, 0, ParameterDirection.Input, objsysdiagrams.version)
			db.AddParamToSQLCmd(sqlCmd, "@definition", SqlDbType.varbinary, 0, ParameterDirection.Input, objsysdiagrams.definition)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_Updatesysdiagrams")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

		Public Shared Function Deletesysdiagrams(ByVal diagram_id As Int32) As String

			If diagram_id<= 0 Then
				Throw New ArgumentOutOfRangeException("diagram_id")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@diagram_id", SqlDbType.Int, 0, ParameterDirection.Input, diagram_id)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_Deletesysdiagrams")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

		Public Shared Function GetsysdiagramsByID(ByVal valdiagram_id As Int32) As clssysdiagrams
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@diagram_id", valdiagram_id))
			Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetsysdiagramsByID"), SqlDataReader)

			If dr.HasRows Then
				Dim objsysdiagrams As clssysdiagrams = New clssysdiagrams
				While dr.Read
					If Not dr.IsDBNull(dr.GetOrdinal("name")) Then
						objsysdiagrams.name = dr.GetString(dr.GetOrdinal("name"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("principal_id")) Then
						objsysdiagrams.principal_id = dr.GetInt32(dr.GetOrdinal("principal_id"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("diagram_id")) Then
						objsysdiagrams.diagram_id = dr.GetInt32(dr.GetOrdinal("diagram_id"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("version")) Then
						objsysdiagrams.version = dr.GetInt32(dr.GetOrdinal("version"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("definition")) Then
						objsysdiagrams.definition = dr.varbinary(dr.GetOrdinal("definition"))
					End If
				End While
				dr.Close()
				Return objsysdiagrams
			Else
				dr.Close()
				Return New clssysdiagrams
			End If
		End Function

		Public Shared Function GetALLsysdiagrams(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllsysdiagrams")
			Return ds
		End Function

		Public Shared Function GetALLsysdiagramsDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllsysdiagramsDrop")
			Return dr
		End Function

	End Class
End Namespace
