'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKSaleOrders
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:51 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKSaleOrders

		Private m_SOrderID As Int32
		Private m_CustomerID As Int32
		Private m_CompanyID As Int32
		Private m_BranchID As Int32
		Private m_ItemID As Int32
		Private m_Quantity As Int32
		Private m_UOMID As Int32
        Private m_Batch As Boolean
		Private m_OrderType As String
		Private m_OrderNumber As String
		Private m_OrderDate As DateTime



		Public Property SOrderID() As Int32

			Get
				Return Me.m_SOrderID
			End Get

			Set(ByVal value As Int32)
				Me.m_SOrderID = value
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

		Public Property OrderType() As String

			Get
				Return Me.m_OrderType
			End Get

			Set(ByVal value As String)
				Me.m_OrderType = value
			End Set

		End Property

		Public Property OrderNumber() As String

			Get
				Return Me.m_OrderNumber
			End Get

			Set(ByVal value As String)
				Me.m_OrderNumber = value
			End Set

		End Property

		Public Property OrderDate() As DateTime

			Get
				Return Me.m_OrderDate
			End Get

			Set(ByVal value As DateTime)
				Me.m_OrderDate = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabKSaleOrders As clsTabKSaleOrders) As Boolean
			If Not objTabKSaleOrders Is Nothing Then
				If objTabKSaleOrders.SOrderID <= 0 Then
					Dim TempId As Integer = dalTabKSaleOrders.CreateNewTabKSaleOrders(objTabKSaleOrders)
					If TempId > 0 Then
						objTabKSaleOrders.m_SOrderID = TempId
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

		Public Shared Function UpdateTabKSaleOrders(ByVal objTabKSaleOrders As clsTabKSaleOrders) As Boolean
			If Not objTabKSaleOrders Is Nothing Then
				Return dalTabKSaleOrders.UpdateTabKSaleOrders(objTabKSaleOrders)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabKSaleOrders(ByVal SOrderID As Int32) As String
			If SOrderID<= 0 Then
				Return ""
			End If

			Return dalTabKSaleOrders.DeleteTabKSaleOrders(SOrderID)
		End Function

		Public Shared Function GetAllTabKSaleOrders(ByVal valUserName As String) As  DataSet
			Return dalTabKSaleOrders.GetALLTabKSaleOrders(valUserName)
		End Function

		Public Shared Function GetAllTabKSaleOrdersDrop() As  SqlDataReader
			Return dalTabKSaleOrders.GetALLTabKSaleOrdersDrop()
		End Function

		Public Shared Function GetTabKSaleOrdersByID(ByVal SOrderID As Int32) As clsTabKSaleOrders
			If SOrderID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKSaleOrders.GetTabKSaleOrdersByID(SOrderID)
		End Function

		Public Shared Function GetTabKSaleOrdersByCustomerID(ByVal CustomerID As Int32) As DataSet
			If CustomerID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabKSaleOrders.GetTabKSaleOrdersByCustomerID(CustomerID)
		End Function
        Public Shared Function GetAllTabKSaleOrdersByCompanyID(ByVal CompanyID As Int32, ByVal SchemaName As String) As DataSet
            If CompanyID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetAllTabKSaleOrdersByCompanyID(CompanyID, SchemaName)
        End Function
        Public Shared Function GetAllTabKSaleOrdersByEmployeeID(ByVal EmployeeID As Int32) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrders.GetAllTabKSaleOrdersByEmployeeID(EmployeeID)
        End Function
	End Class

End Namespace
