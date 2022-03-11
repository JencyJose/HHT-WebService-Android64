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
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS

	Public Class clsTabRole

        Public Shared Function Save(ByVal objTabRole As PropertyTabRole, ByVal SchemaName As String) As Boolean
            If Not objTabRole Is Nothing Then
                If objTabRole.RoleID <= 0 Then
                    Dim TempId As Integer = dalTabRole.CreateNewTabRole(objTabRole, SchemaName)
                    If TempId > 0 Then
                        objTabRole.RoleID = TempId
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

        Public Shared Function UpdateTabRole(ByVal objTabRole As PropertyTabRole, ByVal SchemaName As String) As Boolean
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

        Public Shared Function GetTabRoleByID(ByVal RoleID As Int32, ByVal SchemaName As String) As PropertyTabRole
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
