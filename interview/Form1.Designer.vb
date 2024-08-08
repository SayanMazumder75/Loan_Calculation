<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEId = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.doJoin = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Employee ID"
        '
        'txtEId
        '
        Me.txtEId.Location = New System.Drawing.Point(202, 12)
        Me.txtEId.Name = "txtEId"
        Me.txtEId.Size = New System.Drawing.Size(100, 22)
        Me.txtEId.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(177, 129)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(86, 42)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtEName
        '
        Me.txtEName.Location = New System.Drawing.Point(524, 15)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(100, 22)
        Me.txtEName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Of joining"
        '
        'doJoin
        '
        Me.doJoin.Location = New System.Drawing.Point(202, 71)
        Me.doJoin.Name = "doJoin"
        Me.doJoin.Size = New System.Drawing.Size(231, 22)
        Me.doJoin.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(638, 196)
        Me.Controls.Add(Me.doJoin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtEId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEId As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtEName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents doJoin As DateTimePicker
End Class
