'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMEmpRole
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

	Public Class clsTabMEmpRole

		Private m_EmployeeID As Int32
		Private m_RoleID As Int32



		Public Property EmployeeID() As Int32

			Get
				Return Me.m_EmployeeID
			End Get

			Set(ByVal value As Int32)
				Me.m_EmployeeID = value
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


        'Public Shared Function Save(ByVal objTabMEmpRole As clsTabMEmpRole) As Boolean
        '	If Not objTabMEmpRole Is Nothing Then
        '			Dim TempId As Integer = dalTabMEmpRole.CreateNewTabMEmpRole(objTabMEmpRole)
        '			If TempId > 0 Then
        '				objTabMEmpRole.m_ = TempId
        '				Return True
        '			Else
        '				Return False
        '			End If
        '		Else
        '			Return False
        '		End If
        '	End If
        'End Function

        'Public Shared Function UpdateTabMEmpRole(ByVal objTabMEmpRole As clsTabMEmpRole) As Boolean
        '	If Not objTabMEmpRole Is Nothing Then
        '		Return dalTabMEmpRole.UpdateTabMEmpRole(objTabMEmpRole)
        '	Else
        '		Return False
        '	End If
        'End Function

        'Public Shared Function DeleteTabMEmpRole(ByVal  As ) As String
        '	Return dalTabMEmpRole.DeleteTabMEmpRole()
        'End Function

        'Public Shared Function DeletetTest(ByVal  As )

        'End Function

        'Public Shared Function GetAllTabMEmpRole(ByVal valUserName As String) As  DataSet
        '	Return dalTabMEmpRole.GetALLTabMEmpRole(valUserName)
        'End Function

        'Public Shared Function GetAllTabMEmpRoleDrop() As  SqlDataReader
        '	Return dalTabMEmpRole.GetALLTabMEmpRoleDrop()
        'End Function

        'Public Shared Function GetTabMEmpRoleByID(ByVal  As ) As clsTabMEmpRole
        '	Return dalTabMEmpRole.GetTabMEmpRoleByID()
        'End Function

	End Class

End Namespace
