'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKEmptyCustToSupp
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:45 PM
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
	Public Class dalTabKEmptyCustToSupp

		Private ConnectionString As String

		Public Shared Function CreateNewTabKEmptyCustToSupp(ByVal objTabKEmptyCustToSupp As clsTabKEmptyCustToSupp) As Integer

			If objTabKEmptyCustToSupp Is Nothing Then
				Throw New ArgumentNullException("objTabKEmptyCustToSupp")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.SupplierID)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.Quantity)
			db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.Batch)
			db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustToSupp.Barcode)
			db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.TransferDate)
			db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.TransferBy)
			db.AddParamToSQLCmd(sqlCmd, "@DocumentNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustToSupp.DocumentNumber)
            db.AddParamToSQLCmd(sqlCmd, "@ShippingLine", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustToSupp.ShippingLine)
            db.AddParamToSQLCmd(sqlCmd, "@SerialNo", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustToSupp.SerialNo)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKEmptyCustToSupp")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function UpdateTabKEmptyCustToSupp(ByVal objTabKEmptyCustToSupp As clsTabKEmptyCustToSupp) As Boolean

			If objTabKEmptyCustToSupp Is Nothing Then
				Throw New ArgumentNullException("objTabKEmptyCustToSupp")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@ECSOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.ECSOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.SupplierID)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.BranchID)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.Quantity)
			db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.Batch)
			db.AddParamToSQLCmd(sqlCmd, "@Barcode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabKEmptyCustToSupp.Barcode)
			db.AddParamToSQLCmd(sqlCmd, "@TransferDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.TransferDate)
			db.AddParamToSQLCmd(sqlCmd, "@TransferBy", SqlDbType.Int, 0, ParameterDirection.Input, objTabKEmptyCustToSupp.TransferBy)
			db.AddParamToSQLCmd(sqlCmd, "@DocumentNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustToSupp.DocumentNumber)
			db.AddParamToSQLCmd(sqlCmd, "@ShippingLine", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKEmptyCustToSupp.ShippingLine)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKEmptyCustToSupp")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKEmptyCustToSupp(ByVal ECSOrderID As Int32) As String

			If ECSOrderID<= 0 Then
				Throw New ArgumentOutOfRangeException("ECSOrderID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@ECSOrderID", SqlDbType.Int, 0, ParameterDirection.Input, ECSOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKEmptyCustToSupp")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

		Public Shared Function GetTabKEmptyCustToSuppByID(ByVal valECSOrderID As Int32) As clsTabKEmptyCustToSupp
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@ECSOrderID", valECSOrderID))
			Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKEmptyCustToSuppByID"), SqlDataReader)

			If dr.HasRows Then
				Dim objTabKEmptyCustToSupp As clsTabKEmptyCustToSupp = New clsTabKEmptyCustToSupp
				While dr.Read
					If Not dr.IsDBNull(dr.GetOrdinal("ECSOrderID")) Then
						objTabKEmptyCustToSupp.ECSOrderID = dr.GetInt32(dr.GetOrdinal("ECSOrderID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
						objTabKEmptyCustToSupp.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("SupplierID")) Then
						objTabKEmptyCustToSupp.SupplierID = dr.GetInt32(dr.GetOrdinal("SupplierID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
						objTabKEmptyCustToSupp.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
						objTabKEmptyCustToSupp.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
						objTabKEmptyCustToSupp.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
						objTabKEmptyCustToSupp.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
						objTabKEmptyCustToSupp.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKEmptyCustToSupp.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Barcode")) Then
						objTabKEmptyCustToSupp.Barcode = dr.GetString(dr.GetOrdinal("Barcode"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("TransferDate")) Then
						objTabKEmptyCustToSupp.TransferDate = dr.GetDateTime(dr.GetOrdinal("TransferDate"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("TransferBy")) Then
						objTabKEmptyCustToSupp.TransferBy = dr.GetInt32(dr.GetOrdinal("TransferBy"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("DocumentNumber")) Then
						objTabKEmptyCustToSupp.DocumentNumber = dr.GetString(dr.GetOrdinal("DocumentNumber"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ShippingLine")) Then
						objTabKEmptyCustToSupp.ShippingLine = dr.GetString(dr.GetOrdinal("ShippingLine"))
					End If
				End While
				dr.Close()
				Return objTabKEmptyCustToSupp
			Else
				dr.Close()
				Return New clsTabKEmptyCustToSupp
			End If
		End Function

		Public Shared Function GetALLTabKEmptyCustToSupp(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustToSupp")
			Return ds
		End Function

		Public Shared Function GetALLTabKEmptyCustToSuppDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKEmptyCustToSuppDrop")
			Return dr
		End Function

		Public Shared Function GetTabKEmptyCustToSuppByCustomerID(ByVal valCustomerID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@CustomerID", valCustomerID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustToSuppByCustomerID")
			Return ds
		End Function

		Public Shared Function GetTabKEmptyCustToSuppBySupplierID(ByVal valSupplierID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@SupplierID", valSupplierID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustToSuppBySupplierID")
			Return ds
        End Function

        Public Shared Function GetAllTabKEmptyCustToSuppByCompanyID(ByVal valCompanyID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKEmptyCustToSuppByCompanyID")
            Return ds
        End Function
	End Class
End Namespace
