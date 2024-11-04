Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' Event handler for button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        ' Clear previous entries
        ListBoxEven.Items.Clear()
        ListBoxOdd.Items.Clear()

        ' Validate input to ensure it's a positive integer
        If Integer.TryParse(TextBoxN.Text, n) AndAlso n > 0 Then
            ' Generate n even and n odd numbers
            Dim evenNumber As Integer = 2
            Dim oddNumber As Integer = 1

            For i As Integer = 1 To n
                ' Add even numbers
                ListBoxEven.Items.Add(evenNumber)
                evenNumber += 2

                ' Add odd numbers
                ListBoxOdd.Items.Add(oddNumber)
                oddNumber += 2
            Next
        Else
            MessageBox.Show("Please enter a positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBoxN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxN.TextChanged

    End Sub
End Class
