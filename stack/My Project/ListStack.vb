Public Class ListStack

    Private top As Node

    Public Sub New()
        top = Nothing
    End Sub

    Public Function isEmpty() As Boolean
        Return top Is Nothing
    End Function

    Public Sub push(item As Object)
        Dim node As Node = New Node(item)
        node.NextData = top
        top = node
    End Sub

    Public Function peek() As Object
        If isEmpty() Then
            Console.WriteLine("nothing")
        End If
        Return top.Data
    End Function

    Public Function pop() As Object
        Dim item As Object = peek()
        top = top.NextData
        Return item
    End Function

    Public Sub printStack()
        If isEmpty() Then
            Console.WriteLine("nothing")
        Else
            Console.WriteLine("***** You have *****")
            Dim tempnode As Node = top
            While tempnode IsNot Nothing
                Console.WriteLine(tempnode.Data)
                tempnode = tempnode.NextData
            End While
        End If
    End Sub
End Class
