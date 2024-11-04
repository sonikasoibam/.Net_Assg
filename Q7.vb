Module Module1

    ' Define the IMovable interface
    Public Interface IMovable
        Sub Move()
    End Interface

    ' Define the IFlyable interface
    Public Interface IFlyable
        Sub Fly()
    End Interface

    ' Bird class implements both IMovable and IFlyable interfaces
    Public Class Bird
        Implements IMovable
        Implements IFlyable

        Public Sub Move() Implements IMovable.Move
            Console.WriteLine("The bird is moving on the ground.")
        End Sub

        Public Sub Fly() Implements IFlyable.Fly
            Console.WriteLine("The bird is flying in the sky.")
        End Sub
    End Class

    Sub Main()
        Dim myBird As New Bird()
        myBird.Move() ' Calls the Move method from IMovable
        myBird.Fly()  ' Calls the Fly method from IFlyable

        Console.ReadLine()
    End Sub

End Module
