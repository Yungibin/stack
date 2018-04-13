Public Class Node

    Private mdata As Object
    Private mnext As Node

    Public Sub New(data As Object)
        mdata = data
        mnext = Nothing
    End Sub

    Public Property Data() As Object
        Get
            Return mdata
        End Get
        Set(value As Object)
            mdata = value
        End Set
    End Property

    Public Property NextData() As Node
        Get
            Return mnext
        End Get
        Set(value As Node)
            mnext = value
        End Set
    End Property

End Class
