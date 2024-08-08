<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtLId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLInterest = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLTenure = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtLId
        '
        Me.txtLId.Location = New System.Drawing.Point(304, 25)
        Me.txtLId.Name = "txtLId"
        Me.txtLId.Size = New System.Drawing.Size(100, 22)
        Me.txtLId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Loan ID"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(380, 182)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 61)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Loan Name"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(650, 25)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 22)
        Me.txtLName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter Loan Amount"
        '
        'txtLAmount
        '
        Me.txtLAmount.Location = New System.Drawing.Point(304, 83)
        Me.txtLAmount.Name = "txtLAmount"
        Me.txtLAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtLAmount.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(451, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Enter Loan Interest rate"
        '
        'txtLInterest
        '
        Me.txtLInterest.Location = New System.Drawing.Point(650, 83)
        Me.txtLInterest.Name = "txtLInterest"
        Me.txtLInterest.Size = New System.Drawing.Size(100, 22)
        Me.txtLInterest.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tenure"
        '
        'txtLTenure
        '
        Me.txtLTenure.Location = New System.Drawing.Point(304, 137)
        Me.txtLTenure.Name = "txtLTenure"
        Me.txtLTenure.Size = New System.Drawing.Size(100, 22)
        Me.txtLTenure.TabIndex = 9
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(789, 258)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLTenure)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLInterest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLId)
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLInterest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLTenure As TextBox
End Class
