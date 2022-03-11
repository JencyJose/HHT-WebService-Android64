Namespace TrackITKTS
    Public Class PropertyTabKSaleOrders
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
    End Class
End Namespace

