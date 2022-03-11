Namespace TrackITKTS
    Public Class PropertyTabKSupplierReceive
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
    End Class
End Namespace

