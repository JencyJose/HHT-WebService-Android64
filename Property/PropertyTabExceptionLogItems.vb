Namespace TrackITKTS
    Public Class PropertyTabExceptionLogItems
        Private m_EventId As Int32
        Private m_LogDateTime As DateTime
        Private m_Source As String
        Private m_Message As String
        Private m_QueryString As String
        Private m_TargetSite As String
        Private m_StackTrace As String
        Private m_ServerName As String
        Private m_RequestURL As String
        Private m_UserAgent As String
        Private m_UserIP As String
        Private m_UserAuthentication As String
        Private m_UserName As String

        Public Property EventId() As Int32

            Get
                Return Me.m_EventId
            End Get

            Set(ByVal value As Int32)
                Me.m_EventId = value
            End Set

        End Property

        Public Property LogDateTime() As DateTime

            Get
                Return Me.m_LogDateTime
            End Get

            Set(ByVal value As DateTime)
                Me.m_LogDateTime = value
            End Set

        End Property

        Public Property Source() As String

            Get
                Return Me.m_Source
            End Get

            Set(ByVal value As String)
                Me.m_Source = value
            End Set

        End Property

        Public Property Message() As String

            Get
                Return Me.m_Message
            End Get

            Set(ByVal value As String)
                Me.m_Message = value
            End Set

        End Property

        Public Property QueryString() As String

            Get
                Return Me.m_QueryString
            End Get

            Set(ByVal value As String)
                Me.m_QueryString = value
            End Set

        End Property

        Public Property TargetSite() As String

            Get
                Return Me.m_TargetSite
            End Get

            Set(ByVal value As String)
                Me.m_TargetSite = value
            End Set

        End Property

        Public Property StackTrace() As String

            Get
                Return Me.m_StackTrace
            End Get

            Set(ByVal value As String)
                Me.m_StackTrace = value
            End Set

        End Property

        Public Property ServerName() As String

            Get
                Return Me.m_ServerName
            End Get

            Set(ByVal value As String)
                Me.m_ServerName = value
            End Set

        End Property

        Public Property RequestURL() As String

            Get
                Return Me.m_RequestURL
            End Get

            Set(ByVal value As String)
                Me.m_RequestURL = value
            End Set

        End Property

        Public Property UserAgent() As String

            Get
                Return Me.m_UserAgent
            End Get

            Set(ByVal value As String)
                Me.m_UserAgent = value
            End Set

        End Property

        Public Property UserIP() As String

            Get
                Return Me.m_UserIP
            End Get

            Set(ByVal value As String)
                Me.m_UserIP = value
            End Set

        End Property

        Public Property UserAuthentication() As String

            Get
                Return Me.m_UserAuthentication
            End Get

            Set(ByVal value As String)
                Me.m_UserAuthentication = value
            End Set

        End Property

        Public Property UserName() As String

            Get
                Return Me.m_UserName
            End Get

            Set(ByVal value As String)
                Me.m_UserName = value
            End Set

        End Property
    End Class
End Namespace

