Namespace TrackITKTS
    Public Class PropertyTabUOMMaster
        Private m_UOMID As Int32
        Private m_ItemCode As String
        Private m_PrimayUOM As String
        Private m_RelatedUOM As String
        Private m_ItemID As Int32
        Private m_Factor As String



        Public Property UOMID() As Int32

            Get
                Return Me.m_UOMID
            End Get

            Set(ByVal value As Int32)
                Me.m_UOMID = value
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

        Public Property PrimayUOM() As String

            Get
                Return Me.m_PrimayUOM
            End Get

            Set(ByVal value As String)
                Me.m_PrimayUOM = value
            End Set

        End Property

        Public Property RelatedUOM() As String

            Get
                Return Me.m_RelatedUOM
            End Get

            Set(ByVal value As String)
                Me.m_RelatedUOM = value
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

        Public Property Factor() As String

            Get
                Return Me.m_Factor
            End Get

            Set(ByVal value As String)
                Me.m_Factor = value
            End Set

        End Property


    End Class
End Namespace

