
Namespace TrackITKTS
    Public Class PropertyTABAuditTrail
        Private m_AuditID As Int32
        Private m_UserID As Int32
        Private m_ActionName As String
        Private m_FunctionName As String
        Private m_ActionDate As DateTime
        Private m_PrimaryID As Int32
        Private m_TableName As String

        Public Property PrimaryID() As Int32

            Get
                Return Me.m_PrimaryID
            End Get

            Set(ByVal value As Int32)
                Me.m_PrimaryID = value
            End Set

        End Property

        Public Property TableName() As String

            Get
                Return Me.m_TableName
            End Get

            Set(ByVal value As String)
                Me.m_TableName = value
            End Set

        End Property
        Public Property AuditID() As Int32

            Get
                Return Me.m_AuditID
            End Get

            Set(ByVal value As Int32)
                Me.m_AuditID = value
            End Set

        End Property

        Public Property UserID() As Int32

            Get
                Return Me.m_UserID
            End Get

            Set(ByVal value As Int32)
                Me.m_UserID = value
            End Set

        End Property

        Public Property ActionName() As String

            Get
                Return Me.m_ActionName
            End Get

            Set(ByVal value As String)
                Me.m_ActionName = value
            End Set

        End Property

        Public Property FunctionName() As String

            Get
                Return Me.m_FunctionName
            End Get

            Set(ByVal value As String)
                Me.m_FunctionName = value
            End Set

        End Property

        Public Property ActionDate() As DateTime

            Get
                Return Me.m_ActionDate
            End Get

            Set(ByVal value As DateTime)
                Me.m_ActionDate = value
            End Set

        End Property
    End Class
End Namespace

