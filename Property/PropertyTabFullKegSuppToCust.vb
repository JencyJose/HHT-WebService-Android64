Namespace TrackITKTS
    Public Class PropertyTabFullKegSuppToCust
        Private m_FullKegID As Int32
        Private m_CustomerID As Int32
        Private m_SupplierID As Int32
        Private m_CompanyID As Int32
        Private m_ItemID As Int32
        Private m_Quantity As Int32
        Private m_UOMID As Int32
        Private m_ReceiptDate As DateTime
        Private m_BOLDate As String
        Private m_BOLNumber As String
        Private m_POType As String
        Private m_PONumber As String
        Private m_ContainerNumber As String
        Private m_TrasactionDoneBy As Int32
        Private m_TransactionNumber As String
        Private m_ModifiedBy As Int32

        Public Property FullKegID() As Int32

            Get
                Return Me.m_FullKegID
            End Get

            Set(ByVal value As Int32)
                Me.m_FullKegID = value
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

        Public Property CustomerID() As Int32

            Get
                Return Me.m_CustomerID
            End Get

            Set(ByVal value As Int32)
                Me.m_CustomerID = value
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

        Public Property ReceiptDate() As DateTime

            Get
                Return Me.m_ReceiptDate
            End Get

            Set(ByVal value As DateTime)
                Me.m_ReceiptDate = value
            End Set

        End Property
        Public Property BOLDate() As String

            Get
                Return Me.m_BOLDate
            End Get

            Set(ByVal value As String)
                Me.m_BOLDate = value
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
        Public Property POType() As String

            Get
                Return Me.m_POType
            End Get

            Set(ByVal value As String)
                Me.m_POType = value
            End Set

        End Property
        Public Property PONumber() As String

            Get
                Return Me.m_PONumber
            End Get

            Set(ByVal value As String)
                Me.m_PONumber = value
            End Set

        End Property
        Public Property TrasactionDoneBy() As Int32

            Get
                Return Me.m_TrasactionDoneBy
            End Get

            Set(ByVal value As Int32)
                Me.m_TrasactionDoneBy = value
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
    End Class
End Namespace

