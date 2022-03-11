'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKSupplierReceive
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:52 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKSupplierReceive

		Private m_OrderID As Int32
		Private m_CompanyID As Int32
		Private m_SupplierID As Int32
		Private m_ItemID As Int32
		Private m_BranchID As Int32
		Private m_Quantity As Int32
		Private m_UOMID As Int32
		Private m_ReceivedDate As DateTime
		Private m_ContainerNumber As String
		Private m_BOLNumber As String



		Public Property OrderID() As Int32

			Get
				Return Me.m_OrderID
			End Get

			Set(ByVal value As Int32)
				Me.m_OrderID = value
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

		Public Property SupplierID() As Int32

			Get
				Return Me.m_SupplierID
			End Get

			Set(ByVal value As Int32)
				Me.m_SupplierID = value
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

		Public Property BranchID() As Int32

			Get
				Return Me.m_BranchID
			End Get

			Set(ByVal value As Int32)
				Me.m_BranchID = value
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

		Public Property ReceivedDate() As DateTime

			Get
				Return Me.m_ReceivedDate
			End Get

			Set(ByVal value As DateTime)
				Me.m_ReceivedDate = value
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

		Public Property BOLNumber() As String

			Get
				Return Me.m_BOLNumber
			End Get

			Set(ByVal value As String)
				Me.m_BOLNumber = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabKSupplierReceive As clsTabKSupplierReceive) As Boolean
			If Not objTabKSupplierReceive Is Nothing Then
				If objTabKSupplierReceive.OrderID <= 0 Then
					Dim TempId As Integer = dalTabKSupplierReceive.CreateNewTabKSupplierReceive(objTabKSupplierReceive)
					If TempId > 0 Then
						objTabKSupplierReceive.m_OrderID = TempId
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

		Public Shared Function UpdateTabKSupplierReceive(ByVal objTabKSupplierReceive As clsTabKSupplierReceive) As Boolean
			If Not objTabKSupplierReceive Is Nothing Then
				Return dalTabKSupplierReceive.UpdateTabKSupplierReceive(objTabKSupplierReceive)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKSupplierReceive(ByVal OrderID As Int32) As String
			If OrderID<= 0 Then
				Return ""
			End If

			Return dalTabKSupplierReceive.DeleteTabKSupplierReceive(OrderID)
		End Function

		Public Shared Function GetAllTabKSupplierReceive(ByVal valUserName As String) As  DataSet
			Return dalTabKSupplierReceive.GetALLTabKSupplierReceive(valUserName)
		End Function

		Public Shared Function GetAllTabKSupplierReceiveDrop() As  SqlDataReader
			Return dalTabKSupplierReceive.GetALLTabKSupplierReceiveDrop()
		End Function

		Public Shared Function GetTabKSupplierReceiveByID(ByVal OrderID As Int32) As clsTabKSupplierReceive
			If OrderID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKSupplierReceive.GetTabKSupplierReceiveByID(OrderID)
		End Function

		Public Shared Function GetTabKSupplierReceiveBySupplierID(ByVal SupplierID As Int32) As DataSet
			If SupplierID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKSupplierReceive.GetTabKSupplierReceiveBySupplierID(SupplierID)
		End Function
        Public Shared Function GetTabKSupplierReceiveByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSupplierReceive.GetTabKSupplierReceiveByCompanyID(CompanyID, SchemaName)
        End Function
	End Class

End Namespace
