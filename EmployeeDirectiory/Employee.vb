Public Class Employee


    'Public Shared firstName As String
    Private _firstName As String
    Public Property firstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Public Shared lastName As String
    Public Shared email As String
    Public Shared employeeNumber As String

    Private _salary As String
    Public Property salary() As String
        Get
            Return _salary
        End Get
        Set(ByVal value As String)
            _salary = value
        End Set
    End Property

    Sub New(first$, last$)
        Me._firstName = first
        Me.lastName = last
        Me.employeeNumber = "00032145"
        Me.email = $"{Me.firstName}{Me.lastName}@acmeco.com"
    End Sub

End Class
