'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabUOMMaster
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:03 PM
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

    Public Class clsTabUOMMaster

        Public Shared Function Save(ByVal objTabUOMMaster As PropertyTabUOMMaster) As Boolean
            If Not objTabUOMMaster Is Nothing Then
                If objTabUOMMaster.UOMID <= 0 Then
                    Dim TempId As Integer = dalTabUOMMaster.CreateNewTabUOMMaster(objTabUOMMaster)
                    If TempId > 0 Then
                        objTabUOMMaster.UOMID = TempId
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

        Public Shared Function UpdateTabUOMMaster(ByVal objTabUOMMaster As PropertyTabUOMMaster) As Boolean
            If Not objTabUOMMaster Is Nothing Then
                Return dalTabUOMMaster.UpdateTabUOMMaster(objTabUOMMaster)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabUOMMaster(ByVal UOMID As Int32) As String
            If UOMID <= 0 Then
                Return ""
            End If

            Return dalTabUOMMaster.DeleteTabUOMMaster(UOMID)
        End Function

        Public Shared Function GetAllTabUOMMaster(ByVal valUserName As String) As DataSet
            Return dalTabUOMMaster.GetALLTabUOMMaster(valUserName)
        End Function

        Public Shared Function GetAllTabUOMMasterDrop() As SqlDataReader
            Return dalTabUOMMaster.GetALLTabUOMMasterDrop()
        End Function

        Public Shared Function GetTabUOMMasterByID(ByVal UOMID As Int32) As PropertyTabUOMMaster
            If UOMID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabUOMMaster.GetTabUOMMasterByID(UOMID)
        End Function

        Public Shared Function GetTabUOMMasterByItemID(ByVal ItemID As Int32) As DataSet
            If ItemID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabUOMMaster.GetTabUOMMasterByItemID(ItemID)
        End Function
        Public Shared Function GetTabUOMMasterByItemCode(ByVal ItemCode As String, ByVal SchemaName As String, ByVal valCompanyID As Int32) As DataSet
            If ItemCode = "" Then
                Return (Nothing)
            End If
            Return dalTabUOMMaster.GetTabUOMMasterByItemCode(ItemCode, SchemaName, valCompanyID)
        End Function
        Public Shared Function GetTabUOMMasterByEmployeeID(ByVal EmployeeID As Int32) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabUOMMaster.GetTabUOMMasterByEmployeeID(EmployeeID)
        End Function

        Public Shared Function ItemCodeValForTwoCompanies(ByVal valItemCode As String, ByVal valFromCompanyID As Int32, ByVal valToCompanyID As Int32, ByVal SchemaName As String) As Boolean
            Return dalTabUOMMaster.ItemCodeValForTwoCompanies(valItemCode, valFromCompanyID, valToCompanyID, SchemaName)
        End Function

    End Class

End Namespace
