'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabUOMMaster
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:46:03 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabUOMMaster

		Private m_UOMID As Int32
		Private m_ItemCode As String
		Private m_PrimayUOM As String
		Private m_RelatedUOM As String
		Private m_ItemID As Int32
		Private m_Factor As String



		Public Property UOMID() As Int32

			Get
				Return Me.m_UOMID
			End Get

			Set(ByVal value As Int32)
				Me.m_UOMID = value
			End Set

		End Property

		Public Property ItemCode() As String

			Get
				Return Me.m_ItemCode
			End Get

			Set(ByVal value As String)
				Me.m_ItemCode = value
			End Set

		End Property

		Public Property PrimayUOM() As String

			Get
				Return Me.m_PrimayUOM
			End Get

			Set(ByVal value As String)
				Me.m_PrimayUOM = value
			End Set

		End Property

		Public Property RelatedUOM() As String

			Get
				Return Me.m_RelatedUOM
			End Get

			Set(ByVal value As String)
				Me.m_RelatedUOM = value
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

		Public Property Factor() As String

			Get
				Return Me.m_Factor
			End Get

			Set(ByVal value As String)
				Me.m_Factor = value
			End Set

		End Property


		Public Shared Function Save(ByVal objTabUOMMaster As clsTabUOMMaster) As Boolean
			If Not objTabUOMMaster Is Nothing Then
				If objTabUOMMaster.UOMID <= 0 Then
					Dim TempId As Integer = dalTabUOMMaster.CreateNewTabUOMMaster(objTabUOMMaster)
					If TempId > 0 Then
						objTabUOMMaster.m_UOMID = TempId
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

		Public Shared Function UpdateTabUOMMaster(ByVal objTabUOMMaster As clsTabUOMMaster) As Boolean
			If Not objTabUOMMaster Is Nothing Then
				Return dalTabUOMMaster.UpdateTabUOMMaster(objTabUOMMaster)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabUOMMaster(ByVal UOMID As Int32) As String
			If UOMID<= 0 Then
				Return ""
			End If

			Return dalTabUOMMaster.DeleteTabUOMMaster(UOMID)
		End Function

		Public Shared Function GetAllTabUOMMaster(ByVal valUserName As String) As  DataSet
			Return dalTabUOMMaster.GetALLTabUOMMaster(valUserName)
		End Function

		Public Shared Function GetAllTabUOMMasterDrop() As  SqlDataReader
			Return dalTabUOMMaster.GetALLTabUOMMasterDrop()
		End Function

		Public Shared Function GetTabUOMMasterByID(ByVal UOMID As Int32) As clsTabUOMMaster
			If UOMID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabUOMMaster.GetTabUOMMasterByID(UOMID)
		End Function

		Public Shared Function GetTabUOMMasterByItemID(ByVal ItemID As Int32) As DataSet
			If ItemID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabUOMMaster.GetTabUOMMasterByItemID(ItemID)
		End Function
        Public Shared Function GetTabUOMMasterByItemCode(ByVal ItemCode As String, ByVal SchemaName As String) As DataSet
            If ItemCode = "" Then
                Return (Nothing)
            End If
            Return dalTabUOMMaster.GetTabUOMMasterByItemCode(ItemCode, SchemaName)
        End Function
        Public Shared Function GetTabUOMMasterByEmployeeID(ByVal EmployeeID As Int32) As DataSet
            If EmployeeID <= 0 Then
                Return (Nothing)
            End If

            Return dalTabUOMMaster.GetTabUOMMasterByEmployeeID(EmployeeID)
        End Function
	End Class
   
End Namespace
