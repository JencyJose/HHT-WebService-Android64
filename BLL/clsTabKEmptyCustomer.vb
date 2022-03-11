'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyCustomer
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:44 PM
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

    Public Class clsTabKEmptyCustomer

        Public Shared Function Save(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As Boolean
            If Not objTabKEmptyCustomer Is Nothing Then
                If objTabKEmptyCustomer.EOrderID <= 0 Then
                    Dim TempId As Integer = dalTabKEmptyCustomer.CreateNewTabKEmptyCustomer(objTabKEmptyCustomer, SchemaName)
                    If TempId > 0 Then
                        objTabKEmptyCustomer.EOrderID = TempId
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

        Public Shared Function SaveCR(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As String
            If Not objTabKEmptyCustomer Is Nothing Then
                If objTabKEmptyCustomer.EOrderID <= 0 Then
                    Dim TempId As String = dalTabKEmptyCustomer.CreateNewTabKEmptyCustomerCR(objTabKEmptyCustomer, SchemaName)
                    If Not TempId Is Nothing Then
                        objTabKEmptyCustomer.TransactionNumber = TempId
                        Return TempId
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function UpdateTabKEmptyCustomer(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean
            If Not objTabKEmptyCustomer Is Nothing Then
                Return dalTabKEmptyCustomer.UpdateTabKEmptyCustomer(objTabKEmptyCustomer, SchemaName, PrevQty)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKEmptyCustomer(ByVal EOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String
            Return dalTabKEmptyCustomer.DeleteTabKEmptyCustomer(EOrderID, TransactionNumber, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyCustomer(ByVal valUserName As String) As DataSet
            Return dalTabKEmptyCustomer.GetALLTabKEmptyCustomer(valUserName)
        End Function

        Public Shared Function GetAllTabKEmptyCustomerDrop() As SqlDataReader
            Return dalTabKEmptyCustomer.GetALLTabKEmptyCustomerDrop()
        End Function

        Public Shared Function GetTabKEmptyCustomerByID(ByVal EOrderID As Int32, ByVal SchemaName As String) As PropertyTabKEmptyCustomer
            If EOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetTabKEmptyCustomerByID(EOrderID, SchemaName)
        End Function

        Public Shared Function GetTabKEmptyCustomerByCustomerID(ByVal CustomerID As Int32) As DataSet
            If CustomerID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetTabKEmptyCustomerByCustomerID(CustomerID)
        End Function
        Public Shared Function GetAllTabKEmptyCustomerByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetAllTabKEmptyCustomerByCompanyID(CompanyID, SchemaName, TransactionNumber)
        End Function
        Public Shared Function UpdateEmptyKegsQuantity(ByVal CompanyID As Int32, ByVal FromEntityID As Int32, ByVal FromEntityType As Int32, ByVal ToEntityID As Int32, ByVal ToEntityType As Int32, ByVal Quantity As Int32, ByVal ItemID As Int32, ByVal UOMID As Int32, ByVal IntransitQty As Int32, ByVal SchemaName As String) As Boolean

            Dim TempId As Integer = dalTabKEmptyCustomer.UpdateEmptyKegsQuantity(CompanyID, FromEntityID, FromEntityType, ToEntityID, ToEntityType, Quantity, ItemID, UOMID, IntransitQty, SchemaName)
            If TempId > 0 Then
                Return True
            Else
                Return False
            End If

        End Function
        Public Shared Function GetMaxTransactionNumber(ByVal SchemaName As String, ByVal type As Int32, ByVal CompanyID As Int32) As DataSet
            Return dalTabKEmptyCustomer.GetMaxTransactionNumber(SchemaName, type, CompanyID)
        End Function

        Public Shared Function SaveHHT(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As String
            If Not objTabKEmptyCustomer Is Nothing Then
                If objTabKEmptyCustomer.EOrderID <= 0 Then
                    Dim TempId As String = dalTabKEmptyCustomer.CreateNewTabKEmptyCustomerHHT(objTabKEmptyCustomer, SchemaName)
                    If Not TempId Is Nothing Then
                        objTabKEmptyCustomer.TransactionNumber = TempId
                        Return TempId
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function
        Public Shared Function validateCustomerOpeningBalance(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal schemaname As String) As Integer
            If Not objTabKEmptyCustomer Is Nothing Then
                Return dalTabKEmptyCustomer.validateCustomerOpeningBalance(objTabKEmptyCustomer, schemaname)
            Else
                Return 0
            End If

        End Function
        Public Shared Function GetAllTabKEmptyCustomerByCompanyID_Search(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetAllTabKEmptyCustomerByCompanyID_Search(valCompanyID, EmployeeID, SchemaName, TransactionNumber, ItemCode)
        End Function
        Public Shared Function ItemBarcodeValidation(ByVal valItemID As Int32, ByVal valFromCompanyID As Int32, ByVal valBarcode As String, ByVal SchemaName As String) As Integer
            Return dalTabKEmptyCustomer.ItemBarcodeValidation(valItemID, valFromCompanyID, valBarcode, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyCustomerApprovalHHT(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal ItemCode As String, ByVal TransactionNumber As String, ByVal ApprovalStatus As Int32) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetAllTabKEmptyCustomerApprovalHHT(valCompanyID, EmployeeID, SchemaName, ItemCode, TransactionNumber, ApprovalStatus)
        End Function
        Public Shared Function GetAllTabKEmptyCustomerApprovalCRHHT(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal ItemCode As String, ByVal AprovalStatus As Integer) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetAllTabKEmptyCustomerApprovalCRHHT(valCompanyID, EmployeeID, SchemaName, ItemCode, AprovalStatus)
        End Function

        Public Shared Function UpdateTabKEmptyKegCustomerReturnsHHT(ByVal TransactionNum As String, ByVal FromCompanyID As Int32, ByVal ToCompanyID As Int32, ByVal FromItemID As Int32, ByVal ToItemID As Int32, ByVal ApprovedQuantity As Int32, ByVal UserComments As String, ByVal SchemaName As String) As Boolean

            Dim TempId As Integer = dalTabKEmptyCustomer.UpdateTabKEmptyKegCustomerReturnsHHT(TransactionNum, FromCompanyID, ToCompanyID, FromItemID, ToItemID, ApprovedQuantity, UserComments, SchemaName)
            If TempId > 0 Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Shared Function GetAllUsers(ByVal SchemaName As String) As DataSet
            Return dalTabKEmptyCustomer.GetAllUsers(SchemaName)
        End Function
        Public Shared Function SaveApprovalHHT(ByVal objTabKEmptyCustomer As PropertyTabKEmptyCustomer, ByVal SchemaName As String) As String
            If Not objTabKEmptyCustomer Is Nothing Then
                If objTabKEmptyCustomer.EOrderID <= 0 Then
                    Dim TempId As String = dalTabKEmptyCustomer.CreateNewTabKEmptyCustomerApprovalHHT(objTabKEmptyCustomer, SchemaName)
                    If Not TempId Is Nothing Then
                        objTabKEmptyCustomer.TransactionNumber = TempId
                        Return TempId
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function GetTabKCustomerDumpApprovedQty(ByVal SchemaName As String, ByVal FromDate As Date, ByVal ItemCodes As String, ByVal EmployeeID As Int32) As DataSet

            Return dalTabKEmptyCustomer.GetTabKCustomerDumpApprovedQty(SchemaName, FromDate, ItemCodes, EmployeeID)
        End Function
    End Class

End Namespace
