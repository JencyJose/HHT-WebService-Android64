'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKSaleOrders
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:51 PM
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
	Public Class dalTabKSaleOrders

		Private ConnectionString As String

		Public Shared Function CreateNewTabKSaleOrders(ByVal objTabKSaleOrders As clsTabKSaleOrders) As Integer

			If objTabKSaleOrders Is Nothing Then
				Throw New ArgumentNullException("objTabKSaleOrders")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.BranchID)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.Quantity)
			db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKSaleOrders.Batch)
			db.AddParamToSQLCmd(sqlCmd, "@OrderType", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderType)
			db.AddParamToSQLCmd(sqlCmd, "@OrderNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderNumber)
			db.AddParamToSQLCmd(sqlCmd, "@OrderDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSaleOrders.OrderDate)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKSaleOrders")
			db.ExecuteScalarCmd(sqlCmd)
			Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
		End Function

		Public Shared Function UpdateTabKSaleOrders(ByVal objTabKSaleOrders As clsTabKSaleOrders) As Boolean

			If objTabKSaleOrders Is Nothing Then
				Throw New ArgumentNullException("objTabKSaleOrders")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As SqlCommand = New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.SOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@CustomerID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CustomerID)
			db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.CompanyID)
			db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.BranchID)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.Quantity)
			db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSaleOrders.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabKSaleOrders.Batch)
			db.AddParamToSQLCmd(sqlCmd, "@OrderType", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderType)
			db.AddParamToSQLCmd(sqlCmd, "@OrderNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSaleOrders.OrderNumber)
			db.AddParamToSQLCmd(sqlCmd, "@OrderDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSaleOrders.OrderDate)

			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKSaleOrders")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
			If returnValue = 0 Then
				Return True
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKSaleOrders(ByVal SOrderID As Int32) As String

			If SOrderID<= 0 Then
				Throw New ArgumentOutOfRangeException("SOrderID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@SOrderID", SqlDbType.Int, 0, ParameterDirection.Input, SOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKSaleOrders")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

		Public Shared Function GetTabKSaleOrdersByID(ByVal valSOrderID As Int32) As clsTabKSaleOrders
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@SOrderID", valSOrderID))
			Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKSaleOrdersByID"), SqlDataReader)

			If dr.HasRows Then
				Dim objTabKSaleOrders As clsTabKSaleOrders = New clsTabKSaleOrders
				While dr.Read
					If Not dr.IsDBNull(dr.GetOrdinal("SOrderID")) Then
						objTabKSaleOrders.SOrderID = dr.GetInt32(dr.GetOrdinal("SOrderID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("CustomerID")) Then
						objTabKSaleOrders.CustomerID = dr.GetInt32(dr.GetOrdinal("CustomerID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
						objTabKSaleOrders.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
						objTabKSaleOrders.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
						objTabKSaleOrders.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
						objTabKSaleOrders.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
						objTabKSaleOrders.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabKSaleOrders.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("OrderType")) Then
						objTabKSaleOrders.OrderType = dr.GetString(dr.GetOrdinal("OrderType"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("OrderNumber")) Then
						objTabKSaleOrders.OrderNumber = dr.GetString(dr.GetOrdinal("OrderNumber"))
					End If
					If Not dr.IsDBNull(dr.GetOrdinal("OrderDate")) Then
						objTabKSaleOrders.OrderDate = dr.GetDateTime(dr.GetOrdinal("OrderDate"))
					End If
				End While
				dr.Close()
				Return objTabKSaleOrders
			Else
				dr.Close()
				Return New clsTabKSaleOrders
			End If
		End Function

		Public Shared Function GetALLTabKSaleOrders(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrders")
			Return ds
		End Function

		Public Shared Function GetALLTabKSaleOrdersDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKSaleOrdersDrop")
			Return dr
		End Function

		Public Shared Function GetTabKSaleOrdersByCustomerID(ByVal valCustomerID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@CustomerID", valCustomerID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrdersByCustomerID")
			Return ds
        End Function
        Public Shared Function GetAllTabKSaleOrdersByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKSaleOrdersByCompanyID")
            Return ds
        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeID(ByVal valEmployeeID As Int32) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSaleOrdersByEmployeeID")
            Return ds
        End Function
	End Class
End Namespace
