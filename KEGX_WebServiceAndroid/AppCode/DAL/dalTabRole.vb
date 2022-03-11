'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabRole
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:01 PM
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
	Public Class dalTabRole

		Private ConnectionString As String

        Public Shared Function CreateNewTabRole(ByVal objTabRole As clsTabRole, ByVal SchemaName As String) As Integer

            If objTabRole Is Nothing Then
                Throw New ArgumentNullException("objTabRole")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@RoleName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabRole.RoleName)
            db.AddParamToSQLCmd(sqlCmd, "@EnteredBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabRole.EnteredBy)
            db.AddParamToSQLCmd(sqlCmd, "@EnteredOn", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabRole.EnteredOn)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabRole.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@IsOrganization", SqlDbType.Bit, 0, ParameterDirection.Input, objTabRole.IsOrganization)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabRole")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabRole(ByVal objTabRole As clsTabRole, ByVal SchemaName As String) As Boolean

            If objTabRole Is Nothing Then
                Throw New ArgumentNullException("objTabRole")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, objTabRole.RoleID)
            db.AddParamToSQLCmd(sqlCmd, "@RoleName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabRole.RoleName)
            db.AddParamToSQLCmd(sqlCmd, "@EnteredBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabRole.EnteredBy)
            db.AddParamToSQLCmd(sqlCmd, "@EnteredOn", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabRole.EnteredOn)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabRole.CompanyID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabRole")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabRole(ByVal RoleID As Int32) As String

			If RoleID<= 0 Then
				Throw New ArgumentOutOfRangeException("RoleID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, RoleID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabRole")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabRoleByID(ByVal valRoleID As Int32, ByVal SchemaName As String) As clsTabRole
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@RoleID", valRoleID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabRoleByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabRole As clsTabRole = New clsTabRole
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("RoleID")) Then
                        objTabRole.RoleID = dr.GetInt32(dr.GetOrdinal("RoleID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("RoleName")) Then
                        objTabRole.RoleName = dr.GetString(dr.GetOrdinal("RoleName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EnteredBy")) Then
                        objTabRole.EnteredBy = dr.GetInt32(dr.GetOrdinal("EnteredBy"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("EnteredOn")) Then
                        objTabRole.EnteredOn = dr.GetDateTime(dr.GetOrdinal("EnteredOn"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabRole.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                End While
                dr.Close()
                Return objTabRole
            Else
                dr.Close()
                Return New clsTabRole
            End If
        End Function

		Public Shared Function GetALLTabRole(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabRole")
			Return ds
		End Function

		Public Shared Function GetALLTabRoleDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabRoleDrop")
			Return dr
		End Function
        Public Shared Function GetAllTabRoleByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabRoleByEmployeeID")
            Return ds
        End Function
	End Class
End Namespace
