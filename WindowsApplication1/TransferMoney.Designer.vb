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
        Me.MainFinish = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Cancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Another = New MaterialSkin.Controls.MaterialRaisedButton()
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
        Me.MPaymentB.Location = New System.Drawing.Point(379, 185)
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
        Me.TBetweenAccB.Location = New System.Drawing.Point(12, 279)
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
        Me.TByEmailB.Location = New System.Drawing.Point(12, 185)
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
        'MainFinish
        '
        Me.MainFinish.Depth = 0
        Me.MainFinish.Location = New System.Drawing.Point(12, 498)
        Me.MainFinish.MouseState = MaterialSkin.MouseState.HOVER
        Me.MainFinish.Name = "MainFinish"
        Me.MainFinish.Primary = True
        Me.MainFinish.Size = New System.Drawing.Size(320, 88)
        Me.MainFinish.TabIndex = 46
        Me.MainFinish.Text = "Finish"
        Me.MainFinish.UseVisualStyleBackColor = True
        Me.MainFinish.Visible = False
        '
        'Cancel
        '
        Me.Cancel.Depth = 0
        Me.Cancel.Location = New System.Drawing.Point(527, 73)
        Me.Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Primary = True
        Me.Cancel.Size = New System.Drawing.Size(172, 68)
        Me.Cancel.TabIndex = 47
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'Another
        '
        Me.Another.Depth = 0
        Me.Another.Location = New System.Drawing.Point(12, 404)
        Me.Another.MouseState = MaterialSkin.MouseState.HOVER
        Me.Another.Name = "Another"
        Me.Another.Primary = True
        Me.Another.Size = New System.Drawing.Size(320, 88)
        Me.Another.TabIndex = 51
        Me.Another.Text = "Perform Another Transaction"
        Me.Another.UseVisualStyleBackColor = True
        Me.Another.Visible = False
        '
        'TransferMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 599)
        Me.Controls.Add(Me.Another)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.MainFinish)
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

    End Sub
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Button
    Friend WithEvents MPaymentB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TBetweenAccB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TByEmailB As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents BackB As System.Windows.Forms.Button
    Friend WithEvents MainFinish As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Cancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Another As MaterialSkin.Controls.MaterialRaisedButton



End Class
