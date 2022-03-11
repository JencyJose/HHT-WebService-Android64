Namespace TrackITKTS
    Public Class PropertyTabKEmptyCustToSupp
        Private m_ECSOrderID As Int32
        Private m_CustomerID As Int32
        Private m_SupplierID As Int32
        Private m_CompanyID As Int32
        Private m_BranchID As Int32
        Private m_ItemID As Int32
        Private m_Quantity As Int32
        Private m_UOMID As Int32
        Private m_Batch As Boolean
        Private m_Barcode As String
        Private m_TransferDate As DateTime
        Private m_TransferBy As Int32
        Private m_DocumentNumber As String
        Private m_ShippingLine As String
        Private m_SerialNo As String
        Private m_TransactionNumber As String
        Private m_ModifiedBy As Int32
        Private m_ContainerNumber As String
        Private m_BOLDate As String
        Private m_BOLNumber As String

        Private m_ToCompanyID As Int32
        Private m_ToItemID As Int32

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

        Public Property ECSOrderID() As Int32

            Get
                Return Me.m_ECSOrderID
            End Get

            Set(ByVal value As Int32)
                Me.m_ECSOrderID = value
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

        Public Property SupplierID() As Int32

            Get
                Return Me.m_SupplierID
            End Get

            Set(ByVal value As Int32)
                Me.m_SupplierID = value
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

        Public Property Barcode() As String

            Get
                Return Me.m_Barcode
            End Get

            Set(ByVal value As String)
                Me.m_Barcode = value
            End Set

        End Property

        Public Property TransferDate() As DateTime

            Get
                Return Me.m_TransferDate
            End Get

            Set(ByVal value As DateTime)
                Me.m_TransferDate = value
            End Set

        End Property

        Public Property TransferBy() As Int32

            Get
                Return Me.m_TransferBy
            End Get

            Set(ByVal value As Int32)
                Me.m_TransferBy = value
            End Set

        End Property

        Public Property DocumentNumber() As String

            Get
                Return Me.m_DocumentNumber
            End Get

            Set(ByVal value As String)
                Me.m_DocumentNumber = value
            End Set

        End Property

        Public Property ShippingLine() As String

            Get
                Return Me.m_ShippingLine
            End Get

            Set(ByVal value As String)
                Me.m_ShippingLine = value
            End Set

        End Property
        Public Property SerialNo() As String

            Get
                Return Me.m_SerialNo
            End Get

            Set(ByVal value As String)
                Me.m_SerialNo = value
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
        Public Property TransactionNumber() As String

            Get
                Return Me.m_TransactionNumber
            End Get

            Set(ByVal value As String)
                Me.m_TransactionNumber = value
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

