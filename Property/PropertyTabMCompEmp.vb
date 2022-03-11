Namespace TrackITKTS
    Public Class PropertyTabMCompEmp
        Private m_EmployeeID As Int32
        Private m_CompanyID As Int32
        Private m_RoleID As Int32
        Private m_OrganizationID As Int32



        Public Property EmployeeID() As Int32

            Get
                Return Me.m_EmployeeID
            End Get

            Set(ByVal value As Int32)
                Me.m_EmployeeID = value
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
        Public Property RoleID() As Int32

            Get
                Return Me.m_RoleID
            End Get

            Set(ByVal value As Int32)
                Me.m_RoleID = value
            End Set

        End Property
        Public Property OrganizationID() As Int32

            Get
                Return Me.m_OrganizationID
            End Get

            Set(ByVal value As Int32)
                Me.m_OrganizationID = value
            End Set

        End Property


    End Class
End Namespace

