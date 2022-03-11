
'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMOrganisationMaster
'Created By         :
'File navigation    :
'Created Date       :January 17, 2014, 2:08:31 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************
Imports System.Data.SqlClient
Imports DAL.TrackITKTS
Imports [Property].TrackITKTS
Namespace TrackITKTS
    Public Class clsTabMOrganisationMaster

        Public Shared Function Save(ByVal objTabMOrganizationMaster As PropertyTabMOrganisationMaster, ByVal SchemaName As String) As Boolean
            If Not objTabMOrganizationMaster Is Nothing Then
                Dim TempId As Integer = dalTabMOrganisationMaster.CreateNewTabMOrganization(objTabMOrganizationMaster, SchemaName)
                If TempId > 0 Then
                    objTabMOrganizationMaster.OrganizationID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

        Public Shared Function UpdateTabMOrganization(ByVal objTabMOrganizationMaster As PropertyTabMOrganisationMaster, ByVal SchemaName As String) As Boolean
            If Not objTabMOrganizationMaster Is Nothing Then
                Return dalTabMOrganisationMaster.UpdateTabMOrganization(objTabMOrganizationMaster, SchemaName)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMOrganization(ByVal OrganizationID As Int32) As String
            If OrganizationID <= 0 Then
                Return ""
            End If

            Return dalTabMOrganisationMaster.DeleteTabMOrganization(OrganizationID)
        End Function

        Public Shared Function GetAllTabMOrganizationMaster(ByVal valUserName As String) As DataSet
            Return dalTabMOrganisationMaster.GetAllTabMOrganizationMaster(valUserName)
        End Function

        Public Shared Function GetAllTabMOrganizationMasterDrop() As SqlDataReader
            Return dalTabMOrganisationMaster.GetAllTabMOrganizationMasterDrop()
        End Function

        Public Shared Function GetTabMOrganizationMasterByID(ByVal OrganizationID As Int32, ByVal SchemaName As String) As PropertyTabMOrganisationMaster
            If OrganizationID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMOrganisationMaster.GetTabMOrganizationMasterByID(OrganizationID, SchemaName)
        End Function

        Public Shared Function GetAllTabMOrganizationMasterByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMOrganisationMaster.GetAllTabMOrganizationMasterByEmployeeID(EmployeeID, SchemaName)
        End Function
        Public Shared Function GetTabMOrganizationMasterByOrgCode(ByVal OrganizationCode As String, ByVal SchemaName As String) As PropertyTabMOrganisationMaster

            Return dalTabMOrganisationMaster.GetTabMOrganizationMasterByOrgCode(OrganizationCode, SchemaName)
        End Function
        Public Shared Function GenerateSchema(ByVal OrgCode As String) As String
            Return dalTabMOrganisationMaster.GenerateSchema(OrgCode)
        End Function
    End Class

End Namespace
