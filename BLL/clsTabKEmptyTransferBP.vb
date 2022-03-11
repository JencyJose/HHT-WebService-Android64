'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyTransferBP
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:48 PM
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

    Public Class clsTabKEmptyTransferBP

        Public Shared Function Save(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String) As Boolean
            If Not objTabKEmptyTransferBP Is Nothing Then
                If objTabKEmptyTransferBP.EBPOrderID <= 0 Then
                    Dim TempId As Integer = dalTabKEmptyTransferBP.CreateNewTabKEmptyTransferBP(objTabKEmptyTransferBP, SchemaName)
                    If TempId > 0 Then
                        objTabKEmptyTransferBP.EBPOrderID = TempId
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

        Public Shared Function UpdateTabKEmptyTransferBP(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean
            If Not objTabKEmptyTransferBP Is Nothing Then
                Return dalTabKEmptyTransferBP.UpdateTabKEmptyTransferBP(objTabKEmptyTransferBP, SchemaName, PrevQty)
            Else
                Return False
            End If
        End Function
        Public Shared Function UpdateTabKEmptyReceiveBPtoBP_Edit(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean
            If Not objTabKEmptyTransferBP Is Nothing Then
                Return dalTabKEmptyTransferBP.UpdateTabKEmptyReceiveBPtoBP_Edit(objTabKEmptyTransferBP, SchemaName, PrevQty)
            Else
                Return False
            End If
        End Function
        Public Shared Function UpdateTabKEmptyReceiveBPtoBP(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal SchemaName As String) As Boolean
            If Not objTabKEmptyTransferBP Is Nothing Then
                Return dalTabKEmptyTransferBP.UpdateTabKEmptyReceiveBPtoBP(objTabKEmptyTransferBP, SchemaName)
            Else
                Return False
            End If
        End Function
        Public Shared Function DeleteTabKEmptyTransferBP(ByVal EBPOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Return dalTabKEmptyTransferBP.DeleteTabKEmptyTransferBP(EBPOrderID, TransactionNumber, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyTransferBP(ByVal valUserName As String) As DataSet
            Return dalTabKEmptyTransferBP.GetALLTabKEmptyTransferBP(valUserName)
        End Function

        Public Shared Function GetAllTabKEmptyTransferBPDrop() As SqlDataReader
            Return dalTabKEmptyTransferBP.GetALLTabKEmptyTransferBPDrop()
        End Function

        Public Shared Function GetTabKEmptyTransferBPByID(ByVal EBPOrderID As Int32) As PropertyTabKEmptyTransferBP
            If EBPOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByID(EBPOrderID)
        End Function

        Public Shared Function GetTabKEmptyTransferBPByFromBranchID(ByVal FromBranchID As Int32) As DataSet
            If FromBranchID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByFromBranchID(FromBranchID)
        End Function
        Public Shared Function GetTabKEmptyTransferBPByFromToBranchID(ByVal FromBranchID As Int32, ByVal ToBranchID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet

            Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByFromToBranchID(FromBranchID, ToBranchID, SchemaName, TransactionNumber)

        End Function
        Public Shared Function GetTabKEmptyTransferBPByFromToBranchIDHHT(ByVal FromBranchID As Int32, ByVal ToBranchID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByFromToBranchIDHHT(FromBranchID, ToBranchID, SchemaName)

        End Function
        Public Shared Function GetAllTabKEmptyTransferBPByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetAllTabKEmptyTransferBPByCompanyID(CompanyID, SchemaName, TransactionNumber)
        End Function
        Public Shared Function GetAllTabKEmptyReceiveBPByCompanyID(ByVal CompanyID As Int32) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetAllTabKEmptyReceiveBPByCompanyID(CompanyID)
        End Function
        Public Shared Function SaveHHT(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal schemaName As String) As Integer
            If Not objTabKEmptyTransferBP Is Nothing Then
                If objTabKEmptyTransferBP.EBPOrderID <= 0 Then
                    Dim TempId As Integer = dalTabKEmptyTransferBP.CreateNewTabKEmptyTransferBPHHT(objTabKEmptyTransferBP, schemaName)
                    If TempId > 0 Then
                        objTabKEmptyTransferBP.EBPOrderID = TempId
                        Return TempId
                    Else
                        Return 0
                    End If
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Function

        Public Shared Function ValidateforOpeningBal(ByVal CompanyID As Int32, ByVal EntityID As Int32, ByVal EntityType As Int32, ByVal ItemID As Int32, ByVal Quantity As Int32, ByVal SchemaName As String) As Integer
            Dim TempId As Integer = dalTabKEmptyTransferBP.ValidateforOpeningBal(CompanyID, EntityID, EntityType, ItemID, Quantity, SchemaName)
            Return TempId
        End Function
        Public Shared Function validateBPOpeningBalance(ByVal objTabKEmptyTransferBP As PropertyTabKEmptyTransferBP, ByVal schemaname As String) As Integer
            If Not objTabKEmptyTransferBP Is Nothing Then
                Return dalTabKEmptyTransferBP.validateBPOpeningBalance(objTabKEmptyTransferBP, schemaname)
            Else
                Return 0
            End If

        End Function
        Public Shared Function GetAllTransactionNumbersByCompanyID(ByVal valCompanyID As Int32, ByVal FromBranchID As Int32, ByVal ToBranchID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabKEmptyTransferBP.GetAllTransactionNumbersByCompanyID(valCompanyID, FromBranchID, ToBranchID, SchemaName)

        End Function
       

        Public Shared Function ValidateforNegativeOpeningBal(ByVal CompanyID As Int32, ByVal EntityID As Int32, ByVal EntityType As Int32, ByVal ItemID As Int32, ByVal Quantity As Int32, ByVal TransactionDate As Date, ByVal SchemaName As String) As Integer
            Dim TempId As Integer = dalTabKEmptyTransferBP.ValidateforNegativeOpeningBal(CompanyID, EntityID, EntityType, ItemID, Quantity, TransactionDate, SchemaName)
            Return TempId
        End Function


        Public Shared Function GetAllEmptyKegReceiveBPtoBP_Search(ByVal valCompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String, ByVal Status As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetAllEmptyKegReceiveBPtoBP_Search(valCompanyID, EmployeeID, SchemaName, TransactionNumber, ItemCode, Status)
        End Function


    End Class

End Namespace
