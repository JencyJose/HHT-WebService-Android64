'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabRole
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:01 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabRole

		Private m_RoleID As Int32
		Private m_RoleName As String
		Private m_EnteredBy As Int32
		Private m_EnteredOn As DateTime
        Private m_CompanyID As Int32
        Private m_IsOrganization As Boolean



		Public Property RoleID() As Int32

			Get
				Return Me.m_RoleID
			End Get

			Set(ByVal value As Int32)
				Me.m_RoleID = value
			End Set

		End Property

		Public Property RoleName() As String

			Get
				Return Me.m_RoleName
			End Get

			Set(ByVal value As String)
				Me.m_RoleName = value
			End Set

		End Property

		Public Property EnteredBy() As Int32

			Get
				Return Me.m_EnteredBy
			End Get

			Set(ByVal value As Int32)
				Me.m_EnteredBy = value
			End Set

		End Property

		Public Property EnteredOn() As DateTime

			Get
				Return Me.m_EnteredOn
			End Get

			Set(ByVal value As DateTime)
				Me.m_EnteredOn = value
			End Set

		End Property

		Public Property CompanyID() As Int32

			Get
				Return Me.m_CompanyID
			End Get

			Set(ByVal value As Int32)
				Me.m_CompanyID = value
			End Set

        End Property
        Public Property IsOrganization() As Boolean

            Get
                Return Me.m_IsOrganization
            End Get

            Set(ByVal value As Boolean)
                Me.m_IsOrganization = value
            End Set

        End Property


        Public Shared Function Save(ByVal objTabRole As clsTabRole, ByVal SchemaName As String) As Boolean
            If Not objTabRole Is Nothing Then
                If objTabRole.RoleID <= 0 Then
                    Dim TempId As Integer = dalTabRole.CreateNewTabRole(objTabRole, SchemaName)
                    If TempId > 0 Then
                        objTabRole.m_RoleID = TempId
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

        Public Shared Function UpdateTabRole(ByVal objTabRole As clsTabRole, ByVal SchemaName As String) As Boolean
            If Not objTabRole Is Nothing Then
                Return dalTabRole.UpdateTabRole(objTabRole, SchemaName)
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabRole(ByVal RoleID As Int32) As String
			If RoleID<= 0 Then
				Return ""
			End If

			Return dalTabRole.DeleteTabRole(RoleID)
		End Function

		Public Shared Function GetAllTabRole(ByVal valUserName As String) As  DataSet
			Return dalTabRole.GetALLTabRole(valUserName)
		End Function

		Public Shared Function GetAllTabRoleDrop() As  SqlDataReader
			Return dalTabRole.GetALLTabRoleDrop()
		End Function

        Public Shared Function GetTabRoleByID(ByVal RoleID As Int32, ByVal SchemaName As String) As clsTabRole
            If RoleID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabRole.GetTabRoleByID(RoleID, SchemaName)
        End Function
        Public Shared Function GetAllTabRoleByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabRole.GetAllTabRoleByEmployeeID(EmployeeID, SchemaName)
        End Function
	End Class

End Namespace
