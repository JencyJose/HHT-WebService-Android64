Namespace TrackITKTS
    Public Class PropertyTabKInventory
        Private m_LotID As Int32
        Private m_LotDetails As String
        Private m_LotStatus As String
        Private m_Location As String
        Private m_CompanyID As Int32
        Private m_BranchID As Int32
        Private m_ItemID As Int32
        Private m_UOMID As Int32
        Private m_OnHandQuantity As Int32
        Private m_DamagedQuantity As Int32
        Private m_TransitQuantity As Int32



        Public Property LotID() As Int32

            Get
                Return Me.m_LotID
            End Get

            Set(ByVal value As Int32)
                Me.m_LotID = value
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

    End Class
End Namespace

