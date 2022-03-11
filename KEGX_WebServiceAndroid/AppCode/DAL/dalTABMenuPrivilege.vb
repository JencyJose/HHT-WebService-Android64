'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTABMenuPrivilege
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:58 PM
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
	Public Class dalTABMenuPrivilege

		Private ConnectionString As String

		Public Shared Function CreateNewTABMenuPrivilege(ByVal objTABMenuPrivilege As clsTABMenuPrivilege) As Integer

			If objTABMenuPrivilege Is Nothing Then
				Throw New ArgumentNullException("objTABMenuPrivilege")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@PrivilegeName_en", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenuPrivilege.PrivilegeName_en)
			db.AddParamToSQLCmd(sqlCmd, "@PrivilegeName_ar", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenuPrivilege.PrivilegeName_ar)
			db.AddParamToSQLCmd(sqlCmd, "@Seq", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenuPrivilege.Seq)
			db.AddParamToSQLCmd(sqlCmd, "@MenuID", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenuPrivilege.MenuID)
			db.AddParamToSQLCmd(sqlCmd, "@Mandatory", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenuPrivilege.Mandatory)
			db.AddParamToSQLCmd(sqlCmd, "@UserDefined", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenuPrivilege.UserDefined)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTABMenuPrivilege")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function UpdateTABMenuPrivilege(ByVal objTABMenuPrivilege As clsTABMenuPrivilege) As Boolean

			If objTABMenuPrivilege Is Nothing Then
				Throw New ArgumentNullException("objTABMenuPrivilege")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@PrivID", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenuPrivilege.PrivID)
			db.AddParamToSQLCmd(sqlCmd, "@PrivilegeName_en", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenuPrivilege.PrivilegeName_en)
			db.AddParamToSQLCmd(sqlCmd, "@PrivilegeName_ar", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTABMenuPrivilege.PrivilegeName_ar)
			db.AddParamToSQLCmd(sqlCmd, "@Seq", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenuPrivilege.Seq)
			db.AddParamToSQLCmd(sqlCmd, "@MenuID", SqlDbType.Int, 0, ParameterDirection.Input, objTABMenuPrivilege.MenuID)
			db.AddParamToSQLCmd(sqlCmd, "@Mandatory", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenuPrivilege.Mandatory)
			db.AddParamToSQLCmd(sqlCmd, "@UserDefined", SqlDbType.bit, 0, ParameterDirection.Input, objTABMenuPrivilege.UserDefined)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTABMenuPrivilege")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTABMenuPrivilege(ByVal PrivID As Int32) As String

			If PrivID<= 0 Then
				Throw New ArgumentOutOfRangeException("PrivID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@PrivID", SqlDbType.Int, 0, ParameterDirection.Input, PrivID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTABMenuPrivilege")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

		Public Shared Function GetTABMenuPrivilegeByID(ByVal valPrivID As Int32) As clsTABMenuPrivilege
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@PrivID", valPrivID))
			Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTABMenuPrivilegeByID"), SqlDataReader)

			If dr.HasRows Then
				Dim objTABMenuPrivilege As clsTABMenuPrivilege = New clsTABMenuPrivilege
				While dr.Read
					If Not dr.IsDBNull(dr.GetOrdinal("PrivID")) Then
						objTABMenuPrivilege.PrivID = dr.GetInt32(dr.GetOrdinal("PrivID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("PrivilegeName_en")) Then
						objTABMenuPrivilege.PrivilegeName_en = dr.GetString(dr.GetOrdinal("PrivilegeName_en"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("PrivilegeName_ar")) Then
						objTABMenuPrivilege.PrivilegeName_ar = dr.GetString(dr.GetOrdinal("PrivilegeName_ar"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Seq")) Then
						objTABMenuPrivilege.Seq = dr.GetInt32(dr.GetOrdinal("Seq"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("MenuID")) Then
						objTABMenuPrivilege.MenuID = dr.GetInt32(dr.GetOrdinal("MenuID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Mandatory")) Then
                        objTABMenuPrivilege.Mandatory = dr.GetBoolean(dr.GetOrdinal("Mandatory"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("UserDefined")) Then
                        objTABMenuPrivilege.UserDefined = dr.GetBoolean(dr.GetOrdinal("UserDefined"))
					End If
				End While
				dr.Close()
				Return objTABMenuPrivilege
			Else
				dr.Close()
				Return New clsTABMenuPrivilege
			End If
		End Function

		Public Shared Function GetALLTABMenuPrivilege(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABMenuPrivilege")
			Return ds
		End Function

		Public Shared Function GetALLTABMenuPrivilegeDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTABMenuPrivilegeDrop")
			Return dr
		End Function

		Public Shared Function GetTABMenuPrivilegeByMenuID(ByVal valMenuID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@MenuID", valMenuID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABMenuPrivilegeByMenuID")
			Return ds
		End Function

	End Class
End Namespace
