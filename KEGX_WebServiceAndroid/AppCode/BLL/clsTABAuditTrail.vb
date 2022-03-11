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


Namespace TrackITKTS

    Public Class clsTABAuditTrail

        Private m_AuditID As Int32
        Private m_UserID As Int32
        Private m_ActionName As String
        Private m_FunctionName As String
        Private m_ActionDate As DateTime
        Private m_PrimaryID As Int32
        Private m_TableName As String

        Public Property PrimaryID() As Int32

            Get
                Return Me.m_PrimaryID
            End Get

            Set(ByVal value As Int32)
                Me.m_PrimaryID = value
            End Set

        End Property

        Public Property TableName() As String

            Get
                Return Me.m_TableName
            End Get

            Set(ByVal value As String)
                Me.m_TableName = value
            End Set

        End Property
        Public Property AuditID() As Int32

            Get
                Return Me.m_AuditID
            End Get

            Set(ByVal value As Int32)
                Me.m_AuditID = value
            End Set

        End Property

        Public Property UserID() As Int32

            Get
                Return Me.m_UserID
            End Get

            Set(ByVal value As Int32)
                Me.m_UserID = value
            End Set

        End Property

        Public Property ActionName() As String

            Get
                Return Me.m_ActionName
            End Get

            Set(ByVal value As String)
                Me.m_ActionName = value
            End Set

        End Property

        Public Property FunctionName() As String

            Get
                Return Me.m_FunctionName
            End Get

            Set(ByVal value As String)
                Me.m_FunctionName = value
            End Set

        End Property

        Public Property ActionDate() As DateTime

            Get
                Return Me.m_ActionDate
            End Get

            Set(ByVal value As DateTime)
                Me.m_ActionDate = value
            End Set

        End Property


        Public Shared Function Save(ByVal objTABAuditTrail As clsTABAuditTrail, ByVal SchemaName As String) As Boolean
            If Not objTABAuditTrail Is Nothing Then
                If objTABAuditTrail.AuditID <= 0 Then
                    Dim TempId As Integer = dalTABAuditTrail.CreateNewTABAuditTrail(objTABAuditTrail, SchemaName)
                    If TempId > 0 Then
                        objTABAuditTrail.m_AuditID = TempId
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End If
        End Function

        Public Shared Function UpdateTABAuditTrail(ByVal objTABAuditTrail As clsTABAuditTrail) As Boolean
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

        Public Shared Function DeletetTest(ByVal AuditID As Int32)

        End Function

        Public Shared Function GetAllTABAuditTrail(ByVal valEmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTABAuditTrail.GetALLTABAuditTrail(valEmployeeID, SchemaName)
        End Function

        Public Shared Function GetAllTABAuditTrailDrop() As SqlDataReader
            Return dalTABAuditTrail.GetALLTABAuditTrailDrop()
        End Function

        Public Shared Function GetTABAuditTrailByID(ByVal AuditID As Int32) As clsTABAuditTrail
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
