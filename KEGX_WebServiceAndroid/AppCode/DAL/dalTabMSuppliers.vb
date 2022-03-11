'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMSuppliers
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
	Public Class dalTabMSuppliers

		Private ConnectionString As String

		Public Shared Function CreateNewTabMSuppliers(ByVal objTabMSuppliers As clsTabMSuppliers) As Integer

			If objTabMSuppliers Is Nothing Then
				Throw New ArgumentNullException("objTabMSuppliers")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@SupplierCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.SupplierCode)
			db.AddParamToSQLCmd(sqlCmd, "@SupplierName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMSuppliers.SupplierName)
            db.AddParamToSQLCmd(sqlCmd, "@Address", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMSuppliers.Address1)
			db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.City)
			db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.State)
			db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Phone)
			db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Country)
			db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Email)
			db.AddParamToSQLCmd(sqlCmd, "@Fax", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Fax)
			db.AddParamToSQLCmd(sqlCmd, "@Website", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Website)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMSuppliers.CompanyID)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabMSuppliers")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

        Public Shared Function UpdateTabMSuppliers(ByVal objTabMSuppliers As clsTabMSuppliers, ByVal SchemaName As String) As Boolean

            If objTabMSuppliers Is Nothing Then
                Throw New ArgumentNullException("objTabMSuppliers")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMSuppliers.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.SupplierCode)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMSuppliers.SupplierName)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMSuppliers.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMSuppliers.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@Address3", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMSuppliers.Address3)
            db.AddParamToSQLCmd(sqlCmd, "@Address4", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMSuppliers.Address4)
            db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.City)
            db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.State)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Country)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Email)
            db.AddParamToSQLCmd(sqlCmd, "@Fax", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Fax)
            db.AddParamToSQLCmd(sqlCmd, "@Website", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMSuppliers.Website)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMSuppliers.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ShipmentPort", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMSuppliers.ShipmentPort)
            db.AddParamToSQLCmd(sqlCmd, "@DesignationPort", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMSuppliers.DestinationPort)
            db.AddParamToSQLCmd(sqlCmd, "@TermsOfReturn", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMSuppliers.TermsofReturn)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabMSuppliers")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMSuppliers(ByVal SupplierID As Int32) As String

			If SupplierID<= 0 Then
				Throw New ArgumentOutOfRangeException("SupplierID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, SupplierID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMSuppliers")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabMSuppliersByID(ByVal valSupplierID As Int32, ByVal SchemaName As String) As clsTabMSuppliers
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@SupplierID", valSupplierID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMSuppliersByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMSuppliers As clsTabMSuppliers = New clsTabMSuppliers
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("SupplierID")) Then
                        objTabMSuppliers.SupplierID = dr.GetInt32(dr.GetOrdinal("SupplierID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SupplierCode")) Then
                        objTabMSuppliers.SupplierCode = dr.GetString(dr.GetOrdinal("SupplierCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SupplierName")) Then
                        objTabMSuppliers.SupplierName = dr.GetString(dr.GetOrdinal("SupplierName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMSuppliers.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMSuppliers.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address3")) Then
                        objTabMSuppliers.Address3 = dr.GetString(dr.GetOrdinal("Address3"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address4")) Then
                        objTabMSuppliers.Address4 = dr.GetString(dr.GetOrdinal("Address4"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("City")) Then
                        objTabMSuppliers.City = dr.GetString(dr.GetOrdinal("City"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("State")) Then
                        objTabMSuppliers.State = dr.GetString(dr.GetOrdinal("State"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMSuppliers.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Country")) Then
                        objTabMSuppliers.Country = dr.GetString(dr.GetOrdinal("Country"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMSuppliers.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Fax")) Then
                        objTabMSuppliers.Fax = dr.GetString(dr.GetOrdinal("Fax"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Website")) Then
                        objTabMSuppliers.Website = dr.GetString(dr.GetOrdinal("Website"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMSuppliers.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ShipmentPort")) Then
                        objTabMSuppliers.ShipmentPort = dr.GetString(dr.GetOrdinal("ShipmentPort"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("DesignationPort")) Then
                        objTabMSuppliers.DestinationPort = dr.GetString(dr.GetOrdinal("DesignationPort"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TermsOfReturn")) Then
                        objTabMSuppliers.TermsofReturn = dr.GetString(dr.GetOrdinal("TermsOfReturn"))
                    End If
                End While
                dr.Close()
                Return objTabMSuppliers
            Else
                dr.Close()
                Return New clsTabMSuppliers
            End If
        End Function

		Public Shared Function GetALLTabMSuppliers(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMSuppliers")
			Return ds
		End Function

		Public Shared Function GetALLTabMSuppliersDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMSuppliersDrop")
			Return dr
		End Function

        Public Shared Function GetTabMSuppliersByCompanyID(ByVal valCompanyID As Int32, ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMSuppliersByCompanyID")
            Return ds
        End Function

	End Class
End Namespace
