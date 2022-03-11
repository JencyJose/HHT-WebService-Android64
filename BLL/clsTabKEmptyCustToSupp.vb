'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyCustToSupp
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:45 PM
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

    Public Class clsTabKEmptyCustToSupp

        Public Shared Function Save(ByVal objTabKEmptyCustToSupp As PropertyTabKEmptyCustToSupp, ByVal SchemaName As String) As String
            If Not objTabKEmptyCustToSupp Is Nothing Then
                If objTabKEmptyCustToSupp.ECSOrderID <= 0 Then
                    Dim TempId As String = dalTabKEmptyCustToSupp.CreateNewTabKEmptyCustToSupp(objTabKEmptyCustToSupp, SchemaName)

                    If Not TempId Is Nothing Then
                        objTabKEmptyCustToSupp.TransactionNumber = TempId
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

        Public Shared Function UpdateTabKEmptyCustToSupp(ByVal objTabKEmptyCustToSupp As PropertyTabKEmptyCustToSupp, ByVal SchemaName As String, ByVal PrevQty As Int32) As Boolean
            If Not objTabKEmptyCustToSupp Is Nothing Then
                Return dalTabKEmptyCustToSupp.UpdateTabKEmptyCustToSupp(objTabKEmptyCustToSupp, SchemaName, PrevQty)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKEmptyCustToSupp(ByVal ECSOrderID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String

            Return dalTabKEmptyCustToSupp.DeleteTabKEmptyCustToSupp(ECSOrderID, TransactionNumber, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyCustToSupp(ByVal valUserName As String) As DataSet
            Return dalTabKEmptyCustToSupp.GetALLTabKEmptyCustToSupp(valUserName)
        End Function

        Public Shared Function GetAllTabKEmptyCustToSuppDrop() As SqlDataReader
            Return dalTabKEmptyCustToSupp.GetALLTabKEmptyCustToSuppDrop()
        End Function

        Public Shared Function GetTabKEmptyCustToSuppByID(ByVal ECSOrderID As Int32) As PropertyTabKEmptyCustToSupp
            If ECSOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustToSupp.GetTabKEmptyCustToSuppByID(ECSOrderID)
        End Function

        Public Shared Function GetTabKEmptyCustToSuppByCustomerID(ByVal CustomerID As Int32) As DataSet
            If CustomerID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustToSupp.GetTabKEmptyCustToSuppByCustomerID(CustomerID)
        End Function

        Public Shared Function GetTabKEmptyCustToSuppBySupplierID(ByVal SupplierID As Int32) As DataSet
            If SupplierID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustToSupp.GetTabKEmptyCustToSuppBySupplierID(SupplierID)
        End Function
        Public Shared Function GetAllTabKEmptyCustToSuppByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustToSupp.GetAllTabKEmptyCustToSuppByCompanyID(CompanyID, SchemaName, TransactionNumber)
        End Function
       Public Shared Function GetAllTabKEmptyCustToSuppByCompanyID_Search(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String, ByVal ItemCode As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustToSupp.GetAllTabKEmptyCustToSuppByCompanyID_Search(CompanyID, EmployeeID, SchemaName, TransactionNumber, ItemCode)
        End Function

    End Class

End Namespace
