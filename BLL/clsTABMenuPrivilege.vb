'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTABMenuPrivilege
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:58 PM
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

    Public Class clsTABMenuPrivilege

        Public Shared Function Save(ByVal objTABMenuPrivilege As PropertyTABMenuPrivilege) As Boolean
            If Not objTABMenuPrivilege Is Nothing Then
                If objTABMenuPrivilege.PrivID <= 0 Then
                    Dim TempId As Integer = dalTABMenuPrivilege.CreateNewTABMenuPrivilege(objTABMenuPrivilege)
                    If TempId > 0 Then
                        objTABMenuPrivilege.PrivID = TempId
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

        Public Shared Function UpdateTABMenuPrivilege(ByVal objTABMenuPrivilege As PropertyTABMenuPrivilege) As Boolean
            If Not objTABMenuPrivilege Is Nothing Then
                Return dalTABMenuPrivilege.UpdateTABMenuPrivilege(objTABMenuPrivilege)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTABMenuPrivilege(ByVal PrivID As Int32) As String
            If PrivID <= 0 Then
                Return ""
            End If

            Return dalTABMenuPrivilege.DeleteTABMenuPrivilege(PrivID)
        End Function

        Public Shared Function GetAllTABMenuPrivilege(ByVal valUserName As String) As DataSet
            Return dalTABMenuPrivilege.GetALLTABMenuPrivilege(valUserName)
        End Function

        Public Shared Function GetAllTABMenuPrivilegeDrop() As SqlDataReader
            Return dalTABMenuPrivilege.GetALLTABMenuPrivilegeDrop()
        End Function

        Public Shared Function GetTABMenuPrivilegeByID(ByVal PrivID As Int32) As PropertyTABMenuPrivilege
            If PrivID <= 0 Then
                Return (Nothing)
            End If

            Return dalTABMenuPrivilege.GetTABMenuPrivilegeByID(PrivID)
        End Function

        Public Shared Function GetTABMenuPrivilegeByMenuID(ByVal MenuID As Int32) As DataSet
            If MenuID <= 0 Then
                Return (Nothing)
            End If

            Return dalTABMenuPrivilege.GetTABMenuPrivilegeByMenuID(MenuID)
        End Function

    End Class

End Namespace
