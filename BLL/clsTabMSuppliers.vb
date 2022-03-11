'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMSuppliers
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:01 PM
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

    Public Class clsTabMSuppliers

        Public Shared Function Save(ByVal objTabMSuppliers As PropertyTabMSuppliers) As Boolean
            If Not objTabMSuppliers Is Nothing Then
                If objTabMSuppliers.SupplierID <= 0 Then
                    Dim TempId As Integer = dalTabMSuppliers.CreateNewTabMSuppliers(objTabMSuppliers)
                    If TempId > 0 Then
                        objTabMSuppliers.SupplierID = TempId
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

        Public Shared Function UpdateTabMSuppliers(ByVal objTabMSuppliers As PropertyTabMSuppliers, ByVal SchemaName As String) As Boolean
            If Not objTabMSuppliers Is Nothing Then
                Return dalTabMSuppliers.UpdateTabMSuppliers(objTabMSuppliers, SchemaName)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMSuppliers(ByVal SupplierID As Int32) As String
            If SupplierID <= 0 Then
                Return ""
            End If

            Return dalTabMSuppliers.DeleteTabMSuppliers(SupplierID)
        End Function

        Public Shared Function GetAllTabMSuppliers(ByVal valUserName As String) As DataSet
            Return dalTabMSuppliers.GetALLTabMSuppliers(valUserName)
        End Function

        Public Shared Function GetAllTabMSuppliersDrop() As SqlDataReader
            Return dalTabMSuppliers.GetALLTabMSuppliersDrop()
        End Function

        Public Shared Function GetTabMSuppliersByID(ByVal SupplierID As Int32, ByVal SchemaName As String) As PropertyTabMSuppliers
            If SupplierID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMSuppliers.GetTabMSuppliersByID(SupplierID, SchemaName)
        End Function

        Public Shared Function GetTabMSuppliersByCompanyID(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMSuppliers.GetTabMSuppliersByCompanyID(CompanyID, EmployeeID, SchemaName)
        End Function
        Public Shared Function GetRptSuppliersDrop(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMSuppliers.GetRptSuppliersDrop(CompanyID, EmployeeID, SchemaName)
        End Function
        Public Shared Function GetTabMSuppliersByCode(ByVal valCompanyID As Int32, ByVal valSupplierCode As String, ByVal SchemaName As String) As PropertyTabMSuppliers

            Return dalTabMSuppliers.GetTabMSuppliersByCode(valCompanyID, valSupplierCode, SchemaName)
        End Function

        Public Shared Function GetTabMSuppliersByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMSuppliers.GetTabMSuppliersByEmployeeID(EmployeeID, SchemaName)
        End Function

    End Class

End Namespace
