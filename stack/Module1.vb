Module Module1

    Sub Main()

        Dim stack As ListStack = New ListStack()

        For i As Integer = 0 To 4
            stack.push(i)
        Next
        stack.printStack()

        stack.pop()
        stack.printStack()

        stack.pop()
        stack.printStack()

        stack.pop()
        stack.printStack()

        stack.pop()
        stack.printStack()

    End Sub

End Module
