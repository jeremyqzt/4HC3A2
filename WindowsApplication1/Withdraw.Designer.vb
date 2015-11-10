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
        Me.components = New System.ComponentModel.Container()
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
        Me.W60 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.W80 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.CustomAmountB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.W200 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.W140 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.W100 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.PassKeyCor = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKeyEnter = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey9 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey8 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey7 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey6 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.BackB = New System.Windows.Forms.Button()
        Me.Cancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey0 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WithdrawReciptNo = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WithdrawReciptYes = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WithdrawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WithdrawFinish = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Chequing = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Savings = New MaterialSkin.Controls.MaterialRadioButton()
        Me.SelectPayee = New MaterialSkin.Controls.MaterialRaisedButton()
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
        'W60
        '
        Me.W60.Depth = 0
        Me.W60.Location = New System.Drawing.Point(12, 366)
        Me.W60.MouseState = MaterialSkin.MouseState.HOVER
        Me.W60.Name = "W60"
        Me.W60.Primary = True
        Me.W60.Size = New System.Drawing.Size(320, 88)
        Me.W60.TabIndex = 20
        Me.W60.Text = "$60.00"
        Me.W60.UseVisualStyleBackColor = True
        '
        'W80
        '
        Me.W80.Depth = 0
        Me.W80.Location = New System.Drawing.Point(12, 460)
        Me.W80.MouseState = MaterialSkin.MouseState.HOVER
        Me.W80.Name = "W80"
        Me.W80.Primary = True
        Me.W80.Size = New System.Drawing.Size(320, 88)
        Me.W80.TabIndex = 21
        Me.W80.Text = "$80.00"
        Me.W80.UseVisualStyleBackColor = True
        '
        'CustomAmountB
        '
        Me.CustomAmountB.Depth = 0
        Me.CustomAmountB.Location = New System.Drawing.Point(379, 460)
        Me.CustomAmountB.MouseState = MaterialSkin.MouseState.HOVER
        Me.CustomAmountB.Name = "CustomAmountB"
        Me.CustomAmountB.Primary = True
        Me.CustomAmountB.Size = New System.Drawing.Size(320, 88)
        Me.CustomAmountB.TabIndex = 25
        Me.CustomAmountB.Text = "Custom Amount"
        Me.CustomAmountB.UseVisualStyleBackColor = True
        '
        'W200
        '
        Me.W200.Depth = 0
        Me.W200.Location = New System.Drawing.Point(379, 366)
        Me.W200.MouseState = MaterialSkin.MouseState.HOVER
        Me.W200.Name = "W200"
        Me.W200.Primary = True
        Me.W200.Size = New System.Drawing.Size(320, 88)
        Me.W200.TabIndex = 24
        Me.W200.Text = "$200.00"
        Me.W200.UseVisualStyleBackColor = True
        '
        'W140
        '
        Me.W140.Depth = 0
        Me.W140.Location = New System.Drawing.Point(379, 272)
        Me.W140.MouseState = MaterialSkin.MouseState.HOVER
        Me.W140.Name = "W140"
        Me.W140.Primary = True
        Me.W140.Size = New System.Drawing.Size(320, 88)
        Me.W140.TabIndex = 23
        Me.W140.Text = "$140.00"
        Me.W140.UseVisualStyleBackColor = True
        '
        'W100
        '
        Me.W100.Depth = 0
        Me.W100.Location = New System.Drawing.Point(379, 178)
        Me.W100.MouseState = MaterialSkin.MouseState.HOVER
        Me.W100.Name = "W100"
        Me.W100.Primary = True
        Me.W100.Size = New System.Drawing.Size(320, 88)
        Me.W100.TabIndex = 22
        Me.W100.Text = "$100.00"
        Me.W100.UseVisualStyleBackColor = True
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
        'PassKeyCor
        '
        Me.PassKeyCor.Depth = 0
        Me.PassKeyCor.Location = New System.Drawing.Point(304, 484)
        Me.PassKeyCor.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKeyCor.Name = "PassKeyCor"
        Me.PassKeyCor.Primary = True
        Me.PassKeyCor.Size = New System.Drawing.Size(72, 68)
        Me.PassKeyCor.TabIndex = 37
        Me.PassKeyCor.Text = "<-"
        Me.PassKeyCor.UseVisualStyleBackColor = True
        Me.PassKeyCor.Visible = False
        '
        'PassKeyEnter
        '
        Me.PassKeyEnter.Depth = 0
        Me.PassKeyEnter.Location = New System.Drawing.Point(403, 484)
        Me.PassKeyEnter.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKeyEnter.Name = "PassKeyEnter"
        Me.PassKeyEnter.Primary = True
        Me.PassKeyEnter.Size = New System.Drawing.Size(72, 68)
        Me.PassKeyEnter.TabIndex = 36
        Me.PassKeyEnter.Text = "Enter"
        Me.PassKeyEnter.UseVisualStyleBackColor = True
        Me.PassKeyEnter.Visible = False
        '
        'PassKey9
        '
        Me.PassKey9.Depth = 0
        Me.PassKey9.Location = New System.Drawing.Point(403, 398)
        Me.PassKey9.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey9.Name = "PassKey9"
        Me.PassKey9.Primary = True
        Me.PassKey9.Size = New System.Drawing.Size(72, 68)
        Me.PassKey9.TabIndex = 35
        Me.PassKey9.Text = "9"
        Me.PassKey9.UseVisualStyleBackColor = True
        Me.PassKey9.Visible = False
        '
        'PassKey8
        '
        Me.PassKey8.Depth = 0
        Me.PassKey8.Location = New System.Drawing.Point(304, 398)
        Me.PassKey8.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey8.Name = "PassKey8"
        Me.PassKey8.Primary = True
        Me.PassKey8.Size = New System.Drawing.Size(72, 68)
        Me.PassKey8.TabIndex = 34
        Me.PassKey8.Text = "8"
        Me.PassKey8.UseVisualStyleBackColor = True
        Me.PassKey8.Visible = False
        '
        'PassKey7
        '
        Me.PassKey7.Depth = 0
        Me.PassKey7.Location = New System.Drawing.Point(204, 398)
        Me.PassKey7.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey7.Name = "PassKey7"
        Me.PassKey7.Primary = True
        Me.PassKey7.Size = New System.Drawing.Size(72, 68)
        Me.PassKey7.TabIndex = 33
        Me.PassKey7.Text = "7"
        Me.PassKey7.UseVisualStyleBackColor = True
        Me.PassKey7.Visible = False
        '
        'PassKey6
        '
        Me.PassKey6.Depth = 0
        Me.PassKey6.Location = New System.Drawing.Point(403, 306)
        Me.PassKey6.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey6.Name = "PassKey6"
        Me.PassKey6.Primary = True
        Me.PassKey6.Size = New System.Drawing.Size(72, 68)
        Me.PassKey6.TabIndex = 32
        Me.PassKey6.Text = "6"
        Me.PassKey6.UseVisualStyleBackColor = True
        Me.PassKey6.Visible = False
        '
        'PassKey5
        '
        Me.PassKey5.Depth = 0
        Me.PassKey5.Location = New System.Drawing.Point(304, 306)
        Me.PassKey5.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey5.Name = "PassKey5"
        Me.PassKey5.Primary = True
        Me.PassKey5.Size = New System.Drawing.Size(72, 68)
        Me.PassKey5.TabIndex = 31
        Me.PassKey5.Text = "5"
        Me.PassKey5.UseVisualStyleBackColor = True
        Me.PassKey5.Visible = False
        '
        'PassKey4
        '
        Me.PassKey4.Depth = 0
        Me.PassKey4.Location = New System.Drawing.Point(204, 306)
        Me.PassKey4.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey4.Name = "PassKey4"
        Me.PassKey4.Primary = True
        Me.PassKey4.Size = New System.Drawing.Size(72, 68)
        Me.PassKey4.TabIndex = 30
        Me.PassKey4.Text = "4"
        Me.PassKey4.UseVisualStyleBackColor = True
        Me.PassKey4.Visible = False
        '
        'PassKey3
        '
        Me.PassKey3.Depth = 0
        Me.PassKey3.Location = New System.Drawing.Point(403, 217)
        Me.PassKey3.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey3.Name = "PassKey3"
        Me.PassKey3.Primary = True
        Me.PassKey3.Size = New System.Drawing.Size(72, 68)
        Me.PassKey3.TabIndex = 29
        Me.PassKey3.Text = "3"
        Me.PassKey3.UseVisualStyleBackColor = True
        Me.PassKey3.Visible = False
        '
        'PassKey2
        '
        Me.PassKey2.Depth = 0
        Me.PassKey2.Location = New System.Drawing.Point(304, 217)
        Me.PassKey2.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey2.Name = "PassKey2"
        Me.PassKey2.Primary = True
        Me.PassKey2.Size = New System.Drawing.Size(72, 68)
        Me.PassKey2.TabIndex = 28
        Me.PassKey2.Text = "2"
        Me.PassKey2.UseVisualStyleBackColor = True
        Me.PassKey2.Visible = False
        '
        'PassKey1
        '
        Me.PassKey1.Depth = 0
        Me.PassKey1.Location = New System.Drawing.Point(204, 217)
        Me.PassKey1.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey1.Name = "PassKey1"
        Me.PassKey1.Primary = True
        Me.PassKey1.Size = New System.Drawing.Size(72, 68)
        Me.PassKey1.TabIndex = 27
        Me.PassKey1.Text = "1"
        Me.PassKey1.UseVisualStyleBackColor = True
        Me.PassKey1.Visible = False
        '
        'PassField
        '
        Me.PassField.Depth = 0
        Me.PassField.Hint = ""
        Me.PassField.Location = New System.Drawing.Point(204, 158)
        Me.PassField.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassField.Name = "PassField"
        Me.PassField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PassField.SelectedText = ""
        Me.PassField.SelectionLength = 0
        Me.PassField.SelectionStart = 0
        Me.PassField.Size = New System.Drawing.Size(271, 23)
        Me.PassField.TabIndex = 38
        Me.PassField.Text = "$"
        Me.PassField.UseSystemPasswordChar = False
        Me.PassField.Visible = False
        '
        'BackB
        '
        Me.BackB.BackColor = System.Drawing.Color.SlateGray
        Me.BackB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackB.Image = CType(resources.GetObject("BackB.Image"), System.Drawing.Image)
        Me.BackB.Location = New System.Drawing.Point(585, 28)
        Me.BackB.Name = "BackB"
        Me.BackB.Size = New System.Drawing.Size(30, 30)
        Me.BackB.TabIndex = 39
        Me.BackB.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.Depth = 0
        Me.Cancel.Location = New System.Drawing.Point(527, 73)
        Me.Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Primary = True
        Me.Cancel.Size = New System.Drawing.Size(172, 68)
        Me.Cancel.TabIndex = 40
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'PassKey0
        '
        Me.PassKey0.Depth = 0
        Me.PassKey0.Location = New System.Drawing.Point(204, 484)
        Me.PassKey0.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey0.Name = "PassKey0"
        Me.PassKey0.Primary = True
        Me.PassKey0.Size = New System.Drawing.Size(72, 68)
        Me.PassKey0.TabIndex = 41
        Me.PassKey0.Text = "0"
        Me.PassKey0.UseVisualStyleBackColor = True
        Me.PassKey0.Visible = False
        '
        'WithdrawReciptNo
        '
        Me.WithdrawReciptNo.Depth = 0
        Me.WithdrawReciptNo.Location = New System.Drawing.Point(12, 366)
        Me.WithdrawReciptNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.WithdrawReciptNo.Name = "WithdrawReciptNo"
        Me.WithdrawReciptNo.Primary = True
        Me.WithdrawReciptNo.Size = New System.Drawing.Size(320, 88)
        Me.WithdrawReciptNo.TabIndex = 43
        Me.WithdrawReciptNo.Text = "No"
        Me.WithdrawReciptNo.UseVisualStyleBackColor = True
        Me.WithdrawReciptNo.Visible = False
        '
        'WithdrawReciptYes
        '
        Me.WithdrawReciptYes.Depth = 0
        Me.WithdrawReciptYes.Location = New System.Drawing.Point(12, 272)
        Me.WithdrawReciptYes.MouseState = MaterialSkin.MouseState.HOVER
        Me.WithdrawReciptYes.Name = "WithdrawReciptYes"
        Me.WithdrawReciptYes.Primary = True
        Me.WithdrawReciptYes.Size = New System.Drawing.Size(320, 88)
        Me.WithdrawReciptYes.TabIndex = 42
        Me.WithdrawReciptYes.Text = "Yes"
        Me.WithdrawReciptYes.UseVisualStyleBackColor = True
        Me.WithdrawReciptYes.Visible = False
        '
        'WithdrawTimer
        '
        '
        'WithdrawFinish
        '
        Me.WithdrawFinish.Depth = 0
        Me.WithdrawFinish.Location = New System.Drawing.Point(12, 460)
        Me.WithdrawFinish.MouseState = MaterialSkin.MouseState.HOVER
        Me.WithdrawFinish.Name = "WithdrawFinish"
        Me.WithdrawFinish.Primary = True
        Me.WithdrawFinish.Size = New System.Drawing.Size(320, 88)
        Me.WithdrawFinish.TabIndex = 44
        Me.WithdrawFinish.Text = "Finish"
        Me.WithdrawFinish.UseVisualStyleBackColor = True
        Me.WithdrawFinish.Visible = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(12, 366)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton1.TabIndex = 45
        Me.MaterialRaisedButton1.Text = "Perform Another Action"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton1.Visible = False
        '
        'Chequing
        '
        Me.Chequing.AutoSize = True
        Me.Chequing.BackColor = System.Drawing.Color.Transparent
        Me.Chequing.Depth = 0
        Me.Chequing.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Chequing.Location = New System.Drawing.Point(12, 279)
        Me.Chequing.Margin = New System.Windows.Forms.Padding(0)
        Me.Chequing.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Chequing.MouseState = MaterialSkin.MouseState.HOVER
        Me.Chequing.Name = "Chequing"
        Me.Chequing.Ripple = True
        Me.Chequing.Size = New System.Drawing.Size(87, 30)
        Me.Chequing.TabIndex = 95
        Me.Chequing.TabStop = True
        Me.Chequing.Text = "Chequing"
        Me.Chequing.UseVisualStyleBackColor = False
        Me.Chequing.Visible = False
        '
        'Savings
        '
        Me.Savings.AutoSize = True
        Me.Savings.BackColor = System.Drawing.Color.Transparent
        Me.Savings.Depth = 0
        Me.Savings.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Savings.Location = New System.Drawing.Point(12, 309)
        Me.Savings.Margin = New System.Windows.Forms.Padding(0)
        Me.Savings.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Savings.MouseState = MaterialSkin.MouseState.HOVER
        Me.Savings.Name = "Savings"
        Me.Savings.Ripple = True
        Me.Savings.Size = New System.Drawing.Size(77, 30)
        Me.Savings.TabIndex = 94
        Me.Savings.TabStop = True
        Me.Savings.Text = "Savings"
        Me.Savings.UseVisualStyleBackColor = False
        Me.Savings.Visible = False
        '
        'SelectPayee
        '
        Me.SelectPayee.Depth = 0
        Me.SelectPayee.Location = New System.Drawing.Point(277, 475)
        Me.SelectPayee.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectPayee.Name = "SelectPayee"
        Me.SelectPayee.Primary = True
        Me.SelectPayee.Size = New System.Drawing.Size(153, 88)
        Me.SelectPayee.TabIndex = 93
        Me.SelectPayee.Text = "Select"
        Me.SelectPayee.UseVisualStyleBackColor = True
        Me.SelectPayee.Visible = False
        '
        'Withdraw
        '
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.Chequing)
        Me.Controls.Add(Me.Savings)
        Me.Controls.Add(Me.SelectPayee)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.WithdrawFinish)
        Me.Controls.Add(Me.WithdrawReciptNo)
        Me.Controls.Add(Me.WithdrawReciptYes)
        Me.Controls.Add(Me.PassKey0)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BackB)
        Me.Controls.Add(Me.PassField)
        Me.Controls.Add(Me.PassKeyCor)
        Me.Controls.Add(Me.PassKeyEnter)
        Me.Controls.Add(Me.PassKey9)
        Me.Controls.Add(Me.PassKey8)
        Me.Controls.Add(Me.PassKey7)
        Me.Controls.Add(Me.PassKey6)
        Me.Controls.Add(Me.PassKey5)
        Me.Controls.Add(Me.PassKey4)
        Me.Controls.Add(Me.PassKey3)
        Me.Controls.Add(Me.PassKey2)
        Me.Controls.Add(Me.PassKey1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.CustomAmountB)
        Me.Controls.Add(Me.W200)
        Me.Controls.Add(Me.W140)
        Me.Controls.Add(Me.W100)
        Me.Controls.Add(Me.W80)
        Me.Controls.Add(Me.W60)
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
    Friend WithEvents W60 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents W80 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents CustomAmountB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents W200 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents W140 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents W100 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PassKeyCor As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKeyEnter As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey9 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey8 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey7 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey6 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents BackB As System.Windows.Forms.Button
    Friend WithEvents Cancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey0 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WithdrawReciptNo As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WithdrawReciptYes As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WithdrawTimer As System.Windows.Forms.Timer
    Friend WithEvents WithdrawFinish As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Chequing As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Savings As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents SelectPayee As MaterialSkin.Controls.MaterialRaisedButton



End Class
