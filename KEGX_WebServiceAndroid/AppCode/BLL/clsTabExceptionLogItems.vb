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

Namespace TrackITKTS

	Public Class clsTabExceptionLogItems

		Private m_EventId As Int32
		Private m_LogDateTime As DateTime
		Private m_Source As String
		Private m_Message As String
		Private m_QueryString As String
		Private m_TargetSite As String
		Private m_StackTrace As String
		Private m_ServerName As String
		Private m_RequestURL As String
		Private m_UserAgent As String
		Private m_UserIP As String
		Private m_UserAuthentication As String
		Private m_UserName As String



		Public Property EventId() As Int32

			Get
				Return Me.m_EventId
			End Get

			Set(ByVal value As Int32)
				Me.m_EventId = value
			End Set

		End Property

		Public Property LogDateTime() As DateTime

			Get
				Return Me.m_LogDateTime
			End Get

			Set(ByVal value As DateTime)
				Me.m_LogDateTime = value
			End Set

		End Property

		Public Property Source() As String

			Get
				Return Me.m_Source
			End Get

			Set(ByVal value As String)
				Me.m_Source = value
			End Set

		End Property

		Public Property Message() As String

			Get
				Return Me.m_Message
			End Get

			Set(ByVal value As String)
				Me.m_Message = value
			End Set

		End Property

		Public Property QueryString() As String

			Get
				Return Me.m_QueryString
			End Get

			Set(ByVal value As String)
				Me.m_QueryString = value
			End Set

		End Property

		Public Property TargetSite() As String

			Get
				Return Me.m_TargetSite
			End Get

			Set(ByVal value As String)
				Me.m_TargetSite = value
			End Set

		End Property

		Public Property StackTrace() As String

			Get
				Return Me.m_StackTrace
			End Get

			Set(ByVal value As String)
				Me.m_StackTrace = value
			End Set

		End Property

		Public Property ServerName() As String

			Get
				Return Me.m_ServerName
			End Get

			Set(ByVal value As String)
				Me.m_ServerName = value
			End Set

		End Property

		Public Property RequestURL() As String

			Get
				Return Me.m_RequestURL
			End Get

			Set(ByVal value As String)
				Me.m_RequestURL = value
			End Set

		End Property

		Public Property UserAgent() As String

			Get
				Return Me.m_UserAgent
			End Get

			Set(ByVal value As String)
				Me.m_UserAgent = value
			End Set

		End Property

		Public Property UserIP() As String

			Get
				Return Me.m_UserIP
			End Get

			Set(ByVal value As String)
				Me.m_UserIP = value
			End Set

		End Property

		Public Property UserAuthentication() As String

			Get
				Return Me.m_UserAuthentication
			End Get

			Set(ByVal value As String)
				Me.m_UserAuthentication = value
			End Set

		End Property

		Public Property UserName() As String

			Get
				Return Me.m_UserName
			End Get

			Set(ByVal value As String)
				Me.m_UserName = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabExceptionLogItems As clsTabExceptionLogItems) As Boolean
			If Not objTabExceptionLogItems Is Nothing Then
				If objTabExceptionLogItems.EventId <= 0 Then
					Dim TempId As Integer = dalTabExceptionLogItems.CreateNewTabExceptionLogItems(objTabExceptionLogItems)
					If TempId > 0 Then
						objTabExceptionLogItems.m_EventId = TempId
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

		Public Shared Function UpdateTabExceptionLogItems(ByVal objTabExceptionLogItems As clsTabExceptionLogItems) As Boolean
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

		Public Shared Function GetTabExceptionLogItemsByID(ByVal EventId As Int32) As clsTabExceptionLogItems
			If EventId<= 0 Then
				Return (Nothing)
			End If

			Return dalTabExceptionLogItems.GetTabExceptionLogItemsByID(EventId)
		End Function

	End Class

End Namespace
