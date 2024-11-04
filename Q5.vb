Module Module1

    Class Person
        ' Properties
        Public Property Name As String
        Public Property Age As Integer

        ' Default Constructor
        Public Sub New()
            Name = "Unknown"
            Age = 0
        End Sub

        ' Parameterized Constructor
        Public Sub New(name As String, age As Integer)
            Me.Name = name
            Me.Age = age
        End Sub

        ' Method to display person's information
        Public Sub DisplayInfo()
            Console.WriteLine($"Name: {Name}, Age: {Age}")
        End Sub
    End Class

    Sub Main()
        ' Using the default constructor
        Dim person1 As New Person()
        person1.DisplayInfo()

        ' Using the parameterized constructor
        Dim person2 As New Person("Alice", 30)
        person2.DisplayInfo()

        Console.ReadLine()
    End Sub

End Module
