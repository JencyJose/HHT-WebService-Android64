'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMOrganization
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:59 PM
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
	Public Class dalTabMOrganization

		Private ConnectionString As String

        Public Shared Function CreateNewTabMOrganization(ByVal objTabMOrganization As PropertyTabMOrganization) As Integer

            If objTabMOrganization Is Nothing Then
                Throw New ArgumentNullException("objTabMOrganization")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.CompanyCode)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMOrganization.CompanyName)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganization.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganization.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@Address3", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganization.Address3)
            db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.City)
            db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.State)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.Country)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.Email)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyImage", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganization.CompanyImage)
            db.AddParamToSQLCmd(sqlCmd, "@Thumbnail", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganization.Thumbnail)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabMOrganization")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabMOrganization(ByVal objTabMOrganization As PropertyTabMOrganization) As Boolean

            If objTabMOrganization Is Nothing Then
                Throw New ArgumentNullException("objTabMOrganization")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMOrganization.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.CompanyCode)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMOrganization.CompanyName)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganization.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganization.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@Address3", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMOrganization.Address3)
            db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.City)
            db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.State)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.Country)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMOrganization.Email)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyImage", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganization.CompanyImage)
            db.AddParamToSQLCmd(sqlCmd, "@Thumbnail", SqlDbType.Image, 0, ParameterDirection.Input, objTabMOrganization.Thumbnail)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabMOrganization")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMOrganization(ByVal CompanyID As Int32) As String

			If CompanyID<= 0 Then
				Throw New ArgumentOutOfRangeException("CompanyID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMOrganization")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabMOrganizationByID(ByVal valCompanyID As Int32, ByVal SchemaName As String) As PropertyTabMOrganization
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMOrganizationByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMOrganization As PropertyTabMOrganization = New PropertyTabMOrganization
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMOrganization.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyCode")) Then
                        objTabMOrganization.CompanyCode = dr.GetString(dr.GetOrdinal("CompanyCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyName")) Then
                        objTabMOrganization.CompanyName = dr.GetString(dr.GetOrdinal("CompanyName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMOrganization.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMOrganization.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address3")) Then
                        objTabMOrganization.Address3 = dr.GetString(dr.GetOrdinal("Address3"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("City")) Then
                        objTabMOrganization.City = dr.GetString(dr.GetOrdinal("City"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("State")) Then
                        objTabMOrganization.State = dr.GetString(dr.GetOrdinal("State"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMOrganization.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Country")) Then
                        objTabMOrganization.Country = dr.GetString(dr.GetOrdinal("Country"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMOrganization.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyImage")) Then
                        objTabMOrganization.CompanyImage = CType(dr.Item("CompanyImage"), Byte())
                    End If
                End While
                dr.Close()
                Return objTabMOrganization
            Else
                dr.Close()
                Return New PropertyTabMOrganization
            End If
        End Function

        Public Shared Function GetALLTabMOrganization(ByVal valUserName As String, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMOrganization")
            Return ds
        End Function

		Public Shared Function GetALLTabMOrganizationDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMOrganizationDrop")
			Return dr
		End Function
        Public Shared Function GetAllTabMOrganizationByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMOrganizationByEmployeeID")
            Return ds
        End Function
        Public Shared Function GetTabMOrganizationByCompanyCode(ByVal valCompanyCode As String, ByVal SchemaName As String) As PropertyTabMOrganization
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyCode", valCompanyCode))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMOrganizationByCompanyCode"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMOrganization As PropertyTabMOrganization = New PropertyTabMOrganization
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMOrganization.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyCode")) Then
                        objTabMOrganization.CompanyCode = dr.GetString(dr.GetOrdinal("CompanyCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyName")) Then
                        objTabMOrganization.CompanyName = dr.GetString(dr.GetOrdinal("CompanyName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMOrganization.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMOrganization.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address3")) Then
                        objTabMOrganization.Address3 = dr.GetString(dr.GetOrdinal("Address3"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("City")) Then
                        objTabMOrganization.City = dr.GetString(dr.GetOrdinal("City"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("State")) Then
                        objTabMOrganization.State = dr.GetString(dr.GetOrdinal("State"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMOrganization.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Country")) Then
                        objTabMOrganization.Country = dr.GetString(dr.GetOrdinal("Country"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMOrganization.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyImage")) Then
                        objTabMOrganization.CompanyImage = CType(dr.Item("CompanyImage"), Byte())
                    End If
                End While
                dr.Close()
                Return objTabMOrganization
            Else
                dr.Close()
                Return New PropertyTabMOrganization
            End If
        End Function
	End Class
End Namespace
