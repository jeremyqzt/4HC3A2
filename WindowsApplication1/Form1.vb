Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub mainPage_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Determine whether the key entered is the F1 key. Display help if it is.
        If e.KeyCode = Keys.Q Then
            ' Display a pop-up help topic to assist the user.
            MaterialRaisedButton1.Hide()
        End If
    End Sub
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MsgBox("hi")
    End Sub

    Private Sub ToMain_Click(ByVal sender As Object, e As EventArgs) Handles ToMain.Click
        ToMain.Hide()
        Deposit.Show()
        Withdraw.Show()
        Me.Text = "Welcome User"
    End Sub

    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles Withdraw.Click

    End Sub

    Private Sub Deposit_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        Throw New NotImplementedException
    End Sub

End Class