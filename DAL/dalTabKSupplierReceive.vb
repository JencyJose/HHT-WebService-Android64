'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKSupplierReceive
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:52 PM
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
	Public Class dalTabKSupplierReceive

		Private ConnectionString As String

        Public Shared Function CreateNewTabKSupplierReceive(ByVal objTabKSupplierReceive As PropertyTabKSupplierReceive) As Integer

            If objTabKSupplierReceive Is Nothing Then
                Throw New ArgumentNullException("objTabKSupplierReceive")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@ReceivedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSupplierReceive.ReceivedDate)
            db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSupplierReceive.ContainerNumber)
            db.AddParamToSQLCmd(sqlCmd, "@BOLNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSupplierReceive.BOLNumber)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKSupplierReceive")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKSupplierReceive(ByVal objTabKSupplierReceive As PropertyTabKSupplierReceive) As Boolean

            If objTabKSupplierReceive Is Nothing Then
                Throw New ArgumentNullException("objTabKSupplierReceive")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@OrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.OrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@SupplierID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.SupplierID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@Quantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.Quantity)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKSupplierReceive.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@ReceivedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKSupplierReceive.ReceivedDate)
            db.AddParamToSQLCmd(sqlCmd, "@ContainerNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSupplierReceive.ContainerNumber)
            db.AddParamToSQLCmd(sqlCmd, "@BOLNumber", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKSupplierReceive.BOLNumber)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKSupplierReceive")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabKSupplierReceive(ByVal OrderID As Int32) As String

			If OrderID<= 0 Then
				Throw New ArgumentOutOfRangeException("OrderID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@OrderID", SqlDbType.Int, 0, ParameterDirection.Input, OrderID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKSupplierReceive")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabKSupplierReceiveByID(ByVal valOrderID As Int32) As PropertyTabKSupplierReceive
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@OrderID", valOrderID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKSupplierReceiveByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKSupplierReceive As PropertyTabKSupplierReceive = New PropertyTabKSupplierReceive
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("OrderID")) Then
                        objTabKSupplierReceive.OrderID = dr.GetInt32(dr.GetOrdinal("OrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKSupplierReceive.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("SupplierID")) Then
                        objTabKSupplierReceive.SupplierID = dr.GetInt32(dr.GetOrdinal("SupplierID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKSupplierReceive.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabKSupplierReceive.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Quantity")) Then
                        objTabKSupplierReceive.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKSupplierReceive.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceivedDate")) Then
                        objTabKSupplierReceive.ReceivedDate = dr.GetDateTime(dr.GetOrdinal("ReceivedDate"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ContainerNumber")) Then
                        objTabKSupplierReceive.ContainerNumber = dr.GetString(dr.GetOrdinal("ContainerNumber"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BOLNumber")) Then
                        objTabKSupplierReceive.BOLNumber = dr.GetString(dr.GetOrdinal("BOLNumber"))
                    End If
                End While
                dr.Close()
                Return objTabKSupplierReceive
            Else
                dr.Close()
                Return New PropertyTabKSupplierReceive
            End If
        End Function

		Public Shared Function GetALLTabKSupplierReceive(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSupplierReceive")
			Return ds
		End Function

		Public Shared Function GetALLTabKSupplierReceiveDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKSupplierReceiveDrop")
			Return dr
		End Function

		Public Shared Function GetTabKSupplierReceiveBySupplierID(ByVal valSupplierID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@SupplierID", valSupplierID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKSupplierReceiveBySupplierID")
			Return ds
		End Function
        Public Shared Function GetTabKSupplierReceiveByCompanyID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKSupplierReceiveByCompanyID")
            Return ds
        End Function
	End Class
End Namespace
