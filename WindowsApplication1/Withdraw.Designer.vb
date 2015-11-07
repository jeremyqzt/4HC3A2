<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Withdraw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdraw))
        Me.CheckBalance = New System.Windows.Forms.Button()
        Me.TransferM = New System.Windows.Forms.Button()
        Me.Deposit = New System.Windows.Forms.Button()
        Me.Info = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.W20 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.W40 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton6 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton7 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'CheckBalance
        '
        Me.CheckBalance.BackColor = System.Drawing.Color.SlateGray
        Me.CheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBalance.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBalance.Location = New System.Drawing.Point(379, 261)
        Me.CheckBalance.Name = "CheckBalance"
        Me.CheckBalance.Size = New System.Drawing.Size(320, 88)
        Me.CheckBalance.TabIndex = 1
        Me.CheckBalance.Text = "Check Balance"
        Me.CheckBalance.UseVisualStyleBackColor = False
        '
        'TransferM
        '
        Me.TransferM.BackColor = System.Drawing.Color.SlateGray
        Me.TransferM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransferM.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TransferM.Location = New System.Drawing.Point(379, 400)
        Me.TransferM.Name = "TransferM"
        Me.TransferM.Size = New System.Drawing.Size(320, 88)
        Me.TransferM.TabIndex = 3
        Me.TransferM.Text = "Transfer Money"
        Me.TransferM.UseVisualStyleBackColor = False
        '
        'Deposit
        '
        Me.Deposit.BackColor = System.Drawing.Color.SlateGray
        Me.Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deposit.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deposit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Deposit.Location = New System.Drawing.Point(12, 400)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(320, 88)
        Me.Deposit.TabIndex = 2
        Me.Deposit.Text = "Deposit"
        Me.Deposit.UseVisualStyleBackColor = False
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.Color.SlateGray
        Me.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Info.Image = CType(resources.GetObject("Info.Image"), System.Drawing.Image)
        Me.Info.Location = New System.Drawing.Point(627, 28)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(30, 30)
        Me.Info.TabIndex = 4
        Me.Info.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.SlateGray
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.ForeColor = System.Drawing.Color.Black
        Me.Logout.Image = CType(resources.GetObject("Logout.Image"), System.Drawing.Image)
        Me.Logout.Location = New System.Drawing.Point(669, 28)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(30, 30)
        Me.Logout.TabIndex = 5
        Me.Logout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(669, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(627, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'W20
        '
        Me.W20.Depth = 0
        Me.W20.Location = New System.Drawing.Point(12, 178)
        Me.W20.MouseState = MaterialSkin.MouseState.HOVER
        Me.W20.Name = "W20"
        Me.W20.Primary = True
        Me.W20.Size = New System.Drawing.Size(320, 88)
        Me.W20.TabIndex = 18
        Me.W20.Text = "$20.00"
        Me.W20.UseVisualStyleBackColor = True
        '
        'W40
        '
        Me.W40.Depth = 0
        Me.W40.Location = New System.Drawing.Point(12, 272)
        Me.W40.MouseState = MaterialSkin.MouseState.HOVER
        Me.W40.Name = "W40"
        Me.W40.Primary = True
        Me.W40.Size = New System.Drawing.Size(320, 88)
        Me.W40.TabIndex = 19
        Me.W40.Text = "$40.00"
        Me.W40.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(12, 366)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton2.TabIndex = 20
        Me.MaterialRaisedButton2.Text = "$60.00"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(12, 460)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton3.TabIndex = 21
        Me.MaterialRaisedButton3.Text = "$80.00"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(379, 460)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton4.TabIndex = 25
        Me.MaterialRaisedButton4.Text = "Custom Amount"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton5
        '
        Me.MaterialRaisedButton5.Depth = 0
        Me.MaterialRaisedButton5.Location = New System.Drawing.Point(379, 366)
        Me.MaterialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton5.Name = "MaterialRaisedButton5"
        Me.MaterialRaisedButton5.Primary = True
        Me.MaterialRaisedButton5.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton5.TabIndex = 24
        Me.MaterialRaisedButton5.Text = "$200.00"
        Me.MaterialRaisedButton5.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton6
        '
        Me.MaterialRaisedButton6.Depth = 0
        Me.MaterialRaisedButton6.Location = New System.Drawing.Point(379, 272)
        Me.MaterialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton6.Name = "MaterialRaisedButton6"
        Me.MaterialRaisedButton6.Primary = True
        Me.MaterialRaisedButton6.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton6.TabIndex = 23
        Me.MaterialRaisedButton6.Text = "$140.00"
        Me.MaterialRaisedButton6.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton7
        '
        Me.MaterialRaisedButton7.Depth = 0
        Me.MaterialRaisedButton7.Location = New System.Drawing.Point(379, 178)
        Me.MaterialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton7.Name = "MaterialRaisedButton7"
        Me.MaterialRaisedButton7.Primary = True
        Me.MaterialRaisedButton7.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton7.TabIndex = 22
        Me.MaterialRaisedButton7.Text = "$100.00"
        Me.MaterialRaisedButton7.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 112)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(325, 19)
        Me.MaterialLabel2.TabIndex = 26
        Me.MaterialLabel2.Text = "Please select the amount you want to withdraw"
        '
        'Withdraw
        '
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialRaisedButton4)
        Me.Controls.Add(Me.MaterialRaisedButton5)
        Me.Controls.Add(Me.MaterialRaisedButton6)
        Me.Controls.Add(Me.MaterialRaisedButton7)
        Me.Controls.Add(Me.MaterialRaisedButton3)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.W40)
        Me.Controls.Add(Me.W20)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name = "Withdraw"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Withdraw As System.Windows.Forms.Button
    Friend WithEvents CheckBalance As System.Windows.Forms.Button
    Friend WithEvents TransferM As System.Windows.Forms.Button
    Friend WithEvents Deposit As System.Windows.Forms.Button
    Friend WithEvents Info As System.Windows.Forms.Button
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents W20 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents W40 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton6 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton7 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel




End Class
