Imports MaterialSkin

Public Class Withdraw

    Private Sub Withdraw_Load(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
    Private Sub Withdraw_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Form1.Close()
    End Sub


    Private Sub WithdrawTxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Withdraw_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub W40_Click(sender As Object, e As EventArgs) Handles W40.Click

    End Sub
End Class