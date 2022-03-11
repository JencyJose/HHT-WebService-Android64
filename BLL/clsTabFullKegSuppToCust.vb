'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKFullKegSuppToCust.vb
'Created By         :
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
    Public Class clsTabFullKegSuppToCust
        Public Shared Function Save(ByVal objTabTabFullKegSuppToCust As PropertyTabFullKegSuppToCust, ByVal SchemaName As String) As Boolean
            If Not objTabTabFullKegSuppToCust Is Nothing Then
                If objTabTabFullKegSuppToCust.FullKegID <= 0 Then
                    Dim TempId As Integer = dalTabFullKegSuppToCust.CreateNewTabFullKegSupptoCust(objTabTabFullKegSuppToCust, SchemaName)
                    If TempId > 0 Then
                        objTabTabFullKegSuppToCust.FullKegID = TempId
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
        Public Shared Function UpdateTabFullKegSuppToCust(ByVal objTabTabFullKegSuppToCust As PropertyTabFullKegSuppToCust, ByVal SchemaName As String) As Boolean
            If Not objTabTabFullKegSuppToCust Is Nothing Then
                Return dalTabFullKegSuppToCust.UpdateTabFullKegSuppToCust(objTabTabFullKegSuppToCust, SchemaName)
            Else
                Return False
            End If
        End Function
        Public Shared Function GetAllTabFullKegSuppToCust(ByVal CompanyID As Int32, ByVal SchemaName As String, ByVal TransactionNumber As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabFullKegSuppToCust.GetAllTabFullKegSuppToCust(CompanyID, SchemaName, TransactionNumber)
        End Function
        Public Shared Function DeleteTabFullKegSuppToCust(ByVal FullKegID As Int32, ByVal TransactionNumber As String, ByVal SchemaName As String) As String
            Return dalTabFullKegSuppToCust.DeleteTabFullKegSuppToCust(FullKegID, TransactionNumber, SchemaName)
        End Function
    End Class
End Namespace

