'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKBPTransferBP
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:43 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKBPTransferBP

		Private m_TOrderID As Int32
		Private m_CompanyID As Int32
		Private m_ItemID As Int32
		Private m_FromBranchID As Int32
		Private m_ToBranchID As Int32
		Private m_LotDetails As String
		Private m_LotStatus As String
		Private m_Location As String
		Private m_UOMID As Int32
		Private m_OnHandQuantity As Int32
		Private m_DamagedQuantity As Int32
		Private m_TransitQuantity As Int32
		Private m_ReceivedDate As DateTime



		Public Property TOrderID() As Int32

			Get
				Return Me.m_TOrderID
			End Get

			Set(ByVal value As Int32)
				Me.m_TOrderID = value
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

		Public Property LotDetails() As String

			Get
				Return Me.m_LotDetails
			End Get

			Set(ByVal value As String)
				Me.m_LotDetails = value
			End Set

		End Property

		Public Property LotStatus() As String

			Get
				Return Me.m_LotStatus
			End Get

			Set(ByVal value As String)
				Me.m_LotStatus = value
			End Set

		End Property

		Public Property Location() As String

			Get
				Return Me.m_Location
			End Get

			Set(ByVal value As String)
				Me.m_Location = value
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

		Public Property OnHandQuantity() As Int32

			Get
				Return Me.m_OnHandQuantity
			End Get

			Set(ByVal value As Int32)
				Me.m_OnHandQuantity = value
			End Set

		End Property

		Public Property DamagedQuantity() As Int32

			Get
				Return Me.m_DamagedQuantity
			End Get

			Set(ByVal value As Int32)
				Me.m_DamagedQuantity = value
			End Set

		End Property

		Public Property TransitQuantity() As Int32

			Get
				Return Me.m_TransitQuantity
			End Get

			Set(ByVal value As Int32)
				Me.m_TransitQuantity = value
			End Set

		End Property

		Public Property ReceivedDate() As DateTime

			Get
				Return Me.m_ReceivedDate
			End Get

			Set(ByVal value As DateTime)
				Me.m_ReceivedDate = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabKBPTransferBP As clsTabKBPTransferBP) As Boolean
			If Not objTabKBPTransferBP Is Nothing Then
				If objTabKBPTransferBP.TOrderID <= 0 Then
					Dim TempId As Integer = dalTabKBPTransferBP.CreateNewTabKBPTransferBP(objTabKBPTransferBP)
					If TempId > 0 Then
						objTabKBPTransferBP.m_TOrderID = TempId
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

		Public Shared Function UpdateTabKBPTransferBP(ByVal objTabKBPTransferBP As clsTabKBPTransferBP) As Boolean
			If Not objTabKBPTransferBP Is Nothing Then
				Return dalTabKBPTransferBP.UpdateTabKBPTransferBP(objTabKBPTransferBP)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKBPTransferBP(ByVal TOrderID As Int32) As String
			If TOrderID<= 0 Then
				Return ""
			End If

			Return dalTabKBPTransferBP.DeleteTabKBPTransferBP(TOrderID)
		End Function

		Public Shared Function GetAllTabKBPTransferBP(ByVal valUserName As String) As  DataSet
			Return dalTabKBPTransferBP.GetALLTabKBPTransferBP(valUserName)
		End Function

		Public Shared Function GetAllTabKBPTransferBPDrop() As  SqlDataReader
			Return dalTabKBPTransferBP.GetALLTabKBPTransferBPDrop()
		End Function

		Public Shared Function GetTabKBPTransferBPByID(ByVal TOrderID As Int32) As clsTabKBPTransferBP
			If TOrderID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKBPTransferBP.GetTabKBPTransferBPByID(TOrderID)
		End Function

		Public Shared Function GetTabKBPTransferBPByFromBranchID(ByVal FromBranchID As Int32) As DataSet
			If FromBranchID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKBPTransferBP.GetTabKBPTransferBPByFromBranchID(FromBranchID)
		End Function
        Public Shared Function GetAllTabKBPTransferBPByCompanyID(ByVal CompanyID As Int32) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKBPTransferBP.GetAllTabKBPTransferBPByCompanyID(CompanyID)
        End Function
	End Class

End Namespace
