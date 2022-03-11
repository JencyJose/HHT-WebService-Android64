'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabKSaleOrderBarcode
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:50 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabKSaleOrderBarcode

		Private m_SOrderID As Int32
		Private m_CustomerID As Int32
		Private m_Barcode As String
		Private m_ItemID As Int32
		Private m_Quantity As Int32
		Private m_UOMID As Int32
		Private m_PrintedOn As DateTime
		Private m_PrintedBy As Int32
        Private m_Verified As Boolean



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

		Public Property Barcode() As String

			Get
				Return Me.m_Barcode
			End Get

			Set(ByVal value As String)
				Me.m_Barcode = value
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

		Public Property PrintedOn() As DateTime

			Get
				Return Me.m_PrintedOn
			End Get

			Set(ByVal value As DateTime)
				Me.m_PrintedOn = value
			End Set

		End Property

		Public Property PrintedBy() As Int32

			Get
				Return Me.m_PrintedBy
			End Get

			Set(ByVal value As Int32)
				Me.m_PrintedBy = value
			End Set

		End Property

        Public Property Verified() As Boolean

            Get
                Return Me.m_Verified
            End Get

            Set(ByVal value As Boolean)
                Me.m_Verified = value
            End Set

        End Property


        Public Shared Function Save(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As Boolean
            If Not objTabKSaleOrderBarcode Is Nothing Then
                Dim TempId As Integer = dalTabKSaleOrderBarcode.CreateNewTabKSaleOrderBarcode(objTabKSaleOrderBarcode)
                If TempId > 0 Then
                    objTabKSaleOrderBarcode.m_SOrderID = TempId
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        End Function

        Public Shared Function UpdateTabKSaleOrderBarcode(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As Boolean
            If Not objTabKSaleOrderBarcode Is Nothing Then
                Return dalTabKSaleOrderBarcode.UpdateTabKSaleOrderBarcode(objTabKSaleOrderBarcode)
            Else
                Return False
            End If
        End Function

        'Public Shared Function DeleteTabKSaleOrderBarcode(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As String
        '    Return dalTabKSaleOrderBarcode.DeleteTabKSaleOrderBarcode()
        'End Function

        Public Shared Function GetAllTabKSaleOrderBarcode(ByVal valUserName As String) As DataSet
            Return dalTabKSaleOrderBarcode.GetALLTabKSaleOrderBarcode(valUserName)
        End Function

        Public Shared Function GetAllTabKSaleOrderBarcodeDrop() As SqlDataReader
            Return dalTabKSaleOrderBarcode.GetALLTabKSaleOrderBarcodeDrop()
        End Function

        'Public Shared Function GetTabKSaleOrderBarcodeByID(ByVal objTabKSaleOrderBarcode As clsTabKSaleOrderBarcode) As clsTabKSaleOrderBarcode
        '    Return dalTabKSaleOrderBarcode.GetTabKSaleOrderBarcodeByID(objTabKSaleOrderBarcode)
        'End Function

        Public Shared Function GetTabKSaleOrderBarcodeBySOrderID(ByVal SOrderID As Int32) As DataSet
            If SOrderID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrderBarcode.GetTabKSaleOrderBarcodeBySOrderID(SOrderID)
        End Function
        Public Shared Function GetAllTabKSaleOrderBarcodeByEmployeeID(ByVal EmployeeID As Int32) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabKSaleOrderBarcode.GetAllTabKSaleOrderBarcodeByEmployeeID(EmployeeID)
        End Function
	End Class

End Namespace
