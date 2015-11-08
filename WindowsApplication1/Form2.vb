Imports MaterialSkin

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub
    Private Sub Form2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1.Close()
    End Sub


    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles WithdrawB.Click
        Me.Hide()
        Withdraw.Show()

    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DepositB_Click(sender As Object, e As EventArgs) Handles DepositB.Click
        Me.Hide()
        Deposit.Show()
    End Sub
End Class