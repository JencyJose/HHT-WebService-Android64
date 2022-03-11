'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMCustomers
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:54 PM
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

    Public Class clsTabMCustomers
        Public Shared Function Save(ByVal objTabMCustomers As PropertyTabMCustomers) As Boolean
            If Not objTabMCustomers Is Nothing Then
                If objTabMCustomers.CustomerID <= 0 Then
                    Dim TempId As Integer = dalTabMCustomers.CreateNewTabMCustomers(objTabMCustomers)
                    If TempId > 0 Then
                        objTabMCustomers.CustomerID = TempId
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

        Public Shared Function UpdateTabMCustomers(ByVal objTabMCustomers As PropertyTabMCustomers, ByVal SchemaName As String) As Boolean
            If Not objTabMCustomers Is Nothing Then
                Return dalTabMCustomers.UpdateTabMCustomers(objTabMCustomers, SchemaName)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMCustomers(ByVal CustomerID As Int32) As String
            If CustomerID <= 0 Then
                Return ""
            End If

            Return dalTabMCustomers.DeleteTabMCustomers(CustomerID)
        End Function

        Public Shared Function GetAllTabMCustomers(ByVal valUserName As String) As DataSet
            Return dalTabMCustomers.GetALLTabMCustomers(valUserName)
        End Function

        Public Shared Function GetAllTabMCustomersDrop() As SqlDataReader
            Return dalTabMCustomers.GetALLTabMCustomersDrop()
        End Function

        Public Shared Function GetTabMCustomersByID(ByVal CustomerID As Int32, ByVal SchemaName As String) As PropertyTabMCustomers
            If CustomerID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCustomers.GetTabMCustomersByID(CustomerID, SchemaName)
        End Function

        Public Shared Function GetTabMCustomersByCompanyID(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMCustomers.GetTabMCustomersByCompanyID(CompanyID, EmployeeID, SchemaName)
        End Function

        Public Shared Function GetRptCustomersDrop(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMCustomers.GetRptCustomersDrop(CompanyID, EmployeeID, SchemaName)
        End Function

        Public Shared Function GetAllTabMCustomersByCustomerCode(ByVal valCustomerCode As String, ByVal SchemaName As String) As PropertyTabMCustomers
            Return dalTabMCustomers.GetAllTabMCustomersByCustomerCode(valCustomerCode, SchemaName)
        End Function
        Public Shared Function GetAllTabMCustomersByCusCodeNDCompID(ByVal valCustomerCode As String, ByVal SchemaName As String, ByVal valCompanyID As Int32) As PropertyTabMCustomers
            Return dalTabMCustomers.GetAllTabMCustomersByCusCodeNDCompID(valCustomerCode, SchemaName, valCompanyID)
        End Function

        Public Shared Function GetTabMCustomersByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMCustomers.GetTabMCustomersByEmployeeID(EmployeeID, SchemaName)
        End Function

        Public Shared Function GetRptCustomersByChannel(ByVal Channelname As String, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMCustomers.GetRptCustomersByChannel(Channelname, EmployeeID, SchemaName)
        End Function

    End Class

End Namespace
