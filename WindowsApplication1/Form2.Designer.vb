<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Logout = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Button()
        Me.CheckBalanceB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WithdrawB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DepositB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.BackB = New System.Windows.Forms.Button()
        Me.MainTransfer = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WithdrawReciptYes = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.SlateGray
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Image = CType(resources.GetObject("Logout.Image"), System.Drawing.Image)
        Me.Logout.Location = New System.Drawing.Point(627, 28)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(30, 30)
        Me.Logout.TabIndex = 4
        Me.Logout.UseVisualStyleBackColor = False
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.SlateGray
        Me.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info.ForeColor = System.Drawing.Color.Black
        Me.info.Image = CType(resources.GetObject("info.Image"), System.Drawing.Image)
        Me.info.Location = New System.Drawing.Point(669, 28)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(30, 30)
        Me.info.TabIndex = 5
        Me.info.UseVisualStyleBackColor = False
        '
        'CheckBalanceB
        '
        Me.CheckBalanceB.Depth = 0
        Me.CheckBalanceB.Location = New System.Drawing.Point(379, 206)
        Me.CheckBalanceB.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckBalanceB.Name = "CheckBalanceB"
        Me.CheckBalanceB.Primary = True
        Me.CheckBalanceB.Size = New System.Drawing.Size(320, 88)
        Me.CheckBalanceB.TabIndex = 15
        Me.CheckBalanceB.Text = "Check Balance"
        Me.CheckBalanceB.UseVisualStyleBackColor = True
        '
        'WithdrawB
        '
        Me.WithdrawB.Depth = 0
        Me.WithdrawB.Location = New System.Drawing.Point(12, 314)
        Me.WithdrawB.MouseState = MaterialSkin.MouseState.HOVER
        Me.WithdrawB.Name = "WithdrawB"
        Me.WithdrawB.Primary = True
        Me.WithdrawB.Size = New System.Drawing.Size(320, 88)
        Me.WithdrawB.TabIndex = 18
        Me.WithdrawB.Text = "Withdraw"
        Me.WithdrawB.UseVisualStyleBackColor = True
        '
        'DepositB
        '
        Me.DepositB.Depth = 0
        Me.DepositB.Location = New System.Drawing.Point(12, 206)
        Me.DepositB.MouseState = MaterialSkin.MouseState.HOVER
        Me.DepositB.Name = "DepositB"
        Me.DepositB.Primary = True
        Me.DepositB.Size = New System.Drawing.Size(320, 88)
        Me.DepositB.TabIndex = 17
        Me.DepositB.Text = "Deposit"
        Me.DepositB.UseVisualStyleBackColor = True
        '
        'BackB
        '
        Me.BackB.BackColor = System.Drawing.Color.SlateGray
        Me.BackB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackB.Image = CType(resources.GetObject("BackB.Image"), System.Drawing.Image)
        Me.BackB.Location = New System.Drawing.Point(585, 28)
        Me.BackB.Name = "BackB"
        Me.BackB.Size = New System.Drawing.Size(30, 30)
        Me.BackB.TabIndex = 43
        Me.BackB.UseVisualStyleBackColor = False
        '
        'MainTransfer
        '
        Me.MainTransfer.Depth = 0
        Me.MainTransfer.Location = New System.Drawing.Point(379, 314)
        Me.MainTransfer.MouseState = MaterialSkin.MouseState.HOVER
        Me.MainTransfer.Name = "MainTransfer"
        Me.MainTransfer.Primary = True
        Me.MainTransfer.Size = New System.Drawing.Size(320, 88)
        Me.MainTransfer.TabIndex = 46
        Me.MainTransfer.Text = "Make a Transfer"
        Me.MainTransfer.UseVisualStyleBackColor = True
        '
        'WithdrawReciptYes
        '
        Me.WithdrawReciptYes.Depth = 0
        Me.WithdrawReciptYes.Location = New System.Drawing.Point(12, 499)
        Me.WithdrawReciptYes.MouseState = MaterialSkin.MouseState.HOVER
        Me.WithdrawReciptYes.Name = "WithdrawReciptYes"
        Me.WithdrawReciptYes.Primary = True
        Me.WithdrawReciptYes.Size = New System.Drawing.Size(320, 88)
        Me.WithdrawReciptYes.TabIndex = 54
        Me.WithdrawReciptYes.Text = "Finish"
        Me.WithdrawReciptYes.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.WithdrawReciptYes)
        Me.Controls.Add(Me.MainTransfer)
        Me.Controls.Add(Me.BackB)
        Me.Controls.Add(Me.WithdrawB)
        Me.Controls.Add(Me.DepositB)
        Me.Controls.Add(Me.CheckBalanceB)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Logout)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.Text = "Welcome to X Bank"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Button
    Friend WithEvents CheckBalanceB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WithdrawB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents DepositB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents BackB As System.Windows.Forms.Button
    Friend WithEvents MainTransfer As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WithdrawReciptYes As MaterialSkin.Controls.MaterialRaisedButton



End Class
