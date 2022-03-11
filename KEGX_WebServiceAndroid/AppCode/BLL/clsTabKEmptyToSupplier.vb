'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyToSupplier
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:46 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKEmptyToSupplier

		Private m_ESOrderID As Int32
		Private m_SupplierID As Int32
		Private m_CompanyID As Int32
		Private m_BranchID As Int32
		Private m_ItemID As Int32
		Private m_Quantity As Int32
		Private m_UOMID As Int32
        Private m_Batch As Boolean
		Private m_Barcode As String
		Private m_TransferDate As DateTime
		Private m_TransferBy As Int32
		Private m_DocumentNumber As String
        Private m_ShippingLine As String
        Private m_SerialNo As String



		Public Property ESOrderID() As Int32

			Get
				Return Me.m_ESOrderID
			End Get

			Set(ByVal value As Int32)
				Me.m_ESOrderID = value
			End Set

		End Property

		Public Property SupplierID() As Int32

			Get
				Return Me.m_SupplierID
			End Get

			Set(ByVal value As Int32)
				Me.m_SupplierID = value
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

		Public Property TransferDate() As DateTime

			Get
				Return Me.m_TransferDate
			End Get

			Set(ByVal value As DateTime)
				Me.m_TransferDate = value
			End Set

		End Property

		Public Property TransferBy() As Int32

			Get
				Return Me.m_TransferBy
			End Get

			Set(ByVal value As Int32)
				Me.m_TransferBy = value
			End Set

		End Property

		Public Property DocumentNumber() As String

			Get
				Return Me.m_DocumentNumber
			End Get

			Set(ByVal value As String)
				Me.m_DocumentNumber = value
			End Set

		End Property

		Public Property ShippingLine() As String

			Get
				Return Me.m_ShippingLine
			End Get

			Set(ByVal value As String)
				Me.m_ShippingLine = value
			End Set

		End Property
        Public Property SerialNo() As String

            Get
                Return Me.m_SerialNo
            End Get

            Set(ByVal value As String)
                Me.m_SerialNo = value
            End Set

        End Property

		Public Shared Function Save(ByVal objTabKEmptyToSupplier As clsTabKEmptyToSupplier) As Boolean
			If Not objTabKEmptyToSupplier Is Nothing Then
				If objTabKEmptyToSupplier.ESOrderID <= 0 Then
					Dim TempId As Integer = dalTabKEmptyToSupplier.CreateNewTabKEmptyToSupplier(objTabKEmptyToSupplier)
					If TempId > 0 Then
						objTabKEmptyToSupplier.m_ESOrderID = TempId
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

		Public Shared Function UpdateTabKEmptyToSupplier(ByVal objTabKEmptyToSupplier As clsTabKEmptyToSupplier) As Boolean
			If Not objTabKEmptyToSupplier Is Nothing Then
				Return dalTabKEmptyToSupplier.UpdateTabKEmptyToSupplier(objTabKEmptyToSupplier)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKEmptyToSupplier(ByVal ESOrderID As Int32) As String
			If ESOrderID<= 0 Then
				Return ""
			End If

			Return dalTabKEmptyToSupplier.DeleteTabKEmptyToSupplier(ESOrderID)
		End Function

		Public Shared Function GetAllTabKEmptyToSupplier(ByVal valUserName As String) As  DataSet
			Return dalTabKEmptyToSupplier.GetALLTabKEmptyToSupplier(valUserName)
		End Function

		Public Shared Function GetAllTabKEmptyToSupplierDrop() As  SqlDataReader
			Return dalTabKEmptyToSupplier.GetALLTabKEmptyToSupplierDrop()
		End Function

		Public Shared Function GetTabKEmptyToSupplierByID(ByVal ESOrderID As Int32) As clsTabKEmptyToSupplier
			If ESOrderID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKEmptyToSupplier.GetTabKEmptyToSupplierByID(ESOrderID)
		End Function

		Public Shared Function GetTabKEmptyToSupplierBySupplierID(ByVal SupplierID As Int32) As DataSet
			If SupplierID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKEmptyToSupplier.GetTabKEmptyToSupplierBySupplierID(SupplierID)
		End Function
        Public Shared Function GetAllTabKEmptyToSupplierByCompanyID(ByVal CompanyID As Int32) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyToSupplier.GetAllTabKEmptyToSupplierByCompanyID(CompanyID)
        End Function
	End Class

End Namespace
