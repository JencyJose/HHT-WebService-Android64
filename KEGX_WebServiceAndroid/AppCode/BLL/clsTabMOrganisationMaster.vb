Imports System.Data.SqlClient

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
Namespace TrackITKTS
    Public Class clsTabMOrganisationMaster
        Private m_OrganizationID As Int32
        Private m_OrganizationCode As String
        Private m_OrganizationName As String
        Private m_Address1 As String
        Private m_City As String
        Private m_State As String
        Private m_Phone As String
        Private m_Country As String
        Private m_Email As String
        Private m_OrganizationImage As Byte()
        Private m_Thumbnail As Byte()
        Private m_Address2 As String
        Public Property OrganizationID() As Int32

            Get
                Return Me.m_OrganizationID
            End Get

            Set(ByVal value As Int32)
                Me.m_OrganizationID = value
            End Set

        End Property

        Public Property OrganizationCode() As String

            Get
                Return Me.m_OrganizationCode
            End Get

            Set(ByVal value As String)
                Me.m_OrganizationCode = value
            End Set

        End Property

        Public Property OrganizationName() As String

            Get
                Return Me.m_OrganizationName
            End Get

            Set(ByVal value As String)
                Me.m_OrganizationName = value
            End Set

        End Property

        Public Property Address1() As String

            Get
                Return Me.m_Address1
            End Get

            Set(ByVal value As String)
                Me.m_Address1 = value
            End Set

        End Property
        Public Property Address2() As String

            Get
                Return Me.m_Address2
            End Get

            Set(ByVal value As String)
                Me.m_Address2 = value
            End Set

        End Property

        Public Property City() As String

            Get
                Return Me.m_City
            End Get

            Set(ByVal value As String)
                Me.m_City = value
            End Set

        End Property

        Public Property State() As String

            Get
                Return Me.m_State
            End Get

            Set(ByVal value As String)
                Me.m_State = value
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

        Public Property Country() As String

            Get
                Return Me.m_Country
            End Get

            Set(ByVal value As String)
                Me.m_Country = value
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

        Public Property OrganizationImage() As Byte()

            Get
                Return Me.m_OrganizationImage
            End Get

            Set(ByVal value As Byte())
                Me.m_OrganizationImage = value
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

        Public Shared Function Save(ByVal objTabMOrganizationMaster As clsTabMOrganisationMaster, ByVal SchemaName As String) As Boolean
            If Not objTabMOrganizationMaster Is Nothing Then
                Dim TempId As Integer = dalTabMOrganisationMaster.CreateNewTabMOrganization(objTabMOrganizationMaster, SchemaName)
                If TempId > 0 Then
                    objTabMOrganizationMaster.m_OrganizationID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function

        Public Shared Function UpdateTabMOrganization(ByVal objTabMOrganizationMaster As clsTabMOrganisationMaster, ByVal SchemaName As String) As Boolean
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

        Public Shared Function GetTabMOrganizationMasterByID(ByVal OrganizationID As Int32, ByVal SchemaName As String) As clsTabMOrganisationMaster
            If OrganizationID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMOrganisationMaster.GetTabMOrganizationMasterByID(OrganizationID, SchemaName)
        End Function

        Public Shared Function GetAllTabMOrganizationMasterByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
           
            Return dalTabMOrganisationMaster.GetAllTabMOrganizationMasterByEmployeeID(EmployeeID, SchemaName)
        End Function
        Public Shared Function GetTabMOrganizationMasterByOrgCode(ByVal OrganizationCode As String, ByVal SchemaName As String) As clsTabMOrganisationMaster
           
            Return dalTabMOrganisationMaster.GetTabMOrganizationMasterByOrgCode(OrganizationCode, SchemaName)
        End Function
    End Class

End Namespace
