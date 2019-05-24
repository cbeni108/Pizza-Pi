Public Class Form1
    Private Sub BtnCalculateNoofslices_Click(sender As Object, e As EventArgs) Handles btnCalculateNoofslices.Click
        'Declare the variables for calculation'
        Dim decDiameterpizza As Decimal
        Dim decNumberofslices As Integer
        Dim decslicesize As Decimal = 14.125
        Dim decradius As Decimal
        Dim decArea As Decimal
        Try
            'Calculate and display number of slices'
            decDiameterpizza = CDec(txtdiameterofPizza.Text)
            decradius = decDiameterpizza / 2
            decArea = 3.14159 * (decradius) * (decradius)
            decNumberofslices = decArea / decslicesize
            MessageBox.Show("Number of Slices:" & decNumberofslices)


        Catch ex As Exception
            MessageBox.Show("Input Must be Numeric")

        End Try




    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the information's field'
        txtdiameterofpizza.Clear()
        txtdiameterofpizza.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form'
        Me.Close()
    End Sub
End Class
