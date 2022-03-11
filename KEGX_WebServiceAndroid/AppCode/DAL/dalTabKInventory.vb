'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKInventory
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:49 PM
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
	Public Class dalTabKInventory

		Private ConnectionString As String

        Public Shared Function CreateNewTabKInventory(ByVal objTabKInventory As PropertyTabKInventory) As Integer

            If objTabKInventory Is Nothing Then
                Throw New ArgumentNullException("objTabKInventory")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@LotDetails", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKInventory.LotDetails)
            db.AddParamToSQLCmd(sqlCmd, "@LotStatus", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKInventory.LotStatus)
            db.AddParamToSQLCmd(sqlCmd, "@Location", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKInventory.Location)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@DamagedQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.DamagedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransitQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.TransitQuantity)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKInventory")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKInventory(ByVal objTabKInventory As PropertyTabKInventory) As Boolean

            If objTabKInventory Is Nothing Then
                Throw New ArgumentNullException("objTabKInventory")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@LotID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.LotID)
            db.AddParamToSQLCmd(sqlCmd, "@LotDetails", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKInventory.LotDetails)
            db.AddParamToSQLCmd(sqlCmd, "@LotStatus", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKInventory.LotStatus)
            db.AddParamToSQLCmd(sqlCmd, "@Location", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKInventory.Location)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@DamagedQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.DamagedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransitQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKInventory.TransitQuantity)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKInventory")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabKInventory(ByVal LotID As Int32) As String

			If LotID<= 0 Then
				Throw New ArgumentOutOfRangeException("LotID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@LotID", SqlDbType.Int, 0, ParameterDirection.Input, LotID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKInventory")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabKInventoryByID(ByVal valLotID As Int32) As PropertyTabKInventory
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@LotID", valLotID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKInventoryByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKInventory As PropertyTabKInventory = New PropertyTabKInventory
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("LotID")) Then
                        objTabKInventory.LotID = dr.GetInt32(dr.GetOrdinal("LotID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("LotDetails")) Then
                        objTabKInventory.LotDetails = dr.GetString(dr.GetOrdinal("LotDetails"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("LotStatus")) Then
                        objTabKInventory.LotStatus = dr.GetString(dr.GetOrdinal("LotStatus"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Location")) Then
                        objTabKInventory.Location = dr.GetString(dr.GetOrdinal("Location"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKInventory.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabKInventory.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKInventory.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKInventory.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OnHandQuantity")) Then
                        objTabKInventory.OnHandQuantity = dr.GetInt32(dr.GetOrdinal("OnHandQuantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("DamagedQuantity")) Then
                        objTabKInventory.DamagedQuantity = dr.GetInt32(dr.GetOrdinal("DamagedQuantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TransitQuantity")) Then
                        objTabKInventory.TransitQuantity = dr.GetInt32(dr.GetOrdinal("TransitQuantity"))
                    End If
                End While
                dr.Close()
                Return objTabKInventory
            Else
                dr.Close()
                Return New PropertyTabKInventory
            End If
        End Function

		Public Shared Function GetALLTabKInventory(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKInventory")
			Return ds
		End Function

		Public Shared Function GetALLTabKInventoryDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKInventoryDrop")
			Return dr
		End Function

		Public Shared Function GetTabKInventoryByBranchID(ByVal valBranchID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@BranchID", valBranchID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKInventoryByBranchID")
			Return ds
		End Function

		Public Shared Function GetTabKInventoryByItemID(ByVal valItemID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@ItemID", valItemID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKInventoryByItemID")
			Return ds
		End Function

        Public Shared Function GetTabKInventoryByCompanyID(ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKInventoryByCompanyID")
            Return ds
        End Function
        Public Shared Function GetTabKInventoryByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKInventoryByEmployeeID")
            Return ds
        End Function
	End Class
End Namespace
