'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMBranchPlant
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:53 PM
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

    Public Class clsTabMBranchPlant

        Public Shared Function Save(ByVal objTabMBranchPlant As PropertyTabMBranchPlant) As Boolean
            If Not objTabMBranchPlant Is Nothing Then
                If objTabMBranchPlant.BranchID <= 0 Then
                    Dim TempId As Integer = dalTabMBranchPlant.CreateNewTabMBranchPlant(objTabMBranchPlant)
                    If TempId > 0 Then
                        objTabMBranchPlant.BranchID = TempId
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

        Public Shared Function UpdateTabMBranchPlant(ByVal objTabMBranchPlant As PropertyTabMBranchPlant) As Boolean
            If Not objTabMBranchPlant Is Nothing Then
                Return dalTabMBranchPlant.UpdateTabMBranchPlant(objTabMBranchPlant)
            Else
                Return False
            End If
        End Function
        Public Shared Function UpdateTabMBranchPlant_Batch(ByVal BranchPlantID As Int32, ByVal Batch As Boolean, ByVal SchemaName As String) As Boolean
            If Not BranchPlantID <= 0 Then
                Return dalTabMBranchPlant.UpdateTabMBranchPlant_Batch(BranchPlantID, Batch, SchemaName)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMBranchPlant(ByVal BranchID As Int32) As String
            If BranchID <= 0 Then
                Return ""
            End If

            Return dalTabMBranchPlant.DeleteTabMBranchPlant(BranchID)
        End Function

        Public Shared Function GetAllTabMBranchPlant(ByVal valUserName As String) As DataSet
            Return dalTabMBranchPlant.GetALLTabMBranchPlant(valUserName)
        End Function

        Public Shared Function GetAllTabMBranchPlantDrop() As SqlDataReader
            Return dalTabMBranchPlant.GetALLTabMBranchPlantDrop()
        End Function

        Public Shared Function GetTabMBranchPlantByID(ByVal BranchID As Int32) As PropertyTabMBranchPlant
            If BranchID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMBranchPlant.GetTabMBranchPlantByID(BranchID)
        End Function

        Public Shared Function GetTabMBranchPlantByCompanyID(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMBranchPlant.GetTabMBranchPlantByCompanyID(CompanyID, EmployeeID, SchemaName)
        End Function
        Public Shared Function GetTabMBranchPlantByBranchCode(ByVal valCompanyID As Int32, ByVal valBranchCode As String, ByVal SchemaName As String) As PropertyTabMBranchPlant

            Return dalTabMBranchPlant.GetTabMBranchPlantByBranchCode(valCompanyID, valBranchCode, SchemaName)
        End Function

        Public Shared Function GetTabMBranchPlantByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMBranchPlant.GetTabMBranchPlantByEmployeeID(EmployeeID, SchemaName)
        End Function
        Public Shared Function GetTabMBranchPlantCompByBranchID(ByVal BranchID As Int32, ByVal SchemaName As String) As Integer
            Return dalTabMBranchPlant.GetTabMBranchPlantCompByBranchID(BranchID, SchemaName)
        End Function
      

    End Class

End Namespace
