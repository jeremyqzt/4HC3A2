<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransferMoney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferMoney))
        Me.Logout = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Button()
        Me.MPaymentB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TBetweenAccB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TByEmailB = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.BackB = New System.Windows.Forms.Button()
        Me.Cancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey0 = New MaterialSkin.Controls.MaterialRaisedButton()
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.PassField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton4 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton5 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton6 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton7 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton8 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton9 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton10 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.NextPage = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TransferFrom = New System.Windows.Forms.ComboBox()
        Me.TransferTo = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRadioButton11 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Previous = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SelectPayee = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PrintRecipt = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ReciptNo = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TransferContinue = New MaterialSkin.Controls.MaterialRaisedButton()
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
        'MPaymentB
        '
        Me.MPaymentB.Depth = 0
        Me.MPaymentB.Location = New System.Drawing.Point(12, 329)
        Me.MPaymentB.MouseState = MaterialSkin.MouseState.HOVER
        Me.MPaymentB.Name = "MPaymentB"
        Me.MPaymentB.Primary = True
        Me.MPaymentB.Size = New System.Drawing.Size(320, 88)
        Me.MPaymentB.TabIndex = 15
        Me.MPaymentB.Text = "Make a Payment"
        Me.MPaymentB.UseVisualStyleBackColor = True
        '
        'TBetweenAccB
        '
        Me.TBetweenAccB.Depth = 0
        Me.TBetweenAccB.Location = New System.Drawing.Point(379, 218)
        Me.TBetweenAccB.MouseState = MaterialSkin.MouseState.HOVER
        Me.TBetweenAccB.Name = "TBetweenAccB"
        Me.TBetweenAccB.Primary = True
        Me.TBetweenAccB.Size = New System.Drawing.Size(320, 88)
        Me.TBetweenAccB.TabIndex = 18
        Me.TBetweenAccB.Text = "Transfer Between Accounts"
        Me.TBetweenAccB.UseVisualStyleBackColor = True
        '
        'TByEmailB
        '
        Me.TByEmailB.Depth = 0
        Me.TByEmailB.Location = New System.Drawing.Point(12, 218)
        Me.TByEmailB.MouseState = MaterialSkin.MouseState.HOVER
        Me.TByEmailB.Name = "TByEmailB"
        Me.TByEmailB.Primary = True
        Me.TByEmailB.Size = New System.Drawing.Size(320, 88)
        Me.TByEmailB.TabIndex = 17
        Me.TByEmailB.Text = "Transfer By E-mail"
        Me.TByEmailB.UseVisualStyleBackColor = True
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
        'Cancel
        '
        Me.Cancel.Depth = 0
        Me.Cancel.Location = New System.Drawing.Point(527, 88)
        Me.Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Primary = True
        Me.Cancel.Size = New System.Drawing.Size(172, 68)
        Me.Cancel.TabIndex = 52
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'PassKey0
        '
        Me.PassKey0.Depth = 0
        Me.PassKey0.Location = New System.Drawing.Point(220, 495)
        Me.PassKey0.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey0.Name = "PassKey0"
        Me.PassKey0.Primary = True
        Me.PassKey0.Size = New System.Drawing.Size(72, 68)
        Me.PassKey0.TabIndex = 65
        Me.PassKey0.Text = "0"
        Me.PassKey0.UseVisualStyleBackColor = True
        Me.PassKey0.Visible = False
        '
        'PassKeyCor
        '
        Me.PassKeyCor.Depth = 0
        Me.PassKeyCor.Location = New System.Drawing.Point(320, 495)
        Me.PassKeyCor.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKeyCor.Name = "PassKeyCor"
        Me.PassKeyCor.Primary = True
        Me.PassKeyCor.Size = New System.Drawing.Size(72, 68)
        Me.PassKeyCor.TabIndex = 63
        Me.PassKeyCor.Text = "<-"
        Me.PassKeyCor.UseVisualStyleBackColor = True
        Me.PassKeyCor.Visible = False
        '
        'PassKeyEnter
        '
        Me.PassKeyEnter.Depth = 0
        Me.PassKeyEnter.Location = New System.Drawing.Point(419, 495)
        Me.PassKeyEnter.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKeyEnter.Name = "PassKeyEnter"
        Me.PassKeyEnter.Primary = True
        Me.PassKeyEnter.Size = New System.Drawing.Size(72, 68)
        Me.PassKeyEnter.TabIndex = 62
        Me.PassKeyEnter.Text = "Enter"
        Me.PassKeyEnter.UseVisualStyleBackColor = True
        Me.PassKeyEnter.Visible = False
        '
        'PassKey9
        '
        Me.PassKey9.Depth = 0
        Me.PassKey9.Location = New System.Drawing.Point(419, 409)
        Me.PassKey9.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey9.Name = "PassKey9"
        Me.PassKey9.Primary = True
        Me.PassKey9.Size = New System.Drawing.Size(72, 68)
        Me.PassKey9.TabIndex = 61
        Me.PassKey9.Text = "9"
        Me.PassKey9.UseVisualStyleBackColor = True
        Me.PassKey9.Visible = False
        '
        'PassKey8
        '
        Me.PassKey8.Depth = 0
        Me.PassKey8.Location = New System.Drawing.Point(320, 409)
        Me.PassKey8.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey8.Name = "PassKey8"
        Me.PassKey8.Primary = True
        Me.PassKey8.Size = New System.Drawing.Size(72, 68)
        Me.PassKey8.TabIndex = 60
        Me.PassKey8.Text = "8"
        Me.PassKey8.UseVisualStyleBackColor = True
        Me.PassKey8.Visible = False
        '
        'PassKey7
        '
        Me.PassKey7.Depth = 0
        Me.PassKey7.Location = New System.Drawing.Point(220, 409)
        Me.PassKey7.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey7.Name = "PassKey7"
        Me.PassKey7.Primary = True
        Me.PassKey7.Size = New System.Drawing.Size(72, 68)
        Me.PassKey7.TabIndex = 59
        Me.PassKey7.Text = "7"
        Me.PassKey7.UseVisualStyleBackColor = True
        Me.PassKey7.Visible = False
        '
        'PassKey6
        '
        Me.PassKey6.Depth = 0
        Me.PassKey6.Location = New System.Drawing.Point(419, 317)
        Me.PassKey6.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey6.Name = "PassKey6"
        Me.PassKey6.Primary = True
        Me.PassKey6.Size = New System.Drawing.Size(72, 68)
        Me.PassKey6.TabIndex = 58
        Me.PassKey6.Text = "6"
        Me.PassKey6.UseVisualStyleBackColor = True
        Me.PassKey6.Visible = False
        '
        'PassKey5
        '
        Me.PassKey5.Depth = 0
        Me.PassKey5.Location = New System.Drawing.Point(320, 317)
        Me.PassKey5.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey5.Name = "PassKey5"
        Me.PassKey5.Primary = True
        Me.PassKey5.Size = New System.Drawing.Size(72, 68)
        Me.PassKey5.TabIndex = 57
        Me.PassKey5.Text = "5"
        Me.PassKey5.UseVisualStyleBackColor = True
        Me.PassKey5.Visible = False
        '
        'PassKey4
        '
        Me.PassKey4.Depth = 0
        Me.PassKey4.Location = New System.Drawing.Point(220, 317)
        Me.PassKey4.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey4.Name = "PassKey4"
        Me.PassKey4.Primary = True
        Me.PassKey4.Size = New System.Drawing.Size(72, 68)
        Me.PassKey4.TabIndex = 56
        Me.PassKey4.Text = "4"
        Me.PassKey4.UseVisualStyleBackColor = True
        Me.PassKey4.Visible = False
        '
        'PassKey3
        '
        Me.PassKey3.Depth = 0
        Me.PassKey3.Location = New System.Drawing.Point(419, 228)
        Me.PassKey3.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey3.Name = "PassKey3"
        Me.PassKey3.Primary = True
        Me.PassKey3.Size = New System.Drawing.Size(72, 68)
        Me.PassKey3.TabIndex = 55
        Me.PassKey3.Text = "3"
        Me.PassKey3.UseVisualStyleBackColor = True
        Me.PassKey3.Visible = False
        '
        'PassKey2
        '
        Me.PassKey2.Depth = 0
        Me.PassKey2.Location = New System.Drawing.Point(320, 228)
        Me.PassKey2.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey2.Name = "PassKey2"
        Me.PassKey2.Primary = True
        Me.PassKey2.Size = New System.Drawing.Size(72, 68)
        Me.PassKey2.TabIndex = 54
        Me.PassKey2.Text = "2"
        Me.PassKey2.UseVisualStyleBackColor = True
        Me.PassKey2.Visible = False
        '
        'PassKey1
        '
        Me.PassKey1.Depth = 0
        Me.PassKey1.Location = New System.Drawing.Point(220, 228)
        Me.PassKey1.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey1.Name = "PassKey1"
        Me.PassKey1.Primary = True
        Me.PassKey1.Size = New System.Drawing.Size(72, 68)
        Me.PassKey1.TabIndex = 53
        Me.PassKey1.Text = "1"
        Me.PassKey1.UseVisualStyleBackColor = True
        Me.PassKey1.Visible = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(216, 153)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(241, 19)
        Me.MaterialLabel1.TabIndex = 67
        Me.MaterialLabel1.Text = "Please Dictate Amount of Transfer"
        Me.MaterialLabel1.Visible = False
        '
        'PassField
        '
        Me.PassField.Depth = 0
        Me.PassField.Hint = ""
        Me.PassField.Location = New System.Drawing.Point(220, 199)
        Me.PassField.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassField.Name = "PassField"
        Me.PassField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PassField.SelectedText = ""
        Me.PassField.SelectionLength = 0
        Me.PassField.SelectionStart = 0
        Me.PassField.Size = New System.Drawing.Size(271, 23)
        Me.PassField.TabIndex = 66
        Me.PassField.Text = "$"
        Me.PassField.UseSystemPasswordChar = False
        Me.PassField.Visible = False
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(12, 278)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(65, 30)
        Me.MaterialRadioButton1.TabIndex = 68
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Adam"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = False
        Me.MaterialRadioButton1.Visible = False
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(379, 276)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(60, 30)
        Me.MaterialRadioButton2.TabIndex = 69
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Mary"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = False
        Me.MaterialRadioButton2.Visible = False
        '
        'MaterialRadioButton3
        '
        Me.MaterialRadioButton3.AutoSize = True
        Me.MaterialRadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton3.Depth = 0
        Me.MaterialRadioButton3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton3.Location = New System.Drawing.Point(12, 369)
        Me.MaterialRadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton3.Name = "MaterialRadioButton3"
        Me.MaterialRadioButton3.Ripple = True
        Me.MaterialRadioButton3.Size = New System.Drawing.Size(59, 30)
        Me.MaterialRadioButton3.TabIndex = 70
        Me.MaterialRadioButton3.TabStop = True
        Me.MaterialRadioButton3.Text = "Jane"
        Me.MaterialRadioButton3.UseVisualStyleBackColor = False
        Me.MaterialRadioButton3.Visible = False
        '
        'MaterialRadioButton4
        '
        Me.MaterialRadioButton4.AutoSize = True
        Me.MaterialRadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton4.Depth = 0
        Me.MaterialRadioButton4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton4.Location = New System.Drawing.Point(379, 336)
        Me.MaterialRadioButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton4.Name = "MaterialRadioButton4"
        Me.MaterialRadioButton4.Ripple = True
        Me.MaterialRadioButton4.Size = New System.Drawing.Size(72, 30)
        Me.MaterialRadioButton4.TabIndex = 71
        Me.MaterialRadioButton4.TabStop = True
        Me.MaterialRadioButton4.Text = "Rogers"
        Me.MaterialRadioButton4.UseVisualStyleBackColor = False
        Me.MaterialRadioButton4.Visible = False
        '
        'MaterialRadioButton5
        '
        Me.MaterialRadioButton5.AutoSize = True
        Me.MaterialRadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton5.Depth = 0
        Me.MaterialRadioButton5.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton5.Location = New System.Drawing.Point(12, 399)
        Me.MaterialRadioButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton5.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton5.Name = "MaterialRadioButton5"
        Me.MaterialRadioButton5.Ripple = True
        Me.MaterialRadioButton5.Size = New System.Drawing.Size(89, 30)
        Me.MaterialRadioButton5.TabIndex = 72
        Me.MaterialRadioButton5.TabStop = True
        Me.MaterialRadioButton5.Text = "Mortgage"
        Me.MaterialRadioButton5.UseVisualStyleBackColor = False
        Me.MaterialRadioButton5.Visible = False
        '
        'MaterialRadioButton6
        '
        Me.MaterialRadioButton6.AutoSize = True
        Me.MaterialRadioButton6.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton6.Depth = 0
        Me.MaterialRadioButton6.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton6.Location = New System.Drawing.Point(379, 366)
        Me.MaterialRadioButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton6.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton6.Name = "MaterialRadioButton6"
        Me.MaterialRadioButton6.Ripple = True
        Me.MaterialRadioButton6.Size = New System.Drawing.Size(115, 30)
        Me.MaterialRadioButton6.TabIndex = 78
        Me.MaterialRadioButton6.TabStop = True
        Me.MaterialRadioButton6.Text = "The Spectator"
        Me.MaterialRadioButton6.UseVisualStyleBackColor = False
        Me.MaterialRadioButton6.Visible = False
        '
        'MaterialRadioButton7
        '
        Me.MaterialRadioButton7.AutoSize = True
        Me.MaterialRadioButton7.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton7.Depth = 0
        Me.MaterialRadioButton7.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton7.Location = New System.Drawing.Point(12, 309)
        Me.MaterialRadioButton7.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton7.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton7.Name = "MaterialRadioButton7"
        Me.MaterialRadioButton7.Ripple = True
        Me.MaterialRadioButton7.Size = New System.Drawing.Size(55, 30)
        Me.MaterialRadioButton7.TabIndex = 77
        Me.MaterialRadioButton7.TabStop = True
        Me.MaterialRadioButton7.Text = "Billy"
        Me.MaterialRadioButton7.UseVisualStyleBackColor = False
        Me.MaterialRadioButton7.Visible = False
        '
        'MaterialRadioButton8
        '
        Me.MaterialRadioButton8.AutoSize = True
        Me.MaterialRadioButton8.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton8.Depth = 0
        Me.MaterialRadioButton8.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton8.Location = New System.Drawing.Point(379, 306)
        Me.MaterialRadioButton8.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton8.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton8.Name = "MaterialRadioButton8"
        Me.MaterialRadioButton8.Ripple = True
        Me.MaterialRadioButton8.Size = New System.Drawing.Size(120, 30)
        Me.MaterialRadioButton8.TabIndex = 76
        Me.MaterialRadioButton8.TabStop = True
        Me.MaterialRadioButton8.Text = "NRA Magazine"
        Me.MaterialRadioButton8.UseVisualStyleBackColor = False
        Me.MaterialRadioButton8.Visible = False
        '
        'MaterialRadioButton9
        '
        Me.MaterialRadioButton9.AutoSize = True
        Me.MaterialRadioButton9.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton9.Depth = 0
        Me.MaterialRadioButton9.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton9.Location = New System.Drawing.Point(379, 396)
        Me.MaterialRadioButton9.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton9.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton9.Name = "MaterialRadioButton9"
        Me.MaterialRadioButton9.Ripple = True
        Me.MaterialRadioButton9.Size = New System.Drawing.Size(65, 30)
        Me.MaterialRadioButton9.TabIndex = 75
        Me.MaterialRadioButton9.TabStop = True
        Me.MaterialRadioButton9.Text = "Water"
        Me.MaterialRadioButton9.UseVisualStyleBackColor = False
        Me.MaterialRadioButton9.Visible = False
        '
        'MaterialRadioButton10
        '
        Me.MaterialRadioButton10.AutoSize = True
        Me.MaterialRadioButton10.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton10.Depth = 0
        Me.MaterialRadioButton10.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton10.Location = New System.Drawing.Point(12, 339)
        Me.MaterialRadioButton10.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton10.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton10.Name = "MaterialRadioButton10"
        Me.MaterialRadioButton10.Ripple = True
        Me.MaterialRadioButton10.Size = New System.Drawing.Size(126, 30)
        Me.MaterialRadioButton10.TabIndex = 74
        Me.MaterialRadioButton10.TabStop = True
        Me.MaterialRadioButton10.Text = "General Electric"
        Me.MaterialRadioButton10.UseVisualStyleBackColor = False
        Me.MaterialRadioButton10.Visible = False
        '
        'NextPage
        '
        Me.NextPage.Depth = 0
        Me.NextPage.Location = New System.Drawing.Point(527, 475)
        Me.NextPage.MouseState = MaterialSkin.MouseState.HOVER
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Primary = True
        Me.NextPage.Size = New System.Drawing.Size(153, 88)
        Me.NextPage.TabIndex = 73
        Me.NextPage.Text = "Next Page"
        Me.NextPage.UseVisualStyleBackColor = True
        Me.NextPage.Visible = False
        '
        'TransferFrom
        '
        Me.TransferFrom.FormattingEnabled = True
        Me.TransferFrom.Location = New System.Drawing.Point(99, 284)
        Me.TransferFrom.Name = "TransferFrom"
        Me.TransferFrom.Size = New System.Drawing.Size(182, 21)
        Me.TransferFrom.TabIndex = 79
        Me.TransferFrom.Text = "Chequing Account"
        Me.TransferFrom.Visible = False
        '
        'TransferTo
        '
        Me.TransferTo.FormattingEnabled = True
        Me.TransferTo.Location = New System.Drawing.Point(419, 284)
        Me.TransferTo.Name = "TransferTo"
        Me.TransferTo.Size = New System.Drawing.Size(182, 21)
        Me.TransferTo.TabIndex = 80
        Me.TransferTo.Visible = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(95, 218)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(254, 19)
        Me.MaterialLabel2.TabIndex = 81
        Me.MaterialLabel2.Text = "Choose the account to transfer from"
        Me.MaterialLabel2.Visible = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(415, 219)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(236, 19)
        Me.MaterialLabel3.TabIndex = 82
        Me.MaterialLabel3.Text = "Choose the account to transfer to"
        Me.MaterialLabel3.Visible = False
        '
        'MaterialRadioButton11
        '
        Me.MaterialRadioButton11.AutoSize = True
        Me.MaterialRadioButton11.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton11.Depth = 0
        Me.MaterialRadioButton11.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton11.Location = New System.Drawing.Point(12, 279)
        Me.MaterialRadioButton11.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton11.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton11.Name = "MaterialRadioButton11"
        Me.MaterialRadioButton11.Ripple = True
        Me.MaterialRadioButton11.Size = New System.Drawing.Size(100, 30)
        Me.MaterialRadioButton11.TabIndex = 83
        Me.MaterialRadioButton11.TabStop = True
        Me.MaterialRadioButton11.Text = "Zoo Weekly"
        Me.MaterialRadioButton11.UseVisualStyleBackColor = False
        Me.MaterialRadioButton11.Visible = False
        '
        'Previous
        '
        Me.Previous.Depth = 0
        Me.Previous.Location = New System.Drawing.Point(12, 475)
        Me.Previous.MouseState = MaterialSkin.MouseState.HOVER
        Me.Previous.Name = "Previous"
        Me.Previous.Primary = True
        Me.Previous.Size = New System.Drawing.Size(153, 88)
        Me.Previous.TabIndex = 84
        Me.Previous.Text = "Previous Page"
        Me.Previous.UseVisualStyleBackColor = True
        Me.Previous.Visible = False
        '
        'SelectPayee
        '
        Me.SelectPayee.Depth = 0
        Me.SelectPayee.Location = New System.Drawing.Point(277, 475)
        Me.SelectPayee.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectPayee.Name = "SelectPayee"
        Me.SelectPayee.Primary = True
        Me.SelectPayee.Size = New System.Drawing.Size(153, 88)
        Me.SelectPayee.TabIndex = 85
        Me.SelectPayee.Text = "Select"
        Me.SelectPayee.UseVisualStyleBackColor = True
        Me.SelectPayee.Visible = False
        '
        'PrintRecipt
        '
        Me.PrintRecipt.Depth = 0
        Me.PrintRecipt.Location = New System.Drawing.Point(456, 370)
        Me.PrintRecipt.MouseState = MaterialSkin.MouseState.HOVER
        Me.PrintRecipt.Name = "PrintRecipt"
        Me.PrintRecipt.Primary = True
        Me.PrintRecipt.Size = New System.Drawing.Size(224, 88)
        Me.PrintRecipt.TabIndex = 86
        Me.PrintRecipt.Text = "Yes"
        Me.PrintRecipt.UseVisualStyleBackColor = True
        Me.PrintRecipt.Visible = False
        '
        'ReciptNo
        '
        Me.ReciptNo.Depth = 0
        Me.ReciptNo.Location = New System.Drawing.Point(456, 475)
        Me.ReciptNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.ReciptNo.Name = "ReciptNo"
        Me.ReciptNo.Primary = True
        Me.ReciptNo.Size = New System.Drawing.Size(224, 88)
        Me.ReciptNo.TabIndex = 87
        Me.ReciptNo.Text = "PERFORM MORE ACTIONS"
        Me.ReciptNo.UseVisualStyleBackColor = True
        Me.ReciptNo.Visible = False
        '
        'TransferContinue
        '
        Me.TransferContinue.Depth = 0
        Me.TransferContinue.Location = New System.Drawing.Point(456, 475)
        Me.TransferContinue.MouseState = MaterialSkin.MouseState.HOVER
        Me.TransferContinue.Name = "TransferContinue"
        Me.TransferContinue.Primary = True
        Me.TransferContinue.Size = New System.Drawing.Size(224, 88)
        Me.TransferContinue.TabIndex = 88
        Me.TransferContinue.Text = "Continue"
        Me.TransferContinue.UseVisualStyleBackColor = True
        Me.TransferContinue.Visible = False
        '
        'TransferMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.TransferContinue)
        Me.Controls.Add(Me.ReciptNo)
        Me.Controls.Add(Me.PrintRecipt)
        Me.Controls.Add(Me.SelectPayee)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.MaterialRadioButton11)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.TransferTo)
        Me.Controls.Add(Me.TransferFrom)
        Me.Controls.Add(Me.MaterialRadioButton6)
        Me.Controls.Add(Me.MaterialRadioButton7)
        Me.Controls.Add(Me.MaterialRadioButton8)
        Me.Controls.Add(Me.MaterialRadioButton9)
        Me.Controls.Add(Me.MaterialRadioButton10)
        Me.Controls.Add(Me.NextPage)
        Me.Controls.Add(Me.MaterialRadioButton5)
        Me.Controls.Add(Me.MaterialRadioButton4)
        Me.Controls.Add(Me.MaterialRadioButton3)
        Me.Controls.Add(Me.MaterialRadioButton2)
        Me.Controls.Add(Me.MaterialRadioButton1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.PassField)
        Me.Controls.Add(Me.PassKey0)
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
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.BackB)
        Me.Controls.Add(Me.TBetweenAccB)
        Me.Controls.Add(Me.TByEmailB)
        Me.Controls.Add(Me.MPaymentB)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Logout)
        Me.Name = "TransferMoney"
        Me.ShowIcon = False
        Me.Text = "Make a Transfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Button
    Friend WithEvents MPaymentB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TBetweenAccB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TByEmailB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents BackB As System.Windows.Forms.Button
    Friend WithEvents Cancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey0 As MaterialSkin.Controls.MaterialRaisedButton
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
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PassField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton4 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton5 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton6 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton7 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton8 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton9 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton10 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents NextPage As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TransferFrom As System.Windows.Forms.ComboBox
    Friend WithEvents TransferTo As System.Windows.Forms.ComboBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRadioButton11 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Previous As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents SelectPayee As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PrintRecipt As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ReciptNo As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TransferContinue As MaterialSkin.Controls.MaterialRaisedButton
End Class
