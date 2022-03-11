Namespace TrackITKTS
    Public Class PropertyTabKSaleOrderBarcode
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
    End Class
End Namespace

