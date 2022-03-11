'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMEmployees
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:56 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabMEmployees

		Private m_EmployeeID As Int32
		Private m_EmployeeName As String
		Private m_EmployeeNo As String
		Private m_CompanyID As Int32
		Private m_Position As String
		Private m_Phone As String
		Private m_Email As String
		Private m_Comments As String
		Private m_Show As String
		Private m_UserName As String
		Private m_Password As String
		Private m_RoleID As Int32
		Private m_ChangedBy As String
		Private m_Disable As String
		Private m_Reason As String
		Private m_Logged As String
		Private m_Mobile As String
		Private m_EmpPhoto As Byte()
        Private m_Thumbnail As Byte()
        Private m_IsOrganization As Boolean
        Private m_SchemaName As String
       


		Public Property EmployeeID() As Int32

			Get
				Return Me.m_EmployeeID
			End Get

			Set(ByVal value As Int32)
				Me.m_EmployeeID = value
			End Set

		End Property

		Public Property EmployeeName() As String

			Get
				Return Me.m_EmployeeName
			End Get

			Set(ByVal value As String)
				Me.m_EmployeeName = value
			End Set

		End Property

		Public Property EmployeeNo() As String

			Get
				Return Me.m_EmployeeNo
			End Get

			Set(ByVal value As String)
				Me.m_EmployeeNo = value
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

		Public Property Position() As String

			Get
				Return Me.m_Position
			End Get

			Set(ByVal value As String)
				Me.m_Position = value
			End Set

		End Property

		Public Property Phone() As String

			Get
				Return Me.m_Phone
			End Get

			Set(ByVal value As String)
				Me.m_Phone = value
			End Set

		End Property

		Public Property Email() As String

			Get
				Return Me.m_Email
			End Get

			Set(ByVal value As String)
				Me.m_Email = value
			End Set

		End Property

		Public Property Comments() As String

			Get
				Return Me.m_Comments
			End Get

			Set(ByVal value As String)
				Me.m_Comments = value
			End Set

		End Property

		Public Property Show() As String

			Get
				Return Me.m_Show
			End Get

			Set(ByVal value As String)
				Me.m_Show = value
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

		Public Property Password() As String

			Get
				Return Me.m_Password
			End Get

			Set(ByVal value As String)
				Me.m_Password = value
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

		Public Property ChangedBy() As String

			Get
				Return Me.m_ChangedBy
			End Get

			Set(ByVal value As String)
				Me.m_ChangedBy = value
			End Set

		End Property

		Public Property Disable() As String

			Get
				Return Me.m_Disable
			End Get

			Set(ByVal value As String)
				Me.m_Disable = value
			End Set

		End Property

		Public Property Reason() As String

			Get
				Return Me.m_Reason
			End Get

			Set(ByVal value As String)
				Me.m_Reason = value
			End Set

		End Property

		Public Property Logged() As String

			Get
				Return Me.m_Logged
			End Get

			Set(ByVal value As String)
				Me.m_Logged = value
			End Set

		End Property

		Public Property Mobile() As String

			Get
				Return Me.m_Mobile
			End Get

			Set(ByVal value As String)
				Me.m_Mobile = value
			End Set

		End Property

		Public Property EmpPhoto() As Byte()

			Get
				Return Me.m_EmpPhoto
			End Get

			Set(ByVal value As Byte())
				Me.m_EmpPhoto = value
			End Set

		End Property

		Public Property Thumbnail() As Byte()

			Get
				Return Me.m_Thumbnail
			End Get

			Set(ByVal value As Byte())
				Me.m_Thumbnail = value
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
        Public Property SchemaName() As String

            Get
                Return Me.m_SchemaName
            End Get

            Set(ByVal value As String)
                Me.m_SchemaName = value
            End Set

        End Property

        Public Shared Function Save(ByVal objTabMEmployees As clsTabMEmployees, ByVal SchemaName As String) As Boolean
            If Not objTabMEmployees Is Nothing Then
                If objTabMEmployees.EmployeeID <= 0 Then
                    Dim TempId As Integer = dalTabMEmployees.CreateNewTabMEmployees(objTabMEmployees, SchemaName)
                    If TempId > 0 Then
                        objTabMEmployees.m_EmployeeID = TempId
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

        Public Shared Function UpdateTabMEmployees(ByVal objTabMEmployees As clsTabMEmployees, ByVal SchemaName As String) As Boolean
            If Not objTabMEmployees Is Nothing Then
                Return dalTabMEmployees.UpdateTabMEmployees(objTabMEmployees, SchemaName)
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMEmployees(ByVal EmployeeID As Int32) As String
			If EmployeeID<= 0 Then
				Return ""
			End If

			Return dalTabMEmployees.DeleteTabMEmployees(EmployeeID)
		End Function

        Public Shared Function GetAllTabMEmployees(ByVal valUserName As String, ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMEmployees.GetALLTabMEmployees(valUserName, valCompanyID, SchemaName)
        End Function

		Public Shared Function GetAllTabMEmployeesDrop() As  SqlDataReader
			Return dalTabMEmployees.GetALLTabMEmployeesDrop()
		End Function

        Public Shared Function GetTabMEmployeesByID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As clsTabMEmployees
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMEmployees.GetTabMEmployeesByID(EmployeeID, SchemaName)
        End Function
        Public Shared Function GetAllTabMEmployeesByEmployeeName(ByVal valEmployeeName As String, ByVal SchemaName As String) As clsTabMEmployees

            Return dalTabMEmployees.GetAllTabMEmployeesByEmployeeName(valEmployeeName, SchemaName)
        End Function
        Public Shared Function GetAllTabMEmployeesByUserName(ByVal valUserName As String, ByVal SchemaName As String) As clsTabMEmployees

            Return dalTabMEmployees.GetAllTabMEmployeesByUserName(valUserName, SchemaName)
        End Function

		Public Shared Function GetTabMEmployeesByCompanyID(ByVal CompanyID As Int32) As DataSet
           
			Return dalTabMEmployees.GetTabMEmployeesByCompanyID(CompanyID)
		End Function

		Public Shared Function GetTabMEmployeesByRoleID(ByVal RoleID As Int32) As DataSet
			If RoleID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabMEmployees.GetTabMEmployeesByRoleID(RoleID)
		End Function
        Public Shared Function chkValidUser(ByVal objATSUsers As clsTabMEmployees) As Hashtable
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.chkValidUser(objATSUsers)
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function UpdateTabMEmployees_LoggedIn(ByVal objTabMEmployees As clsTabMEmployees, ByVal SchemaName As String) As Boolean
            If Not objTabMEmployees Is Nothing Then
                Return dalTabMEmployees.UpdateTabMEmployees_LoggedIn(objTabMEmployees, SchemaName)
            Else
                Return False
            End If
        End Function

        Public Shared Function GetAllTABUserPrivilegesByEmployeeID(ByVal EmployeeID As Int32, ByVal CompanyID As Int32, ByVal OrganizationID As Int32, ByVal SchemaName As String) As Hashtable
            If EmployeeID > 0 Then
                Return dalTabMEmployees.GetAllTABUserPrivilegesByEmployeeID(EmployeeID, CompanyID, OrganizationID, SchemaName)
            Else
                Return Nothing
            End If
        End Function
        Public Shared Function GetAllTABUserPrivilegesByEmployeeID_Menu(ByVal EmployeeID As Int32, ByVal CompanyID As Int32, ByVal OrganizationID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMEmployees.GetAllTABUserPrivilegesByEmployeeID_Menu(EmployeeID, CompanyID, OrganizationID, SchemaName)
        End Function
        Public Shared Function UpdateATSUserPassword(ByVal objATSUsers As clsTabMEmployees, ByVal oldPass As String) As Boolean
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.UpdateATSUserPassword(objATSUsers, oldPass)
            Else
                Return False
            End If
        End Function
        Public Shared Function GetEmployeeCompanyAndRoles(ByVal objATSUsers As clsTabMEmployees, ByVal SchemaName As String) As Hashtable
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.GetEmployeeCompanyAndRoles(objATSUsers, SchemaName)
            Else
                Return Nothing
            End If
        End Function
	End Class

End Namespace
