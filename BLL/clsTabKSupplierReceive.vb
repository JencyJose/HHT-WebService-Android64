'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKSupplierReceive
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:52 PM
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

    Public Class clsTabKSupplierReceive

        Public Shared Function Save(ByVal objTabKSupplierReceive As PropertyTabKSupplierReceive) As Boolean
            If Not objTabKSupplierReceive Is Nothing Then
                If objTabKSupplierReceive.OrderID <= 0 Then
                    Dim TempId As Integer = dalTabKSupplierReceive.CreateNewTabKSupplierReceive(objTabKSupplierReceive)
                    If TempId > 0 Then
                        objTabKSupplierReceive.OrderID = TempId
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

        Public Shared Function UpdateTabKSupplierReceive(ByVal objTabKSupplierReceive As PropertyTabKSupplierReceive) As Boolean
            If Not objTabKSupplierReceive Is Nothing Then
                Return dalTabKSupplierReceive.UpdateTabKSupplierReceive(objTabKSupplierReceive)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKSupplierReceive(ByVal OrderID As Int32) As String
            If OrderID <= 0 Then
                Return ""
            End If

            Return dalTabKSupplierReceive.DeleteTabKSupplierReceive(OrderID)
        End Function


        Public Shared Function GetAllTabKSupplierReceive(ByVal valUserName As String) As DataSet
            Return dalTabKSupplierReceive.GetALLTabKSupplierReceive(valUserName)
        End Function

        Public Shared Function GetAllTabKSupplierReceiveDrop() As SqlDataReader
            Return dalTabKSupplierReceive.GetALLTabKSupplierReceiveDrop()
        End Function

        Public Shared Function GetTabKSupplierReceiveByID(ByVal OrderID As Int32) As PropertyTabKSupplierReceive
            If OrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSupplierReceive.GetTabKSupplierReceiveByID(OrderID)
        End Function

        Public Shared Function GetTabKSupplierReceiveBySupplierID(ByVal SupplierID As Int32) As DataSet
            If SupplierID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSupplierReceive.GetTabKSupplierReceiveBySupplierID(SupplierID)
        End Function
        Public Shared Function GetTabKSupplierReceiveByCompanyID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSupplierReceive.GetTabKSupplierReceiveByCompanyID(EmployeeID, SchemaName)
        End Function

    End Class

End Namespace
