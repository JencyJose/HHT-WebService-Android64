'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMCustomers
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:54 PM
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
	Public Class dalTabMCustomers

		Private ConnectionString As String

		Public Shared Function CreateNewTabMCustomers(ByVal objTabMCustomers As clsTabMCustomers) As Integer

			If objTabMCustomers Is Nothing Then
				Throw New ArgumentNullException("objTabMCustomers")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.CustomerCode)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.CustomerName)
            db.AddParamToSQLCmd(sqlCmd, "@Address", SqlDbType.NVarChar, 500, ParameterDirection.Input, objTabMCustomers.Address1)
			db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.City)
			db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.State)
			db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Phone)
			db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Country)
			db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Email)
			db.AddParamToSQLCmd(sqlCmd, "@Fax", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Fax)
			db.AddParamToSQLCmd(sqlCmd, "@Website", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Website)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCustomers.CompanyID)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabMCustomers")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

        Public Shared Function UpdateTabMCustomers(ByVal objTabMCustomers As clsTabMCustomers, ByVal SchemaName As String) As Boolean

            If objTabMCustomers Is Nothing Then
                Throw New ArgumentNullException("objTabMCustomers")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCustomers.CustomerID)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.CustomerCode)
            db.AddParamToSQLCmd(sqlCmd, "@CustomerName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.CustomerName)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMCustomers.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMCustomers.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@Address3", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMCustomers.Address3)
            db.AddParamToSQLCmd(sqlCmd, "@Address4", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMCustomers.Address4)
            db.AddParamToSQLCmd(sqlCmd, "@City", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.City)
            db.AddParamToSQLCmd(sqlCmd, "@State", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.State)
            db.AddParamToSQLCmd(sqlCmd, "@Phone", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Phone)
            db.AddParamToSQLCmd(sqlCmd, "@Country", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Country)
            db.AddParamToSQLCmd(sqlCmd, "@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Email)
            db.AddParamToSQLCmd(sqlCmd, "@Fax", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Fax)
            db.AddParamToSQLCmd(sqlCmd, "@Website", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMCustomers.Website)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMCustomers.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@LOB", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.LOB)
            db.AddParamToSQLCmd(sqlCmd, "@Channel", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.Channel)
            db.AddParamToSQLCmd(sqlCmd, "@SoldToParty", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.SoldtoParty)
            db.AddParamToSQLCmd(sqlCmd, "@ShipToParty", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.ShiptoParty)
            db.AddParamToSQLCmd(sqlCmd, "@CollectionFrequency", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.CollectionFrequency)
            db.AddParamToSQLCmd(sqlCmd, "@Region", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.Region)
            db.AddParamToSQLCmd(sqlCmd, "@IsPartner", SqlDbType.Bit, 0, ParameterDirection.Input, objTabMCustomers.IsPartner)
            db.AddParamToSQLCmd(sqlCmd, "@Username", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.UserName)
            db.AddParamToSQLCmd(sqlCmd, "@Password", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMCustomers.Password)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabMCustomers")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMCustomers(ByVal CustomerID As Int32) As String

			If CustomerID<= 0 Then
				Throw New ArgumentOutOfRangeException("CustomerID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMCustomers")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabMCustomersByID(ByVal valCustomerID As Int32, ByVal SchemaName As String) As clsTabMCustomers
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CustomerID", valCustomerID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMCustomersByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMCustomers As clsTabMCustomers = New clsTabMCustomers
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
                        objTabMCustomers.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CustomerCode")) Then
                        objTabMCustomers.CustomerCode = dr.GetString(dr.GetOrdinal("CustomerCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CustomerName")) Then
                        objTabMCustomers.CustomerName = dr.GetString(dr.GetOrdinal("CustomerName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMCustomers.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMCustomers.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address3")) Then
                        objTabMCustomers.Address3 = dr.GetString(dr.GetOrdinal("Address3"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address4")) Then
                        objTabMCustomers.Address4 = dr.GetString(dr.GetOrdinal("Address4"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("City")) Then
                        objTabMCustomers.City = dr.GetString(dr.GetOrdinal("City"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("State")) Then
                        objTabMCustomers.State = dr.GetString(dr.GetOrdinal("State"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Phone")) Then
                        objTabMCustomers.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Country")) Then
                        objTabMCustomers.Country = dr.GetString(dr.GetOrdinal("Country"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Email")) Then
                        objTabMCustomers.Email = dr.GetString(dr.GetOrdinal("Email"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Fax")) Then
                        objTabMCustomers.Fax = dr.GetString(dr.GetOrdinal("Fax"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Website")) Then
                        objTabMCustomers.Website = dr.GetString(dr.GetOrdinal("Website"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMCustomers.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
                        objTabMCustomers.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("LOB")) Then
                        objTabMCustomers.LOB = dr.GetString(dr.GetOrdinal("LOB"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Channel")) Then
                        objTabMCustomers.Channel = dr.GetString(dr.GetOrdinal("Channel"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SoldToParty")) Then
                        objTabMCustomers.SoldtoParty = dr.GetString(dr.GetOrdinal("SoldToParty"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ShipToParty")) Then
                        objTabMCustomers.ShiptoParty = dr.GetString(dr.GetOrdinal("ShipToParty"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CollectionFrequency")) Then
                        objTabMCustomers.CollectionFrequency = dr.GetString(dr.GetOrdinal("CollectionFrequency"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Region")) Then
                        objTabMCustomers.Region = dr.GetString(dr.GetOrdinal("Region"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("IsPartner")) Then
                        objTabMCustomers.IsPartner = dr.GetBoolean(dr.GetOrdinal("IsPartner"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Username")) Then
                        objTabMCustomers.Username = dr.GetString(dr.GetOrdinal("Username"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Password")) Then
                        objTabMCustomers.Password = dr.GetString(dr.GetOrdinal("Password"))
                    End If
                End While
                dr.Close()
                Return objTabMCustomers
            Else
                dr.Close()
                Return New clsTabMCustomers
            End If
        End Function

		Public Shared Function GetALLTabMCustomers(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMCustomers")
			Return ds
		End Function

		Public Shared Function GetALLTabMCustomersDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMCustomersDrop")
			Return dr
		End Function

        Public Shared Function GetTabMCustomersByCompanyID(ByVal valCompanyID As Int32, ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMCustomersByCompanyID")
            Return ds
        End Function

	End Class
End Namespace
