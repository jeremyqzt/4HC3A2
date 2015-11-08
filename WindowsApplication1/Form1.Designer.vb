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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.PassKeyCor = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKeyEnter = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey9 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey8 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey7 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey5 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey6 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassKey1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PassField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Cancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ToMain = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Logout = New System.Windows.Forms.Button()
        Me.PassKey0 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(200, 112)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(153, 19)
        Me.MaterialLabel1.TabIndex = 13
        Me.MaterialLabel1.Text = "Please Enter Your Pin"
        Me.MaterialLabel1.Visible = False
        '
        'PassKeyCor
        '
        Me.PassKeyCor.Depth = 0
        Me.PassKeyCor.Location = New System.Drawing.Point(304, 484)
        Me.PassKeyCor.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKeyCor.Name = "PassKeyCor"
        Me.PassKeyCor.Primary = True
        Me.PassKeyCor.Size = New System.Drawing.Size(72, 68)
        Me.PassKeyCor.TabIndex = 11
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
        Me.PassKeyEnter.TabIndex = 10
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
        Me.PassKey9.TabIndex = 8
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
        Me.PassKey8.TabIndex = 7
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
        Me.PassKey7.TabIndex = 6
        Me.PassKey7.Text = "7"
        Me.PassKey7.UseVisualStyleBackColor = True
        Me.PassKey7.Visible = False
        '
        'PassKey4
        '
        Me.PassKey4.Depth = 0
        Me.PassKey4.Location = New System.Drawing.Point(204, 306)
        Me.PassKey4.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey4.Name = "PassKey4"
        Me.PassKey4.Primary = True
        Me.PassKey4.Size = New System.Drawing.Size(72, 68)
        Me.PassKey4.TabIndex = 3
        Me.PassKey4.Text = "4"
        Me.PassKey4.UseVisualStyleBackColor = True
        Me.PassKey4.Visible = False
        '
        'PassKey5
        '
        Me.PassKey5.Depth = 0
        Me.PassKey5.Location = New System.Drawing.Point(304, 306)
        Me.PassKey5.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey5.Name = "PassKey5"
        Me.PassKey5.Primary = True
        Me.PassKey5.Size = New System.Drawing.Size(72, 68)
        Me.PassKey5.TabIndex = 4
        Me.PassKey5.Text = "5"
        Me.PassKey5.UseVisualStyleBackColor = True
        Me.PassKey5.Visible = False
        '
        'PassKey6
        '
        Me.PassKey6.Depth = 0
        Me.PassKey6.Location = New System.Drawing.Point(403, 306)
        Me.PassKey6.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey6.Name = "PassKey6"
        Me.PassKey6.Primary = True
        Me.PassKey6.Size = New System.Drawing.Size(72, 68)
        Me.PassKey6.TabIndex = 5
        Me.PassKey6.Text = "6"
        Me.PassKey6.UseVisualStyleBackColor = True
        Me.PassKey6.Visible = False
        '
        'PassKey3
        '
        Me.PassKey3.Depth = 0
        Me.PassKey3.Location = New System.Drawing.Point(403, 217)
        Me.PassKey3.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey3.Name = "PassKey3"
        Me.PassKey3.Primary = True
        Me.PassKey3.Size = New System.Drawing.Size(72, 68)
        Me.PassKey3.TabIndex = 2
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
        Me.PassKey2.TabIndex = 1
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
        Me.PassKey1.TabIndex = 0
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
        Me.PassField.TabIndex = 9
        Me.PassField.UseSystemPasswordChar = False
        Me.PassField.Visible = False
        '
        'Cancel
        '
        Me.Cancel.Depth = 0
        Me.Cancel.Location = New System.Drawing.Point(527, 73)
        Me.Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Primary = True
        Me.Cancel.Size = New System.Drawing.Size(172, 68)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'ToMain
        '
        Me.ToMain.Depth = 0
        Me.ToMain.Location = New System.Drawing.Point(204, 291)
        Me.ToMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.ToMain.Name = "ToMain"
        Me.ToMain.Primary = True
        Me.ToMain.Size = New System.Drawing.Size(271, 83)
        Me.ToMain.TabIndex = 14
        Me.ToMain.Text = "Please Swipe Your Card"
        Me.ToMain.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(204, 158)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(271, 23)
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.Visible = False
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
        Me.Logout.TabIndex = 16
        Me.Logout.UseVisualStyleBackColor = False
        '
        'PassKey0
        '
        Me.PassKey0.Depth = 0
        Me.PassKey0.Location = New System.Drawing.Point(204, 484)
        Me.PassKey0.MouseState = MaterialSkin.MouseState.HOVER
        Me.PassKey0.Name = "PassKey0"
        Me.PassKey0.Primary = True
        Me.PassKey0.Size = New System.Drawing.Size(72, 68)
        Me.PassKey0.TabIndex = 17
        Me.PassKey0.Text = "0"
        Me.PassKey0.UseVisualStyleBackColor = True
        Me.PassKey0.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.PassKey0)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ToMain)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.PassKeyCor)
        Me.Controls.Add(Me.PassKeyEnter)
        Me.Controls.Add(Me.PassField)
        Me.Controls.Add(Me.PassKey9)
        Me.Controls.Add(Me.PassKey8)
        Me.Controls.Add(Me.PassKey7)
        Me.Controls.Add(Me.PassKey6)
        Me.Controls.Add(Me.PassKey5)
        Me.Controls.Add(Me.PassKey4)
        Me.Controls.Add(Me.PassKey3)
        Me.Controls.Add(Me.PassKey2)
        Me.Controls.Add(Me.PassKey1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Welcome to X Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PassKeyCor As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKeyEnter As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey9 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey8 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey7 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey5 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey6 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassKey1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PassField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Cancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ToMain As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents PassKey0 As MaterialSkin.Controls.MaterialRaisedButton

End Class
