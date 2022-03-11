'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabExceptionLogItems
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:41 PM
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

	Public Class clsTabExceptionLogItems

        Public Shared Function Save(ByVal objTabExceptionLogItems As PropertyTabExceptionLogItems) As Boolean
            If Not objTabExceptionLogItems Is Nothing Then
                If objTabExceptionLogItems.EventId <= 0 Then
                    Dim TempId As Integer = dalTabExceptionLogItems.CreateNewTabExceptionLogItems(objTabExceptionLogItems)
                    If TempId > 0 Then
                        objTabExceptionLogItems.EventId = TempId
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

        Public Shared Function UpdateTabExceptionLogItems(ByVal objTabExceptionLogItems As PropertyTabExceptionLogItems) As Boolean
            If Not objTabExceptionLogItems Is Nothing Then
                Return dalTabExceptionLogItems.UpdateTabExceptionLogItems(objTabExceptionLogItems)
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabExceptionLogItems(ByVal EventId As Int32) As String
			If EventId<= 0 Then
				Return ""
			End If

			Return dalTabExceptionLogItems.DeleteTabExceptionLogItems(EventId)
		End Function

		Public Shared Function GetAllTabExceptionLogItems(ByVal valUserName As String) As  DataSet
			Return dalTabExceptionLogItems.GetALLTabExceptionLogItems(valUserName)
		End Function

		Public Shared Function GetAllTabExceptionLogItemsDrop() As  SqlDataReader
			Return dalTabExceptionLogItems.GetALLTabExceptionLogItemsDrop()
		End Function

        Public Shared Function GetTabExceptionLogItemsByID(ByVal EventId As Int32) As PropertyTabExceptionLogItems
            If EventId <= 0 Then
                Return (Nothing)
            End If

            Return dalTabExceptionLogItems.GetTabExceptionLogItemsByID(EventId)
        End Function

	End Class

End Namespace
