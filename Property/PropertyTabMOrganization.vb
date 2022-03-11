Namespace TrackITKTS
    Public Class PropertyTabMOrganization
        Private m_CompanyID As Int32
        Private m_CompanyCode As String
        Private m_CompanyName As String
        Private m_Address1 As String
        Private m_Address2 As String
        Private m_Address3 As String
        Private m_City As String
        Private m_State As String
        Private m_Phone As String
        Private m_Country As String
        Private m_Email As String
        Private m_CompanyImage As Byte()
        Private m_Thumbnail As Byte()



        Public Property CompanyID() As Int32

            Get
                Return Me.m_CompanyID
            End Get

            Set(ByVal value As Int32)
                Me.m_CompanyID = value
            End Set

        End Property

        Public Property CompanyCode() As String

            Get
                Return Me.m_CompanyCode
            End Get

            Set(ByVal value As String)
                Me.m_CompanyCode = value
            End Set

        End Property

        Public Property CompanyName() As String

            Get
                Return Me.m_CompanyName
            End Get

            Set(ByVal value As String)
                Me.m_CompanyName = value
            End Set

        End Property

        Public Property Address1() As String

            Get
                Return Me.m_Address1
            End Get

            Set(ByVal value As String)
                Me.m_Address1 = value
            End Set

        End Property
        Public Property Address2() As String

            Get
                Return Me.m_Address2
            End Get

            Set(ByVal value As String)
                Me.m_Address2 = value
            End Set

        End Property
        Public Property Address3() As String

            Get
                Return Me.m_Address3
            End Get

            Set(ByVal value As String)
                Me.m_Address3 = value
            End Set

        End Property

        Public Property City() As String

            Get
                Return Me.m_City
            End Get

            Set(ByVal value As String)
                Me.m_City = value
            End Set

        End Property

        Public Property State() As String

            Get
                Return Me.m_State
            End Get

            Set(ByVal value As String)
                Me.m_State = value
            End Set

        End Property

        Public Property Phone() As String

            Get
                Return Me.m_Phone
            End Get

            Set(ByVal value As String)
                Me.m_Phone = value
            End Set

        End Property

        Public Property Country() As String

            Get
                Return Me.m_Country
            End Get

            Set(ByVal value As String)
                Me.m_Country = value
            End Set

        End Property

        Public Property Email() As String

            Get
                Return Me.m_Email
            End Get

            Set(ByVal value As String)
                Me.m_Email = value
            End Set

        End Property

        Public Property CompanyImage() As Byte()

            Get
                Return Me.m_CompanyImage
            End Get

            Set(ByVal value As Byte())
                Me.m_CompanyImage = value
            End Set

        End Property

        Public Property Thumbnail() As Byte()

            Get
                Return Me.m_Thumbnail
            End Get

            Set(ByVal value As Byte())
                Me.m_Thumbnail = value
            End Set

        End Property

    End Class
End Namespace

