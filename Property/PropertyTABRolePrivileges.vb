Namespace TrackITKTS
    Public Class PropertyTABRolePrivileges
        Private m_PrivilegeID As Int32
        Private m_MenuID As Int32
        Private m_AllowView As Boolean
        Private m_AllowAdd As Boolean
        Private m_AllowEdit As Boolean
        Private m_AllowDelete As Boolean
        Private m_RoleID As Int32



        Public Property PrivilegeID() As Int32

            Get
                Return Me.m_PrivilegeID
            End Get

            Set(ByVal value As Int32)
                Me.m_PrivilegeID = value
            End Set

        End Property

        Public Property MenuID() As Int32

            Get
                Return Me.m_MenuID
            End Get

            Set(ByVal value As Int32)
                Me.m_MenuID = value
            End Set

        End Property

        Public Property AllowView() As Boolean

            Get
                Return Me.m_AllowView
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowView = value
            End Set

        End Property

        Public Property AllowAdd() As Boolean

            Get
                Return Me.m_AllowAdd
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowAdd = value
            End Set

        End Property

        Public Property AllowEdit() As Boolean

            Get
                Return Me.m_AllowEdit
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowEdit = value
            End Set

        End Property

        Public Property AllowDelete() As Boolean

            Get
                Return Me.m_AllowDelete
            End Get

            Set(ByVal value As Boolean)
                Me.m_AllowDelete = value
            End Set

        End Property

        Public Property RoleID() As Int32

            Get
                Return Me.m_RoleID
            End Get

            Set(ByVal value As Int32)
                Me.m_RoleID = value
            End Set

        End Property


    End Class
End Namespace

