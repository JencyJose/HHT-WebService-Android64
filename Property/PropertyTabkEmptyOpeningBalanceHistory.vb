Namespace TrackITKTS
    Public Class PropertyTabkEmptyOpeningBalanceHistory
        Private m_OBHistoryID As Int32
        Private m_InventoryID As Int32
        Private m_TransactionID As String
        Private m_Quantity As Int32
        Private m_AdjustmentQuantity As Int32
        Private m_CreatedBy As Int32
        Private m_ModifiedBy As Int32
        Private m_CreatedDate As String
        Private m_ModifiedDate As String
        Private m_CompanyID As Int32
        Private m_EntityType As Int32
        Private m_EntityID As Int32
        Public Property OBHistoryID() As Int32

            Get
                Return Me.m_OBHistoryID
            End Get

            Set(ByVal value As Int32)
                Me.m_OBHistoryID = value
            End Set

        End Property
        Public Property InventoryID() As Int32

            Get
                Return Me.m_InventoryID
            End Get

            Set(ByVal value As Int32)
                Me.m_InventoryID = value
            End Set

        End Property
        Public Property TransactionID() As String

            Get
                Return Me.m_TransactionID
            End Get

            Set(ByVal value As String)
                Me.m_TransactionID = value
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
        Public Property AdjustmentQuantity() As Int32

            Get
                Return Me.m_AdjustmentQuantity
            End Get

            Set(ByVal value As Int32)
                Me.m_AdjustmentQuantity = value
            End Set

        End Property
        Public Property CreatedBy() As Int32

            Get
                Return Me.m_CreatedBy
            End Get

            Set(ByVal value As Int32)
                Me.m_CreatedBy = value
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
        Public Property CreatedDate() As String

            Get
                Return Me.m_CreatedDate
            End Get

            Set(ByVal value As String)
                Me.m_CreatedDate = value
            End Set

        End Property
        Public Property ModifiedDate() As String

            Get
                Return Me.m_ModifiedDate
            End Get

            Set(ByVal value As String)
                Me.m_ModifiedDate = value
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
        Public Property EntityType() As Int32

            Get
                Return Me.m_EntityType
            End Get

            Set(ByVal value As Int32)
                Me.m_EntityType = value
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
    End Class
End Namespace

