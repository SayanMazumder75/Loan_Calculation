Public Class Product

    Public mycon As New dbConnection
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLId.Text = "" OrElse txtLName.Text = "" OrElse txtLAmount.Text = "" OrElse txtLInterest.Text = "" OrElse txtLTenure.Text = "" Then
            MessageBox.Show("Please Enter Details Correctly", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim InsertQuery = "Insert into Loan Values ('" + txtLId.Text + "','" + txtLName.Text + "','" + txtLAmount.Text + "','" + txtLInterest.Text + "','" + txtLTenure.Text + "')"
            mycon.InsertData(InsertQuery)
            MessageBox.Show("Loan Datails saved Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim newForm As New Loan_Apply()
            newForm.Show()
        End If

    End Sub
End Class