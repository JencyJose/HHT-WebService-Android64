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

Namespace TrackITKTS

	Public Class clsTabMOrganization

		Private m_CompanyID As Int32
		Private m_CompanyCode As String
		Private m_CompanyName As String
        Private m_Address1 As String
        Private m_Address2 As String
        Private m_Address3 As String
		Private m_City As String
		Private m_State As String
		Private m_Phone As String
		Private m_Country As String
		Private m_Email As String
		Private m_CompanyImage As Byte()
		Private m_Thumbnail As Byte()



		Public Property CompanyID() As Int32

			Get
				Return Me.m_CompanyID
			End Get

			Set(ByVal value As Int32)
				Me.m_CompanyID = value
			End Set

		End Property

		Public Property CompanyCode() As String

			Get
				Return Me.m_CompanyCode
			End Get

			Set(ByVal value As String)
				Me.m_CompanyCode = value
			End Set

		End Property

		Public Property CompanyName() As String

			Get
				Return Me.m_CompanyName
			End Get

			Set(ByVal value As String)
				Me.m_CompanyName = value
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
        Public Property Address3() As String

            Get
                Return Me.m_Address3
            End Get

            Set(ByVal value As String)
                Me.m_Address3 = value
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

		Public Property CompanyImage() As Byte()

			Get
				Return Me.m_CompanyImage
			End Get

			Set(ByVal value As Byte())
				Me.m_CompanyImage = value
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


		Public Shared Function Save(ByVal objTabMOrganization As clsTabMOrganization) As Boolean
			If Not objTabMOrganization Is Nothing Then
				If objTabMOrganization.CompanyID <= 0 Then
					Dim TempId As Integer = dalTabMOrganization.CreateNewTabMOrganization(objTabMOrganization)
					If TempId > 0 Then
						objTabMOrganization.m_CompanyID = TempId
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

		Public Shared Function UpdateTabMOrganization(ByVal objTabMOrganization As clsTabMOrganization) As Boolean
			If Not objTabMOrganization Is Nothing Then
				Return dalTabMOrganization.UpdateTabMOrganization(objTabMOrganization)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabMOrganization(ByVal CompanyID As Int32) As String
			If CompanyID<= 0 Then
				Return ""
			End If

			Return dalTabMOrganization.DeleteTabMOrganization(CompanyID)
		End Function


        Public Shared Function GetAllTabMOrganization(ByVal valUserName As String, ByVal SchemaName As String) As DataSet
            Return dalTabMOrganization.GetALLTabMOrganization(valUserName, SchemaName)
        End Function

		Public Shared Function GetAllTabMOrganizationDrop() As  SqlDataReader
			Return dalTabMOrganization.GetALLTabMOrganizationDrop()
		End Function

        Public Shared Function GetTabMOrganizationByID(ByVal CompanyID As Int32, ByVal SchemaName As String) As clsTabMOrganization
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMOrganization.GetTabMOrganizationByID(CompanyID, SchemaName)
        End Function
       

        Public Shared Function GetSelectedCompanyID(ByRef frmMaster As MasterPage) As String
            Dim cbo As Telerik.Web.UI.RadComboBox = CType(frmMaster.FindControl("rcbCompany"), Telerik.Web.UI.RadComboBox)
            Return cbo.SelectedValue
        End Function
        Public Shared Function GetAllTabMOrganizationByEmployeeID(ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMOrganization.GetAllTabMOrganizationByEmployeeID(EmployeeID, SchemaName)
        End Function
	End Class
    
End Namespace
