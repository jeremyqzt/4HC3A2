<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance))
        Me.TByEmailB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MPaymentB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Another = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WithdrawReciptYes = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.BackB = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TByEmailB
        '
        Me.TByEmailB.Depth = 0
        Me.TByEmailB.Location = New System.Drawing.Point(12, 113)
        Me.TByEmailB.MouseState = MaterialSkin.MouseState.HOVER
        Me.TByEmailB.Name = "TByEmailB"
        Me.TByEmailB.Primary = True
        Me.TByEmailB.Size = New System.Drawing.Size(320, 88)
        Me.TByEmailB.TabIndex = 19
        Me.TByEmailB.Text = "Show Checkings Balance"
        Me.TByEmailB.UseVisualStyleBackColor = True
        '
        'MPaymentB
        '
        Me.MPaymentB.Depth = 0
        Me.MPaymentB.Location = New System.Drawing.Point(12, 207)
        Me.MPaymentB.MouseState = MaterialSkin.MouseState.HOVER
        Me.MPaymentB.Name = "MPaymentB"
        Me.MPaymentB.Primary = True
        Me.MPaymentB.Size = New System.Drawing.Size(320, 88)
        Me.MPaymentB.TabIndex = 18
        Me.MPaymentB.Text = "Show Savings Balance"
        Me.MPaymentB.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(338, 182)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(295, 19)
        Me.MaterialLabel1.TabIndex = 20
        Me.MaterialLabel1.Text = "Your Most Recent Transaction Was: Today"
        Me.MaterialLabel1.Visible = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(338, 147)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(271, 19)
        Me.MaterialLabel2.TabIndex = 21
        Me.MaterialLabel2.Text = "Your Checkings Account Balance: $500"
        Me.MaterialLabel2.Visible = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(338, 241)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(237, 19)
        Me.MaterialLabel3.TabIndex = 23
        Me.MaterialLabel3.Text = "Your Savings Account Balance: $0"
        Me.MaterialLabel3.Visible = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(338, 276)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(295, 19)
        Me.MaterialLabel4.TabIndex = 22
        Me.MaterialLabel4.Text = "Your Most Recent Transaction Was: Today"
        Me.MaterialLabel4.Visible = False
        '
        'Another
        '
        Me.Another.Depth = 0
        Me.Another.Location = New System.Drawing.Point(12, 366)
        Me.Another.MouseState = MaterialSkin.MouseState.HOVER
        Me.Another.Name = "Another"
        Me.Another.Primary = True
        Me.Another.Size = New System.Drawing.Size(320, 88)
        Me.Another.TabIndex = 53
        Me.Another.Text = "Perform Another Transaction"
        Me.Another.UseVisualStyleBackColor = True
        '
        'WithdrawReciptYes
        '
        Me.WithdrawReciptYes.Depth = 0
        Me.WithdrawReciptYes.Location = New System.Drawing.Point(12, 460)
        Me.WithdrawReciptYes.MouseState = MaterialSkin.MouseState.HOVER
        Me.WithdrawReciptYes.Name = "WithdrawReciptYes"
        Me.WithdrawReciptYes.Primary = True
        Me.WithdrawReciptYes.Size = New System.Drawing.Size(320, 88)
        Me.WithdrawReciptYes.TabIndex = 51
        Me.WithdrawReciptYes.Text = "Finish"
        Me.WithdrawReciptYes.UseVisualStyleBackColor = True
        '
        'BackB
        '
        Me.BackB.BackColor = System.Drawing.Color.SlateGray
        Me.BackB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackB.Image = CType(resources.GetObject("BackB.Image"), System.Drawing.Image)
        Me.BackB.Location = New System.Drawing.Point(569, 29)
        Me.BackB.Name = "BackB"
        Me.BackB.Size = New System.Drawing.Size(30, 30)
        Me.BackB.TabIndex = 56
        Me.BackB.UseVisualStyleBackColor = False
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.SlateGray
        Me.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info.ForeColor = System.Drawing.Color.Black
        Me.info.Image = CType(resources.GetObject("info.Image"), System.Drawing.Image)
        Me.info.Location = New System.Drawing.Point(653, 29)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(30, 30)
        Me.info.TabIndex = 55
        Me.info.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.SlateGray
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Image = CType(resources.GetObject("Logout.Image"), System.Drawing.Image)
        Me.Logout.Location = New System.Drawing.Point(611, 29)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(30, 30)
        Me.Logout.TabIndex = 54
        Me.Logout.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(444, 298)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(239, 46)
        Me.MaterialRaisedButton1.TabIndex = 58
        Me.MaterialRaisedButton1.Text = "Print Balances on Receipt"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLabel5.Location = New System.Drawing.Point(342, 95)
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(212, 31)
        Me.MaterialLabel5.TabIndex = 59
        Me.MaterialLabel5.Text = "Your Balances:"
        '
        'Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 560)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.BackB)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Another)
        Me.Controls.Add(Me.WithdrawReciptYes)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.TByEmailB)
        Me.Controls.Add(Me.MPaymentB)
        Me.Name = "Balance"
        Me.Text = "Account Balances"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TByEmailB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MPaymentB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Another As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WithdrawReciptYes As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents BackB As Button
    Friend WithEvents info As Button
    Friend WithEvents Logout As Button
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel5 As Label

    Friend Shared Sub updateCheckings(v As Integer)
        Throw New NotImplementedException()
    End Sub
End Class
