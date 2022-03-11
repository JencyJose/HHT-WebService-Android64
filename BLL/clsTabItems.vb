'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabItems
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:42 PM
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

    Public Class clsTabItems

        Public Shared Function Save(ByVal objTabItems As PropertyTabItems) As Boolean
            If Not objTabItems Is Nothing Then
                If objTabItems.ItemID <= 0 Then
                    Dim TempId As Integer = dalTabItems.CreateNewTabItems(objTabItems)
                    If TempId > 0 Then
                        objTabItems.ItemID = TempId
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

        Public Shared Function UpdateTabItems(ByVal objTabItems As PropertyTabItems) As Boolean
            If Not objTabItems Is Nothing Then
                Return dalTabItems.UpdateTabItems(objTabItems)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabItems(ByVal ItemID As Int32) As String
            If ItemID <= 0 Then
                Return ""
            End If

            Return dalTabItems.DeleteTabItems(ItemID)
        End Function

        Public Shared Function GetAllTabItems(ByVal valUserName As String) As DataSet
            Return dalTabItems.GetALLTabItems(valUserName)
        End Function

        Public Shared Function GetAllTabItemsDrop() As SqlDataReader
            Return dalTabItems.GetALLTabItemsDrop()
        End Function

        Public Shared Function GetTabItemsByID(ByVal ItemID As Int32) As PropertyTabItems
            If ItemID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabItems.GetTabItemsByID(ItemID)
        End Function

        Public Shared Function GetTabItemsByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabItems.GetTabItemsByCompanyID(CompanyID, SchemaName)
        End Function
        Public Shared Function GetTabItemsByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabItems.GetTabItemsByEmployeeID(EmployeeID, SchemaName)
        End Function
        'HHT Methods
        Public Shared Function GetTabItemsByEmployeeIDHHT(ByVal EmployeeID As Int32, ByVal schema As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabItems.GetTabItemsByEmployeeIDHHT(EmployeeID, schema)
        End Function

        Public Shared Function GetTabItemsBySearchHHT(ByVal schema As String, ByVal companyID As Integer, ByVal Search As String) As DataSet
            If companyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabItems.GetTabItemsBySearchHHT(schema, companyID, Search)
        End Function

        Public Shared Function GetItemsByChannel(ByVal Channelname As String, ByVal SchemaName As String) As DataSet
            If Channelname = Nothing Then
                Return (Nothing)
            End If

            Return dalTabItems.GetItemsByChannel(Channelname, SchemaName)
        End Function

    End Class

End Namespace
