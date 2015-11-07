<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ToMain = New System.Windows.Forms.Button()
        Me.Withdraw = New System.Windows.Forms.Button()
        Me.Deposit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(900, 32)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(29, 27)
        Me.MaterialRaisedButton1.TabIndex = 0
        Me.MaterialRaisedButton1.Text = "?"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'ToMain
        '
        Me.ToMain.Location = New System.Drawing.Point(0, 2)
        Me.ToMain.Name = "ToMain"
        Me.ToMain.Size = New System.Drawing.Size(75, 23)
        Me.ToMain.TabIndex = 1
        Me.ToMain.Text = "ToMain"
        Me.ToMain.UseVisualStyleBackColor = True
        '
        'Withdraw
        '
        Me.Withdraw.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Withdraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Withdraw.Location = New System.Drawing.Point(31, 241)
        Me.Withdraw.Name = "Withdraw"
        Me.Withdraw.Size = New System.Drawing.Size(155, 54)
        Me.Withdraw.TabIndex = 2
        Me.Withdraw.Text = "Withdraw"
        Me.Withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Withdraw.UseVisualStyleBackColor = False
        Me.Withdraw.Visible = False
        '
        'Deposit
        '
        Me.Deposit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Deposit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Deposit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Deposit.Location = New System.Drawing.Point(31, 357)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(155, 54)
        Me.Deposit.TabIndex = 3
        Me.Deposit.Text = "Deposit"
        Me.Deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Deposit.UseVisualStyleBackColor = False
        Me.Deposit.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 644)
        Me.Controls.Add(Me.Deposit)
        Me.Controls.Add(Me.Withdraw)
        Me.Controls.Add(Me.ToMain)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Welcome to X Bank"
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ToMain As System.Windows.Forms.Button
    Friend WithEvents Withdraw As System.Windows.Forms.Button
    Friend WithEvents Deposit As System.Windows.Forms.Button
End Class
