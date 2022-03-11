'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyToSupplier
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:46 PM
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

    Public Class clsTabKEmptyToSupplier

        Public Shared Function Save(ByVal objTabKEmptyToSupplier As PropertyTabKEmptyToSupplier, ByVal SchemaName As String) As Boolean
            If Not objTabKEmptyToSupplier Is Nothing Then
                If objTabKEmptyToSupplier.ESOrderID <= 0 Then
                    Dim TempId As Integer = dalTabKEmptyToSupplier.CreateNewTabKEmptyToSupplier(objTabKEmptyToSupplier, SchemaName)
                    If TempId > 0 Then
                        objTabKEmptyToSupplier.ESOrderID = TempId
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

        Public Shared Function UpdateTabKEmptyToSupplier(ByVal objTabKEmptyToSupplier As PropertyTabKEmptyToSupplier, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean
            If Not objTabKEmptyToSupplier Is Nothing Then
                Return dalTabKEmptyToSupplier.UpdateTabKEmptyToSupplier(objTabKEmptyToSupplier, SchemaName, PrevQty)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKEmptyToSupplier(ByVal ESOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Return dalTabKEmptyToSupplier.DeleteTabKEmptyToSupplier(ESOrderID, TransactionNumber, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyToSupplier(ByVal valUserName As String) As DataSet
            Return dalTabKEmptyToSupplier.GetALLTabKEmptyToSupplier(valUserName)
        End Function

        Public Shared Function GetAllTabKEmptyToSupplierDrop() As SqlDataReader
            Return dalTabKEmptyToSupplier.GetALLTabKEmptyToSupplierDrop()
        End Function

        Public Shared Function GetTabKEmptyToSupplierByID(ByVal ESOrderID As Int32) As PropertyTabKEmptyToSupplier
            If ESOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyToSupplier.GetTabKEmptyToSupplierByID(ESOrderID)
        End Function

        Public Shared Function GetTabKEmptyToSupplierBySupplierID(ByVal SupplierID As Int32) As DataSet
            If SupplierID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyToSupplier.GetTabKEmptyToSupplierBySupplierID(SupplierID)
        End Function
        Public Shared Function GetAllTabKEmptyToSupplierByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyToSupplier.GetAllTabKEmptyToSupplierByCompanyID(CompanyID, SchemaName, TransactionNumber)
        End Function
        Public Shared Function GetAllTabKEmptyToSupplierByCompanyID_Search(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyToSupplier.GetAllTabKEmptyToSupplierByCompanyID_Search(CompanyID, EmployeeID, SchemaName, TransactionNumber, ItemCode)
        End Function
    End Class

End Namespace
