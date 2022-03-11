Namespace TrackITKTS
    Public Class PropertyTABMenu
        Private m_MenuID As Int32
        Private m_Feature_en As String
        Private m_Feature_ar As String
        Private m_Description As String
        Private m_ParentID As Int32
        Private m_NavigateURL As String
        Private m_FeatureType As Char
        Private m_Imp_View As Boolean
        Private m_Imp_New As Boolean
        Private m_Imp_Edit As Boolean
        Private m_Imp_Delete As Boolean



        Public Property MenuID() As Int32

            Get
                Return Me.m_MenuID
            End Get

            Set(ByVal value As Int32)
                Me.m_MenuID = value
            End Set

        End Property

        Public Property Feature_en() As String

            Get
                Return Me.m_Feature_en
            End Get

            Set(ByVal value As String)
                Me.m_Feature_en = value
            End Set

        End Property

        Public Property Feature_ar() As String

            Get
                Return Me.m_Feature_ar
            End Get

            Set(ByVal value As String)
                Me.m_Feature_ar = value
            End Set

        End Property

        Public Property Description() As String

            Get
                Return Me.m_Description
            End Get

            Set(ByVal value As String)
                Me.m_Description = value
            End Set

        End Property

        Public Property ParentID() As Int32

            Get
                Return Me.m_ParentID
            End Get

            Set(ByVal value As Int32)
                Me.m_ParentID = value
            End Set

        End Property

        Public Property NavigateURL() As String

            Get
                Return Me.m_NavigateURL
            End Get

            Set(ByVal value As String)
                Me.m_NavigateURL = value
            End Set

        End Property

        Public Property FeatureType() As Char

            Get
                Return Me.m_FeatureType
            End Get

            Set(ByVal value As Char)
                Me.m_FeatureType = value
            End Set

        End Property

        Public Property Imp_View() As Boolean

            Get
                Return Me.m_Imp_View
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_View = value
            End Set

        End Property

        Public Property Imp_New() As Boolean

            Get
                Return Me.m_Imp_New
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_New = value
            End Set

        End Property

        Public Property Imp_Edit() As Boolean

            Get
                Return Me.m_Imp_Edit
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_Edit = value
            End Set

        End Property

        Public Property Imp_Delete() As Boolean

            Get
                Return Me.m_Imp_Delete
            End Get

            Set(ByVal value As Boolean)
                Me.m_Imp_Delete = value
            End Set

        End Property


    End Class
End Namespace

