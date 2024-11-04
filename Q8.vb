Module Module1
    Sub Main()
        ' Using ArrayList
        Dim arrayList As New ArrayList()
        arrayList.Add("Apple")
        arrayList.Add("Banana")
        arrayList.Add("Cherry")
        arrayList.Add(42) ' ArrayList can hold different data types

        Console.WriteLine("ArrayList Contents:")
        For Each item In arrayList
            Console.WriteLine(item)
        Next

        ' Using Dictionary
        Dim dictionary As New Dictionary(Of String, Integer)()
        dictionary.Add("Apple", 1)
        dictionary.Add("Banana", 2)
        dictionary.Add("Cherry", 3)

        Console.WriteLine(vbCrLf & "Dictionary Contents:")
        For Each kvp In dictionary
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}")
        Next

        Console.ReadLine()
    End Sub
End Module
