'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMCustomers
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:54 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabMCustomers

		Private m_CustomerID As Int32
		Private m_CustomerCode As String
		Private m_CustomerName As String
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
        Private m_LOB As String
        Private m_Channel As String
        Private m_SoldtoParty As String
        Private m_ShiptoParty As String
        Private m_CollectionFrequency As String
        Private m_Region As String
        Private m_IsPartner As Boolean
        Private m_UserName As String
        Private m_Password As String
        Private m_Barcode As String



		Public Property CustomerID() As Int32

			Get
				Return Me.m_CustomerID
			End Get

			Set(ByVal value As Int32)
				Me.m_CustomerID = value
			End Set

		End Property

		Public Property CustomerCode() As String

			Get
				Return Me.m_CustomerCode
			End Get

			Set(ByVal value As String)
				Me.m_CustomerCode = value
			End Set

		End Property

		Public Property CustomerName() As String

			Get
				Return Me.m_CustomerName
			End Get

			Set(ByVal value As String)
				Me.m_CustomerName = value
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
        Public Property LOB() As String

            Get
                Return Me.m_LOB
            End Get

            Set(ByVal value As String)
                Me.m_LOB = value
            End Set

        End Property
        Public Property Channel() As String

            Get
                Return Me.m_Channel
            End Get

            Set(ByVal value As String)
                Me.m_Channel = value
            End Set

        End Property
        Public Property SoldtoParty() As String

            Get
                Return Me.m_SoldtoParty
            End Get

            Set(ByVal value As String)
                Me.m_SoldtoParty = value
            End Set

        End Property
        Public Property ShiptoParty() As String

            Get
                Return Me.m_ShiptoParty
            End Get

            Set(ByVal value As String)
                Me.m_ShiptoParty = value
            End Set

        End Property
        Public Property Region() As String

            Get
                Return Me.m_Region
            End Get

            Set(ByVal value As String)
                Me.m_Region = value
            End Set

        End Property
        Public Property IsPartner() As Boolean

            Get
                Return Me.m_IsPartner
            End Get

            Set(ByVal value As Boolean)
                Me.m_IsPartner = value
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
        Public Property CollectionFrequency() As String

            Get
                Return Me.m_CollectionFrequency
            End Get

            Set(ByVal value As String)
                Me.m_CollectionFrequency = value
            End Set

        End Property
        Public Property Barcode() As String

            Get
                Return Me.m_Barcode
            End Get

            Set(ByVal value As String)
                Me.m_Barcode = value
            End Set

        End Property

		Public Shared Function Save(ByVal objTabMCustomers As clsTabMCustomers) As Boolean
			If Not objTabMCustomers Is Nothing Then
				If objTabMCustomers.CustomerID <= 0 Then
					Dim TempId As Integer = dalTabMCustomers.CreateNewTabMCustomers(objTabMCustomers)
					If TempId > 0 Then
						objTabMCustomers.m_CustomerID = TempId
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

        Public Shared Function UpdateTabMCustomers(ByVal objTabMCustomers As clsTabMCustomers, ByVal SchemaName As String) As Boolean
            If Not objTabMCustomers Is Nothing Then
                Return dalTabMCustomers.UpdateTabMCustomers(objTabMCustomers, SchemaName)
            Else
                Return False
            End If
        End Function

		Public Shared Function DeleteTabMCustomers(ByVal CustomerID As Int32) As String
			If CustomerID<= 0 Then
				Return ""
			End If

			Return dalTabMCustomers.DeleteTabMCustomers(CustomerID)
		End Function

		Public Shared Function GetAllTabMCustomers(ByVal valUserName As String) As  DataSet
			Return dalTabMCustomers.GetALLTabMCustomers(valUserName)
		End Function

		Public Shared Function GetAllTabMCustomersDrop() As  SqlDataReader
			Return dalTabMCustomers.GetALLTabMCustomersDrop()
		End Function

        Public Shared Function GetTabMCustomersByID(ByVal CustomerID As Int32, ByVal SchemaName As String) As clsTabMCustomers
            If CustomerID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabMCustomers.GetTabMCustomersByID(CustomerID, SchemaName)
        End Function

        Public Shared Function GetTabMCustomersByCompanyID(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet

            Return dalTabMCustomers.GetTabMCustomersByCompanyID(CompanyID, EmployeeID, SchemaName)
        End Function

	End Class

End Namespace
