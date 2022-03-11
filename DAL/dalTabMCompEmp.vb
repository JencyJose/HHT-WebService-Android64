'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMCompEmp
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:53 PM
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
	Public Class dalTabMCompEmp

		Private ConnectionString As String

        Public Shared Function CreateNewTabMCompEmp(ByVal objTabMCompEmp As PropertyTabMCompEmp, ByVal SchemaName As String) As Integer

            If objTabMCompEmp Is Nothing Then
                Throw New ArgumentNullException("objTabMCompEmp")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCompEmp.EmployeeID)
            db.AddParamToSQLCmd(sqlCmd, "@RoleID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCompEmp.RoleID)
            db.AddParamToSQLCmd(sqlCmd, "@OrganizationID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCompEmp.OrganizationID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCompEmp.CompanyID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_CreateNewTabMCompEmp")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabMCompEmp(ByVal objTabMCompEmp As PropertyTabMCompEmp) As Boolean

            If objTabMCompEmp Is Nothing Then
                Throw New ArgumentNullException("objTabMCompEmp")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCompEmp.EmployeeID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCompEmp.CompanyID)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabMCompEmp")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMCompEmp(ByVal CompanyID As Int32) As String

			If CompanyID<= 0 Then
				Throw New ArgumentOutOfRangeException("CompanyID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMCompEmp")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabMCompEmpByID(ByVal valCompanyID As Int32) As PropertyTabMCompEmp
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabMCompEmpByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMCompEmp As PropertyTabMCompEmp = New PropertyTabMCompEmp
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("EmployeeID")) Then
                        objTabMCompEmp.EmployeeID = dr.GetInt32(dr.GetOrdinal("EmployeeID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMCompEmp.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                End While
                dr.Close()
                Return objTabMCompEmp
            Else
                dr.Close()
                Return New PropertyTabMCompEmp
            End If
        End Function

		Public Shared Function GetALLTabMCompEmp(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMCompEmp")
			Return ds
		End Function

		Public Shared Function GetALLTabMCompEmpDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMCompEmpDrop")
			Return dr
		End Function

        Public Shared Function GetTabMAllCompEmpByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetComEmpAllHHTUsersNewCR")
            Return ds
        End Function
        Public Shared Function GetTabMCompEmpByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMCompEmpByEmployeeID")
            Return ds
        End Function
		Public Shared Function GetTabMCompEmpByCompanyID(ByVal valCompanyID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMCompEmpByCompanyID")
			Return ds
		End Function
        Public Shared Function GetAllTabMCompEmpOrgByEmployeeID(ByVal valUserName As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMCompEmpOrgByEmployeeID")
            Return ds
        End Function

        Public Shared Function GetTabMAllHHTUsersNewCR(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetHHTUsersNewCR")
            Return ds
        End Function
	End Class
End Namespace
