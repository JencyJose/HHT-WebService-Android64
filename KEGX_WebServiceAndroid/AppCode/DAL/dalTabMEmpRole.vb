'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMEmpRole
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:56 PM
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
	Public Class dalTabMEmpRole

		Private ConnectionString As String

		Public Shared Function CreateNewTabMEmpRole(ByVal objTabMEmpRole As clsTabMEmpRole) As Integer

			If objTabMEmpRole Is Nothing Then
				Throw New ArgumentNullException("objTabMEmpRole")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMEmpRole.EmployeeID)
			db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMEmpRole.RoleID)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabMEmpRole")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function UpdateTabMEmpRole(ByVal objTabMEmpRole As clsTabMEmpRole) As Boolean

			If objTabMEmpRole Is Nothing Then
				Throw New ArgumentNullException("objTabMEmpRole")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMEmpRole.EmployeeID)
			db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMEmpRole.RoleID)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabMEmpRole")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

        'Public Shared Function DeleteTabMEmpRole(ByVal  As ) As String


        '	Dim db As DBAccess = New DBAccess
        '	Dim sqlCmd As New SqlCommand()
        '	db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
        '	db.AddParamToSQLCmd(sqlCmd, "@", , 0, ParameterDirection.Input, )
        '	db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
        '	db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMEmpRole")
        '	db.ExecuteScalarCmd(sqlCmd)
        '	Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
        '	If Not String.IsNullOrEmpty(returnValue) Then
        '		Return returnValue
        '	Else
        '		Return ""
        '	End If
        'End Function

        'Public Shared Function GetTabMEmpRoleByID(ByVal val As ) As clsTabMEmpRole
        '	Dim db As DBAccess = New DBAccess
        '	db.Parameters.Add(New SqlParameter("@", val))
        '	Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabMEmpRoleByID"), SqlDataReader)

        '	If dr.HasRows Then
        '		Dim objTabMEmpRole As clsTabMEmpRole = New clsTabMEmpRole
        '		While dr.Read
        '			If Not dr.IsDBNull(dr.GetOrdinal("EmployeeID")) Then
        '				objTabMEmpRole.EmployeeID = dr.GetInt32(dr.GetOrdinal("EmployeeID"))
        '			End If
        '			If Not dr.IsDBNull(dr.GetOrdinal("RoleID")) Then
        '				objTabMEmpRole.RoleID = dr.GetInt32(dr.GetOrdinal("RoleID"))
        '			End If
        '		End While
        '		dr.Close()
        '		Return objTabMEmpRole
        '	Else
        '		dr.Close()
        '		Return New clsTabMEmpRole
        '	End If
        'End Function

		Public Shared Function GetALLTabMEmpRole(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMEmpRole")
			Return ds
		End Function

		Public Shared Function GetALLTabMEmpRoleDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMEmpRoleDrop")
			Return dr
		End Function

	End Class
End Namespace
