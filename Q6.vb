Module Module1

    ' Base class
    Class Animal
        Public Sub Eat()
            Console.WriteLine("The animal is eating.")
        End Sub
    End Class

    ' Single inheritance: Dog inherits from Animal
    Class Dog
        Inherits Animal

        Public Sub Bark()
            Console.WriteLine("The dog is barking.")
        End Sub
    End Class

    ' Multi-level inheritance: Bulldog inherits from Dog
    Class Bulldog
        Inherits Dog

        Public Sub ShowBreed()
            Console.WriteLine("This is a Bulldog.")
        End Sub
    End Class

    Sub Main()
        ' Single Inheritance
        Dim myDog As New Dog()
        myDog.Eat() ' From Animal class
        myDog.Bark() ' From Dog class

        ' Multi-Level Inheritance
        Dim myBulldog As New Bulldog()
        myBulldog.Eat() ' From Animal class
        myBulldog.Bark() ' From Dog class
        myBulldog.ShowBreed() ' From Bulldog class

        Console.ReadLine()
    End Sub

End Module
