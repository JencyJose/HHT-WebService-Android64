'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :dalATSAssets
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :5/12/2008 3:00:27 PM
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
Imports TrackIT.ExceptionHandler
Imports [Property].TrackITKTS
Namespace TrackITKTS

    Public Class dalValidations
        Public Shared Function ValidateTable(ByVal objValidations As PropertyValidations, ByVal SchemaName As String) As Boolean
            Try
                Dim db As DBAccess = New DBAccess
                Dim sqlCmd As SqlCommand = New SqlCommand()
                db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
                db.AddParamToSQLCmd(sqlCmd, "@Name", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.Name)
                db.AddParamToSQLCmd(sqlCmd, "@NameVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.NameVal))
                db.AddParamToSQLCmd(sqlCmd, "@ID", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.ID)
                db.AddParamToSQLCmd(sqlCmd, "@IDVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.IDVal))
                db.AddParamToSQLCmd(sqlCmd, "@TableName", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.Table)
                db.AddParamToSQLCmd(sqlCmd, "@FName", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.FName)
                db.AddParamToSQLCmd(sqlCmd, "@FNameVal", SqlDbType.NVarChar, 5, ParameterDirection.Input, Trim(objValidations.FNameVal))
                db.AddParamToSQLCmd(sqlCmd, "@FName1", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.FName1)
                db.AddParamToSQLCmd(sqlCmd, "@FNameVal1", SqlDbType.NVarChar, 25, ParameterDirection.Input, Trim(objValidations.FNameVal1))
                db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DoValidation")
                db.ExecuteScalarCmd(sqlCmd)
                Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
                If returnValue > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
                dbErrorLogging.LogError(ex)
            End Try
        End Function
        Public Shared Function ValidateTableByUserName(ByVal objValidations As PropertyValidations, ByVal SchemaName As String) As Boolean
            Try
                Dim db As DBAccess = New DBAccess
                Dim sqlCmd As SqlCommand = New SqlCommand()
                db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
                db.AddParamToSQLCmd(sqlCmd, "@Name", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.Name)
                db.AddParamToSQLCmd(sqlCmd, "@NameVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.NameVal))
                db.AddParamToSQLCmd(sqlCmd, "@ID", SqlDbType.NVarChar, 100, ParameterDirection.Input, objValidations.ID)
                db.AddParamToSQLCmd(sqlCmd, "@IDVal", SqlDbType.NVarChar, 100, ParameterDirection.Input, Trim(objValidations.IDVal))
                db.AddParamToSQLCmd(sqlCmd, "@TableName", SqlDbType.NVarChar, 25, ParameterDirection.Input, objValidations.Table)
                db.SetCommandType(sqlCmd, CommandType.StoredProcedure, SchemaName + ".TIT_DoValidationByUserName")
                db.ExecuteScalarCmd(sqlCmd)
                Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
                If returnValue > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
                dbErrorLogging.LogError(ex)
            End Try
        End Function

        Public Shared Function GetLookupItems(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpItems")
            Return ds
        End Function

        Public Shared Function GetCustomerLookup(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpCustomers")
            Return ds
        End Function

        Public Shared Function GetSupplierLookup(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpSuppliers")
            Return ds
        End Function

        Public Shared Function GetBPLookup(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpBranchPlant")
            Return ds
        End Function

        Public Shared Function GetLookupIDs(ByVal CompanyID As Integer, ByVal strCode As String, ByVal strType As Char, ByVal schema As String) As Integer
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@strCode", strCode))
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@LType", strType))
            Return db.ExecuteScalar(schema + ".GetLookupIDs")
        End Function

        Public Shared Function GetBPLookupbyEmpID(ByVal searchText As String, ByVal EmployeeID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpBranchPlantByEmpID")
            Return ds
        End Function


        Public Shared Function GetLookupItemsByEmpID(ByVal searchText As String, ByVal EmployeeID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpItemsByEmpID")
            Return ds
        End Function


        Public Shared Function GetLookupIDsEmpID(ByVal EmployeeID As Integer, ByVal strCode As String, ByVal strType As Char, ByVal schema As String) As Integer
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@strCode", strCode))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@LType", strType))
            Return db.ExecuteScalar(schema + ".GetLookupIDsbyEmpID")
        End Function

        Public Shared Function GetCustomerLookupByEmpID(ByVal searchText As String, ByVal EmployeeID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpCustomersByEmpID")
            Return ds
        End Function

        Public Shared Function GetSupplierLookupByEmpID(ByVal searchText As String, ByVal EmployeeID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@searchText", searchText))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@ROWCNT", count))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetLookUpSuppliersByEmployeeID")
            Return ds
        End Function

        'Dashboard
        Public Shared Function GetCustomerDashBoard1(ByVal CompanyID As Integer, ByVal EmployeeID As Integer, ByVal Region As String, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@Region", Region))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".CustomerDashBoardMnth")
            Return ds
        End Function

        Public Shared Function GetTop10CustomerDashBoard(ByVal CompanyID As Integer, ByVal EmployeeID As Integer, ByVal Region As String, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@Region", Region))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".CustomerTop10DashBoard")
            Return ds
        End Function

        Public Shared Function GetSupplierDashBoardOrg(ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetSupplierDashBoardOrg")
            Return ds
        End Function

        Public Shared Function GetSupplierDashBoardOrgTop10(ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetSupplierDashBoardOrgTop10")
            Return ds
        End Function

        Public Shared Function GetBPEmptyKegsStockDashBoard(ByVal EmployeeID As Integer, ByVal BranchCode As String, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            db.Parameters.Add(New SqlParameter("@BranchCode", BranchCode))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".EmptiesInYardDashBoard")
            Return ds
        End Function

        Public Shared Function GetCustomerRegions(ByVal CompanyID As Integer, ByVal EmployeeID As Integer, ByVal schema As String) As DataSet
            Dim db As DBAccess = New DBAccess
            db.Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
            db.Parameters.Add(New SqlParameter("@EmployeeID", EmployeeID))
            Dim ds As DataSet = db.ExecuteDataSet(schema + ".GetCustomerRegions")
            Return ds
        End Function

        Public Shared Function validatedevicedate(ByVal DeviceDate As String) As Boolean

            Try

                Dim db As DBAccess = New DBAccess
                Dim sqlCmd As SqlCommand = New SqlCommand()
                db.AddParamToSQLCmd(sqlCmd, "@ReturnValue", SqlDbType.Int, 0, ParameterDirection.ReturnValue, Nothing)
                db.AddParamToSQLCmd(sqlCmd, "@DeviceDate", SqlDbType.NVarChar, 100, ParameterDirection.Input, DeviceDate)
                db.SetCommandType(sqlCmd, CommandType.StoredProcedure, "dbo.TIT_DeviceDateValidation")
                db.ExecuteScalarCmd(sqlCmd)
                Dim returnValue As Integer = CInt(sqlCmd.Parameters("@ReturnValue").Value)
                If returnValue > 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Return False
                dbErrorLogging.LogError(ex)
            End Try
        End Function

    End Class
End Namespace