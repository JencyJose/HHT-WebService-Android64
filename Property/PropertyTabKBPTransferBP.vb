Namespace TrackITKTS
    Public Class PropertyTabKBPTransferBP
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
    End Class
End Namespace

