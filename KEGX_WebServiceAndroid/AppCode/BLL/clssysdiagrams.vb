'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clssysdiagrams
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:39 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clssysdiagrams

		Private m_name As String
		Private m_principal_id As Int32
		Private m_diagram_id As Int32
		Private m_version As Int32
		Private m_definition As varbinary



		Public Property name() As String

			Get
				Return Me.m_name
			End Get

			Set(ByVal value As String)
				Me.m_name = value
			End Set

		End Property

		Public Property principal_id() As Int32

			Get
				Return Me.m_principal_id
			End Get

			Set(ByVal value As Int32)
				Me.m_principal_id = value
			End Set

		End Property

		Public Property diagram_id() As Int32

			Get
				Return Me.m_diagram_id
			End Get

			Set(ByVal value As Int32)
				Me.m_diagram_id = value
			End Set

		End Property

		Public Property version() As Int32

			Get
				Return Me.m_version
			End Get

			Set(ByVal value As Int32)
				Me.m_version = value
			End Set

		End Property

		Public Property definition() As varbinary

			Get
				Return Me.m_definition
			End Get

			Set(ByVal value As varbinary)
				Me.m_definition = value
			End Set

		End Property


		Public Shared Function Save(ByVal objsysdiagrams As clssysdiagrams) As Boolean
			If Not objsysdiagrams Is Nothing Then
				If objsysdiagrams.diagram_id <= 0 Then
					Dim TempId As Integer = dalsysdiagrams.CreateNewsysdiagrams(objsysdiagrams)
					If TempId > 0 Then
						objsysdiagrams.m_diagram_id = TempId
						Return True
					Else
						Return False
					End If
				Else
					Return False
				End If
			End If
		End Function

		Public Shared Function Updatesysdiagrams(ByVal objsysdiagrams As clssysdiagrams) As Boolean
			If Not objsysdiagrams Is Nothing Then
				Return dalsysdiagrams.Updatesysdiagrams(objsysdiagrams)
			Else
				Return False
			End If
		End Function

		Public Shared Function Deletesysdiagrams(ByVal diagram_id As Int32) As String
			If diagram_id<= 0 Then
				Return ""
			End If

			Return dalsysdiagrams.Deletesysdiagrams(diagram_id)
		End Function

		Public Shared Function DeletetTest(ByVal diagram_id As Int32)

		End Function

		Public Shared Function GetAllsysdiagrams(ByVal valUserName As String) As  DataSet
			Return dalsysdiagrams.GetALLsysdiagrams(valUserName)
		End Function

		Public Shared Function GetAllsysdiagramsDrop() As  SqlDataReader
			Return dalsysdiagrams.GetALLsysdiagramsDrop()
		End Function

		Public Shared Function GetsysdiagramsByID(ByVal diagram_id As Int32) As clssysdiagrams
			If diagram_id<= 0 Then
				Return (Nothing)
			End If

			Return dalsysdiagrams.GetsysdiagramsByID(diagram_id)
		End Function

	End Class

End Namespace
