'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKSaleOrders
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:51 PM
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

    Public Class clsTabKSaleOrders

        Public Shared Function Save(ByVal objTabKSaleOrders As PropertyTabKSaleOrders) As Boolean
            If Not objTabKSaleOrders Is Nothing Then
                If objTabKSaleOrders.SOrderID <= 0 Then
                    Dim TempId As Integer = dalTabKSaleOrders.CreateNewTabKSaleOrders(objTabKSaleOrders)
                    If TempId > 0 Then
                        objTabKSaleOrders.SOrderID = TempId
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

        Public Shared Function UpdateTabKSaleOrders(ByVal objTabKSaleOrders As PropertyTabKSaleOrders) As Boolean
            If Not objTabKSaleOrders Is Nothing Then
                Return dalTabKSaleOrders.UpdateTabKSaleOrders(objTabKSaleOrders)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKSaleOrders(ByVal SOrderID As Int32) As String
            If SOrderID <= 0 Then
                Return ""
            End If

            Return dalTabKSaleOrders.DeleteTabKSaleOrders(SOrderID)
        End Function

        Public Shared Function GetAllTabKSaleOrders(ByVal valUserName As String) As DataSet
            Return dalTabKSaleOrders.GetALLTabKSaleOrders(valUserName)
        End Function

        Public Shared Function GetAllTabKSaleOrdersDrop() As SqlDataReader
            Return dalTabKSaleOrders.GetALLTabKSaleOrdersDrop()
        End Function

        Public Shared Function GetTabKSaleOrdersByID(ByVal SOrderID As Int32) As PropertyTabKSaleOrders
            If SOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetTabKSaleOrdersByID(SOrderID)
        End Function

        Public Shared Function GetTabKSaleOrdersByCustomerID(ByVal CustomerID As Int32) As DataSet
            If CustomerID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetTabKSaleOrdersByCustomerID(CustomerID)
        End Function
        Public Shared Function GetAllTabKSaleOrdersByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal SaleOrderNumber As String, ByVal ItemCode As String, ByVal ItemBarcode As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetAllTabKSaleOrdersByCompanyID(CompanyID, SchemaName, SaleOrderNumber, ItemCode, ItemBarcode)
        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeIDSearch(ByVal EmployeeID As Int32, ByVal SchemaName As String, ByVal SaleOrderNumber As String, ByVal ItemCode As String, ByVal ItemBarcode As String, BranchID As Integer) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetAllTabKSaleOrdersByEmployeeIDSearch(EmployeeID, SchemaName, SaleOrderNumber, ItemCode, ItemBarcode, BranchID)
        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetAllTabKSaleOrdersByEmployeeID(EmployeeID, SchemaName)
        End Function
        'HHT Methods
        Public Shared Function GetAllTabKSaleOrdersByEmployeeIDHHT(ByVal EmployeeID As Int32, ByVal schema As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetAllTabKSaleOrdersByEmployeeIDHHT(EmployeeID, schema)
        End Function

        Public Shared Function GetSaleOrderNoByBarcodeHHT(ByVal barcode As String, ByVal CompanyID As Integer, ByVal schema As String) As Object


            Return dalTabKSaleOrders.GetSaleOrderNoByBarcodeHHT(barcode, CompanyID, schema)
        End Function

        Public Shared Function GetSaleOrderNoByCompanyIDHHT(ByVal CompanyID As Integer, ByVal schema As String) As DataSet


            Return dalTabKSaleOrders.GetSaleOrderNoByCompanyIDHHT(CompanyID, schema)
        End Function

        Public Shared Function GetSaleOrderDetailsByOrderIDHHT(ByVal CompanyID As Integer, ByVal schema As String, ByVal OrderID As Integer) As DataSet


            Return dalTabKSaleOrders.GetSaleOrderDetailsByOrderIDHHT(CompanyID, schema, OrderID)
        End Function

        Public Shared Function VerifySaleOrderHHT(ByVal CompanyID As Integer, ByVal EntityID As Integer, ByVal OnHandQuantity As Integer, ByVal SOrderID As Integer, ByVal ItemID As Integer, ByVal schema As String, ByVal BarCode As String) As Integer


            Return dalTabKSaleOrders.VerifySaleOrderHHT(CompanyID, EntityID, OnHandQuantity, SOrderID, ItemID, schema, BarCode)
        End Function

        Public Shared Function GetCountVerifiedSaleOrderHHT(ByVal SOrderID As Integer, ByVal schema As String) As Integer


            Return dalTabKSaleOrders.GetCountVerifiedSaleOrderHHT(SOrderID, schema)
        End Function
        Public Shared Function GetItemsByCompBarcodeDHHT(ByVal Barcode As String, ByVal CompanyID As Integer, ByVal schema As String) As DataSet


            Return dalTabKSaleOrders.GetItemsByCompBarcodeDHHT(Barcode, CompanyID, schema)
        End Function

        Public Shared Function GetItemsByCompBarcodeNewHHT(ByVal Barcode As String, ByVal CompanyID As Integer, ByVal schema As String) As DataSet


            Return dalTabKSaleOrders.GetItemsByCompBarcodeNewHHT(Barcode, CompanyID, schema)
        End Function

        Public Shared Function UpdateRePrintStatusSO(OrderNumber As String, ItemID As Integer, ItemBarcode As String, schema As String) As Boolean
            Return dalTabKSaleOrders.UpdateRePrintStatusSO(OrderNumber, ItemID, ItemBarcode, schema)
        End Function
    End Class

End Namespace
