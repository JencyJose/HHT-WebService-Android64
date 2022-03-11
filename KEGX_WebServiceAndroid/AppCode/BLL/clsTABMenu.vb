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

Namespace TrackITKTS

	Public Class clsTABMenu

		Private m_MenuID As Int32
		Private m_Feature_en As String
		Private m_Feature_ar As String
		Private m_Description As String
		Private m_ParentID As Int32
		Private m_NavigateURL As String
		Private m_FeatureType As Char
        Private m_Imp_View As Boolean
        Private m_Imp_New As Boolean
        Private m_Imp_Edit As Boolean
        Private m_Imp_Delete As Boolean



		Public Property MenuID() As Int32

			Get
				Return Me.m_MenuID
			End Get

			Set(ByVal value As Int32)
				Me.m_MenuID = value
			End Set

		End Property

		Public Property Feature_en() As String

			Get
				Return Me.m_Feature_en
			End Get

			Set(ByVal value As String)
				Me.m_Feature_en = value
			End Set

		End Property

		Public Property Feature_ar() As String

			Get
				Return Me.m_Feature_ar
			End Get

			Set(ByVal value As String)
				Me.m_Feature_ar = value
			End Set

		End Property

		Public Property Description() As String

			Get
				Return Me.m_Description
			End Get

			Set(ByVal value As String)
				Me.m_Description = value
			End Set

		End Property

		Public Property ParentID() As Int32

			Get
				Return Me.m_ParentID
			End Get

			Set(ByVal value As Int32)
				Me.m_ParentID = value
			End Set

		End Property

		Public Property NavigateURL() As String

			Get
				Return Me.m_NavigateURL
			End Get

			Set(ByVal value As String)
				Me.m_NavigateURL = value
			End Set

		End Property

		Public Property FeatureType() As Char

			Get
				Return Me.m_FeatureType
			End Get

			Set(ByVal value As Char)
				Me.m_FeatureType = value
			End Set

		End Property

        Public Property Imp_View() As Boolean

            Get
                Return Me.m_Imp_View
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_View = value
            End Set

        End Property

        Public Property Imp_New() As Boolean

            Get
                Return Me.m_Imp_New
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_New = value
            End Set

        End Property

        Public Property Imp_Edit() As Boolean

            Get
                Return Me.m_Imp_Edit
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_Edit = value
            End Set

        End Property

        Public Property Imp_Delete() As Boolean

            Get
                Return Me.m_Imp_Delete
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_Delete = value
            End Set

        End Property


		Public Shared Function Save(ByVal objTABMenu As clsTABMenu) As Boolean
			If Not objTABMenu Is Nothing Then
				If objTABMenu.MenuID <= 0 Then
					Dim TempId As Integer = dalTABMenu.CreateNewTABMenu(objTABMenu)
					If TempId > 0 Then
						objTABMenu.m_MenuID = TempId
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

		Public Shared Function UpdateTABMenu(ByVal objTABMenu As clsTABMenu) As Boolean
			If Not objTABMenu Is Nothing Then
				Return dalTABMenu.UpdateTABMenu(objTABMenu)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTABMenu(ByVal MenuID As Int32) As String
			If MenuID<= 0 Then
				Return ""
			End If

			Return dalTABMenu.DeleteTABMenu(MenuID)
		End Function

		Public Shared Function GetAllTABMenu(ByVal valUserName As String) As  DataSet
			Return dalTABMenu.GetALLTABMenu(valUserName)
		End Function

		Public Shared Function GetAllTABMenuDrop() As  SqlDataReader
			Return dalTABMenu.GetALLTABMenuDrop()
		End Function

		Public Shared Function GetTABMenuByID(ByVal MenuID As Int32) As clsTABMenu
			If MenuID<= 0 Then
				Return (Nothing)
			End If

			Return dalTABMenu.GetTABMenuByID(MenuID)
		End Function

	End Class

End Namespace
