
Namespace TrackITKTS
    Public Class PropertyValidations
        Private m_ID As String
        Private m_Name As String
        Private m_IDVal As String
        Private m_NameVal As String
        Private m_Table As String
        Private m_FName As String
        Private m_FNameVal As String
        Private m_FName1 As String
        Private m_FNameVal1 As String

        Public Property Table() As String

            Get
                Return Me.m_Table
            End Get

            Set(ByVal value As String)
                Me.m_Table = value
            End Set

        End Property
        Public Property FName() As String

            Get
                Return Me.m_FName
            End Get

            Set(ByVal value As String)
                Me.m_FName = value
            End Set

        End Property
        Public Property FNameVal() As String

            Get
                Return Me.m_FNameVal
            End Get

            Set(ByVal value As String)
                Me.m_FNameVal = value
            End Set

        End Property
        Public Property FName1() As String

            Get
                Return Me.m_FName1
            End Get

            Set(ByVal value As String)
                Me.m_FName1 = value
            End Set

        End Property
        Public Property FNameVal1() As String

            Get
                Return Me.m_FNameVal1
            End Get

            Set(ByVal value As String)
                Me.m_FNameVal1 = value
            End Set

        End Property
        Public Property Name() As String

            Get
                Return Me.m_Name
            End Get

            Set(ByVal value As String)
                Me.m_Name = value
            End Set

        End Property

        Public Property IDVal() As String

            Get
                Return Me.m_IDVal
            End Get

            Set(ByVal value As String)
                Me.m_IDVal = value
            End Set

        End Property
        Public Property ID() As String

            Get
                Return Me.m_ID
            End Get

            Set(ByVal value As String)
                Me.m_ID = value
            End Set

        End Property
        Public Property NameVal() As String

            Get
                Return Me.m_NameVal
            End Get

            Set(ByVal value As String)
                Me.m_NameVal = value
            End Set

        End Property

    End Class
End Namespace

