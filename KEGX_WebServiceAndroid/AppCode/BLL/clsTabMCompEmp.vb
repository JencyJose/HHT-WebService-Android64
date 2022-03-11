'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMCompEmp
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:53 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabMCompEmp

		Private m_EmployeeID As Int32
        Private m_CompanyID As Int32
        Private m_RoleID As Int32
        Private m_OrganizationID As Int32



		Public Property EmployeeID() As Int32

			Get
				Return Me.m_EmployeeID
			End Get

			Set(ByVal value As Int32)
				Me.m_EmployeeID = value
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
        Public Property RoleID() As Int32

            Get
                Return Me.m_RoleID
            End Get

            Set(ByVal value As Int32)
                Me.m_RoleID = value
            End Set

        End Property
        Public Property OrganizationID() As Int32

            Get
                Return Me.m_OrganizationID
            End Get

            Set(ByVal value As Int32)
                Me.m_OrganizationID = value
            End Set

        End Property


        Public Shared Function Save(ByVal objTabMCompEmp As clsTabMCompEmp, ByVal SchemaName As String) As Boolean
            If Not objTabMCompEmp Is Nothing Then
                Dim TempId As Integer = dalTabMCompEmp.CreateNewTabMCompEmp(objTabMCompEmp, SchemaName)
                If TempId > 0 Then
                    objTabMCompEmp.m_CompanyID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

		Public Shared Function UpdateTabMCompEmp(ByVal objTabMCompEmp As clsTabMCompEmp) As Boolean
			If Not objTabMCompEmp Is Nothing Then
				Return dalTabMCompEmp.UpdateTabMCompEmp(objTabMCompEmp)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabMCompEmp(ByVal CompanyID As Int32) As String
			If CompanyID<= 0 Then
				Return ""
			End If

			Return dalTabMCompEmp.DeleteTabMCompEmp(CompanyID)
		End Function

		Public Shared Function GetAllTabMCompEmp(ByVal valUserName As String) As  DataSet
			Return dalTabMCompEmp.GetALLTabMCompEmp(valUserName)
		End Function

		Public Shared Function GetAllTabMCompEmpDrop() As  SqlDataReader
			Return dalTabMCompEmp.GetALLTabMCompEmpDrop()
		End Function

		Public Shared Function GetTabMCompEmpByID(ByVal CompanyID As Int32) As clsTabMCompEmp
			If CompanyID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabMCompEmp.GetTabMCompEmpByID(CompanyID)
		End Function

        Public Shared Function GetTabMCompEmpByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCompEmp.GetTabMCompEmpByEmployeeID(EmployeeID, SchemaName)
        End Function

		Public Shared Function GetTabMCompEmpByCompanyID(ByVal CompanyID As Int32) As DataSet
			If CompanyID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabMCompEmp.GetTabMCompEmpByCompanyID(CompanyID)
		End Function
        Public Shared Function GetAllTabMCompEmpOrgByEmployeeID(ByVal valUserName As String, ByVal SchemaName As String) As DataSet
            Return dalTabMCompEmp.GetAllTabMCompEmpOrgByEmployeeID(valUserName, SchemaName)
        End Function
	End Class

End Namespace
