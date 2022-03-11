Namespace TrackITKTS
    Public Class PropertyTabItems
        Private m_ItemID As Int32
        Private m_ItemCode As String
        Private m_ItemName As String
        Private m_BranchID As Int32
        Private m_CompanyID As Int32
        Private m_UOM As String

        Public Property ItemID() As Int32

            Get
                Return Me.m_ItemID
            End Get

            Set(ByVal value As Int32)
                Me.m_ItemID = value
            End Set

        End Property

        Public Property ItemCode() As String

            Get
                Return Me.m_ItemCode
            End Get

            Set(ByVal value As String)
                Me.m_ItemCode = value
            End Set

        End Property

        Public Property ItemName() As String

            Get
                Return Me.m_ItemName
            End Get

            Set(ByVal value As String)
                Me.m_ItemName = value
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

        Public Property CompanyID() As Int32

            Get
                Return Me.m_CompanyID
            End Get

            Set(ByVal value As Int32)
                Me.m_CompanyID = value
            End Set

        End Property

        Public Property UOM() As String

            Get
                Return Me.m_UOM
            End Get

            Set(ByVal value As String)
                Me.m_UOM = value
            End Set

        End Property
    End Class
End Namespace

