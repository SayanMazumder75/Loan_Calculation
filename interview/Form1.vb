Public Class Form1
    Public mycon As New dbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtEId.Text = "" OrElse txtEName.Text = "" Then
            MessageBox.Show("Please Enter Details Correctly", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Dim insertQuery = "Insert Into Employee1 values('" + txtEId.Text + "','" + txtEName.Text + "','" + doJoin.Value + "')"
            mycon.InsertData(insertQuery)
            If MessageBox.Show("Employee Datails saved Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information) Then

                Dim newForm As New Product()
                newForm.Show()

            End If
        End If

    End Sub
End Class
