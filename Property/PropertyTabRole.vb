Namespace TrackITKTS
    Public Class PropertyTabRole
        Private m_RoleID As Int32
        Private m_RoleName As String
        Private m_EnteredBy As Int32
        Private m_EnteredOn As DateTime
        Private m_CompanyID As Int32
        Private m_IsOrganization As Boolean



        Public Property RoleID() As Int32

            Get
                Return Me.m_RoleID
            End Get

            Set(ByVal value As Int32)
                Me.m_RoleID = value
            End Set

        End Property

        Public Property RoleName() As String

            Get
                Return Me.m_RoleName
            End Get

            Set(ByVal value As String)
                Me.m_RoleName = value
            End Set

        End Property

        Public Property EnteredBy() As Int32

            Get
                Return Me.m_EnteredBy
            End Get

            Set(ByVal value As Int32)
                Me.m_EnteredBy = value
            End Set

        End Property

        Public Property EnteredOn() As DateTime

            Get
                Return Me.m_EnteredOn
            End Get

            Set(ByVal value As DateTime)
                Me.m_EnteredOn = value
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
        Public Property IsOrganization() As Boolean

            Get
                Return Me.m_IsOrganization
            End Get

            Set(ByVal value As Boolean)
                Me.m_IsOrganization = value
            End Set

        End Property


    End Class
End Namespace

