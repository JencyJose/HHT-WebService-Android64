'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabKBPTransferBP
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:43 PM
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
	Public Class dalTabKBPTransferBP

		Private ConnectionString As String

        Public Shared Function CreateNewTabKBPTransferBP(ByVal objTabKBPTransferBP As PropertyTabKBPTransferBP) As Integer

            If objTabKBPTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKBPTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@LotDetails", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKBPTransferBP.LotDetails)
            db.AddParamToSQLCmd(sqlCmd, "@LotStatus", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKBPTransferBP.LotStatus)
            db.AddParamToSQLCmd(sqlCmd, "@Location", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKBPTransferBP.Location)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@DamagedQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.DamagedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransitQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.TransitQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@ReceivedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKBPTransferBP.ReceivedDate)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabKBPTransferBP")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabKBPTransferBP(ByVal objTabKBPTransferBP As PropertyTabKBPTransferBP) As Boolean

            If objTabKBPTransferBP Is Nothing Then
                Throw New ArgumentNullException("objTabKBPTransferBP")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@TOrderID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.TOrderID)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@ItemID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.ItemID)
            db.AddParamToSQLCmd(sqlCmd, "@FromBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.FromBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@ToBranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.ToBranchID)
            db.AddParamToSQLCmd(sqlCmd, "@LotDetails", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKBPTransferBP.LotDetails)
            db.AddParamToSQLCmd(sqlCmd, "@LotStatus", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKBPTransferBP.LotStatus)
            db.AddParamToSQLCmd(sqlCmd, "@Location", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabKBPTransferBP.Location)
            db.AddParamToSQLCmd(sqlCmd, "@UOMID", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.UOMID)
            db.AddParamToSQLCmd(sqlCmd, "@OnHandQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.OnHandQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@DamagedQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.DamagedQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@TransitQuantity", SqlDbType.Int, 0, ParameterDirection.Input, objTabKBPTransferBP.TransitQuantity)
            db.AddParamToSQLCmd(sqlCmd, "@ReceivedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, objTabKBPTransferBP.ReceivedDate)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabKBPTransferBP")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabKBPTransferBP(ByVal TOrderID As Int32) As String

			If TOrderID<= 0 Then
				Throw New ArgumentOutOfRangeException("TOrderID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@TOrderID", SqlDbType.Int, 0, ParameterDirection.Input, TOrderID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabKBPTransferBP")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabKBPTransferBPByID(ByVal valTOrderID As Int32) As PropertyTabKBPTransferBP
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@TOrderID", valTOrderID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabKBPTransferBPByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabKBPTransferBP As PropertyTabKBPTransferBP = New PropertyTabKBPTransferBP
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("TOrderID")) Then
                        objTabKBPTransferBP.TOrderID = dr.GetInt32(dr.GetOrdinal("TOrderID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabKBPTransferBP.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ItemID")) Then
                        objTabKBPTransferBP.ItemID = dr.GetInt32(dr.GetOrdinal("ItemID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("FromBranchID")) Then
                        objTabKBPTransferBP.FromBranchID = dr.GetInt32(dr.GetOrdinal("FromBranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ToBranchID")) Then
                        objTabKBPTransferBP.ToBranchID = dr.GetInt32(dr.GetOrdinal("ToBranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("LotDetails")) Then
                        objTabKBPTransferBP.LotDetails = dr.GetString(dr.GetOrdinal("LotDetails"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("LotStatus")) Then
                        objTabKBPTransferBP.LotStatus = dr.GetString(dr.GetOrdinal("LotStatus"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Location")) Then
                        objTabKBPTransferBP.Location = dr.GetString(dr.GetOrdinal("Location"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("UOMID")) Then
                        objTabKBPTransferBP.UOMID = dr.GetInt32(dr.GetOrdinal("UOMID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("OnHandQuantity")) Then
                        objTabKBPTransferBP.OnHandQuantity = dr.GetInt32(dr.GetOrdinal("OnHandQuantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("DamagedQuantity")) Then
                        objTabKBPTransferBP.DamagedQuantity = dr.GetInt32(dr.GetOrdinal("DamagedQuantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("TransitQuantity")) Then
                        objTabKBPTransferBP.TransitQuantity = dr.GetInt32(dr.GetOrdinal("TransitQuantity"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("ReceivedDate")) Then
                        objTabKBPTransferBP.ReceivedDate = dr.GetDateTime(dr.GetOrdinal("ReceivedDate"))
                    End If
                End While
                dr.Close()
                Return objTabKBPTransferBP
            Else
                dr.Close()
                Return New PropertyTabKBPTransferBP
            End If
        End Function

		Public Shared Function GetALLTabKBPTransferBP(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKBPTransferBP")
			Return ds
		End Function

		Public Shared Function GetALLTabKBPTransferBPDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabKBPTransferBPDrop")
			Return dr
		End Function

		Public Shared Function GetTabKBPTransferBPByFromBranchID(ByVal valFromBranchID As Int32) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@FromBranchID", valFromBranchID))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabKBPTransferBPByFromBranchID")
			Return ds
		End Function
        Public Shared Function GetAllTabKBPTransferBPByCompanyID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabKBPTransferBPByCompanyID")
            Return ds
        End Function
	End Class
End Namespace
