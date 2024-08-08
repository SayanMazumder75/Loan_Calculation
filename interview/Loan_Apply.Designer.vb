<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loan_Apply
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtEId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLTenure = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLInterest = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalinterest = New System.Windows.Forms.TextBox()
        Me.cmbLId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtEId
        '
        Me.txtEId.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEId.Location = New System.Drawing.Point(325, 22)
        Me.txtEId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEId.Name = "txtEId"
        Me.txtEId.Size = New System.Drawing.Size(136, 31)
        Me.txtEId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Employee ID"
        '
        'btnLoan
        '
        Me.btnLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.Location = New System.Drawing.Point(395, 501)
        Me.btnLoan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(135, 73)
        Me.btnLoan.TabIndex = 2
        Me.btnLoan.Text = "Take Loan"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'txtEName
        '
        Me.txtEName.Enabled = False
        Me.txtEName.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEName.Location = New System.Drawing.Point(800, 31)
        Me.txtEName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(136, 31)
        Me.txtEName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(542, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Employee Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tenure(YEAR)"
        '
        'txtLTenure
        '
        Me.txtLTenure.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLTenure.Location = New System.Drawing.Point(325, 271)
        Me.txtLTenure.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLTenure.Name = "txtLTenure"
        Me.txtLTenure.Size = New System.Drawing.Size(136, 31)
        Me.txtLTenure.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(542, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Loan Interest rate(%)"
        '
        'txtLInterest
        '
        Me.txtLInterest.Enabled = False
        Me.txtLInterest.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLInterest.Location = New System.Drawing.Point(800, 190)
        Me.txtLInterest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLInterest.Name = "txtLInterest"
        Me.txtLInterest.Size = New System.Drawing.Size(136, 31)
        Me.txtLInterest.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter Loan Amount"
        '
        'txtLAmount
        '
        Me.txtLAmount.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLAmount.Location = New System.Drawing.Point(325, 190)
        Me.txtLAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLAmount.Name = "txtLAmount"
        Me.txtLAmount.Size = New System.Drawing.Size(136, 31)
        Me.txtLAmount.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(542, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Loan Name"
        '
        'txtLName
        '
        Me.txtLName.Enabled = False
        Me.txtLName.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(800, 103)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(136, 31)
        Me.txtLName.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Select Loan ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(217, 389)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 22)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total Amount Have to Pay"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(564, 378)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(136, 31)
        Me.txtTotalAmount.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(542, 275)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 22)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Total Loan Interest "
        '
        'txtTotalinterest
        '
        Me.txtTotalinterest.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalinterest.Location = New System.Drawing.Point(800, 266)
        Me.txtTotalinterest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalinterest.Name = "txtTotalinterest"
        Me.txtTotalinterest.Size = New System.Drawing.Size(136, 31)
        Me.txtTotalinterest.TabIndex = 23
        '
        'cmbLId
        '
        Me.cmbLId.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLId.FormattingEnabled = True
        Me.cmbLId.Location = New System.Drawing.Point(325, 111)
        Me.cmbLId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbLId.Name = "cmbLId"
        Me.cmbLId.Size = New System.Drawing.Size(165, 32)
        Me.cmbLId.TabIndex = 25
        '
        'Loan_Apply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(961, 594)
        Me.Controls.Add(Me.cmbLId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalinterest)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLTenure)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLInterest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEId)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Loan_Apply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan_Apply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoan As Button
    Friend WithEvents txtEName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLTenure As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLInterest As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalinterest As TextBox
    Friend WithEvents cmbLId As ComboBox
End Class
