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
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
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
        Me.MPaymentB.Visible = False
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
        Me.TBetweenAccB.Visible = False
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
        Me.TByEmailB.Visible = False
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
        Me.PassField.UseSystemPasswordChar = False
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(12, 219)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton1.TabIndex = 68
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "MaterialRadioButton1"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = False
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(12, 249)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton2.TabIndex = 69
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "MaterialRadioButton2"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = False
        '
        'MaterialRadioButton3
        '
        Me.MaterialRadioButton3.AutoSize = True
        Me.MaterialRadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton3.Depth = 0
        Me.MaterialRadioButton3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton3.Location = New System.Drawing.Point(12, 279)
        Me.MaterialRadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton3.Name = "MaterialRadioButton3"
        Me.MaterialRadioButton3.Ripple = True
        Me.MaterialRadioButton3.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton3.TabIndex = 70
        Me.MaterialRadioButton3.TabStop = True
        Me.MaterialRadioButton3.Text = "MaterialRadioButton3"
        Me.MaterialRadioButton3.UseVisualStyleBackColor = False
        '
        'MaterialRadioButton4
        '
        Me.MaterialRadioButton4.AutoSize = True
        Me.MaterialRadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton4.Depth = 0
        Me.MaterialRadioButton4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton4.Location = New System.Drawing.Point(12, 309)
        Me.MaterialRadioButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton4.Name = "MaterialRadioButton4"
        Me.MaterialRadioButton4.Ripple = True
        Me.MaterialRadioButton4.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton4.TabIndex = 71
        Me.MaterialRadioButton4.TabStop = True
        Me.MaterialRadioButton4.Text = "MaterialRadioButton4"
        Me.MaterialRadioButton4.UseVisualStyleBackColor = False
        '
        'MaterialRadioButton5
        '
        Me.MaterialRadioButton5.AutoSize = True
        Me.MaterialRadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.MaterialRadioButton5.Depth = 0
        Me.MaterialRadioButton5.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton5.Location = New System.Drawing.Point(12, 339)
        Me.MaterialRadioButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton5.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton5.Name = "MaterialRadioButton5"
        Me.MaterialRadioButton5.Ripple = True
        Me.MaterialRadioButton5.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton5.TabIndex = 72
        Me.MaterialRadioButton5.TabStop = True
        Me.MaterialRadioButton5.Text = "MaterialRadioButton5"
        Me.MaterialRadioButton5.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(360, 475)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(320, 88)
        Me.MaterialRaisedButton1.TabIndex = 73
        Me.MaterialRaisedButton1.Text = "Continue"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        Me.MaterialRaisedButton1.Visible = False
        '
        'TransferMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.MaterialRaisedButton1)
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
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
