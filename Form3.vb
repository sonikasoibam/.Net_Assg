Public Class Form1
    ' Event handler for button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        ' Clear previous entries
        ListBoxSquares.Items.Clear()

        ' Validate input to ensure it is a positive integer
        If Integer.TryParse(TextBoxN.Text, n) AndAlso n > 0 Then
            ' Generate and display squares from 1 to n
            For i As Integer = 1 To n
                Dim square As Integer = i * i
                ListBoxSquares.Items.Add("Square of " & i & " is " & square)
            Next
        Else
            MessageBox.Show("Please enter a positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class

