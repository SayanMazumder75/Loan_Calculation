Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Loan_Apply
    Public mycon As New dbConnection
    Public data As DataSet = New DataSet
    Private Sub Loan_Apply_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim ShowData = "SELECT * FROM Loan"
        data = mycon.viewData(ShowData)
        Dim item As DataRow
        For Each item In data.Tables(0).Rows
            cmbLId.Items.Add(item("Id").ToString)
        Next




    End Sub



    Private Sub cmbLId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLId.SelectedIndexChanged
        Dim ShowData = "SELECT * FROM Loan Where Id='" + cmbLId.SelectedItem + "'"
        data = mycon.viewData(ShowData)
        Dim item As DataRow
        For Each item In data.Tables(0).Rows
            txtLName.Text = (item("Name").ToString)
            txtLAmount.Text = (item("Amount").ToString)
            txtLInterest.Text = (item("Interest_Rate").ToString)
            txtLTenure.Text = (item("Tenure").ToString)


        Next




    End Sub

    Private Sub txtLAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLAmount.TextChanged
        Dim loanAmount As Double
        Dim interestRate As Double
        Dim tenure As Integer
        Dim totalInterest As Double

        Double.TryParse(txtLAmount.Text, loanAmount)
        Double.TryParse(txtLInterest.Text, interestRate)
        Integer.TryParse(txtLTenure.Text, tenure)

        totalInterest = CalculateTotalInterest(loanAmount, interestRate, tenure)

            txtTotalinterest.Text = totalInterest.ToString("F2")



    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click

        If txtEId.Text = "" OrElse txtEName.Text = "" OrElse cmbLId.Text = "" OrElse txtLTenure.Text >= 20 OrElse txtLAmount.Text < 1000 OrElse txtTotalinterest.Text < 1 Then

            MessageBox.Show("Please Enter a Valid Information", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim insertQuery = "Insert Into Sanctioned_Loan values('" + txtEId.Text + "','" + txtEName.Text + "','" + cmbLId.SelectedItem + "','" + txtLName.Text + "','" + txtLAmount.Text + "','" + txtLInterest.Text + "','" + txtLTenure.Text + "','" + txtTotalinterest.Text + "','" + txtTotalAmount.Text + "')"
            mycon.InsertData(insertQuery)

            MessageBox.Show("Application For Loan Send Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
        End If

    End Sub

    Private Function CalculateTotalInterest(ByVal principal As Double, ByVal rate As Double, ByVal years As Integer) As Double

        Dim decimalRate As Double = rate / 100

        Dim totalInterest As Double = principal * decimalRate * years
        Dim totalAmount As Double = principal + totalInterest

        txtTotalAmount.Text = totalAmount.ToString("F2")

        Return totalInterest
    End Function

    'Dim insertQuery = "Insert Into Sanctioned_Loan values('" + txtEId.Text + "','" + txtEName.Text + "','" + cmbLId.SelectedItem + "','" + txtLName.Text + "','" + txtLAmount.Text + "','" + txtLInterest.Text + "','" + txtLTenure.Text + "','" + txtTotalinterest.Text + "','" + txtTotalAmount.Text + "')"
    'mycon.InsertData(insertQuery)

    'MessageBox.Show("Loan Sanctioned Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)


    Private Sub txtEId_TextChanged(sender As Object, e As EventArgs) Handles txtEId.TextChanged

        Dim ShowEmployee = "SELECT * FROM Employee1 Where Employee_ID='" + txtEId.Text + "' AND Date_Of_Joining<='2024-08-03'"
        data = mycon.viewData(ShowEmployee)


        Dim items As DataRow
        For Each items In data.Tables(0).Rows
            txtEName.Text = (items("Employee_Name").ToString)

        Next

    End Sub

    Private Sub txtLAmount_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLAmount.MouseClick
        Dim loanAmount As Double
        Dim interestRate As Double
        Dim tenure As Integer
        Dim totalInterest As Double

        Double.TryParse(txtLAmount.Text, loanAmount)
        Double.TryParse(txtLInterest.Text, interestRate)
        Integer.TryParse(txtLTenure.Text, tenure)

        totalInterest = CalculateTotalInterest(loanAmount, interestRate, tenure)

        txtTotalinterest.Text = totalInterest.ToString("F2")
    End Sub

    Private Sub txtLTenure_TextChanged(sender As Object, e As EventArgs) Handles txtLTenure.TextChanged
    End Sub



    Private Sub txtLTenure_Enter(sender As Object, e As EventArgs) Handles txtLTenure.Enter
        Dim loanAmount As Double
        Dim interestRate As Double
        Dim tenure As Integer
        Dim totalInterest As Double

        Double.TryParse(txtLAmount.Text, loanAmount)
        Double.TryParse(txtLInterest.Text, interestRate)
        Integer.TryParse(txtLTenure.Text, tenure)

        totalInterest = CalculateTotalInterest(loanAmount, interestRate, tenure)

        txtTotalinterest.Text = totalInterest.ToString("F2")
    End Sub

    Public Function Clear()
        txtEId.Text = ""
        txtEName.Text = ""
        txtLAmount.Text = ""
        txtLInterest.Text = ""
        txtLName.Text = ""
        cmbLId.Text = ""
        txtLTenure.Text = ""
        txtTotalAmount.Text = ""
        txtTotalinterest.Text = ""

    End Function
End Class