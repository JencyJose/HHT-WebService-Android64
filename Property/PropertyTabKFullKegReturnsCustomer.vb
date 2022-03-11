Namespace TrackITKTS
    Public Class PropertyTabKFullKegReturnsCustomer
        Private m_FCOrderID As Int32
        Private m_CustomerID As Int32
        Private m_ItemID As Int32
        Private m_Quantity As Int32
        Private m_UOMID As Int32
        Private m_Barcode As String
        Private m_ReturnDate As DateTime
        Private m_TransactionNumber As String
        Private m_ModifiedBy As Int32
        Private m_CompanyID As Int32
        Private m_ReturnBy As Int32


        Private m_BranchID As Int32
        Private m_ToCompanyID As Int32
        Private m_ToItemID As Int32
        Private m_Batch As Boolean

        Public Property CompanyID() As Int32

            Get
                Return Me.m_CompanyID
            End Get

            Set(ByVal value As Int32)
                Me.m_CompanyID = value
            End Set

        End Property

        Public Property FCOrderID() As Int32

            Get
                Return Me.m_FCOrderID
            End Get

            Set(ByVal value As Int32)
                Me.m_FCOrderID = value
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

       

        Public Property Barcode() As String

            Get
                Return Me.m_Barcode
            End Get

            Set(ByVal value As String)
                Me.m_Barcode = value
            End Set

        End Property

        Public Property ReturnDate() As DateTime

            Get
                Return Me.m_ReturnDate
            End Get

            Set(ByVal value As DateTime)
                Me.m_ReturnDate = value
            End Set

        End Property

       
        Public Property TransactionNumber() As String

            Get
                Return Me.m_TransactionNumber
            End Get

            Set(ByVal value As String)
                Me.m_TransactionNumber = value
            End Set

        End Property
        Public Property ModifiedBy() As Int32

            Get
                Return Me.m_ModifiedBy
            End Get

            Set(ByVal value As Int32)
                Me.m_ModifiedBy = value
            End Set

        End Property
        Public Property ReturnBy() As Int32

            Get
                Return Me.m_ReturnBy
            End Get

            Set(ByVal value As Int32)
                Me.m_ReturnBy = value
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
        Public Property ToCompanyID() As Int32

            Get
                Return Me.m_ToCompanyID
            End Get

            Set(ByVal value As Int32)
                Me.m_ToCompanyID = value
            End Set

        End Property

        Public Property ToItemID() As Int32

            Get
                Return Me.m_ToItemID
            End Get

            Set(ByVal value As Int32)
                Me.m_ToItemID = value
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
    End Class
End Namespace
