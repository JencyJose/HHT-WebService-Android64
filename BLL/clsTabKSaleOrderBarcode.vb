'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKSaleOrderBarcode
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:50 PM
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

    Public Class clsTabKSaleOrderBarcode

        Public Shared Function Save(ByVal objTabKSaleOrderBarcode As PropertyTabKSaleOrderBarcode) As Boolean
            If Not objTabKSaleOrderBarcode Is Nothing Then
                Dim TempId As Integer = dalTabKSaleOrderBarcode.CreateNewTabKSaleOrderBarcode(objTabKSaleOrderBarcode)
                If TempId > 0 Then
                    objTabKSaleOrderBarcode.SOrderID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        End Function

        Public Shared Function UpdateTabKSaleOrderBarcode(ByVal objTabKSaleOrderBarcode As PropertyTabKSaleOrderBarcode) As Boolean
            If Not objTabKSaleOrderBarcode Is Nothing Then
                Return dalTabKSaleOrderBarcode.UpdateTabKSaleOrderBarcode(objTabKSaleOrderBarcode)
            Else
                Return False
            End If
        End Function

        'Public Shared Function DeleteTabKSaleOrderBarcode(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As String
        '    Return dalTabKSaleOrderBarcode.DeleteTabKSaleOrderBarcode()
        'End Function

        Public Shared Function GetAllTabKSaleOrderBarcode(ByVal valUserName As String) As DataSet
            Return dalTabKSaleOrderBarcode.GetALLTabKSaleOrderBarcode(valUserName)
        End Function

        Public Shared Function GetAllTabKSaleOrderBarcodeDrop() As SqlDataReader
            Return dalTabKSaleOrderBarcode.GetALLTabKSaleOrderBarcodeDrop()
        End Function

        'Public Shared Function GetTabKSaleOrderBarcodeByID(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As clsTabKSaleOrderBarcode
        '    Return dalTabKSaleOrderBarcode.GetTabKSaleOrderBarcodeByID(objTabKSaleOrderBarcode)
        'End Function

        Public Shared Function GetTabKSaleOrderBarcodeBySOrderID(ByVal SOrderID As Int32) As DataSet
            If SOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrderBarcode.GetTabKSaleOrderBarcodeBySOrderID(SOrderID)
        End Function
        Public Shared Function GetAllTabKSaleOrderBarcodeByEmployeeID(ByVal EmployeeID As Int32) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrderBarcode.GetAllTabKSaleOrderBarcodeByEmployeeID(EmployeeID)
        End Function
        'HHT Methods
        Public Shared Function GetAllTabKSaleOrderBarcodeByEmployeeIDHHT(ByVal EmployeeID As Int32, ByVal schema As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrderBarcode.GetAllTabKSaleOrderBarcodeByEmployeeIDHHT(EmployeeID, schema)
        End Function
        Public Shared Function GetSaleOrderItemDetailsByBarcodeHHT(ByVal barcode As String, ByVal schema As String) As DataSet

            Return dalTabKSaleOrderBarcode.GetSaleOrderItemDetailsByBarcodeHHT(barcode, schema)
        End Function
    End Class

End Namespace
