'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMSuppliers
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

	Public Class clsTabMSuppliers

		Private m_SupplierID As Int32
		Private m_SupplierCode As String
		Private m_SupplierName As String
        Private m_Address1 As String
        Private m_Address2 As String
        Private m_Address3 As String
        Private m_Address4 As String
		Private m_City As String
		Private m_State As String
		Private m_Phone As String
		Private m_Country As String
		Private m_Email As String
		Private m_Fax As String
		Private m_Website As String
        Private m_CompanyID As Int32
        Private m_ShipmentPort As String
        Private m_DestinationPort As String
        Private m_Termsofreturn As String



		Public Property SupplierID() As Int32

			Get
				Return Me.m_SupplierID
			End Get

			Set(ByVal value As Int32)
				Me.m_SupplierID = value
			End Set

		End Property

		Public Property SupplierCode() As String

			Get
				Return Me.m_SupplierCode
			End Get

			Set(ByVal value As String)
				Me.m_SupplierCode = value
			End Set

		End Property

		Public Property SupplierName() As String

			Get
				Return Me.m_SupplierName
			End Get

			Set(ByVal value As String)
				Me.m_SupplierName = value
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
        Public Property Address4() As String

            Get
                Return Me.m_Address4
            End Get

            Set(ByVal value As String)
                Me.m_Address4 = value
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

		Public Property Fax() As String

			Get
				Return Me.m_Fax
			End Get

			Set(ByVal value As String)
				Me.m_Fax = value
			End Set

		End Property

		Public Property Website() As String

			Get
				Return Me.m_Website
			End Get

			Set(ByVal value As String)
				Me.m_Website = value
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
        Public Property ShipmentPort() As String

            Get
                Return Me.m_ShipmentPort
            End Get

            Set(ByVal value As String)
                Me.m_ShipmentPort = value
            End Set

        End Property
        Public Property DestinationPort() As String

            Get
                Return Me.m_DestinationPort
            End Get

            Set(ByVal value As String)
                Me.m_DestinationPort = value
            End Set

        End Property
        Public Property TermsofReturn() As String

            Get
                Return Me.m_Termsofreturn
            End Get

            Set(ByVal value As String)
                Me.m_Termsofreturn = value
            End Set

        End Property

		Public Shared Function Save(ByVal objTabMSuppliers As clsTabMSuppliers) As Boolean
			If Not objTabMSuppliers Is Nothing Then
				If objTabMSuppliers.SupplierID <= 0 Then
					Dim TempId As Integer = dalTabMSuppliers.CreateNewTabMSuppliers(objTabMSuppliers)
					If TempId > 0 Then
						objTabMSuppliers.m_SupplierID = TempId
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

        Public Shared Function UpdateTabMSuppliers(ByVal objTabMSuppliers As clsTabMSuppliers, ByVal SchemaName As String) As Boolean
            If Not objTabMSuppliers Is Nothing Then
                Return dalTabMSuppliers.UpdateTabMSuppliers(objTabMSuppliers, SchemaName)
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMSuppliers(ByVal SupplierID As Int32) As String
			If SupplierID<= 0 Then
				Return ""
			End If

			Return dalTabMSuppliers.DeleteTabMSuppliers(SupplierID)
		End Function

		Public Shared Function GetAllTabMSuppliers(ByVal valUserName As String) As  DataSet
			Return dalTabMSuppliers.GetALLTabMSuppliers(valUserName)
		End Function

		Public Shared Function GetAllTabMSuppliersDrop() As  SqlDataReader
			Return dalTabMSuppliers.GetALLTabMSuppliersDrop()
		End Function

        Public Shared Function GetTabMSuppliersByID(ByVal SupplierID As Int32, ByVal SchemaName As String) As clsTabMSuppliers
            If SupplierID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMSuppliers.GetTabMSuppliersByID(SupplierID, SchemaName)
        End Function

        Public Shared Function GetTabMSuppliersByCompanyID(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMSuppliers.GetTabMSuppliersByCompanyID(CompanyID, EmployeeID, SchemaName)
        End Function

	End Class

End Namespace
