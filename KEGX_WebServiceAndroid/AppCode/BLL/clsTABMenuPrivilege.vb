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

Namespace TrackITKTS

	Public Class clsTABMenuPrivilege

		Private m_PrivID As Int32
		Private m_PrivilegeName_en As String
		Private m_PrivilegeName_ar As String
		Private m_Seq As Int32
		Private m_MenuID As Int32
        Private m_Mandatory As Boolean
        Private m_UserDefined As Boolean



		Public Property PrivID() As Int32

			Get
				Return Me.m_PrivID
			End Get

			Set(ByVal value As Int32)
				Me.m_PrivID = value
			End Set

		End Property

		Public Property PrivilegeName_en() As String

			Get
				Return Me.m_PrivilegeName_en
			End Get

			Set(ByVal value As String)
				Me.m_PrivilegeName_en = value
			End Set

		End Property

		Public Property PrivilegeName_ar() As String

			Get
				Return Me.m_PrivilegeName_ar
			End Get

			Set(ByVal value As String)
				Me.m_PrivilegeName_ar = value
			End Set

		End Property

		Public Property Seq() As Int32

			Get
				Return Me.m_Seq
			End Get

			Set(ByVal value As Int32)
				Me.m_Seq = value
			End Set

		End Property

		Public Property MenuID() As Int32

			Get
				Return Me.m_MenuID
			End Get

			Set(ByVal value As Int32)
				Me.m_MenuID = value
			End Set

		End Property

        Public Property Mandatory() As Boolean

            Get
                Return Me.m_Mandatory
            End Get

            Set(ByVal value As Boolean)
                Me.m_Mandatory = value
            End Set

        End Property

        Public Property UserDefined() As Boolean

            Get
                Return Me.m_UserDefined
            End Get

            Set(ByVal value As Boolean)
                Me.m_UserDefined = value
            End Set

        End Property


		Public Shared Function Save(ByVal objTABMenuPrivilege As clsTABMenuPrivilege) As Boolean
			If Not objTABMenuPrivilege Is Nothing Then
				If objTABMenuPrivilege.PrivID <= 0 Then
					Dim TempId As Integer = dalTABMenuPrivilege.CreateNewTABMenuPrivilege(objTABMenuPrivilege)
					If TempId > 0 Then
						objTABMenuPrivilege.m_PrivID = TempId
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

		Public Shared Function UpdateTABMenuPrivilege(ByVal objTABMenuPrivilege As clsTABMenuPrivilege) As Boolean
			If Not objTABMenuPrivilege Is Nothing Then
				Return dalTABMenuPrivilege.UpdateTABMenuPrivilege(objTABMenuPrivilege)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTABMenuPrivilege(ByVal PrivID As Int32) As String
			If PrivID<= 0 Then
				Return ""
			End If

			Return dalTABMenuPrivilege.DeleteTABMenuPrivilege(PrivID)
		End Function

		Public Shared Function GetAllTABMenuPrivilege(ByVal valUserName As String) As  DataSet
			Return dalTABMenuPrivilege.GetALLTABMenuPrivilege(valUserName)
		End Function

		Public Shared Function GetAllTABMenuPrivilegeDrop() As  SqlDataReader
			Return dalTABMenuPrivilege.GetALLTABMenuPrivilegeDrop()
		End Function

		Public Shared Function GetTABMenuPrivilegeByID(ByVal PrivID As Int32) As clsTABMenuPrivilege
			If PrivID<= 0 Then
				Return (Nothing)
			End If

			Return dalTABMenuPrivilege.GetTABMenuPrivilegeByID(PrivID)
		End Function

		Public Shared Function GetTABMenuPrivilegeByMenuID(ByVal MenuID As Int32) As DataSet
			If MenuID<= 0 Then
				Return (Nothing)
			End If

			Return dalTABMenuPrivilege.GetTABMenuPrivilegeByMenuID(MenuID)
		End Function

	End Class

End Namespace
