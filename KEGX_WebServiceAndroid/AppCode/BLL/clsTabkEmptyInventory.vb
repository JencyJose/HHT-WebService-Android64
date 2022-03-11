
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Namespace TrackITKTS
    Public Class clsTabkEmptyInventory

        Private m_InventoryID As Int32
        Private m_CompanyID As Int32
        Private m_EntityID As Int32
        Private m_EntityTypeID As Int32
        Private m_ItemID As Int32
        Private m_UOMID As Int32
        Private m_OnHandQuantity As Int32
        Private m_DamagedQuantity As Int32
        Private m_TransitQuantity As Int32

        Public Property InventoryID() As Int32

            Get
                Return Me.m_InventoryID
            End Get

            Set(ByVal value As Int32)
                Me.m_InventoryID = value
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
        Public Property EntityID() As Int32

            Get
                Return Me.m_EntityID
            End Get

            Set(ByVal value As Int32)
                Me.m_EntityID = value
            End Set

        End Property
        Public Property EntityTypeID() As Int32

            Get
                Return Me.m_EntityTypeID
            End Get

            Set(ByVal value As Int32)
                Me.m_EntityTypeID = value
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
        Public Shared Function Save(ByVal objTabKEInventory As clsTabkEmptyInventory, ByVal SchemaName As String) As Boolean
            If Not objTabKEInventory Is Nothing Then
                If objTabKEInventory.InventoryID <= 0 Then
                    Dim TempId As Integer = dalTabkEmptyInventory.CreateNewTabKEmptyInventory(objTabKEInventory, SchemaName)
                    If TempId > 0 Then
                        objTabKEInventory.m_InventoryID = TempId
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

    End Class
End Namespace

