'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalTabMBranchPlant
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:53 PM
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
	Public Class dalTabMBranchPlant

		Private ConnectionString As String

        Public Shared Function CreateNewTabMBranchPlant(ByVal objTabMBranchPlant As PropertyTabMBranchPlant) As Integer

            If objTabMBranchPlant Is Nothing Then
                Throw New ArgumentNullException("objTabMBranchPlant")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@BranchCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMBranchPlant.BranchCode)
            db.AddParamToSQLCmd(sqlCmd, "@BranchName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMBranchPlant.BranchName)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabMBranchPlant.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMBranchPlant.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@Address3", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address3)
            db.AddParamToSQLCmd(sqlCmd, "@Address4", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address4)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_CreateNewTabMBranchPlant")
            db.ExecuteScalarCmd(sqlCmd)
            Return CInt(sqlCmd.Parameters("@ReturnValue").Value)
        End Function

        Public Shared Function UpdateTabMBranchPlant(ByVal objTabMBranchPlant As PropertyTabMBranchPlant) As Boolean

            If objTabMBranchPlant Is Nothing Then
                Throw New ArgumentNullException("objTabMBranchPlant")
            End If

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMBranchPlant.BranchID)
            db.AddParamToSQLCmd(sqlCmd, "@BranchCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, objTabMBranchPlant.BranchCode)
            db.AddParamToSQLCmd(sqlCmd, "@BranchName", SqlDbType.NVarChar, 100, ParameterDirection.Input, objTabMBranchPlant.BranchName)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, objTabMBranchPlant.Batch)
            db.AddParamToSQLCmd(sqlCmd, "@CompanyID", SqlDbType.Int, 0, ParameterDirection.Input, objTabMBranchPlant.CompanyID)
            db.AddParamToSQLCmd(sqlCmd, "@Address1", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address1)
            db.AddParamToSQLCmd(sqlCmd, "@Address2", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address2)
            db.AddParamToSQLCmd(sqlCmd, "@Address3", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address3)
            db.AddParamToSQLCmd(sqlCmd, "@Address4", SqlDbType.NVarChar, 250, ParameterDirection.Input, objTabMBranchPlant.Address4)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_UpdateTabMBranchPlant")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Shared Function UpdateTabMBranchPlant_Batch(ByVal BranchPlantID As Int32, ByVal Batch As Boolean, ByVal SchemaName As String) As Boolean

            Dim db As DBAccess = New DBAccess
            Dim sqlCmd As SqlCommand = New SqlCommand()
            db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
            db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, BranchPlantID)
            db.AddParamToSQLCmd(sqlCmd, "@Batch", SqlDbType.Bit, 0, ParameterDirection.Input, Batch)

            db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_UpdateTabMBranchPlant_Batch")
            db.ExecuteScalarCmd(sqlCmd)
            Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
            If returnValue = 0 Then
                Return True
            Else
                Return False
            End If
        End Function
		Public Shared Function DeleteTabMBranchPlant(ByVal BranchID As Int32) As String

			If BranchID<= 0 Then
				Throw New ArgumentOutOfRangeException("BranchID")
			End If

			Dim db As DBAccess = New DBAccess
			Dim sqlCmd As New SqlCommand()
			db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.VarChar, 200, ParameterDirection.ReturnValue, Nothing)
			db.AddParamToSQLCmd(sqlCmd, "@BranchID", SqlDbType.Int, 0, ParameterDirection.Input, BranchID)
			db.AddParamToSQLCmd(sqlCmd, "@errMessage", SqlDbType.VarChar, 3, ParameterDirection.Output, Nothing)
			db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "TIT_DeleteTabMBranchPlant")
			db.ExecuteScalarCmd(sqlCmd)
			Dim returnValue As String = sqlCmd.Parameters("@errMessage").Value
			If Not String.IsNullOrEmpty(returnValue) Then
				Return returnValue
			Else
				Return ""
			End If
		End Function

        Public Shared Function GetTabMBranchPlantByID(ByVal valBranchID As Int32) As PropertyTabMBranchPlant
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@BranchID", valBranchID))
            Dim dr As SqlDataReader = CType(db.ExecuteReader("TIT_GetTabMBranchPlantByID"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMBranchPlant As PropertyTabMBranchPlant = New PropertyTabMBranchPlant
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabMBranchPlant.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchCode")) Then
                        objTabMBranchPlant.BranchCode = dr.GetString(dr.GetOrdinal("BranchCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchName")) Then
                        objTabMBranchPlant.BranchName = dr.GetString(dr.GetOrdinal("BranchName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabMBranchPlant.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMBranchPlant.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMBranchPlant.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMBranchPlant.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address3")) Then
                        objTabMBranchPlant.Address3 = dr.GetString(dr.GetOrdinal("Address3"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address4")) Then
                        objTabMBranchPlant.Address4 = dr.GetString(dr.GetOrdinal("Address4"))
                    End If
                End While
                dr.Close()
                Return objTabMBranchPlant
            Else
                dr.Close()
                Return New PropertyTabMBranchPlant
            End If
        End Function

		Public Shared Function GetALLTabMBranchPlant(ByVal valUserName As String) As DataSet
			Dim db As DBAccess = New DBAccess
			db.Parameters.Add(New SqlParameter("@USERNAME", valUserName))
			Dim ds As DataSet = db.ExecuteDataSet("TIT_GetAllTabMBranchPlant")
			Return ds
		End Function

		Public Shared Function GetALLTabMBranchPlantDrop() As SqlDataReader
			Dim db As DBAccess = New DBAccess
			Dim dr As SqlDataReader = db.ExecuteReader("TIT_GetAllTabMBranchPlantDrop")
			Return dr
		End Function

        Public Shared Function GetTabMBranchPlantByCompanyID(ByVal valCompanyID As Int32, ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMBranchPlantByCompanyID")
            Return ds
        End Function

        Public Shared Function GetTabMBranchPlantByBranchCode(ByVal valCompanyID As Int32, ByVal valBranchCode As String, ByVal SchemaName As String) As PropertyTabMBranchPlant
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", valCompanyID))
            db.Parameters.Add(New SqlParameter("@BranchCode", valBranchCode))
            Dim dr As SqlDataReader = CType(db.ExecuteReader(SchemaName + ".TIT_GetTabMBranchPlantByBranchCode"), SqlDataReader)

            If dr.HasRows Then
                Dim objTabMBranchPlant As PropertyTabMBranchPlant = New PropertyTabMBranchPlant
                While dr.Read
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchID")) Then
                        objTabMBranchPlant.BranchID = dr.GetInt32(dr.GetOrdinal("BranchID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchCode")) Then
                        objTabMBranchPlant.BranchCode = dr.GetString(dr.GetOrdinal("BranchCode"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("BranchName")) Then
                        objTabMBranchPlant.BranchName = dr.GetString(dr.GetOrdinal("BranchName"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Batch")) Then
                        objTabMBranchPlant.Batch = dr.GetBoolean(dr.GetOrdinal("Batch"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("CompanyID")) Then
                        objTabMBranchPlant.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address1")) Then
                        objTabMBranchPlant.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address2")) Then
                        objTabMBranchPlant.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address3")) Then
                        objTabMBranchPlant.Address3 = dr.GetString(dr.GetOrdinal("Address3"))
                    End If
                    If Not dr.IsDBNull(dr.GetOrdinal("Address4")) Then
                        objTabMBranchPlant.Address4 = dr.GetString(dr.GetOrdinal("Address4"))
                    End If
                End While
                dr.Close()
                Return objTabMBranchPlant
            Else
                dr.Close()
                Return New PropertyTabMBranchPlant
            End If

        End Function

        Public Shared Function GetTabMBranchPlantByEmployeeID(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", valEmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(SchemaName + ".TIT_GetAllTabMBranchPlantByEmployeeID")
            Return ds
        End Function


	End Class
End Namespace
