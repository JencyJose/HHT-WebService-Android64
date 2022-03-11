Namespace TrackITKTS
    Public Class PropertyTabKEmptyTransferBP
        Private m_EBPOrderID As Int32
        Private m_FromBranchID As Int32
        Private m_ToBranchID As Int32
        Private m_CompanyID As Int32
        Private m_ItemID As Int32
        Private m_Quantity As Int32
        Private m_UOMID As Int32
        Private m_Batch As Boolean
        Private m_Barcode As String
        Private m_TransferDate As DateTime
        Private m_TransferBy As Int32
        Private m_ReceiveDate As DateTime
        Private m_ReceiveBy As Int32
        Private m_ReceiveQty As Int32
        Private m_ContainerNumber As String
        Private m_TransactionNumber As String
        Private m_Status As String
        Private m_ModifiedBy As Int32
        Private m_InTransitQuantity As Int32

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

        Public Property EBPOrderID() As Int32

            Get
                Return Me.m_EBPOrderID
            End Get

            Set(ByVal value As Int32)
                Me.m_EBPOrderID = value
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

        Public Property ReceiveDate() As DateTime

            Get
                Return Me.m_ReceiveDate
            End Get

            Set(ByVal value As DateTime)
                Me.m_ReceiveDate = value
            End Set

        End Property

        Public Property ReceiveBy() As Int32

            Get
                Return Me.m_ReceiveBy
            End Get

            Set(ByVal value As Int32)
                Me.m_ReceiveBy = value
            End Set

        End Property

        Public Property ReceiveQty() As Int32

            Get
                Return Me.m_ReceiveQty
            End Get

            Set(ByVal value As Int32)
                Me.m_ReceiveQty = value
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
        Public Property TransactionNumber() As String

            Get
                Return Me.m_TransactionNumber
            End Get

            Set(ByVal value As String)
                Me.m_TransactionNumber = value
            End Set

        End Property
        Public Property Status() As String

            Get
                Return Me.m_Status
            End Get

            Set(ByVal value As String)
                Me.m_Status = value
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
        Public Property InTransitQuantity() As Int32

            Get
                Return Me.m_InTransitQuantity
            End Get

            Set(ByVal value As Int32)
                Me.m_InTransitQuantity = value
            End Set

        End Property
    End Class
End Namespace

