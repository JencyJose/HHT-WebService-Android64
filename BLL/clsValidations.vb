'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsATSAssets
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :5/12/2008 3:00:27 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS

Namespace TrackITKTS
    Public Class clsValidations

        Public Shared Function ValidateTable(ByVal objValidation As PropertyValidations, ByVal SchemaName As String) As Boolean

            Return dalValidations.ValidateTable(objValidation, SchemaName)

        End Function
        Public Shared Function ValidateTableByUserName(ByVal objValidation As PropertyValidations, ByVal SchemaName As String) As Boolean

            Return dalValidations.ValidateTableByUserName(objValidation, SchemaName)

        End Function

        Public Shared Function GetLookupItems(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Return dalValidations.GetLookupItems(searchText, CompanyID, schema, count)
        End Function

        Public Shared Function GetCustomerLookup(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Return dalValidations.GetCustomerLookup(searchText, CompanyID, schema, count)
        End Function

        Public Shared Function GetSupplierLookup(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Return dalValidations.GetSupplierLookup(searchText, CompanyID, schema, count)
        End Function

        Public Shared Function GetBPLookup(ByVal searchText As String, ByVal CompanyID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Return dalValidations.GetBPLookup(searchText, CompanyID, schema, count)
        End Function

        Private Shared Function GetLookupIDs(ByVal CompanyID As Integer, ByVal strCode As String, ByVal strType As Char, ByVal schema As String) As Integer
            Return dalValidations.GetLookupIDs(CompanyID, strCode, strType, schema)
        End Function

        Public Shared Function GetLookUpIDByCode(ByVal CompanyID As Integer, ByVal strCodeCSB As String, ByVal strType As Char, ByVal schema As String) As Integer

            Dim intID As Integer = -1
            Dim strCode As String = ""

            If strCodeCSB.IndexOf(" -") < 1 Then
                Return -1
            End If
            strCode = Left(strCodeCSB, strCodeCSB.IndexOf(" -"))

            Return clsValidations.GetLookupIDs(CompanyID, strCode, strType, schema)
        End Function

        Public Shared Function GetBPLookupbyEmpID(ByVal searchText As String, ByVal EmployeeID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Return dalValidations.GetBPLookupbyEmpID(searchText, EmployeeID, schema, count)
        End Function


        Public Shared Function GetLookupItemsByEmpID(ByVal searchText As String, ByVal EmployeeID As Integer, ByVal schema As String, ByVal count As Integer) As DataSet
            Return dalValidations.GetLookupItemsByEmpID(searchText, EmployeeID, schema, count)
        End Function


        Public Shared Function GetLookupIDsbyEmpID(ByVal EmployeeID As Integer, ByVal strCode As String, ByVal strType As Char, ByVal schema As String) As Integer
            Return dalValidations.GetLookupIDsEmpID(EmployeeID, strCode, strType, schema)
        End Function

        Public Shared Function GetLookUpIDByEmployeeCode(ByVal strCodeCSB As String) As String

            Dim intID As Integer = -1
            Dim strCode As String = ""

            If strCodeCSB.IndexOf(" -") < 1 Then
                Return -1
            End If
            strCode = Left(strCodeCSB, strCodeCSB.IndexOf(" -"))

            Return strCode
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
            Return dalValidations.GetSupplierLookupByEmpID(searchText, EmployeeID, schema, count)
        End Function

        'Dashboard
        Public Shared Function GetCustomerDashBoard1(ByVal CompanyID As Integer, ByVal EmployeeID As Integer, ByVal Region As String, ByVal schema As String) As DataSet
            If CompanyID < 1 Or EmployeeID < 1 Or schema = "" Then
                Return Nothing
            End If

            Return dalValidations.GetCustomerDashBoard1(CompanyID, EmployeeID, Region, schema)
        End Function

        Public Shared Function GetTop10CustomerDashBoard(ByVal CompanyID As Integer, ByVal EmployeeID As Integer, ByVal Region As String, ByVal schema As String) As DataSet
            If CompanyID < 1 Or EmployeeID < 1 Or schema = "" Then
                Return Nothing
            End If

            Return dalValidations.GetTop10CustomerDashBoard(CompanyID, EmployeeID, Region, schema)
        End Function

        Public Shared Function GetSupplierDashBoardOrg(ByVal schema As String) As DataSet
            If schema = "" Then
                Return Nothing
            End If

            Return dalValidations.GetSupplierDashBoardOrg(schema)
        End Function

        Public Shared Function GetSupplierDashBoardOrgTop10(ByVal schema As String) As DataSet
            If schema = "" Then
                Return Nothing
            End If

            Return dalValidations.GetSupplierDashBoardOrgTop10(schema)
        End Function

        Public Shared Function GetBPEmptyKegsStockDashBoard(ByVal EmployeeID As Integer, ByVal BranchCode As String, ByVal schema As String) As DataSet
            If BranchCode.Length < 1 Or EmployeeID < 1 Or schema = "" Then
                Return Nothing
            End If

            Return dalValidations.GetBPEmptyKegsStockDashBoard(EmployeeID, BranchCode, schema)
        End Function

        Public Shared Function GetCustomerRegions(ByVal CompanyID As Integer, ByVal EmployeeID As Integer, ByVal schema As String) As DataSet
            If CompanyID < 0 Or EmployeeID < 1 Or schema = "" Then
                Return Nothing
            End If

            Return dalValidations.GetCustomerRegions(CompanyID, EmployeeID, schema)
        End Function

        Public Shared Function ValidateDeviceDate(ByVal deviceDate As String) As Boolean
            Return dalValidations.validatedevicedate(deviceDate)
        End Function

    End Class
End Namespace