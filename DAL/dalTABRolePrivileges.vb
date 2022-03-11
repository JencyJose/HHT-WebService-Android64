'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTABRolePrivileges
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:02 PM
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
	Public Class dalTABRolePrivileges

		Private ConnectionString As String

        Public Shared Function CreateNewTABRolePrivileges(ByVal objTABRolePrivileges As PropertyTABRolePrivileges, ByVal SchemaName As String) As Integer

            If objTABRolePrivileges Is Nothing Then
                Throw New ArgumentNullException("objTABRolePrivileges")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@MenuID", SqlDbType.Int, 0, ParameterDirection.Input, objTABRolePrivileges.MenuID)
            db.AddParamToSQLCmd(sqlCmd, "@AllowView", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowView)
            db.AddParamToSQLCmd(sqlCmd, "@AllowAdd", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowAdd)
            db.AddParamToSQLCmd(sqlCmd, "@AllowEdit", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowEdit)
            db.AddParamToSQLCmd(sqlCmd, "@AllowDelete", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowDelete)
            db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, objTABRolePrivileges.RoleID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTABRolePrivileges")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function CreateNewTABRolePrivileges_ForDefaultRole(ByVal RoleID As Int32, ByVal SchemaName As String) As Integer

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, RoleID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTABRolePrivileges_ForDefaultRole")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTABRolePrivileges(ByVal objTABRolePrivileges As PropertyTABRolePrivileges) As Boolean

            If objTABRolePrivileges Is Nothing Then
                Throw New ArgumentNullException("objTABRolePrivileges")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@PrivilegeID", SqlDbType.Int, 0, ParameterDirection.Input, objTABRolePrivileges.PrivilegeID)
            db.AddParamToSQLCmd(sqlCmd, "@MenuID", SqlDbType.Int, 0, ParameterDirection.Input, objTABRolePrivileges.MenuID)
            db.AddParamToSQLCmd(sqlCmd, "@AllowView", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowView)
            db.AddParamToSQLCmd(sqlCmd, "@AllowAdd", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowAdd)
            db.AddParamToSQLCmd(sqlCmd, "@AllowEdit", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowEdit)
            db.AddParamToSQLCmd(sqlCmd, "@AllowDelete", SqlDbType.Bit, 0, ParameterDirection.Input, objTABRolePrivileges.AllowDelete)
            db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, objTABRolePrivileges.RoleID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTABRolePrivileges")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTABRolePrivileges(ByVal RoleID As Int32, ByVal SchemaName As String) As String

            If RoleID <= 0 Then
                Throw New ArgumentOutOfRangeException("RoleID")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, RoleID)
            db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DeleteTABRolePrivileges")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
            If Not String.IsNullOrEmpty(returnValue) Then
                Return returnValue
            Else
                Return ""
            End If
        End Function

        Public Shared Function GetTABRolePrivilegesByID(ByVal valPrivilegeID As Int32) As PropertyTABRolePrivileges
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@PrivilegeID", valPrivilegeID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTABRolePrivilegesByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTABRolePrivileges As PropertyTABRolePrivileges = New PropertyTABRolePrivileges
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("PrivilegeID")) Then
                        objTABRolePrivileges.PrivilegeID = dr.GetInt32(dr.GetOrdinal("PrivilegeID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("MenuID")) Then
                        objTABRolePrivileges.MenuID = dr.GetInt32(dr.GetOrdinal("MenuID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("AllowView")) Then
                        objTABRolePrivileges.AllowView = dr.GetBoolean(dr.GetOrdinal("AllowView"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("AllowAdd")) Then
                        objTABRolePrivileges.AllowAdd = dr.GetBoolean(dr.GetOrdinal("AllowAdd"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("AllowEdit")) Then
                        objTABRolePrivileges.AllowEdit = dr.GetBoolean(dr.GetOrdinal("AllowEdit"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("AllowDelete")) Then
                        objTABRolePrivileges.AllowDelete = dr.GetBoolean(dr.GetOrdinal("AllowDelete"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("RoleID")) Then
                        objTABRolePrivileges.RoleID = dr.GetInt32(dr.GetOrdinal("RoleID"))
                    End If
                End While
                dr.Close()
                Return objTABRolePrivileges
            Else
                dr.Close()
                Return New PropertyTABRolePrivileges
            End If
        End Function

        Public Shared Function GetALLTABRolePrivileges(ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTABRolePrivileges")
            Return ds
        End Function

		Public Shared Function GetALLTABRolePrivilegesDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTABRolePrivilegesDrop")
			Return dr
		End Function

		Public Shared Function GetTABRolePrivilegesByMenuID(ByVal valMenuID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@MenuID", valMenuID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABRolePrivilegesByMenuID")
			Return ds
		End Function

		Public Shared Function GetTABRolePrivilegesByRoleID(ByVal valRoleID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@RoleID", valRoleID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABRolePrivilegesByRoleID")
			Return ds
		End Function
        Public Shared Function GetAllTABPrivilegeMasterByRoleID(ByVal RoleID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@RoleID", RoleID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTABPrivilegeMasterByRoleID")
            Return ds
        End Function
        Public Shared Function GetAllTABRolePrivilegesByEmployeeID_HHT(ByVal EmployeeID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTABRolePrivilegesByEmployeeID_HHT")
            Return ds
        End Function
	End Class
End Namespace
