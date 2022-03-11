'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKEmptyTransferBP
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:48 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKEmptyTransferBP

		Private m_EBPOrderID As Int32
		Private m_FromBranchID As Int32
		Private m_ToBranchID As Int32
		Private m_CompanyID As Int32
		Private m_ItemID As Int32
		Private m_Quantity As Int32
		Private m_UOMID As Int32
        Private m_Batch As Boolean
		Private m_Barcode As String
		Private m_TransferDate As DateTime
		Private m_TransferBy As Int32
		Private m_ReceiveDate As DateTime
		Private m_ReceiveBy As Int32
		Private m_ReceiveQty As Int32
		Private m_ContainerNumber As String



		Public Property EBPOrderID() As Int32

			Get
				Return Me.m_EBPOrderID
			End Get

			Set(ByVal value As Int32)
				Me.m_EBPOrderID = value
			End Set

		End Property

		Public Property FromBranchID() As Int32

			Get
				Return Me.m_FromBranchID
			End Get

			Set(ByVal value As Int32)
				Me.m_FromBranchID = value
			End Set

		End Property

		Public Property ToBranchID() As Int32

			Get
				Return Me.m_ToBranchID
			End Get

			Set(ByVal value As Int32)
				Me.m_ToBranchID = value
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

		Public Property ReceiveQty() As Int32

			Get
				Return Me.m_ReceiveQty
			End Get

			Set(ByVal value As Int32)
				Me.m_ReceiveQty = value
			End Set

		End Property

		Public Property ContainerNumber() As String

			Get
				Return Me.m_ContainerNumber
			End Get

			Set(ByVal value As String)
				Me.m_ContainerNumber = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabKEmptyTransferBP As clsTabKEmptyTransferBP) As Boolean
			If Not objTabKEmptyTransferBP Is Nothing Then
				If objTabKEmptyTransferBP.EBPOrderID <= 0 Then
					Dim TempId As Integer = dalTabKEmptyTransferBP.CreateNewTabKEmptyTransferBP(objTabKEmptyTransferBP)
					If TempId > 0 Then
						objTabKEmptyTransferBP.m_EBPOrderID = TempId
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

		Public Shared Function UpdateTabKEmptyTransferBP(ByVal objTabKEmptyTransferBP As clsTabKEmptyTransferBP) As Boolean
			If Not objTabKEmptyTransferBP Is Nothing Then
				Return dalTabKEmptyTransferBP.UpdateTabKEmptyTransferBP(objTabKEmptyTransferBP)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKEmptyTransferBP(ByVal EBPOrderID As Int32) As String
			If EBPOrderID<= 0 Then
				Return ""
			End If

			Return dalTabKEmptyTransferBP.DeleteTabKEmptyTransferBP(EBPOrderID)
		End Function

		Public Shared Function GetAllTabKEmptyTransferBP(ByVal valUserName As String) As  DataSet
			Return dalTabKEmptyTransferBP.GetALLTabKEmptyTransferBP(valUserName)
		End Function

		Public Shared Function GetAllTabKEmptyTransferBPDrop() As  SqlDataReader
			Return dalTabKEmptyTransferBP.GetALLTabKEmptyTransferBPDrop()
		End Function

		Public Shared Function GetTabKEmptyTransferBPByID(ByVal EBPOrderID As Int32) As clsTabKEmptyTransferBP
			If EBPOrderID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByID(EBPOrderID)
		End Function

		Public Shared Function GetTabKEmptyTransferBPByFromBranchID(ByVal FromBranchID As Int32) As DataSet
			If FromBranchID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByFromBranchID(FromBranchID)
        End Function
        Public Shared Function GetTabKEmptyTransferBPByFromToBranchID(ByVal FromBranchID As Int32, ByVal ToBranchID As Int32) As DataSet

            Return dalTabKEmptyTransferBP.GetTabKEmptyTransferBPByFromToBranchID(FromBranchID, ToBranchID)

        End Function
        Public Shared Function GetAllTabKEmptyTransferBPByCompanyID(ByVal CompanyID As Int32) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetAllTabKEmptyTransferBPByCompanyID(CompanyID)
        End Function
        Public Shared Function GetAllTabKEmptyReceiveBPByCompanyID(ByVal CompanyID As Int32) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKEmptyTransferBP.GetAllTabKEmptyReceiveBPByCompanyID(CompanyID)
        End Function
	End Class

End Namespace
