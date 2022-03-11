'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMOrganization
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:59 PM
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
Imports System.Web.UI
Namespace TrackITKTS

    Public Class clsTabMOrganization

        Public Shared Function Save(ByVal objTabMOrganization As PropertyTabMOrganization) As Boolean
            If Not objTabMOrganization Is Nothing Then
                If objTabMOrganization.CompanyID <= 0 Then
                    Dim TempId As Integer = dalTabMOrganization.CreateNewTabMOrganization(objTabMOrganization)
                    If TempId > 0 Then
                        objTabMOrganization.CompanyID = TempId
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

        Public Shared Function UpdateTabMOrganization(ByVal objTabMOrganization As PropertyTabMOrganization) As Boolean
            If Not objTabMOrganization Is Nothing Then
                Return dalTabMOrganization.UpdateTabMOrganization(objTabMOrganization)
            Else
                Return False
            End If
        End Function

        Public Shared Function DeleteTabMOrganization(ByVal CompanyID As Int32) As String
            If CompanyID <= 0 Then
                Return ""
            End If

            Return dalTabMOrganization.DeleteTabMOrganization(CompanyID)
        End Function

        Public Shared Function GetAllTabMOrganization(ByVal valUserName As String, ByVal SchemaName As String) As DataSet
            Return dalTabMOrganization.GetALLTabMOrganization(valUserName, SchemaName)
        End Function

        Public Shared Function GetAllTabMOrganizationDrop() As SqlDataReader
            Return dalTabMOrganization.GetALLTabMOrganizationDrop()
        End Function

        Public Shared Function GetTabMOrganizationByID(ByVal CompanyID As Int32, ByVal SchemaName As String) As PropertyTabMOrganization
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMOrganization.GetTabMOrganizationByID(CompanyID, SchemaName)
        End Function


        'Public Shared Function GetSelectedCompanyID(ByRef frmMaster As MasterPage) As String
        '    'Dim cbo As Telerik.Web.UI.RadComboBox = CType(frmMaster.FindControl("rcbCompany"), Telerik.Web.UI.RadComboBox)
        '    'Return cbo.SelectedValue
        '    Return 1
        'End Function

        Public Shared Function GetAllTabMOrganizationByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMOrganization.GetAllTabMOrganizationByEmployeeID(EmployeeID, SchemaName)
        End Function
        Public Shared Function GetTabMOrganizationByCompanyCode(ByVal valCompanyCode As String, ByVal SchemaName As String) As PropertyTabMOrganization

            Return dalTabMOrganization.GetTabMOrganizationByCompanyCode(valCompanyCode, SchemaName)
        End Function

        'Public Shared Function GetSelectedCompanyName(ByRef frmMaster As MasterPage) As String
        '    Dim cbo As Telerik.Web.UI.RadComboBox = CType(frmMaster.FindControl("rcbCompany"), Telerik.Web.UI.RadComboBox)
        '    Return cbo.SelectedItem.Text
        'End Function

    End Class

End Namespace
