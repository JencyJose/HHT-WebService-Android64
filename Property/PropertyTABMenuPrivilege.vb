Namespace TrackITKTS
    Public Class PropertyTABMenuPrivilege
        Private m_PrivID As Int32
        Private m_PrivilegeName_en As String
        Private m_PrivilegeName_ar As String
        Private m_Seq As Int32
        Private m_MenuID As Int32
        Private m_Mandatory As Boolean
        Private m_UserDefined As Boolean



        Public Property PrivID() As Int32

            Get
                Return Me.m_PrivID
            End Get

            Set(ByVal value As Int32)
                Me.m_PrivID = value
            End Set

        End Property

        Public Property PrivilegeName_en() As String

            Get
                Return Me.m_PrivilegeName_en
            End Get

            Set(ByVal value As String)
                Me.m_PrivilegeName_en = value
            End Set

        End Property

        Public Property PrivilegeName_ar() As String

            Get
                Return Me.m_PrivilegeName_ar
            End Get

            Set(ByVal value As String)
                Me.m_PrivilegeName_ar = value
            End Set

        End Property

        Public Property Seq() As Int32

            Get
                Return Me.m_Seq
            End Get

            Set(ByVal value As Int32)
                Me.m_Seq = value
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

        Public Property Mandatory() As Boolean

            Get
                Return Me.m_Mandatory
            End Get

            Set(ByVal value As Boolean)
                Me.m_Mandatory = value
            End Set

        End Property

        Public Property UserDefined() As Boolean

            Get
                Return Me.m_UserDefined
            End Get

            Set(ByVal value As Boolean)
                Me.m_UserDefined = value
            End Set

        End Property


    End Class
End Namespace

