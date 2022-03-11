'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTABMenu
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:57 PM
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

    Public Class clsTABMenu

        Public Shared Function Save(ByVal objTABMenu As PropertyTABMenu) As Boolean
            If Not objTABMenu Is Nothing Then
                If objTABMenu.MenuID <= 0 Then
                    Dim TempId As Integer = dalTABMenu.CreateNewTABMenu(objTABMenu)
                    If TempId > 0 Then
                        objTABMenu.MenuID = TempId
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

        Public Shared Function UpdateTABMenu(ByVal objTABMenu As PropertyTABMenu) As Boolean
            If Not objTABMenu Is Nothing Then
                Return dalTABMenu.UpdateTABMenu(objTABMenu)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTABMenu(ByVal MenuID As Int32) As String
            If MenuID <= 0 Then
                Return ""
            End If

            Return dalTABMenu.DeleteTABMenu(MenuID)
        End Function

        Public Shared Function GetAllTABMenu(ByVal valUserName As String) As DataSet
            Return dalTABMenu.GetALLTABMenu(valUserName)
        End Function

        Public Shared Function GetAllTABMenuDrop() As SqlDataReader
            Return dalTABMenu.GetALLTABMenuDrop()
        End Function

        Public Shared Function GetTABMenuByID(ByVal MenuID As Int32) As PropertyTABMenu
            If MenuID <= 0 Then
                Return (Nothing)
            End If

            Return dalTABMenu.GetTABMenuByID(MenuID)
        End Function

    End Class

End Namespace
