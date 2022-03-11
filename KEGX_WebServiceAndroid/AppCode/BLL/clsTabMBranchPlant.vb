'***************************************************************
'Application        :TrackIT Asset Tracking System
'File Name          :clsTabMBranchPlant
'Created By         :Hari Prasad
'File navigation    :
'Created Date       :11/19/2013 12:45:53 PM
'Description        :This file contains business logic details and get the data from data access layer...
'Modified By        :
'Modified Date      :
'***************************************************************

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Namespace TrackITKTS

	Public Class clsTabMBranchPlant

		Private m_BranchID As Int32
		Private m_BranchCode As String
		Private m_BranchName As String
        Private m_Batch As Boolean
		Private m_CompanyID As Int32
        Private m_Address1 As String
        Private m_Address2 As String
        Private m_Address3 As String
        Private m_Address4 As String



		Public Property BranchID() As Int32

			Get
				Return Me.m_BranchID
			End Get

			Set(ByVal value As Int32)
				Me.m_BranchID = value
			End Set

		End Property

		Public Property BranchCode() As String

			Get
				Return Me.m_BranchCode
			End Get

			Set(ByVal value As String)
				Me.m_BranchCode = value
			End Set

		End Property

		Public Property BranchName() As String

			Get
				Return Me.m_BranchName
			End Get

			Set(ByVal value As String)
				Me.m_BranchName = value
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

		Public Property CompanyID() As Int32

			Get
				Return Me.m_CompanyID
			End Get

			Set(ByVal value As Int32)
				Me.m_CompanyID = value
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


		Public Shared Function Save(ByVal objTabMBranchPlant As clsTabMBranchPlant) As Boolean
			If Not objTabMBranchPlant Is Nothing Then
				If objTabMBranchPlant.BranchID <= 0 Then
					Dim TempId As Integer = dalTabMBranchPlant.CreateNewTabMBranchPlant(objTabMBranchPlant)
					If TempId > 0 Then
						objTabMBranchPlant.m_BranchID = TempId
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

		Public Shared Function UpdateTabMBranchPlant(ByVal objTabMBranchPlant As clsTabMBranchPlant) As Boolean
			If Not objTabMBranchPlant Is Nothing Then
				Return dalTabMBranchPlant.UpdateTabMBranchPlant(objTabMBranchPlant)
			Else
				Return False
			End If
		End Function

		Public Shared Function DeleteTabMBranchPlant(ByVal BranchID As Int32) As String
			If BranchID<= 0 Then
				Return ""
			End If

			Return dalTabMBranchPlant.DeleteTabMBranchPlant(BranchID)
		End Function

		Public Shared Function GetAllTabMBranchPlant(ByVal valUserName As String) As  DataSet
			Return dalTabMBranchPlant.GetALLTabMBranchPlant(valUserName)
		End Function

		Public Shared Function GetAllTabMBranchPlantDrop() As  SqlDataReader
			Return dalTabMBranchPlant.GetALLTabMBranchPlantDrop()
		End Function

		Public Shared Function GetTabMBranchPlantByID(ByVal BranchID As Int32) As clsTabMBranchPlant
			If BranchID<= 0 Then
				Return (Nothing)
			End If

			Return dalTabMBranchPlant.GetTabMBranchPlantByID(BranchID)
		End Function

        Public Shared Function GetTabMBranchPlantByCompanyID(ByVal CompanyID As Int32, ByVal EmployeeID As Int32, ByVal SchemaName As String) As DataSet
            Return dalTabMBranchPlant.GetTabMBranchPlantByCompanyID(CompanyID, EmployeeID, SchemaName)
        End Function

	End Class

End Namespace
