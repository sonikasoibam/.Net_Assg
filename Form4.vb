Public Class Form1
    ' Event handler for button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        ' Clear previous entries
        ListBoxFactorials.Items.Clear()

        ' Validate input to ensure it is a positive integer
        If Integer.TryParse(TextBoxN.Text, n) AndAlso n > 0 Then
            ' Generate and display factorials from 1 to n
            For i As Integer = 1 To n
                Dim factorial As Long = CalculateFactorial(i)
                ListBoxFactorials.Items.Add("Factorial of " & i & " is " & factorial)
            Next
        Else
            MessageBox.Show("Please enter a positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Function to calculate factorial
    Private Function CalculateFactorial(num As Integer) As Long
        Dim result As Long = 1
        For j As Integer = 1 To num
            result *= j
        Next
        Return result
    End Function
End Class
