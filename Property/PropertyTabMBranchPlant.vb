Namespace TrackITKTS
    Public Class PropertyTabMBranchPlant
        Private m_BranchID As Int32
        Private m_BranchCode As String
        Private m_BranchName As String
        Private m_Batch As Boolean
        Private m_CompanyID As Int32
        Private m_Address1 As String
        Private m_Address2 As String
        Private m_Address3 As String
        Private m_Address4 As String



        Public Property BranchID() As Int32

            Get
                Return Me.m_BranchID
            End Get

            Set(ByVal value As Int32)
                Me.m_BranchID = value
            End Set

        End Property

        Public Property BranchCode() As String

            Get
                Return Me.m_BranchCode
            End Get

            Set(ByVal value As String)
                Me.m_BranchCode = value
            End Set

        End Property

        Public Property BranchName() As String

            Get
                Return Me.m_BranchName
            End Get

            Set(ByVal value As String)
                Me.m_BranchName = value
            End Set

        End Property

        Public Property Batch() As Boolean

            Get
                Return Me.m_Batch
            End Get

            Set(ByVal value As Boolean)
                Me.m_Batch = value
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
        Public Property Address4() As String

            Get
                Return Me.m_Address4
            End Get

            Set(ByVal value As String)
                Me.m_Address4 = value
            End Set

        End Property


    End Class
End Namespace

