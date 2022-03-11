'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKEmptyCustomer
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:44 PM
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
	Public Class dalTabKEmptyCustomer

		Private ConnectionString As String

		Public Shared Function CreateNewTabKEmptyCustomer(ByVal objTabKEmptyCustomer As clsTabKEmptyCustomer) As Integer

			If objTabKEmptyCustomer Is Nothing Then
				Throw New ArgumentNullException("objTabKEmptyCustomer")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
			db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
			db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
			db.AddParamToSQLCmd(sqlCmd, "@ReceiveDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveDate)
			db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKEmptyCustomer")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function UpdateTabKEmptyCustomer(ByVal objTabKEmptyCustomer As clsTabKEmptyCustomer) As Boolean

			If objTabKEmptyCustomer Is Nothing Then
				Throw New ArgumentNullException("objTabKEmptyCustomer")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@EOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.EOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.BranchID)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.Quantity)
			db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustomer.Batch)
			db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustomer.Barcode)
			db.AddParamToSQLCmd(sqlCmd, "@ReceiveDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveDate)
			db.AddParamToSQLCmd(sqlCmd, "@ReceiveBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustomer.ReceiveBy)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKEmptyCustomer")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKEmptyCustomer(ByVal EOrderID As Int32) As String

			If EOrderID<= 0 Then
				Throw New ArgumentOutOfRangeException("EOrderID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@EOrderID", SqlDbType.Int, 0, ParameterDirection.Input, EOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKEmptyCustomer")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

		Public Shared Function GetTabKEmptyCustomerByID(ByVal valEOrderID As Int32) As clsTabKEmptyCustomer
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@EOrderID", valEOrderID))
			Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKEmptyCustomerByID"), SqlDataReader)

			If dr.HasRows Then
				Dim objTabKEmptyCustomer As clsTabKEmptyCustomer = New clsTabKEmptyCustomer
				While dr.Read
					If Not dr.IsDBNull(dr.GetOrdinal("EOrderID")) Then
						objTabKEmptyCustomer.EOrderID = dr.GetInt32(dr.GetOrdinal("EOrderID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
						objTabKEmptyCustomer.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
						objTabKEmptyCustomer.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
						objTabKEmptyCustomer.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
						objTabKEmptyCustomer.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
						objTabKEmptyCustomer.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
						objTabKEmptyCustomer.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKEmptyCustomer.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
						objTabKEmptyCustomer.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ReceiveDate")) Then
						objTabKEmptyCustomer.ReceiveDate = dr.GetDateTime(dr.GetOrdinal("ReceiveDate"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ReceiveBy")) Then
						objTabKEmptyCustomer.ReceiveBy = dr.GetInt32(dr.GetOrdinal("ReceiveBy"))
					End If
				End While
				dr.Close()
				Return objTabKEmptyCustomer
			Else
				dr.Close()
				Return New clsTabKEmptyCustomer
			End If
		End Function

		Public Shared Function GetALLTabKEmptyCustomer(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustomer")
			Return ds
		End Function

		Public Shared Function GetALLTabKEmptyCustomerDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKEmptyCustomerDrop")
			Return dr
		End Function

		Public Shared Function GetTabKEmptyCustomerByCustomerID(ByVal valCustomerID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@CustomerID", valCustomerID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustomerByCustomerID")
			Return ds
		End Function
        Public Shared Function GetAllTabKEmptyCustomerByCompanyID(ByVal valCompanyID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustomerByCompanyID")
            Return ds
        End Function
	End Class
End Namespace
