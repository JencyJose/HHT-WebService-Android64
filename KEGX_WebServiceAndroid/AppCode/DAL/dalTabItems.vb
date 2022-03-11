'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabItems
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:42 PM
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
	Public Class dalTabItems

		Private ConnectionString As String

        Public Shared Function CreateNewTabItems(ByVal objTabItems As PropertyTabItems) As Integer

            If objTabItems Is Nothing Then
                Throw New ArgumentNullException("objTabItems")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabItems.ItemCode)
            db.AddParamToSQLCmd(sqlCmd, "@ItemName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabItems.ItemName)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabItems.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabItems.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@UOM", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabItems.UOM)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabItems")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabItems(ByVal objTabItems As PropertyTabItems) As Boolean

            If objTabItems Is Nothing Then
                Throw New ArgumentNullException("objTabItems")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabItems.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabItems.ItemCode)
            db.AddParamToSQLCmd(sqlCmd, "@ItemName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabItems.ItemName)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabItems.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabItems.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@UOM", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabItems.UOM)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabItems")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabItems(ByVal ItemID As Int32) As String

			If ItemID<= 0 Then
				Throw New ArgumentOutOfRangeException("ItemID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, ItemID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabItems")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabItemsByID(ByVal valItemID As Int32) As PropertyTabItems
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@ItemID", valItemID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabItemsByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabItems As PropertyTabItems = New PropertyTabItems
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabItems.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemCode")) Then
                        objTabItems.ItemCode = dr.GetString(dr.GetOrdinal("ItemCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemName")) Then
                        objTabItems.ItemName = dr.GetString(dr.GetOrdinal("ItemName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabItems.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabItems.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOM")) Then
                        objTabItems.UOM = dr.GetString(dr.GetOrdinal("UOM"))
                    End If
                End While
                dr.Close()
                Return objTabItems
            Else
                dr.Close()
                Return New PropertyTabItems
            End If
        End Function

		Public Shared Function GetALLTabItems(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabItems")
			Return ds
		End Function

		Public Shared Function GetALLTabItemsDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabItemsDrop")
			Return dr
		End Function

        Public Shared Function GetTabItemsByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabItemsByCompanyID")
            Return ds
        End Function
        Public Shared Function GetTabItemsByEmployeeID(ByVal valEmployeeID As Int32, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_GetTABAllItemsByEmployeeID")
            Return ds
        End Function
        'HHT Methods
        Public Shared Function GetTabItemsByEmployeeIDHHT(ByVal valEmployeeID As Int32, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".TIT_GetTABAllItemsByEmployeeIDHHT")
            Return ds
        End Function
	End Class
End Namespace
