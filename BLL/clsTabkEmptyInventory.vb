
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS
    Public Class clsTabkEmptyInventory

        Public Shared Function Save(ByVal objTabKEInventory As PropertyTabkEmptyInventory, ByVal SchemaName As String, ByVal AdjustementQty As Int32) As Boolean
            If Not objTabKEInventory Is Nothing Then
                If objTabKEInventory.InventoryID <= 0 Then
                    Dim TempId As Integer = dalTabkEmptyInventory.CreateNewTabKEmptyInventory(objTabKEInventory, SchemaName, AdjustementQty)
                    If TempId > 0 Then
                        objTabKEInventory.InventoryID = TempId
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
        Public Shared Function GetAllTabKEmptyInventoryLatestOB(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabkEmptyInventory.GetAllTabKEmptyInventoryLatestOB(valCompanyID, valEntityID, valEntityType, SchemaName)
        End Function
        Public Shared Function CheckEmptyOpeningBalExist(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Int32, ByVal SchemaName As String) As Boolean          
            Dim TempId As Integer = dalTabkEmptyInventory.CheckEmptyOpeningBalExist(valCompanyID, valEntityID, valEntityType, valItemID, SchemaName)
            If TempId = 0 Then
                Return False
            Else
                Return True
            End If
        End Function
        Public Shared Function CheckAndGetEmptyOpeningBal(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Int32, ByVal SchemaName As String) As String
            Return dalTabkEmptyInventory.CheckAndGetEmptyOpeningBal(valCompanyID, valEntityID, valEntityType, valItemID, SchemaName)
        End Function

        Public Shared Function CheckAndGetEmptyOpeningBalInTransit(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Int32, ByVal SchemaName As String) As Integer
            Return dalTabkEmptyInventory.CheckAndGetEmptyOpeningBalInTransit(valCompanyID, valEntityID, valEntityType, valItemID, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyInventoryHHT(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabkEmptyInventory.GetAllTabKEmptyInventoryHHT(valEmployeeID, SchemaName)
        End Function

        Public Shared Function GetAllTabKEmptyInventoryLatestOBByItemID(ByVal valCompanyID As Int32, ByVal valEntityID As Int32, ByVal valEntityType As Int32, ByVal valItemID As Integer, ByVal SchemaName As String) As DataSet

            Return dalTabkEmptyInventory.GetAllTabKEmptyInventoryLatestOBNyItemID(valCompanyID, valEntityID, valEntityType, valItemID, SchemaName)
        End Function



    End Class
End Namespace

