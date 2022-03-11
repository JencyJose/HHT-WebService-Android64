'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTABRolePrivileges
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:02 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTABRolePrivileges

		Private m_PrivilegeID As Int32
		Private m_MenuID As Int32
        Private m_AllowView As Boolean
        Private m_AllowAdd As Boolean
        Private m_AllowEdit As Boolean
        Private m_AllowDelete As Boolean
		Private m_RoleID As Int32



		Public Property PrivilegeID() As Int32

			Get
				Return Me.m_PrivilegeID
			End Get

			Set(ByVal value As Int32)
				Me.m_PrivilegeID = value
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

        Public Property AllowView() As Boolean

            Get
                Return Me.m_AllowView
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowView = value
            End Set

        End Property

        Public Property AllowAdd() As Boolean

            Get
                Return Me.m_AllowAdd
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowAdd = value
            End Set

        End Property

        Public Property AllowEdit() As Boolean

            Get
                Return Me.m_AllowEdit
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowEdit = value
            End Set

        End Property

        Public Property AllowDelete() As Boolean

            Get
                Return Me.m_AllowDelete
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowDelete = value
            End Set

        End Property

		Public Property RoleID() As Int32

			Get
				Return Me.m_RoleID
			End Get

			Set(ByVal value As Int32)
				Me.m_RoleID = value
			End Set

		End Property


        Public Shared Function Save(ByVal objTABRolePrivileges As clsTABRolePrivileges, ByVal SchemaName As String) As Boolean
            If Not objTABRolePrivileges Is Nothing Then
                If objTABRolePrivileges.PrivilegeID <= 0 Then
                    Dim TempId As Integer = dalTABRolePrivileges.CreateNewTABRolePrivileges(objTABRolePrivileges, SchemaName)
                    If TempId > 0 Then
                        objTABRolePrivileges.m_PrivilegeID = TempId
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
        Public Shared Function CreateNewTABRolePrivileges_ForDefaultRole(ByVal RoleID As Int32, ByVal SchemaName As String) As Boolean
            Dim TempId As Integer = dalTABRolePrivileges.CreateNewTABRolePrivileges_ForDefaultRole(RoleID, SchemaName)
            If TempId > 0 Then
                Return True
            Else
                Return False
            End If          
        End Function

		Public Shared Function UpdateTABRolePrivileges(ByVal objTABRolePrivileges As clsTABRolePrivileges) As Boolean
			If Not objTABRolePrivileges Is Nothing Then
				Return dalTABRolePrivileges.UpdateTABRolePrivileges(objTABRolePrivileges)
			Else
				Return False
			End If
		End Function

        Public Shared Function DeleteTABRolePrivileges(ByVal RoleID As Int32, ByVal SchemaName As String) As String
            If RoleID <= 0 Then
                Return ""
            End If

            Return dalTABRolePrivileges.DeleteTABRolePrivileges(RoleID, SchemaName)
        End Function

        Public Shared Function GetAllTABRolePrivileges(ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTABRolePrivileges.GetALLTABRolePrivileges(valCompanyID, SchemaName)
        End Function

		Public Shared Function GetAllTABRolePrivilegesDrop() As  SqlDataReader
			Return dalTABRolePrivileges.GetALLTABRolePrivilegesDrop()
		End Function

		Public Shared Function GetTABRolePrivilegesByID(ByVal PrivilegeID As Int32) As clsTABRolePrivileges
			If PrivilegeID<= 0 Then
				Return (Nothing)
			End If

			Return dalTABRolePrivileges.GetTABRolePrivilegesByID(PrivilegeID)
		End Function

		Public Shared Function GetTABRolePrivilegesByMenuID(ByVal MenuID As Int32) As DataSet
			If MenuID<= 0 Then
				Return (Nothing)
			End If

			Return dalTABRolePrivileges.GetTABRolePrivilegesByMenuID(MenuID)
		End Function

		Public Shared Function GetTABRolePrivilegesByRoleID(ByVal RoleID As Int32) As DataSet
			If RoleID<= 0 Then
				Return (Nothing)
			End If

			Return dalTABRolePrivileges.GetTABRolePrivilegesByRoleID(RoleID)
        End Function

        Public Shared Function GetAllTABPrivilegeMasterByRoleID(ByVal RoleID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTABRolePrivileges.GetAllTABPrivilegeMasterByRoleID(RoleID, SchemaName)
        End Function
        Public Shared Function GetAllTABRolePrivilegesByEmployeeID_HHT(ByVal EmployeeID As Int32) As DataSet
            Return dalTABRolePrivileges.GetAllTABRolePrivilegesByEmployeeID_HHT(EmployeeID)
        End Function
	End Class

End Namespace
