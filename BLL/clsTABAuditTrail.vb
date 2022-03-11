'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTABAuditTrail
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :2/17/2009 12:12:37 PM
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

    Public Class clsTABAuditTrail

        Public Shared Function Save(ByVal objTABAuditTrail As PropertyTABAuditTrail, ByVal SchemaName As String) As Boolean
            If Not objTABAuditTrail Is Nothing Then
                If objTABAuditTrail.AuditID <= 0 Then
                    Dim TempId As Integer = dalTABAuditTrail.CreateNewTABAuditTrail(objTABAuditTrail, SchemaName)
                    If TempId > 0 Then
                        objTABAuditTrail.AuditID = TempId
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

        Public Shared Function UpdateTABAuditTrail(ByVal objTABAuditTrail As PropertyTABAuditTrail) As Boolean
            If Not objTABAuditTrail Is Nothing Then
                Return dalTABAuditTrail.UpdateTABAuditTrail(objTABAuditTrail)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTABAuditTrail(ByVal AuditID As Int32) As String
            If AuditID <= 0 Then
                Return ""
            End If

            Return dalTABAuditTrail.DeleteTABAuditTrail(AuditID)
        End Function

        Public Shared Function GetAllTABAuditTrail(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTABAuditTrail.GetALLTABAuditTrail(valEmployeeID, SchemaName)
        End Function

        Public Shared Function GetAllTABAuditTrailDrop() As SqlDataReader
            Return dalTABAuditTrail.GetALLTABAuditTrailDrop()
        End Function

        Public Shared Function GetTABAuditTrailByID(ByVal AuditID As Int32) As PropertyTABAuditTrail
            If AuditID <= 0 Then
                Return (Nothing)
            End If

            Return dalTABAuditTrail.GetTABAuditTrailByID(AuditID)
        End Function

        Public Shared Function GetTABAuditTrailByUserID(ByVal UserID As Int32) As DataSet
            If UserID <= 0 Then
                Return (Nothing)
            End If

            Return dalTABAuditTrail.GetTABAuditTrailByUserID(UserID)
        End Function

    End Class

End Namespace
