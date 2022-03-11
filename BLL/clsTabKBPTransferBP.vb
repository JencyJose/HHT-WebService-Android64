'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKBPTransferBP
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:43 PM
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

    Public Class clsTabKBPTransferBP

        Public Shared Function Save(ByVal objTabKBPTransferBP As PropertyTabKBPTransferBP) As Boolean
            If Not objTabKBPTransferBP Is Nothing Then
                If objTabKBPTransferBP.TOrderID <= 0 Then
                    Dim TempId As Integer = dalTabKBPTransferBP.CreateNewTabKBPTransferBP(objTabKBPTransferBP)
                    If TempId > 0 Then
                        objTabKBPTransferBP.TOrderID = TempId
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

        Public Shared Function UpdateTabKBPTransferBP(ByVal objTabKBPTransferBP As PropertyTabKBPTransferBP) As Boolean
            If Not objTabKBPTransferBP Is Nothing Then
                Return dalTabKBPTransferBP.UpdateTabKBPTransferBP(objTabKBPTransferBP)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabKBPTransferBP(ByVal TOrderID As Int32) As String
            If TOrderID <= 0 Then
                Return ""
            End If

            Return dalTabKBPTransferBP.DeleteTabKBPTransferBP(TOrderID)
        End Function

        Public Shared Function GetAllTabKBPTransferBP(ByVal valUserName As String) As DataSet
            Return dalTabKBPTransferBP.GetALLTabKBPTransferBP(valUserName)
        End Function

        Public Shared Function GetAllTabKBPTransferBPDrop() As SqlDataReader
            Return dalTabKBPTransferBP.GetALLTabKBPTransferBPDrop()
        End Function

        Public Shared Function GetTabKBPTransferBPByID(ByVal TOrderID As Int32) As PropertyTabKBPTransferBP
            If TOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKBPTransferBP.GetTabKBPTransferBPByID(TOrderID)
        End Function

        Public Shared Function GetTabKBPTransferBPByFromBranchID(ByVal FromBranchID As Int32) As DataSet
            If FromBranchID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKBPTransferBP.GetTabKBPTransferBPByFromBranchID(FromBranchID)
        End Function
        Public Shared Function GetAllTabKBPTransferBPByCompanyID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKBPTransferBP.GetAllTabKBPTransferBPByCompanyID(EmployeeID, SchemaName)
        End Function
    End Class

End Namespace
