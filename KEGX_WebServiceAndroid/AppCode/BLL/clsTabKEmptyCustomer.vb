'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyCustomer
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:44 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKEmptyCustomer

		Private m_EOrderID As Int32
		Private m_CustomerID As Int32
		Private m_CompanyID As Int32
		Private m_BranchID As Int32
		Private m_ItemID As Int32
		Private m_Quantity As Int32
		Private m_UOMID As Int32
        Private m_Batch As Boolean
		Private m_Barcode As String
		Private m_ReceiveDate As DateTime
		Private m_ReceiveBy As Int32



		Public Property EOrderID() As Int32

			Get
				Return Me.m_EOrderID
			End Get

			Set(ByVal value As Int32)
				Me.m_EOrderID = value
			End Set

		End Property

		Public Property CustomerID() As Int32

			Get
				Return Me.m_CustomerID
			End Get

			Set(ByVal value As Int32)
				Me.m_CustomerID = value
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

		Public Property BranchID() As Int32

			Get
				Return Me.m_BranchID
			End Get

			Set(ByVal value As Int32)
				Me.m_BranchID = value
			End Set

		End Property

		Public Property ItemID() As Int32

			Get
				Return Me.m_ItemID
			End Get

			Set(ByVal value As Int32)
				Me.m_ItemID = value
			End Set

		End Property

		Public Property Quantity() As Int32

			Get
				Return Me.m_Quantity
			End Get

			Set(ByVal value As Int32)
				Me.m_Quantity = value
			End Set

		End Property

		Public Property UOMID() As Int32

			Get
				Return Me.m_UOMID
			End Get

			Set(ByVal value As Int32)
				Me.m_UOMID = value
			End Set

		End Property

        Public Property Batch() As Boolean

            Get
                Return Me.m_Batch
            End Get

            Set(ByVal value As Boolean)
                Me.m_Batch = value
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

		Public Property ReceiveDate() As DateTime

			Get
				Return Me.m_ReceiveDate
			End Get

			Set(ByVal value As DateTime)
				Me.m_ReceiveDate = value
			End Set

		End Property

		Public Property ReceiveBy() As Int32

			Get
				Return Me.m_ReceiveBy
			End Get

			Set(ByVal value As Int32)
				Me.m_ReceiveBy = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabKEmptyCustomer As clsTabKEmptyCustomer) As Boolean
			If Not objTabKEmptyCustomer Is Nothing Then
				If objTabKEmptyCustomer.EOrderID <= 0 Then
					Dim TempId As Integer = dalTabKEmptyCustomer.CreateNewTabKEmptyCustomer(objTabKEmptyCustomer)
					If TempId > 0 Then
						objTabKEmptyCustomer.m_EOrderID = TempId
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

		Public Shared Function UpdateTabKEmptyCustomer(ByVal objTabKEmptyCustomer As clsTabKEmptyCustomer) As Boolean
			If Not objTabKEmptyCustomer Is Nothing Then
				Return dalTabKEmptyCustomer.UpdateTabKEmptyCustomer(objTabKEmptyCustomer)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKEmptyCustomer(ByVal EOrderID As Int32) As String
			If EOrderID<= 0 Then
				Return ""
			End If

			Return dalTabKEmptyCustomer.DeleteTabKEmptyCustomer(EOrderID)
		End Function

		Public Shared Function GetAllTabKEmptyCustomer(ByVal valUserName As String) As  DataSet
			Return dalTabKEmptyCustomer.GetALLTabKEmptyCustomer(valUserName)
		End Function

		Public Shared Function GetAllTabKEmptyCustomerDrop() As  SqlDataReader
			Return dalTabKEmptyCustomer.GetALLTabKEmptyCustomerDrop()
		End Function

		Public Shared Function GetTabKEmptyCustomerByID(ByVal EOrderID As Int32) As clsTabKEmptyCustomer
			If EOrderID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKEmptyCustomer.GetTabKEmptyCustomerByID(EOrderID)
		End Function

		Public Shared Function GetTabKEmptyCustomerByCustomerID(ByVal CustomerID As Int32) As DataSet
			If CustomerID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKEmptyCustomer.GetTabKEmptyCustomerByCustomerID(CustomerID)
		End Function
        Public Shared Function GetAllTabKEmptyCustomerByCompanyID(ByVal CompanyID As Int32) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyCustomer.GetAllTabKEmptyCustomerByCompanyID(CompanyID)
        End Function
	End Class

End Namespace
