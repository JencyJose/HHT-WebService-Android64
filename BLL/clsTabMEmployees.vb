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
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS

    Public Class clsTabMEmployees

        Public Shared Function Save(ByVal objTabMEmployees As PropertyTabMEmployees, ByVal SchemaName As String) As Boolean
            If Not objTabMEmployees Is Nothing Then

                Dim TempId As Integer = dalTabMEmployees.CreateNewTabMEmployees(objTabMEmployees, SchemaName)
                If TempId > 0 Then
                    objTabMEmployees.EmployeeID = TempId
                    Return True
                Else
                    Return False
                End If

            Else
                Return False
            End If
        End Function

        Public Shared Function UpdateTabMEmployees(ByVal objTabMEmployees As PropertyTabMEmployees, ByVal SchemaName As String) As Boolean
            If Not objTabMEmployees Is Nothing Then
                Return dalTabMEmployees.UpdateTabMEmployees(objTabMEmployees, SchemaName)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMEmployees(ByVal EmployeeID As Int32) As String
            If EmployeeID <= 0 Then
                Return ""
            End If

            Return dalTabMEmployees.DeleteTabMEmployees(EmployeeID)
        End Function

        Public Shared Function GetAllTabMEmployees(ByVal valUserName As String, ByVal valCompanyID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMEmployees.GetALLTabMEmployees(valUserName, valCompanyID, SchemaName)
        End Function
        Public Shared Function GetAllTabMEmployeesByEmployeeID(ByVal valUserName As String, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMEmployees.GetALLTabMEmployeesByEmployeeID(valUserName, EmployeeID, SchemaName)
        End Function

        Public Shared Function GetAllTabMEmployeesDrop() As SqlDataReader
            Return dalTabMEmployees.GetALLTabMEmployeesDrop()
        End Function

        Public Shared Function GetTabMEmployeesByID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As PropertyTabMEmployees
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMEmployees.GetTabMEmployeesByID(EmployeeID, SchemaName)
        End Function
        Public Shared Function GetAllTabMEmployeesByEmployeeName(ByVal valEmployeeName As String, ByVal SchemaName As String) As PropertyTabMEmployees

            Return dalTabMEmployees.GetAllTabMEmployeesByEmployeeName(valEmployeeName, SchemaName)
        End Function
        Public Shared Function GetAllTabMEmployeesByUserName(ByVal valUserName As String, ByVal SchemaName As String) As PropertyTabMEmployees

            Return dalTabMEmployees.GetAllTabMEmployeesByUserName(valUserName, SchemaName)
        End Function

        Public Shared Function GetTabMEmployeesByCompanyID(ByVal CompanyID As Int32) As DataSet

            Return dalTabMEmployees.GetTabMEmployeesByCompanyID(CompanyID)
        End Function

        Public Shared Function GetTabMEmployeesByRoleID(ByVal RoleID As Int32) As DataSet
            If RoleID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMEmployees.GetTabMEmployeesByRoleID(RoleID)
        End Function
        Public Shared Function chkValidUser(ByVal objATSUsers As PropertyTabMEmployees) As Hashtable
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.chkValidUser(objATSUsers)
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function ValidateAzureADUser(UserName As String) As Hashtable
            Return dalTabMEmployees.ValidateAzureADUser(UserName)
        End Function

        Public Shared Function UpdateTabMEmployees_LoggedIn(ByVal objTabMEmployees As PropertyTabMEmployees, ByVal SchemaName As String) As Boolean
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
        Public Shared Function UpdateATSUserPassword(ByVal objATSUsers As PropertyTabMEmployees, ByVal oldPass As String, ByVal SchemaName As String) As Boolean
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.UpdateATSUserPassword(objATSUsers, oldPass, SchemaName)
            Else
                Return False
            End If
        End Function
        Public Shared Function GetEmployeeCompanyAndRoles(ByVal objATSUsers As PropertyTabMEmployees, ByVal SchemaName As String) As Hashtable
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.GetEmployeeCompanyAndRoles(objATSUsers, SchemaName)
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function GetEmployeeCompanyAndRolesAzureAD(ByVal objATSUsers As PropertyTabMEmployees, ByVal SchemaName As String) As Hashtable
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.GetEmployeeCompanyAndRolesAzureAD(objATSUsers, SchemaName)
            Else
                Return Nothing
            End If
        End Function

        'HHT Methods
        Public Shared Function ChkUserValidityHHT(ByVal objATSUsers As PropertyTabMEmployees) As DataSet
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.ChkUserValidity(objATSUsers)
            Else
                Return Nothing
            End If
        End Function
        Public Shared Function GetEmployeeCompanyAndRolesHHT(ByVal objATSUsers As PropertyTabMEmployees, ByVal SchemaName As String) As DataSet
            If Not objATSUsers Is Nothing Then
                Return dalTabMEmployees.GetEmployeeCompanyAndRolesHHT(objATSUsers, SchemaName)
            Else
                Return Nothing
            End If
        End Function
        Public Shared Function GetAllTABUserPrivilegesByEmployeeID_HHTMenu(ByVal EmployeeID As Int32, ByVal CompanyID As Int32, ByVal OrganizationID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMEmployees.GetAllTABUserPrivilegesByEmployeeID_HHTMenu(EmployeeID, CompanyID, OrganizationID, SchemaName)
        End Function
    End Class
End Namespace
