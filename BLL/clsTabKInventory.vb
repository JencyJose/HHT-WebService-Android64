'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKInventory
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:49 PM
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

    Public Class clsTabKInventory

        Public Shared Function Save(ByVal objTabKInventory As PropertyTabKInventory) As Boolean
            If Not objTabKInventory Is Nothing Then
                If objTabKInventory.LotID <= 0 Then
                    Dim TempId As Integer = dalTabKInventory.CreateNewTabKInventory(objTabKInventory)
                    If TempId > 0 Then
                        objTabKInventory.LotID = TempId
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

        Public Shared Function UpdateTabKInventory(ByVal objTabKInventory As PropertyTabKInventory) As Boolean
            If Not objTabKInventory Is Nothing Then
                Return dalTabKInventory.UpdateTabKInventory(objTabKInventory)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKInventory(ByVal LotID As Int32) As String
            If LotID <= 0 Then
                Return ""
            End If

            Return dalTabKInventory.DeleteTabKInventory(LotID)
        End Function


        Public Shared Function GetAllTabKInventory(ByVal valUserName As String) As DataSet
            Return dalTabKInventory.GetALLTabKInventory(valUserName)
        End Function

        Public Shared Function GetAllTabKInventoryDrop() As SqlDataReader
            Return dalTabKInventory.GetALLTabKInventoryDrop()
        End Function

        Public Shared Function GetTabKInventoryByID(ByVal LotID As Int32) As PropertyTabKInventory
            If LotID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKInventory.GetTabKInventoryByID(LotID)
        End Function

        Public Shared Function GetTabKInventoryByBranchID(ByVal BranchID As Int32) As DataSet
            If BranchID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKInventory.GetTabKInventoryByBranchID(BranchID)
        End Function

        Public Shared Function GetTabKInventoryByItemID(ByVal ItemID As Int32) As DataSet
            If ItemID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKInventory.GetTabKInventoryByItemID(ItemID)
        End Function
        Public Shared Function GetTabKInventoryByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKInventory.GetTabKInventoryByCompanyID(CompanyID, SchemaName)
        End Function

        Public Shared Function GetTabKInventoryByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKInventory.GetTabKInventoryByEmployeeID(EmployeeID, SchemaName)
        End Function

    End Class

End Namespace
